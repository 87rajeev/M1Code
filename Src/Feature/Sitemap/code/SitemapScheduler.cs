using M1CP.Feature.Sitemap.Models;
using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Sitemap
{
    public class SitemapScheduler
    {
        public void Run()
        {
            Log.Info("Sitemap sechedule task - Start", this);
            var sh = new SitemapHandler();
            sh.RefreshSitemap(this, new EventArgs());
            Log.Info("Sitemap sechedule task - End", this);
        }
    }
}