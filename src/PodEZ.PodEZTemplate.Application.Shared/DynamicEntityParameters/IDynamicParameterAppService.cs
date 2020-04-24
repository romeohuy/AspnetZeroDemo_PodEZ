using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.UI.Inputs;
using PodEZ.PodEZTemplate.DynamicEntityParameters.Dto;

namespace PodEZ.PodEZTemplate.DynamicEntityParameters
{
    public interface IDynamicParameterAppService
    {
        Task<DynamicParameterDto> Get(int id);

        Task<ListResultDto<DynamicParameterDto>> GetAll();

        Task Add(DynamicParameterDto dto);

        Task Update(DynamicParameterDto dto);

        Task Delete(int id);

        IInputType FindAllowedInputType(string name);
    }
}
