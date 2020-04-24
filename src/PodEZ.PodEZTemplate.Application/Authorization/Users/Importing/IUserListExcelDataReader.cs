using System.Collections.Generic;
using PodEZ.PodEZTemplate.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace PodEZ.PodEZTemplate.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
