using M1CP.Foundation.GlassMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace M1CP.Foundation.Base.Helpers
{
    public static class HTMLHelper
    {
        public static string BuildPictureTag(CustomImage Model, string Class = null,bool IstopBanner=false)
        {
            StringBuilder PictureTag = new StringBuilder();
            PictureTag.Append("<picture class=\"" + (Class!=null? Class : "") + "\">");
            if (Model != null)
            {
                if (IstopBanner)
                {
                    PictureTag.Append("<source media=\"(" + (Model.MediaQuery != null ? Model.MediaQuery.Dimension : "") + ")\" srcset = \"" + Model.Src + "\" >");
                }
                else
                {
                    PictureTag.Append("<data-src media=\"(" + (Model.MediaQuery != null ? Model.MediaQuery.Dimension : "") + ")\" srcset = \"" + Model.Src + "\" ></data-src>");
                }
                if (Model.children != null)
                {
                    foreach (var image in Model.children)
                    {
                        if (IstopBanner)
                        {
                            PictureTag.Append("<source media=\"(" + (image.Dimension != null ? image.Dimension : "") + ")\" srcset = \"" + image.URL + "\" >");
                        }
                        else
                        {
                            PictureTag.Append("<data-src media=\"(" + (image.Dimension != null ? image.Dimension : "") + ")\" srcset = \"" + image.URL + "\" ></data-src>");
                        }
                    }
                }
                if (IstopBanner)
                {
                    PictureTag.Append("<img src=\"" + Model.Src + "\" alt=\"" + Model.Alt + "\">");
                }
                else
                {
                    PictureTag.Append("<data-img src=\"../images/thumb.gif\" class=\"img-responsive imagewidthloader\" data-src=\"" + Model.Src + "\" alt=\"" + Model.Alt + "\"></data-img>");
                }
            }
            PictureTag.Append("</picture>");
            return PictureTag.ToString();
        }
    }
}