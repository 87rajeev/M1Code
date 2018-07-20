using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Feature.StockInformation.Models
{
    /// <summary>
    /// IStockInformationRepositiry Interface
    /// <para></para>
    /// <para>Path: /sitecore/templates/User Defined/m1/M1CP/Feature/StockInformation/_StockInformation</para>	
    /// <para>ID: FB6017B5-D3B6-45BC-BEA0-48A44D648024</para>	
    /// </summary>

    [SitecoreType(TemplateId = Templates.StockInformation.TemplateIdString, AutoMap = true)]
    public interface IStockInformation : IGlassBase
    {
        [SitecoreField(Templates.StockInformation.Fields.ExchangeName)]
        string Exchange { get; set; }

        [SitecoreField(Templates.StockInformation.Fields.IndustryName)]
        string Industry { get; set; }

        [SitecoreField(Templates.StockInformation.Fields.IssuedSharesName)]
        string IssuedShares { get; set; }

        [SitecoreField(Templates.StockInformation.Fields.IssuedCapitalName)]
        string IssuedCapital { get; set; }

        [SitecoreField(Templates.StockInformation.Fields.AxiataInvestmentsName)]
        string AxiataInvestments { get; set; }

        [SitecoreField(Templates.StockInformation.Fields.KeppelTelecomsName)]
        string KeppelTelecoms { get; set; }

        [SitecoreField(Templates.StockInformation.Fields.SPHMultimediaName)]
        string SPHMultimedia { get; set; }

        [SitecoreField(Templates.StockInformation.Fields.ProfileLastUpdateName)]
        string ProfileLastUpdate { get; set; }

        [SitecoreField(Templates.StockInformation.Fields.MajorShareholderLastUpdateName)]
        string MajorShareholderLastUpdate { get; set; }
    }
}
