using Sitecore.Collections;
using Sitecore.Data;
using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using M1CP.Foundation.DependencyInjection;
using System.Web.Mvc;
using M1CP.Foundation.CustomAPI.Helpers;
using Sitecore.Layouts;
using Sitecore.Data.Items;

namespace M1CP.Foundation.CustomAPI.Repositories
{
    [Service(typeof(ICustomAPIRepository))]
    public class CustomAPIRepository : BaseController, ICustomAPIRepository
    {
        /// <summary>
        /// return id is valid guid or not
        /// </summary>
        public static bool IsGuid(string guidString)
        {
            bool isValid = false;
            if (!string.IsNullOrEmpty(guidString))
            {
                Regex isGuid =
                new Regex(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$"
                , RegexOptions.Compiled);

                if (isGuid.IsMatch(guidString))
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        /// <summary>
        /// returns does item has rendering as boolean value
        /// </summary>
        public bool DoesItemHasRendering(string id, string rid)
        {
            if (ID.IsID(id) && ID.IsID(rid))
            {
                var item = Sitecore.Context.Database.GetItem(ID.Parse(id));
                if (item != null)
                {
                    if ((item.Visualization.GetRenderings(Sitecore.Context.Device, true).Where(r => r.RenderingID == ID.Parse(rid))).Any())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// returns list of rendering that is used by the item
        /// </summary>
        public RenderingReference[] GetListOfRendering(string id, string rid)
        {
            RenderingReference[] renderings = null;
            if (ID.IsID(id) && ID.IsID(rid))
            {
                Item item = Sitecore.Context.Database.GetItem(ID.Parse(id));
                if (item != null)
                {
                    //renderings = item.Visualization.GetRenderings(Sitecore.Context.Device, true);
                    renderings = item.Visualization.GetRenderings(Sitecore.Context.Device, true).Where(r => r.RenderingID == (ID.Parse(rid))).ToArray();
                }
            }
            return renderings;
        }

        /// <summary>
        /// returns list of data source and placeholder
        /// </summary>
        public List<Dictionary<string, string>> GetListOfDataSource(RenderingReference[] renderings)
        {
            List<Dictionary<string, string>> ListOfDataSource = new List<Dictionary<string, string>>();
            foreach (RenderingReference rendering in renderings)
            {
                var item = Sitecore.Context.Database.GetItem(ID.Parse(rendering.Settings.DataSource));
                Dictionary<string, string> rd = new Dictionary<string, string>();
                rd.Add("Rendering Item Name", rendering.RenderingItem.DisplayName);
                rd.Add("Rendering Item DataSource Path", item.Paths.FullPath);
                rd.Add("Rendering Item Placeholder", rendering.Settings.Placeholder);
                rd.Add("Rendering Item Parameters", rendering.Settings.Parameters);
                ListOfDataSource.Add(rd);
            }
            return ListOfDataSource;
        }

        /// <summary>
        /// ~/m1api/item?id=110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9
        /// returns all fields of item as json response
        /// </summary>
        public JsonResult GetSitecoreItem(string id)
        {
            try
            {
                //check input string is valid GUID or not
                if (IsGuid(id) == true)
                {
                    var item = Sitecore.Context.Database.GetItem(ID.Parse(id));
                    //check item exist in sitecore
                    if (item != null)
                    {
                        //get all the fields associated with the item                      
                        FieldCollection fieldcollection = item.Fields;
                        Dictionary<string, string> dictionary = new Dictionary<string, string>();
                        dictionary.Add("ItemName", item.Name);
                        dictionary.Add("ItemPath", item.Paths.FullPath);
                        dictionary.Add("ParentID", item.ParentID.ToString());
                        dictionary.Add("TemplateID", item.TemplateID.ToString());
                        dictionary.Add("TemplateName", item.TemplateName);
                        foreach (Field field in fieldcollection)
                        {                            
                            //to exclude system fields
                            if (!field.Name.StartsWith("__"))
                            {
                                //check if the field already exixt in the directory
                                if (!dictionary.ContainsKey(field.Name))
                                {
                                    dictionary.Add(field.Name, field.Value);
                                }
                                else
                                {
                                    dictionary[field.Name] = field.Value;
                                }
                            }
                        }
                        return Json(dictionary);
                    }
                    else
                    {
                        return Json("Item doesn't exist in sitecore");
                    }
                }
                else
                {
                    return Json("Item ID is Invalid!");
                }

            }
            catch (Exception ex)
            {
                var ErrMsg = ex.Message;
                return Json(ErrMsg);
            }

        }

        /// <summary>
        /// ~/m1api/getchilditems?pid=0DE95AE4-41AB-4D01-9EB0-67441B7C2450
        /// ~/m1api/getchilditems?pid=0DE95AE4-41AB-4D01-9EB0-67441B7C2450&fields="DisplayName,Price"
        /// returns all child item as json response
        /// </summary>
        public JsonResult GetSitecoreChildItems(string pid, string fields)
        {
            try
            {
                string[] fieldsarray = fields.Split(',');
                //check pid is valid and exist in sitecore
                if (IsGuid(pid) == true)
                {
                    var items = Sitecore.Context.Database.GetItem(ID.Parse(pid));
                    if (items != null && items.HasChildren)
                    {
                        #region
                        var childitems = Sitecore.Context.Database.GetItem(ID.Parse(pid)).Children;
                        List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
                        foreach (Item item in childitems)
                        {
                            Dictionary<string, string> dir = new Dictionary<string, string>();

                            foreach (string fieldsarrayitem in fieldsarray)
                            {
                                if (item.Fields[fieldsarrayitem] != null)
                                {
                                    #region
                                    if (!fieldsarrayitem.StartsWith("__"))
                                    {
                                        string output = childitems.Where(f => f == item).Select(v => v.Fields[fieldsarrayitem].Value.ToString()).FirstOrDefault();
                                        dir.Add(fieldsarrayitem, output);
                                    }
                                    else
                                    {
                                        return Json(fieldsarrayitem + "Standard Field Value is inaccessible !");
                                    }
                                    #endregion
                                }
                                else
                                {
                                    return Json("Field Name " + fieldsarrayitem + " is unavailable in " + item.DisplayName + "item");
                                }
                            }
                            list.Add(dir);
                        }
                        #endregion
                        return Json(list);
                    }
                    else
                    {
                        return Json("Item doesn't have any child");
                    }
                }
                else
                {
                    return Json("Parent ID is Invalid!");
                }
            }
            catch (Exception)
            {
                //var ErrMsg = ex.Message;
                return Json("field parameter is missing ex: /m1api/getchilditems?pid=''&fields=''");
            }


        }

        /// <summary>
        /// ~/m1api/itemrendering?id=110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9&rid=493B3A83-0FA7-4484-8FC9-4680991CF743
        /// returns all fields of all the rendering items
        /// </summary>
        public JsonResult GetSitecoreItemRendering(string id, string rid)
        {
            bool doesItemHasRendering = DoesItemHasRendering(id, rid);
            try
            {
                //check input string is valid GUID or not
                if (IsGuid(id) == true && IsGuid(rid) == true)
                {
                    var item = Sitecore.Context.Database.GetItem(ID.Parse(id));
                    var itemrendering = Sitecore.Context.Database.GetItem(ID.Parse(rid));
                    if (item != null && itemrendering != null)
                    {
                        if (doesItemHasRendering == true)
                        {
                            RenderingReference[] renderings = GetListOfRendering(id, rid);
                            List<Dictionary<string, string>> ListOfDataSource = GetListOfDataSource(renderings);
                           
                            return Json(ListOfDataSource);
                        }
                        else
                        {
                            return Json("Item doen't have rendering id " + rid);
                        }
                    }
                    else
                    {
                        return Json("Item ID or Rendering ID doesn't exist in sitecore");
                    }

                }
                else
                {
                    return Json("rendering parameter is missing ex: /m1api/itemrendering?id=''&rid=''");
                }

            }
            catch (Exception ex)
            {
                var error = ex.Message;
                return Json(error);
            }

        }

        /// <summary>
        /// ~/m1api/getmatchingitems?fid=75577384-3C97-45DA-A847-81B00500E250&fvalue=Experience
        /// returns all fields of all the rendering items
        /// </summary>
        public JsonResult GetSitecoreMatchingItems(string fid, string fvalue)
        {
            try
            {
                //check input string is valid GUID or not
                if (IsGuid(fid) == true && fvalue != null)
                {
                    if (fid != null)
                    {
                        var items = Sitecore.Context.Database.GetItem("/sitecore/").Axes.GetDescendants().Where(i => i.Fields[ID.Parse(fid)].Value.ToLower().Contains(fvalue.ToLower()));
                        Dictionary<string, string> directory = new Dictionary<string, string>();
                        foreach (var item in items)
                        {
                            directory.Add(item.Name,item.Paths.FullPath);
                        }
                        return Json(directory);
                    }
                    else
                    {
                        return Json("Field ID doesn't exist in sitecore");
                    }
                }
                else
                {
                    return Json("Field Id is not valid or fvalue is missing");
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                return Json(error);
            }
        }


    }
}