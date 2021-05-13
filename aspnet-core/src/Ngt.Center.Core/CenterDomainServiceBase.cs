using Abp.Domain.Services;

namespace Ngt.Center
{
    public abstract class CenterDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected CenterDomainServiceBase()
        {
            LocalizationSourceName = CenterConsts.LocalizationSourceName;
        }
    }
}
