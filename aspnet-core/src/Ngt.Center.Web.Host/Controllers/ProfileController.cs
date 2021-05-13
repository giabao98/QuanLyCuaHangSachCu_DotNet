using Abp.AspNetCore.Mvc.Authorization;
using Ngt.Center.Storage;

namespace Ngt.Center.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(ITempFileCacheManager tempFileCacheManager) :
            base(tempFileCacheManager)
        {
        }
    }
}