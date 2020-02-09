using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RssFeedReader.Controllers
{
    public abstract class RSSFeedReaderControllerBase: AbpController
    {
        protected RSSFeedReaderControllerBase()
        {
            LocalizationSourceName = RSSFeedReaderConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
