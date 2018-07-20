using M1CP.Feature.Form.Models;
using M1CP.Feature.Form.Models.Events;
using M1CP.Feature.Forms;
using M1CP.Feature.Forms.Models.M1CP;
using M1CP.Feature.Forms.Repository.M1CP;
using M1CP.Feature.Forms.Service.M1CP;
using M1CP.Foundation.FileUpload.Controllers.M1CP;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace M1CP.Feature.Form.Repository
{
    public class FormRepository : Controller, IFormRepository
    {
        public HttpRequestBase requestobject;
        ISitecoreBuilder _formrepo;
        public FormRepository()
        {
            _formrepo = new SitecoreBuilder();
        }


        public IForms LoadForm(Item currentItem)
        {
            return ConstructForm(currentItem);
        }


        public IForms LoadFormById(Item formfield, HttpRequestBase requests)
        {
            requestobject = requests;
            return ValidateForm(formfield);
        }


        public void UploadFiles()
        {
            if (requestobject.Files.Count > 0)
            {
                FileUploadController fileupload = new FileUploadController();
                foreach (string filename in requestobject.Files)
                {
                    HttpPostedFileBase file = requestobject.Files[filename];
                    fileupload.UploadFile(file);
                }
            }
        }

        public void SaveToDatabase()
        {
            {
                UploadFiles();
                StringBuilder coloumnSQL = new StringBuilder();
                StringBuilder fieldSQL = new StringBuilder();
                Dictionary<string, string> dict = new Dictionary<string, string>();
                string strcon = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                //Get FORM details
                var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
                var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);
                string saveEvent = dataSource["Form Events"];
                var saveID = Sitecore.Context.Database.GetItem(saveEvent);
                string tableName = saveID["SQLTable"];
                var selectedFields = Sitecore.Data.ID.ParseArray(saveID["SQLFields"]);
                //Form SQLQuery 
                foreach (var loginFields in selectedFields)
                {
                    if (Request.Form[Sitecore.Context.Database.GetItem(loginFields).Name] != null)
                    {
                        var form = Request.Form[Sitecore.Context.Database.GetItem(loginFields).Name];
                        dict.Add(Sitecore.Context.Database.GetItem(loginFields)["SQL ColoumnName"], Request.Form[Sitecore.Context.Database.GetItem(loginFields).Name]);
                        coloumnSQL.Append(Sitecore.Context.Database.GetItem(loginFields)["SQL ColoumnName"]);
                        coloumnSQL.Append(",");
                        fieldSQL.Append("@");
                        fieldSQL.Append(Sitecore.Context.Database.GetItem(loginFields)["SQL ColoumnName"]);
                        fieldSQL.Append(",");
                    }
                }
                coloumnSQL.Remove(coloumnSQL.Length - 1, 1);
                fieldSQL.Remove(fieldSQL.Length - 1, 1);
                string query = "INSERT INTO " + tableName + " (" + coloumnSQL + ")" +
                      " VALUES (" + fieldSQL + " )";

                // Create connection and command
                using (SqlConnection cn = new SqlConnection(strcon))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    foreach (KeyValuePair<string, string> pair in dict)
                    {
                        cmd.Parameters.Add(new SqlParameter(pair.Key.ToString(), pair.Value.ToString()));
                    }

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }


        private IForms ConstructForm(Item currentItem)
        {
            IForms form = _formrepo.GetFormData(currentItem);
            return form;
        }

        private IForms ValidateForm(Item currentItem)
        {
            IForms form = _formrepo.GetFormData(currentItem);
            form.FieldGroups = form.FieldGroups.Where(i => i != null).Select(ConstructFormFieldGroup).ToList();
            if (form.FieldGroups.Any(b => b.ApplyValidation == true))
            {
                form.FormInvalid = true;

            }
            return form;
        }

        private IListFormField ContructFormFields(IListFormField formitem)
        {
            formitem.Validations = formitem.Validations.Select(r => ValidateField(r, formitem.SitecoreItemId.ToString(), formitem.Type.Text)).ToList();
            formitem.ValidationMessage = formitem.Validations.Where(b => b.SitecoreValidationMessage != string.Empty).Select(n => n.SitecoreValidationMessage).FirstOrDefault();
            return formitem;

        }

        private IFormValidationBase ValidateField(IFormValidationBase validationitem, string sitecoreid, string fieldtype)
        {
            validationitem.SitecoreValidationMessage = ValidationMessage(validationitem, sitecoreid, fieldtype.ToLower());
            return validationitem;
        }

        private string ValidationMessage(IFormValidationBase validationitem, string sitecoreid, string fieldtype)
        {
            string errormessage = string.Empty;
            string fieldValue = requestobject.Form[sitecoreid];
            if (validationitem.Regex != string.Empty && sitecoreid != string.Empty && validationitem.Regex != null)
            {
                if (fieldtype == Constants.FormControls.TextBox || fieldtype == Constants.FormControls.TextArea || fieldtype == Constants.FormControls.Password || fieldtype == Constants.FormControls.DateTime)
                {
                    Regex regex = new Regex(validationitem.Regex);
                    Match match = regex.Match(fieldValue);
                    if (!match.Success)
                    {
                        errormessage = validationitem.Validation_Message;
                    }
                }
            }
            if (validationitem.IsRequired == true)
            {
                if ((fieldtype == Constants.FormControls.RadioButton || fieldtype == Constants.FormControls.TextBox || fieldtype == Constants.FormControls.TextArea || fieldtype == Constants.FormControls.Password || fieldtype == Constants.FormControls.Select || fieldtype == Constants.FormControls.RadioButton || fieldtype == Constants.FormControls.Checkbox || fieldtype == Constants.FormControls.Disclaimer || fieldtype == Constants.FormControls.DateTime || fieldtype == Constants.FormControls.MultiSelectDropdown) && (requestobject.Form[sitecoreid] == string.Empty || requestobject.Form[sitecoreid] == null || requestobject.Form[sitecoreid].Count() == 0))
                {
                    errormessage = validationitem.Validation_Message;
                }
                if (fieldtype == Constants.FormControls.File && requestobject.Files[sitecoreid].ContentLength == 0)
                {
                    errormessage = validationitem.Validation_Message;
                }

            }

            if (validationitem.MaximumUploadedFileSize != null && validationitem.MaximumUploadedFileSize != string.Empty)
            {
                if ((fieldtype == Constants.FormControls.File && requestobject.Files[sitecoreid].ContentLength > Convert.ToInt64(validationitem.MaximumUploadedFileSize)))
                    {
                    errormessage = validationitem.Validation_Message;
                }

            }

            if (validationitem.UploadedFileFormat != null && validationitem.UploadedFileFormat != string.Empty)
            {
                string[] validatefileextension = validationitem.UploadedFileFormat.ToLower().Split(',');
                if (!validatefileextension.Contains(System.IO.Path.GetExtension(requestobject.Files[sitecoreid].FileName).ToLower()))
                {
                    errormessage = validationitem.Validation_Message;
                }

            }
            return errormessage;
        }


        private IFormFieldGroup ConstructFormFieldGroup(IFormFieldGroup fieldGroup)
        {
            if (fieldGroup != null)
            {
                fieldGroup.Fields = fieldGroup.Fields.Where(i => i != null).Select(ContructFormFields).ToList();
                if (fieldGroup.Fields.Any(b => b.ValidationMessage != "" && b.ValidationMessage != null))
                {
                    fieldGroup.ApplyValidation = true;
                }
            }
            return fieldGroup;
        }
    }
}