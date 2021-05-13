using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Ngt.Center.Common.Dto;
using Ngt.Center.Editions.Dto;

namespace Ngt.Center.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}