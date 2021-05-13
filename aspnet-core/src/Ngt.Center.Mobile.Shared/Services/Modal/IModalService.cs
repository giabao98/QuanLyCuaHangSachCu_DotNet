using System.Threading.Tasks;
using Ngt.Center.Views;
using Xamarin.Forms;

namespace Ngt.Center.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
