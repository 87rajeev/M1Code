using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.UI;
using Sitecore;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Globalization;
using Sitecore.IO;
using Sitecore.Resources;
using Sitecore.Text;
using Sitecore.Web;
using Sitecore.Web.UI;
using Sitecore.Web.UI.HtmlControls;
using Sitecore.Web.UI.Pages;
using Sitecore.Web.UI.Sheer;

namespace M1CP.Foundation.SitecoreExtensions.Dialogs
{


    public class SetIconForm : DialogForm
    {
        protected Scrollbox CustomList { get; set; }
        protected Scrollbox ApplicationsV2List { get; set; }
        protected Scrollbox FlagsV2List { get; set; }
        protected Scrollbox BusinessV2List { get; set; }
        protected Scrollbox NetworkV2List { get; set; }
        protected Scrollbox PeopleV2List { get; set; }
        protected Scrollbox SoftwareV2List { get; set; }

        protected Scrollbox ApplicationsList { get; set; }

        protected Scrollbox AppsList { get; set; }

        protected Scrollbox BusinessList { get; set; }

        protected Scrollbox ControlsList { get; set; }

        protected Scrollbox Core1List { get; set; }

        protected Scrollbox Core2List { get; set; }

        protected Scrollbox Core3List { get; set; }

        protected Scrollbox DatabaseList { get; set; }

        protected Scrollbox FlagsList { get; set; }

        protected Edit IconFile { get; set; }

        protected Scrollbox ImagingList { get; set; }

        protected Scrollbox MultimediaList { get; set; }

        protected Scrollbox NetworkList { get; set; }

        protected Scrollbox OfficeList { get; set; }

        protected Scrollbox OfficeWhiteList { get; set; }

        protected Scrollbox OtherList { get; set; }

        protected Scrollbox PeopleList { get; set; }

        protected Scrollbox RecentList { get; set; }

        protected Scrollbox SoftwareList { get; set; }

        protected VerticalTabstrip TabStrip { get; set; }

        protected Scrollbox WordProcessingList { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            Assert.ArgumentNotNull((object)e, "e");
            base.OnLoad(e);
            this.TabStrip.OnChange += new EventHandler(this.TabStrip_OnChange);
            if (Context.ClientPage.IsEvent)
                return;
            Item itemFromQueryString = UIUtil.GetItemFromQueryString(Database.GetDatabase(WebUtil.GetQueryString("sc_content", Context.ContentDatabase.Name)));
            Assert.IsNotNull((object)itemFromQueryString, typeof(Item));
            string queryString = WebUtil.GetQueryString("fld_id");
            if (string.IsNullOrEmpty(queryString))
                this.IconFile.Value = itemFromQueryString.Appearance.Icon;
            else
                this.IconFile.Value = itemFromQueryString.Fields[ID.Parse(queryString)].Value;
            this.RenderIcons();
            this.RenderRecentIcons();
        }

        protected override void OnOK(object sender, EventArgs args)
        {
            Assert.ArgumentNotNull(sender, "sender");
            Assert.ArgumentNotNull((object)args, "args");
            SheerResponse.SetDialogValue(this.IconFile.Value);
            base.OnOK(sender, args);
        }

        protected void TabStrip_OnChange(object sender, EventArgs e)
        {
            Assert.ArgumentNotNull(sender, "sender");
            Assert.ArgumentNotNull((object)e, "e");
            SheerResponse.Eval("scUpdateControls();");
        }

