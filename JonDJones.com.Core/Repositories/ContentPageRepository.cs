using EPiServer.Core;
using EPiServer.DataAccess;
using EPiServer.Security;
using JonDJones.com.Core.Guard;
using JonDJones.com.Core.ScheduledTasks;
using JonDJones.Com.Core;
using JonDJones.Com.Core.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonDJones.com.Core.Repositories
{
    public class ContentPageRepository
    {
        private IEpiServerDependencies _epiServerDependencies;

        public ContentPageRepository(IEpiServerDependencies epiServerDependencies)
        {
            _epiServerDependencies = epiServerDependencies;
        }

        public ContentPage CreateContentPage(ContentPageData contentPageData)
        {
            var existingPage = _epiServerDependencies
                                                .ContentRepository
                                                .GetChildren<ContentPage>(ContentReference.RootPage)
                                                .FirstOrDefault(x => x.PageTitle == contentPageData.PageName);

            if (existingPage != null)
                return existingPage;

            var newPage = _epiServerDependencies.ContentRepository
                       .GetDefault<ContentPage>(contentPageData.ParentContentReference);

            newPage.PageTitle = contentPageData.PageName;
            newPage.Name = contentPageData.PageName;

            newPage.SeoTitle = contentPageData.SeoTitle;
            newPage.Keywords = contentPageData.Keywords;

            return Save(newPage) != null ? newPage : null;
        }

        public ContentReference Save(ContentPage contentPage,
                                     SaveAction saveAction = SaveAction.Publish,
                                     AccessLevel accessLevel = AccessLevel.NoAccess)
        {
            if (contentPage == null)
                return null;

            return _epiServerDependencies.ContentRepository
                                   .Save(contentPage, saveAction, accessLevel);
        }
    }
}
