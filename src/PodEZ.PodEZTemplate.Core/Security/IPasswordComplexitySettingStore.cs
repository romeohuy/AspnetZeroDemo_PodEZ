using System.Threading.Tasks;

namespace PodEZ.PodEZTemplate.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
