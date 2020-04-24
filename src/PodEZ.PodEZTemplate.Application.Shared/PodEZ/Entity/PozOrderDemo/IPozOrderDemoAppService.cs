using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo
{
    public interface IPozOrderDemoAppService : IApplicationService 
    {
        Task<PagedResultDto<GetPozOrderDemoForViewDto>> GetAll(GetAllPozOrderDemoInput input);

        Task<GetPozOrderDemoForViewDto> GetPozOrderDemoForView(long id);

		Task<GetPozOrderDemoForEditOutput> GetPozOrderDemoForEdit(EntityDto<long> input);

		Task CreateOrEdit(CreateOrEditPozOrderDemoDto input);

		Task Delete(EntityDto<long> input);

		Task<FileDto> GetPozOrderDemoToExcel(GetAllPozOrderDemoForExcelInput input);

		
    }
}