using System.Threading.Tasks;
using Abp.Dependency;

namespace Ngt.Center.UiCustomization
{
    public interface IUiThemeCustomizerFactory : ISingletonDependency
    {
        Task<IUiCustomizer> GetCurrentUiCustomizer();

        IUiCustomizer GetUiCustomizer(string theme);
    }
}