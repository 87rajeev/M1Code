using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace M1CP.Foundation.Base.Extensions
{
    public static class StringExtensions
    {
   
        public static string SafeReplace(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str=str.Replace("'", "");
                str = str.Replace(";", "");
                str = str.Replace("&#39;", "");
             
                str = Regex.Replace(str, @"char\(\s*\d+\s*\)", ""); 
            }
            return str;
        }
     
        public static string CompleteComma(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Substring(0, 1) != ",") str = "," + str;
                if (str.Substring(str.Length - 1, 1) != ",") str += ",";
            }
            return str;
        }
      
        public static string ClearComma(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = Regex.Replace(str, "^,+", "");
                str = Regex.Replace(str, ",+$", "");
            }
            return str;
        }
   
        public static string MakeRepeatChar(this string str, int n)
        {
            if (n > 0)
            {
                string ostr = str;
                for (int i = 1; i < n; i++)
                {
                    str += ostr;
                }
                return str;
            }
            else
            {
                return "";
            }
        }
     
        public static int GetNlength(this string str)
        {
            Char[] cc = str.ToCharArray();
            int intLen = str.Length;
            int i;
            for (i = 0; i < cc.Length; i++)
            {
                if (cc[i] > 255)
                {
                    intLen++;
                }
            }
            return intLen;
        }
      
        public static string Concat(this string str, int n, string Suffix="...")
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Length > n)
                {
                    str = str.Substring(0, n);
                    str += Suffix;
                }
            }
            return str;
        }
        
        public static string Ncat(this string str, int n, string Suffix="...")
        {
            Char[] c = str.ToCharArray();
            int i, intLen = 0;
            string newStr = "";
            for (i = 0; i < c.Length; i++)
            {
                if (intLen >= n)
                {
                    return newStr;
                }
                newStr += c[i];

                if (c[i] > 255)
                {
                    intLen += 2;
                }
                else 
                {
                    intLen++;
                }
            }
            newStr += Suffix;
            return newStr;
        }
    
        public static string BRToNewLine(this string str, string brstr = "\n")
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = Regex.Replace(str, "<br[^>]*>", brstr);
            }
            return str;
        }
      
        public static string NewLineToBR(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = Regex.Replace(str, "\r\n", "<br />");
                str = Regex.Replace(str, "\r", "<br />");
                str = Regex.Replace(str, "\n", "<br />");
            }
            return str;
        }
      
        public static string ClearNewLine(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = Regex.Replace(str, "\r\n", "");
                str = Regex.Replace(str, "\r", "");
                str = Regex.Replace(str, "\n", "");
            }
            return str;
        }
      
        public static int[] SplitToInt(this string str,char charsplit)
        {
            string[] StrArr = str.Split(charsplit);
            int[] NewArr = new int[StrArr.Length];

            for (int i = 0; i < StrArr.Length; i++)
            {
                NewArr[i] = int.Parse(StrArr[i]);
            }
            return NewArr;
        }
       
        public static string RemoveHTML(this string Htmlstring)
        {
            //remove the header
            Htmlstring = Regex.Replace(Htmlstring, "(<head>).*(</head>)", string.Empty, RegexOptions.IgnoreCase);
            //remove all styles
            Htmlstring = Regex.Replace(Htmlstring, @"<style([^>])*?>", "<style>", RegexOptions.IgnoreCase);
    
            Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
         
            Htmlstring = Regex.Replace(Htmlstring, @"<br([^>]*)>", "{-br-}", RegexOptions.IgnoreCase);
          
            Htmlstring = Regex.Replace(Htmlstring, @"<[^>]*?>", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);
         
            Htmlstring = Htmlstring.Replace("{-br-}", "<br/>");

            Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", "   ", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);

    

            return Htmlstring;
        }
   
        public static string RemoveSpace(this string str)
        {
            str = Regex.Replace(str, @"\s", string.Empty, RegexOptions.IgnoreCase);
            str = Regex.Replace(str, @"&nbsp;", string.Empty, RegexOptions.IgnoreCase);
            return str;
        }
    
    
        public static string Escape(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str) {
                sb.Append((Char.IsLetterOrDigit(c) || c == '-' || c == '_' || c == '\\' || c == '/' || c == '.') ? c.ToString() : Uri.HexEscape(c)); 
            } 
            return sb.ToString();
        }
  
        public static string UnEscape(this string str)
        {
            StringBuilder sb = new StringBuilder();
            int len = str.Length;
            int i = 0;
            while (i != len)
            {
                if (Uri.IsHexEncoding(str, i)) sb.Append(Uri.HexUnescape(str, ref i));
                else sb.Append(str[i++]);
            }
            return sb.ToString();
        }
    
        public static bool isEmail(this string str)
        {
            bool ismail = false;
            if (!string.IsNullOrWhiteSpace(str))
            {
                string emailpattren = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))";
                if (Regex.IsMatch(str, emailpattren))
                {
                    ismail = true;
                }
            }
            return ismail;
        }

        #region Html 
   
        public static string HtmlEncode(string str)
        {
            str = str.Replace("&", "&amp;");
            str = str.Replace("'", "''");
            str = str.Replace("\"", "&quot;");
            str = str.Replace(" ", "&nbsp;");
            str = str.Replace("<", "&lt;");
            str = str.Replace(">", "&gt;");
            str = str.Replace("\n", "<br>");
            str = str.Replace("\r", "<br>");
            str = str.Replace("\r\n", "<br>");
            return str;
        }
 
        public static string HtmlDecode(string str)
        {
            str = str.Replace("<br>", "\n");
            str = str.Replace("&gt;", ">");
            str = str.Replace("&lt;", "<");
            str = str.Replace("&nbsp;", " ");
            str = str.Replace("&quot;", "\"");
            return str;
        }
        #endregion
    }
}
