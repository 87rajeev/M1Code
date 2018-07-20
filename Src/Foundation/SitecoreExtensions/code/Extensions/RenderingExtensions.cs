namespace M1CP.Foundation.SitecoreExtensions.Extensions
{
    using System;
    using Sitecore;
    using Sitecore.Mvc.Presentation;
    using Newtonsoft.Json;

    public static class RenderingExtensions
    {
        public static int GetIntegerParameter(this Rendering rendering, string parameterName, int defaultValue = 0)
        {
            if (rendering == null)
            {
                throw new ArgumentNullException(nameof(rendering));
            }

            var parameter = rendering.Parameters[parameterName];
            if (string.IsNullOrEmpty(parameter))
            {
                return defaultValue;
            }

            int returnValue;
            return !int.TryParse(parameter, out returnValue) ? defaultValue : returnValue;
        }

        public static T GetParameters<T>(this Rendering rendering)
        {
            if (rendering == null)
            {
                throw new ArgumentNullException(nameof(rendering));
            }
            JsonSerializer serializer = new JsonSerializer();
            var parameter = JsonConvert.DeserializeObject<T>(rendering.Parameters.ToJson());
            return parameter;        
        }

        public static bool GetUseStaticPlaceholderNames([NotNull] this Rendering rendering)
        {
            return MainUtil.GetBool(rendering.Parameters[M1CP.Foundation.SitecoreExtensions.Constants.DynamicPlaceholdersLayoutParameters.UseStaticPlaceholderNames], false);
        }

        public static bool IsContainerFluid([NotNull] this Rendering rendering)
        {
            return MainUtil.GetBool(rendering.Parameters[M1CP.Foundation.SitecoreExtensions.Constants.HasContainerLayoutParameters.IsFluid], false);
        }
        public static string GetContainerClass([NotNull] this Rendering rendering)
        {
            return rendering.IsContainerFluid() ? "container-fluid" : "container";
        }
    }
}