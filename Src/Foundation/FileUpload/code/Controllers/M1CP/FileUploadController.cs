using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M1CP.Foundation.FileUpload.Service.M1CP;
using M1CP.Feature.Form.Models;

namespace M1CP.Foundation.FileUpload.Controllers.M1CP
{
    public class FileUploadController : Controller
    {
        IFileUpload _fileuploadrepo;
        public FileUploadController()
        {
            _fileuploadrepo = new FileUpload.Repositery.M1CP.FileUpload();
        }
        [HttpPost]
        public string UploadFile(HttpPostedFileBase filesinput)
        {
            FileDetails inputFileDetails = new FileDetails();
            inputFileDetails.FileContent = filesinput;
            inputFileDetails.serviceId = 111;
            inputFileDetails.UserId = 2222;
            return _fileuploadrepo.UploadFile(inputFileDetails);
        }

        public DownloadFile DownloadFilefromId(string id)
        {
            return _fileuploadrepo.DownloadFilefromId(id);
        }
        public void DeleteFile(string id)
        {
            _fileuploadrepo.DeleteFile(id);
        }

    }
}