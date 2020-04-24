

using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Exporting;
using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos;
using PodEZ.PodEZTemplate.Dto;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;

namespace PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo
{
	[AbpAuthorize(AppPermissions.Pages_PozOrderDemo)]
    public class PozOrderDemoAppService : PodEZTemplateAppServiceBase, IPozOrderDemoAppService
    {
		 private readonly IRepository<PozOrderDemo, long> _pozOrderDemoRepository;
		 private readonly IPozOrderDemoExcelExporter _pozOrderDemoExcelExporter;
		 

		  public PozOrderDemoAppService(IRepository<PozOrderDemo, long> pozOrderDemoRepository, IPozOrderDemoExcelExporter pozOrderDemoExcelExporter ) 
		  {
			_pozOrderDemoRepository = pozOrderDemoRepository;
			_pozOrderDemoExcelExporter = pozOrderDemoExcelExporter;
			
		  }

		 public async Task<PagedResultDto<GetPozOrderDemoForViewDto>> GetAll(GetAllPozOrderDemoInput input)
         {
			
			var filteredPozOrderDemo = _pozOrderDemoRepository.GetAll()
						.WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false  || e.PozOrderName.Contains(input.Filter) || e.PozOrderDescription.Contains(input.Filter))
						.WhereIf(!string.IsNullOrWhiteSpace(input.PozOrderNameFilter),  e => e.PozOrderName == input.PozOrderNameFilter)
						.WhereIf(!string.IsNullOrWhiteSpace(input.PozOrderDescriptionFilter),  e => e.PozOrderDescription == input.PozOrderDescriptionFilter)
						.WhereIf(input.MinPozImageTotalFilter != null, e => e.PozImageTotal >= input.MinPozImageTotalFilter)
						.WhereIf(input.MaxPozImageTotalFilter != null, e => e.PozImageTotal <= input.MaxPozImageTotalFilter);

			var pagedAndFilteredPozOrderDemo = filteredPozOrderDemo
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

			var pozOrderDemo = from o in pagedAndFilteredPozOrderDemo
                         select new GetPozOrderDemoForViewDto() {
							PozOrderDemo = new PozOrderDemoDto
							{
                                PozOrderName = o.PozOrderName,
                                PozOrderDescription = o.PozOrderDescription,
                                PozImageTotal = o.PozImageTotal,
                                Id = o.Id
							}
						};

            var totalCount = await filteredPozOrderDemo.CountAsync();

            return new PagedResultDto<GetPozOrderDemoForViewDto>(
                totalCount,
                await pozOrderDemo.ToListAsync()
            );
         }
		 
		 public async Task<GetPozOrderDemoForViewDto> GetPozOrderDemoForView(long id)
         {
            var pozOrderDemo = await _pozOrderDemoRepository.GetAsync(id);

            var output = new GetPozOrderDemoForViewDto { PozOrderDemo = ObjectMapper.Map<PozOrderDemoDto>(pozOrderDemo) };
			
            return output;
         }
		 
		 [AbpAuthorize(AppPermissions.Pages_PozOrderDemo_Edit)]
		 public async Task<GetPozOrderDemoForEditOutput> GetPozOrderDemoForEdit(EntityDto<long> input)
         {
            var pozOrderDemo = await _pozOrderDemoRepository.FirstOrDefaultAsync(input.Id);
           
		    var output = new GetPozOrderDemoForEditOutput {PozOrderDemo = ObjectMapper.Map<CreateOrEditPozOrderDemoDto>(pozOrderDemo)};
			
            return output;
         }

		 public async Task CreateOrEdit(CreateOrEditPozOrderDemoDto input)
         {
            if(input.Id == null){
				await Create(input);
			}
			else{
				await Update(input);
			}
         }

		 [AbpAuthorize(AppPermissions.Pages_PozOrderDemo_Create)]
		 protected virtual async Task Create(CreateOrEditPozOrderDemoDto input)
         {
            var pozOrderDemo = ObjectMapper.Map<PozOrderDemo>(input);

            await _pozOrderDemoRepository.InsertAsync(pozOrderDemo);
         }

		 [AbpAuthorize(AppPermissions.Pages_PozOrderDemo_Edit)]
		 protected virtual async Task Update(CreateOrEditPozOrderDemoDto input)
         {
            var pozOrderDemo = await _pozOrderDemoRepository.FirstOrDefaultAsync((long)input.Id);
             ObjectMapper.Map(input, pozOrderDemo);
         }

		 [AbpAuthorize(AppPermissions.Pages_PozOrderDemo_Delete)]
         public async Task Delete(EntityDto<long> input)
         {
            await _pozOrderDemoRepository.DeleteAsync(input.Id);
         } 

		public async Task<FileDto> GetPozOrderDemoToExcel(GetAllPozOrderDemoForExcelInput input)
         {
			
			var filteredPozOrderDemo = _pozOrderDemoRepository.GetAll()
						.WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false  || e.PozOrderName.Contains(input.Filter) || e.PozOrderDescription.Contains(input.Filter))
						.WhereIf(!string.IsNullOrWhiteSpace(input.PozOrderNameFilter),  e => e.PozOrderName == input.PozOrderNameFilter)
						.WhereIf(!string.IsNullOrWhiteSpace(input.PozOrderDescriptionFilter),  e => e.PozOrderDescription == input.PozOrderDescriptionFilter)
						.WhereIf(input.MinPozImageTotalFilter != null, e => e.PozImageTotal >= input.MinPozImageTotalFilter)
						.WhereIf(input.MaxPozImageTotalFilter != null, e => e.PozImageTotal <= input.MaxPozImageTotalFilter);

			var query = (from o in filteredPozOrderDemo
                         select new GetPozOrderDemoForViewDto() { 
							PozOrderDemo = new PozOrderDemoDto
							{
                                PozOrderName = o.PozOrderName,
                                PozOrderDescription = o.PozOrderDescription,
                                PozImageTotal = o.PozImageTotal,
                                Id = o.Id
							}
						 });


            var pozOrderDemoListDtos = await query.ToListAsync();

            return _pozOrderDemoExcelExporter.ExportToFile(pozOrderDemoListDtos);
         }


    }
}