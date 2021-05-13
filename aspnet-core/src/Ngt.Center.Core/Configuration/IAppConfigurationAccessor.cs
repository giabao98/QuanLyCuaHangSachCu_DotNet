using Microsoft.Extensions.Configuration;

namespace Ngt.Center.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
