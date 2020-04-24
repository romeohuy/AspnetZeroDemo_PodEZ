using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
