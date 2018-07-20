/* *********************************************************************** *
 * File   : SitemapHandler.cs                             Part of Sitecore *
 * Version: 1.0.0                                         www.sitecore.net *
 *                                                                         *
 *                                                                         *
 * Purpose: Contains logic which fires when event submitted                *
 *                                                                         *
 * Copyright (C) 1999-2009 by Sitecore A/S. All rights reserved.           *
 *                                                                         *
 * This work is the property of:                                           *
 *                                                                         *
 *        Sitecore A/S                                                     *
 *        Meldahlsgade 5, 4.                                               *
 *        1613 Copenhagen V.                                               *
 *        Denmark                                                          *
 *                                                                         *
 * This is a Sitecore published work under Sitecore's                      *
 * shared source license.                                                  *
 *                                                                         *
 * *********************************************************************** */

using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using System;

namespace M1CP.Feature.Sitemap.Models
{
    public class SitemapHandler
    {
        public void RefreshSitemap(object sender, EventArgs args)
        {
            var sites = SitemapManagerConfiguration.GetSiteNames();
            foreach (var site in sites)
            {
                Log.Info("Sitemap Module - Function Has Been Started", this);
                var config = new SitemapManagerConfiguration(site);
                var sitemapManager = new SitemapManager(config);
                sitemapManager.SubmitSitemapToSearchenginesByHttp();

                if (!config.GenerateRobotsFile) continue;
                sitemapManager.RegisterSitemapToRobotsFile();
                Log.Info("Sitemap Module - Function Has Finished", this);
            }
        }

    }

}