        private static void DrawIcons(string prefix, string img, string area)
        {
            string[] files = SetIconForm.GetFiles(prefix);
            int num1 = files.Length;
            if (num1 == 0)
                num1 = 1;
            int height = (num1 / 24 + (num1 % 24 == 0 ? 0 : 1)) * 40;
            using (Bitmap bitmap1 = new Bitmap(960, height, PixelFormat.Format32bppArgb))
            {
                if (prefix == "OfficeWhite")
                    Graphics.FromImage((System.Drawing.Image)bitmap1).FillRectangle(Brushes.DarkGray, 0, 0, 960, height);
                HtmlTextWriter htmlTextWriter = new HtmlTextWriter((TextWriter)new StringWriter());
                htmlTextWriter.WriteLine("<map name=\"" + prefix + "\">");
                string relativeIconPath = prefix + "/32x32/";
                int num2 = 0;
                using (Graphics graphics = Graphics.FromImage((System.Drawing.Image)bitmap1))
                {
                    foreach (string path in files)
                    {
                        int num3 = num2 % 24;
                        int num4 = num2 / 24;
                        string themedImageSource = Images.GetThemedImageSource(relativeIconPath + path, ImageDimension.id32x32);
                        try
                        {
                            using (Bitmap bitmap2 = Settings.Icons.UseZippedIcons ? new Bitmap(ZippedIcon.GetStream(relativeIconPath + path, ZippedIcon.GetZipFile(relativeIconPath))) : new Bitmap(FileUtil.MapPath(themedImageSource)))
                                graphics.DrawImage((System.Drawing.Image)bitmap2, num3 * 40 + 4, num4 * 40 + 4, 32, 32);
                            string str1 = string.Format("{0},{1},{2},{3}", (object)(num3 * 40 + 4), (object)(num4 * 40 + 4), (object)(num3 * 40 + 36), (object)(num4 * 40 + 36));
                            string str2 = StringUtil.Capitalize(Path.GetFileNameWithoutExtension(path).Replace("_", " "));
                            htmlTextWriter.WriteLine("<area shape=\"rect\" coords=\"{0}\" href=\"#\" alt=\"{1}\" sc_path=\"{2}\"/>", (object)str1, (object)str2, (object)(relativeIconPath + path));
                            ++num2;
                        }
                        catch (Exception ex)
                        {
                            Log.Warn("Unable to open icon " + themedImageSource, ex, (object)typeof(SetIconForm));
                        }
                    }
                }
                htmlTextWriter.WriteLine("</map>");
                FileUtil.WriteToFile(area, htmlTextWriter.InnerWriter.ToString());
                bitmap1.Save(img, ImageFormat.Png);
            }
        }

        private static string GetFilename(string prefix)
        {
            return FileUtil.MapPath(FileUtil.MakePath(TempFolder.Folder, "icons_" + prefix + ".png"));
        }

        private static string[] GetFiles(string prefix)
        {
            Assert.ArgumentNotNullOrEmpty(prefix, "prefix");
            if (!Settings.Icons.UseZippedIcons)
                return SetIconForm.GetFolderFiles(prefix);
            return SetIconForm.GetZippedFiles(prefix);
        }

        private static string[] GetFolderFiles(string prefix)
        {
            string[] files = Directory.GetFiles(FileUtil.MapPath("/sitecore/shell/themes/standard/" + prefix + "/32x32"));
            for (int index = 0; index < files.Length; ++index)
                files[index] = Path.GetFileName(files[index]);
            return files;
        }

        private static string[] GetZippedFiles(string prefix)
        {
            return ZippedIcon.GetFiles(prefix, "/sitecore/shell/themes/standard/" + prefix + ".zip");
        }

        private static void RenderIcons(Scrollbox scrollbox, string prefix)
        {
            Assert.ArgumentNotNull((object)scrollbox, "scrollbox");
            Assert.ArgumentNotNullOrEmpty(prefix, "prefix");
            string filename = SetIconForm.GetFilename(prefix);
            string str = Path.ChangeExtension(filename, ".html");
            if (!File.Exists(filename) || !File.Exists(str))
                SetIconForm.DrawIcons(prefix, filename, str);
            HtmlTextWriter output = new HtmlTextWriter((TextWriter)new StringWriter());
            output.Write(FileUtil.ReadFromFile(str));
            SetIconForm.WriteImageTag(filename, prefix, output);
            scrollbox.InnerHtml = output.InnerWriter.ToString();
        }

