using ASR.Interface;
using M1CP.Feature.ASRReports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.ASRReports.Filters
{
    public class SmartHomeSolutionFilter : BaseFilter
    {
        /// <summary>
        /// Filter for the from Date
        /// </summary>
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Filter for To date
        /// </summary>
        public DateTime ToDate { get; set; }
        /// <summary>
        /// Filter for Campaign
        /// </summary>
        public string  Campaign { get; set; }
        /// <summary>
        /// Filter the result and get the values by applying filter.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public override bool Filter(object element)
        {
            var logElement = element as SmartHomeSolution;
            DateTime dateCreated = (DateTime)logElement.CreateDate;
            var campaignName = logElement.CampaignName;
            if (String.IsNullOrEmpty(Campaign.Trim()))
            {
                if(FromDate<=dateCreated.Date && dateCreated.Date<= ToDate)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if(FromDate<=dateCreated.Date && dateCreated.Date<=ToDate && campaignName == Campaign.Trim())
                {
                    return true;
                }
                return false;
            }
        }
    }
}