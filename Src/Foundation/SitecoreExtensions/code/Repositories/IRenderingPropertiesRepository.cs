namespace M1CP.Foundation.SitecoreExtensions.Repositories
{
    using Sitecore.Mvc.Presentation;

    public interface IRenderingPropertiesRepository
  {
    T Get<T>(Rendering rendering);
  }
}