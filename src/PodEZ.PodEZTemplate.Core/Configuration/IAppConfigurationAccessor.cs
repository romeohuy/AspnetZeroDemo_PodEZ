using Microsoft.Extensions.Configuration;

namespace PodEZ.PodEZTemplate.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