        private void RenderIcons()
        {
            SetIconForm.RenderIcons(this.CustomList, "Custom");
            SetIconForm.RenderIcons(this.ApplicationsV2List, "ApplicationsV2");
            SetIconForm.RenderIcons(this.BusinessV2List, "BusinessV2");
            SetIconForm.RenderIcons(this.FlagsV2List, "FlagsV2");
            SetIconForm.RenderIcons(this.NetworkV2List, "NetworkV2");
            SetIconForm.RenderIcons(this.PeopleV2List, "PeopleV2");
            SetIconForm.RenderIcons(this.SoftwareV2List, "SoftwareV2");

            SetIconForm.RenderIcons(this.ApplicationsList, "Applications");
            SetIconForm.RenderIcons(this.AppsList, "Apps");
            SetIconForm.RenderIcons(this.BusinessList, "Business");
            SetIconForm.RenderIcons(this.ControlsList, "Control");
            SetIconForm.RenderIcons(this.Core1List, "Core");
            SetIconForm.RenderIcons(this.Core2List, "Core2");
            SetIconForm.RenderIcons(this.Core3List, "Core3");
            SetIconForm.RenderIcons(this.DatabaseList, "Database");
            SetIconForm.RenderIcons(this.FlagsList, "Flags");
            SetIconForm.RenderIcons(this.ImagingList, "Imaging");
            SetIconForm.RenderIcons(this.MultimediaList, "Multimedia");
            SetIconForm.RenderIcons(this.NetworkList, "Network");
            SetIconForm.RenderIcons(this.OfficeList, "Office");
            SetIconForm.RenderIcons(this.OfficeWhiteList, "OfficeWhite");
            SetIconForm.RenderIcons(this.OtherList, "Other");
            SetIconForm.RenderIcons(this.PeopleList, "People");
            SetIconForm.RenderIcons(this.SoftwareList, "Software");
            SetIconForm.RenderIcons(this.WordProcessingList, "WordProcessing");
        }

        private void RenderRecentIcons()
        {
            int num = 0;
            ListString listString = new ListString(Registry.GetString("/Current_User/RecentIcons"));
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter((TextWriter)new StringWriter());
            ImageBuilder imageBuilder = new ImageBuilder()
            {
                Width = 32,
                Height = 32
            };
            foreach (string str in listString)
            {
                imageBuilder.Src = Images.GetThemedImageSource(str, ImageDimension.id32x32);
                imageBuilder.Alt = StringUtil.Capitalize(FileUtil.GetFileNameWithoutExtension(str).Replace("_", " "));
                imageBuilder.Class = "scRecentIcon";
                htmlTextWriter.Write(imageBuilder.ToString());
                ++num;
            }
            if (num == 0)
            {
                htmlTextWriter.Write("<div align=\"center\" style=\"padding:32px 0px 0px 0px\"><i>");
                htmlTextWriter.Write(Translate.Text("There are no icons to display."));
                htmlTextWriter.Write("</i></div>");
            }
            this.RecentList.InnerHtml = htmlTextWriter.InnerWriter.ToString();
        }

        private static void WriteImageTag(string img, string prefix, HtmlTextWriter output)
        {
            Assert.ArgumentNotNull((object)img, "img");
            Assert.ArgumentNotNull((object)prefix, "prefix");
            Assert.ArgumentNotNull((object)output, "output");
            ImageBuilder imageBuilder;
            using (Bitmap bitmap = new Bitmap(img))
                imageBuilder = new ImageBuilder()
                {
                    Src = FileUtil.UnmapPath(img),
                    Width = bitmap.Width,
                    Height = bitmap.Height,
                    Usemap = "#" + prefix
                };
            output.WriteLine(imageBuilder.ToString());
        }
    }

}