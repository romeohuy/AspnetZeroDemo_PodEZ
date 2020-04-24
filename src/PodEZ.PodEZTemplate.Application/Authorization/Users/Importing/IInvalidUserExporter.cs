using System.Collections.Generic;
using PodEZ.PodEZTemplate.Authorization.Users.Importing.Dto;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
