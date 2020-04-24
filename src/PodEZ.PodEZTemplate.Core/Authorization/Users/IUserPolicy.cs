using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace PodEZ.PodEZTemplate.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
