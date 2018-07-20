namespace M1CP.Foundation.AssetsIncludes.Pipelines.GetPageRendering
{
    using System.Linq;
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using M1CP.Foundation.AssetsIncludes.Models;
    using M1CP.Foundation.AssetsIncludes.Repositories;
    using M1CP.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.Mvc.Pipelines.Response.GetPageRendering;
    using Sitecore.Mvc.Presentation;
    using M1CP.Foundation.Base.Repositories;

    using M1CP.Foundation.DependencyInjection;
    using Glass.Mapper;

    public class AddPageAssets : GetPageRenderingProcessor
    {
        public override void Process(GetPageRenderingArgs args)
        {
            this.AddAssets(PageContext.Current.Item);
        }

        protected void AddAssets(Item item)
        {
            //var styling = this.GetPageAssetValue(item, Templates.PageAssets.Fields.CssCode);


            //if (!string.IsNullOrWhiteSpace(styling))
            //{
            //    AssetRepository.Current.AddInlineStyling(styling, true);
            //}
            AssetRepository.Current.AddInlineStyling(item, true);
            AssetRepository.Current.AddInlineScript(item, ScriptLocation.Head, true);
            AssetRepository.Current.AddGAScript(item, ScriptLocation.Body, true);
            //            AssetRepository.Current.AddInlineScript(item, ScriptLocation.Body, true);
            //var scriptBottom = this.GetPageAssetValue(item, Templates.PageAssets.Fields.JavascriptCodeBottom);
            //if (!string.IsNullOrWhiteSpace(scriptBottom))
            //{
            //    AssetRepository.Current.AddInlineScript(scriptBottom, ScriptLocation.Body, true);
            //}
            //var scriptHead = this.GetPageAssetValue(item, Templates.PageAssets.Fields.JavascriptCodeTop);
            //if (!string.IsNullOrWhiteSpace(scriptHead))
            //{
            //    AssetRepository.Current.AddInlineScript(scriptHead, ScriptLocation.Head, true);
            //}

            //var scriptGoogle = this.GetPageAssetValue(item, Templates.PageAssets.Fields.GACode);
            //if (!string.IsNullOrWhiteSpace(scriptGoogle))
            //{
            //    AssetRepository.Current.AddInlineScript(scriptGoogle, ScriptLocation.Body, true);
            //}
        }

        private string GetPageAssetValue(Item item, ID assetField)
        {
            if (item.IsDerived(Templates.PageAssets.ID))
            {
                var assetValue = item[assetField];
                if (!string.IsNullOrWhiteSpace(assetValue))
                {
                    return assetValue;
                }
            }
            return null;
            //return GetInheritedPageAssetValue(item, assetField);
        }

        //private static string GetInheritedPageAssetValue(Item item, ID assetField)
        //{
        //    var inheritedAssetItem = item.Axes.GetAncestors().FirstOrDefault(i => i.IsDerived(Templates.PageAssets.ID) && MainUtil.GetBool(item[Templates.PageAssets.Fields.InheritAssets], false) && string.IsNullOrWhiteSpace(item[assetField]));
        //    return inheritedAssetItem?[assetField];
        //}
    }
}