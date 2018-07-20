using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Form.Models.Events
{
    public interface IFormActionEvent
    {
        NameValueCollection Data { get; set; }
        bool ContinueOnError { get; set; }
        void Do(ActionArguments args);
    }
    public class ActionArguments
    {
        public bool Abort { get; set; }
        public FormModel FormData { get; set; }
    }
}