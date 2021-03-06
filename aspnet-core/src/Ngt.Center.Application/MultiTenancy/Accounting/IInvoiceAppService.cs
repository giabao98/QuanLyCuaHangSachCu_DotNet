using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Ngt.Center.MultiTenancy.Accounting.Dto;

namespace Ngt.Center.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
