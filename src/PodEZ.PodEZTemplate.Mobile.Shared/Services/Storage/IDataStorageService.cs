using System.Threading.Tasks;
using PodEZ.PodEZTemplate.ApiClient;
using PodEZ.PodEZTemplate.ApiClient.Models;
using PodEZ.PodEZTemplate.Sessions.Dto;

namespace PodEZ.PodEZTemplate.Services.Storage
{
    public interface IDataStorageService
    {
        Task StoreAccessTokenAsync(string newAccessToken);

        Task StoreAuthenticateResultAsync(AbpAuthenticateResultModel authenticateResultModel);

        AbpAuthenticateResultModel RetrieveAuthenticateResult();

        TenantInformation RetrieveTenantInfo();

        GetCurrentLoginInformationsOutput RetrieveLoginInfo();

        void ClearSessionPersistance();

        Task StoreLoginInformationAsync(GetCurrentLoginInformationsOutput loginInfo);

        Task StoreTenantInfoAsync(TenantInformation tenantInfo);
    }
}
