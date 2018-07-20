using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using System;

namespace M1CP.Feature.FAQ.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IFAQ : IGlassBase
    {      
        [SitecoreField(Templates._FAQ.Fields.AnswerFieldName)]
        string Answer { get; set; }

        [SitecoreField(Templates._FAQ.Fields.QuestionFieldName)]
        string Question { get; set; }
    }
}