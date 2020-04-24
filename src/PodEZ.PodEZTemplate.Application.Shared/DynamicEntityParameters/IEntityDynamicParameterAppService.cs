using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.DynamicEntityParameters.Dto;
using PodEZ.PodEZTemplate.EntityDynamicParameters;

namespace PodEZ.PodEZTemplate.DynamicEntityParameters
{
    public interface IEntityDynamicParameterAppService
    {
        Task<EntityDynamicParameterDto> Get(int id);

        Task<ListResultDto<EntityDynamicParameterDto>> GetAllParametersOfAnEntity(EntityDynamicParameterGetAllInput input);

        Task<ListResultDto<EntityDynamicParameterDto>> GetAll();

        Task Add(EntityDynamicParameterDto dto);

        Task Update(EntityDynamicParameterDto dto);

        Task Delete(int id);
    }
}
