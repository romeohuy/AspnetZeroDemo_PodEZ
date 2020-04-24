using System.Threading.Tasks;
using Abp.Application.Services;
using PodEZ.PodEZTemplate.Install.Dto;

namespace PodEZ.PodEZTemplate.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}