using System.Threading.Tasks;
using Abp.Dependency;

namespace Ngt.Center.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}