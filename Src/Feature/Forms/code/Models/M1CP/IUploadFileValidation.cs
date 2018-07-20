using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.UploadFileValidation.TemplateIdString, AutoMap = true)]
    public interface IUploadFileValidation
    {
        [SitecoreField(Templates.UploadFileValidation.Fields.MaximumUploadedFileSize)]
        string MaximumUploadedFileSize { get; set; }

        [SitecoreField(Templates.UploadFileValidation.Fields.UploadedFileFormat)]
        string UploadedFileFormat { get; set; }


    }
}