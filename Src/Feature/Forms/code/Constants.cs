using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms
{
    public static class Constants
    {
        public static class Views
        {
            public const string FormIndexView = "~/Views/M1CP/Forms/Index.cshtml";
            public const string FieldView = "~/Views/M1CP/Forms/Fields/";
            public const string ViewExtension = ".cshtml";
            public const string ButtonView = "~/Views/M1CP/Forms/Buttons/";
        }

        public static class FormControls
        {
            public const string Checkbox = "checkbox";
            public const string DateTime = "datetime";
            public const string Disclaimer = "disclaimer";
            public const string File = "file";
            public const string HtmlContent = "htmlcontent";
            public const string MultiSelectDropdown = "multiselectdropdown";
            public const string Password = "password";
            public const string RadioButton = "radiobutton";
            public const string Select = "select";
            public const string TextArea = "textarea";
            public const string TextBox = "textbox";
        }
    }
}