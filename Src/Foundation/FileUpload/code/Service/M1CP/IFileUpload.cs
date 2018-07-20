using M1CP.Feature.Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M1CP.Foundation.FileUpload.Service.M1CP
{
    public interface IFileUpload
    {
        string UploadFile(FileDetails filesinput);
        DownloadFile DownloadFilefromId(string id);
        void DeleteFile(string id);
    }
}