using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Form.Models
{
    public class FileUpload
    {
      public IEnumerable<HttpPostedFileBase> file { get; set; }
    }

    public class FileDetails
    {
        public int UserId { get; set; }
        public int serviceId { get; set; }
        public HttpPostedFileBase FileContent { get; set; }

        public String DocumentType { get; set; }
    }

    public class DownloadFile
    {
        public string FileStream { get; set; }
        public string FileName { get; set; }
        public string FIleExtension { get; set; }

    }
    public class DownloadFiles
    {
        public string FileStream { get; set; }
        public string FileName { get; set; }
        public string FIleExtension { get; set; }

    }

}