using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace MSBuildExtensionPack.CommonBLL
{
    public static class SyndicationFeedFacade 
    {

        public static SyndicationFeed GetBuild()
        {
            string urlOfList = string.Format("{0}{1}/{2}", Framework.Web.WebFormApplicationApplicationVariables.WebAppRootUrl, "Build", "WPCommonOfBuild");

            SyndicationFeed feed = new SyndicationFeed(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Rss_Title_of_Build, MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Rss_Description_of_Build, new Uri(urlOfList));
            //feed.Authors.Add(new SyndicationPerson(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.));
            //feed.Categories.Add(new SyndicationCategory(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.));

            MSBuildExtensionPack.CommonBLL.BuildService instance = new MSBuildExtensionPack.CommonBLL.BuildService();

            var request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll();
            request.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            request.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection("LastModifiedDateTime:DESC");
            var fromDataSource = instance.GetCollectionOfRssItemOfAll(request);

            List<SyndicationItem> items = new List<SyndicationItem>();
            if (fromDataSource.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                foreach (var datasourceItem in fromDataSource.Message)
                {
		            //string urlOfEntityRelated = string.Format("{0}{1}/{2}?{3}", MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.HomeOwner, "Build", "WPEntityRelatedOfBuild", "{Query String Parameters}");
                    SyndicationItem item1 = new SyndicationItem(
                        datasourceItem.Title, 
                        datasourceItem.Description, 
                        new Uri(urlOfList), // should be urlOfEntityRelated, should enter query string parameters
                        datasourceItem.IdentifierInString, 
                        datasourceItem.PubDate);

                    items.Add(item1);
                }
            }

            feed.Items = items;
            return feed;
        }


        public static SyndicationFeed GetBuildEventCode()
        {
            string urlOfList = string.Format("{0}{1}/{2}", Framework.Web.WebFormApplicationApplicationVariables.WebAppRootUrl, "BuildEventCode", "WPCommonOfBuildEventCode");

            SyndicationFeed feed = new SyndicationFeed(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.Rss_Title_of_BuildEventCode, MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.Rss_Description_of_BuildEventCode, new Uri(urlOfList));
            //feed.Authors.Add(new SyndicationPerson(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.));
            //feed.Categories.Add(new SyndicationCategory(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.));

            MSBuildExtensionPack.CommonBLL.BuildEventCodeService instance = new MSBuildExtensionPack.CommonBLL.BuildEventCodeService();

            var request = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll();
            request.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            request.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection("LastModifiedDateTime:DESC");
            var fromDataSource = instance.GetCollectionOfRssItemOfAll(request);

            List<SyndicationItem> items = new List<SyndicationItem>();
            if (fromDataSource.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                foreach (var datasourceItem in fromDataSource.Message)
                {
		            //string urlOfEntityRelated = string.Format("{0}{1}/{2}?{3}", MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.HomeOwner, "BuildEventCode", "WPEntityRelatedOfBuildEventCode", "{Query String Parameters}");
                    SyndicationItem item1 = new SyndicationItem(
                        datasourceItem.Title, 
                        datasourceItem.Description, 
                        new Uri(urlOfList), // should be urlOfEntityRelated, should enter query string parameters
                        datasourceItem.IdentifierInString, 
                        datasourceItem.PubDate);

                    items.Add(item1);
                }
            }

            feed.Items = items;
            return feed;
        }


        public static SyndicationFeed GetBuildLog()
        {
            string urlOfList = string.Format("{0}{1}/{2}", Framework.Web.WebFormApplicationApplicationVariables.WebAppRootUrl, "BuildLog", "WPCommonOfBuildLog");

            SyndicationFeed feed = new SyndicationFeed(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog.Rss_Title_of_BuildLog, MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog.Rss_Description_of_BuildLog, new Uri(urlOfList));
            //feed.Authors.Add(new SyndicationPerson(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog.));
            //feed.Categories.Add(new SyndicationCategory(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog.));

            MSBuildExtensionPack.CommonBLL.BuildLogService instance = new MSBuildExtensionPack.CommonBLL.BuildLogService();

            var request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll();
            request.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            request.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection("LastModifiedDateTime:DESC");
            var fromDataSource = instance.GetCollectionOfRssItemOfAll(request);

            List<SyndicationItem> items = new List<SyndicationItem>();
            if (fromDataSource.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                foreach (var datasourceItem in fromDataSource.Message)
                {
		            //string urlOfEntityRelated = string.Format("{0}{1}/{2}?{3}", MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog.HomeOwner, "BuildLog", "WPEntityRelatedOfBuildLog", "{Query String Parameters}");
                    SyndicationItem item1 = new SyndicationItem(
                        datasourceItem.Title, 
                        datasourceItem.Description, 
                        new Uri(urlOfList), // should be urlOfEntityRelated, should enter query string parameters
                        datasourceItem.IdentifierInString, 
                        datasourceItem.PubDate);

                    items.Add(item1);
                }
            }

            feed.Items = items;
            return feed;
        }


        public static SyndicationFeed GetSolution()
        {
            string urlOfList = string.Format("{0}{1}/{2}", Framework.Web.WebFormApplicationApplicationVariables.WebAppRootUrl, "Solution", "WPCommonOfSolution");

            SyndicationFeed feed = new SyndicationFeed(MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution.Rss_Title_of_Solution, MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution.Rss_Description_of_Solution, new Uri(urlOfList));
            //feed.Authors.Add(new SyndicationPerson(MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution.));
            //feed.Categories.Add(new SyndicationCategory(MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution.));

            MSBuildExtensionPack.CommonBLL.SolutionService instance = new MSBuildExtensionPack.CommonBLL.SolutionService();

            var request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll();
            request.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            request.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection("LastModifiedDateTime:DESC");
            var fromDataSource = instance.GetCollectionOfRssItemOfAll(request);

            List<SyndicationItem> items = new List<SyndicationItem>();
            if (fromDataSource.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                foreach (var datasourceItem in fromDataSource.Message)
                {
		            //string urlOfEntityRelated = string.Format("{0}{1}/{2}?{3}", MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution.HomeOwner, "Solution", "WPEntityRelatedOfSolution", "{Query String Parameters}");
                    SyndicationItem item1 = new SyndicationItem(
                        datasourceItem.Title, 
                        datasourceItem.Description, 
                        new Uri(urlOfList), // should be urlOfEntityRelated, should enter query string parameters
                        datasourceItem.IdentifierInString, 
                        datasourceItem.PubDate);

                    items.Add(item1);
                }
            }

            feed.Items = items;
            return feed;
        }


    }
}

