namespace M1CP.Foundation.LocalDatasource.Infrastructure.Pipelines
{
  using System.Collections.Generic;
  using System.Linq;
  using Sitecore.ContentSearch;
  using Sitecore.ContentSearch.Pipelines.GetDependencies;
  using Sitecore.Data.Items;
  using Sitecore.Diagnostics;
  using M1CP.Foundation.LocalDatasource.Extensions;

  public class GetLocalDatasourceDependencies : BaseProcessor
  {
    public override void Process(GetDependenciesArgs args)
    {
      Assert.IsNotNull(args.Dependencies, "Dependencies is null");
      Item item = args.IndexedItem as SitecoreIndexableItem;
      if (item == null)
        return;

      if (item.IsLocalDatasourceItem())
        this.AddLocalDatasourceParentDependency(item, args.Dependencies);
    }

    private void AddLocalDatasourceParentDependency(Item item, List<IIndexableUniqueId> dependencies)
    {
      var localDatasourceFolder = item.GetParentLocalDatasourceFolder();
      if (localDatasourceFolder?.Parent == null)
        return;
      dependencies.Add((SitecoreItemUniqueId)localDatasourceFolder.Parent.Uri);
    }
  }
}