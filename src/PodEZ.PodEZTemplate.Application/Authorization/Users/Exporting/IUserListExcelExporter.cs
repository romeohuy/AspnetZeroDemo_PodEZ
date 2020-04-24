using System.Collections.Generic;
using PodEZ.PodEZTemplate.Authorization.Users.Dto;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}