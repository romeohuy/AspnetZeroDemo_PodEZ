using System.Threading.Tasks;
using PodEZ.PodEZTemplate.ApiClient.Models;

namespace PodEZ.PodEZTemplate.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        
        Task LoginUserAsync();

        Task LogoutAsync();
    }
}
