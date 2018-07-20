
namespace M1CP.Feature.Carousal.Models
{
    using Foundation.GlassMapper.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;

    [SitecoreType(TemplateId = Templates.CarousalParameter.TemplateIdString, AutoMap = true)]
    public interface ICarousalParameter: IComponentItemMaxMin
    {
        ///// <summary>
        ///// The Max Value field.
        ///// <para></para>
        ///// <para>Field Type: Number</para>		
        ///// <para>Field ID: A4441F0F-C14F-47EE-8FF7-5C5292B51EF8</para>
        ///// <para>Custom Data: </para>
        ///// </summary>
        ///// 
        //[SitecoreField(Templates.CarousalParameter.Fields.MaxValueFieldName)]
        //public float MaxValue { get; set; }

        ///// <summary>
        ///// The Min Value field.
        ///// <para></para>
        ///// <para>Field Type: Number</para>		
        ///// <para>Field ID: 9235B2C0-9B9F-4621-80A3-D6B4F9BCD735</para>
        ///// <para>Custom Data: </para>
        ///// </summary>
        //[SitecoreField(Templates.CarousalParameter.Fields.MinValueFieldName)]
        //public float MinValue { get; set; }


        /// <summary>
        /// The Enable Auto Scroll field.
        /// <para></para>
        /// <para>Field Type: Checkbox</para>		
        /// <para>Field ID: 251E946A-62F2-4A1F-BBFD-BB97F5CD26C1</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.CarousalParameter.Fields.EnableAutoScrollFieldName)]
        bool AutoScroll { get; set; }

        /// <summary>
        /// The Enable Infinite field.
        /// <para></para>
        /// <para>Field Type: Checkbox</para>		
        /// <para>Field ID: 248F9C08-A227-4D5E-81CA-E6D96783D4CE</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.CarousalParameter.Fields.EnableInfiniteScrollFieldName)]
        bool InfiniteScroll { get; set; }

        /// <summary>
        /// The Carousal Speed field.
        /// <para></para>
        /// <para>Field Type: Number</para>		
        /// <para>Field ID: AC84D9CB-B1F7-4E08-823E-25CF2E0FE36D</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.CarousalParameter.Fields.CarousalSpeedFieldName)]
        float Carousal_Speed { get; set; }

        /// <summary>
        /// The Auto Play field.
        /// <para></para>
        /// <para>Field Type: Number</para>		
        /// <para>Field ID: D9CA8F64-B96E-42A8-855F-4B74C8C6DEE6</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.CarousalParameter.Fields.AutoPlaySpeedFieldName)]
        float AutoPlaySpeed { get; set; }

    }
}