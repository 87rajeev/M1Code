using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Base.Extensions
{
    public class ExtensionHelper
    {
        private static string SplitId(string myId)
        {
            var myIDdata = myId.Split('-');
            string newId = myIDdata[0];

            if (myIDdata.Count() > 1)
                newId += myIDdata[1];

            return newId;
        }

        public static string ParseId(Guid myId)
        {
            return SplitId(myId.ToString());
        }
    }
}