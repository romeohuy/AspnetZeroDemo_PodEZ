using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.DynamicEntityParameters.Dto;
using PodEZ.PodEZTemplate.EntityDynamicParameterValues.Dto;

namespace PodEZ.PodEZTemplate.DynamicEntityParameters
{
    public interface IEntityDynamicParameterValueAppService
    {
        Task<EntityDynamicParameterValueDto> Get(int id);

        Task<ListResultDto<EntityDynamicParameterValueDto>> GetAll(GetAllInput input);

        Task Add(EntityDynamicParameterValueDto input);

        Task Update(EntityDynamicParameterValueDto input);

        Task Delete(int id);

        Task<GetAllEntityDynamicParameterValuesOutput> GetAllEntityDynamicParameterValues(GetAllEntityDynamicParameterValuesInput input);
    }
}
