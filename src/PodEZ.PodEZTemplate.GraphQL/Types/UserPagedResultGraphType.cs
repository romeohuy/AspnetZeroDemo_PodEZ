using Abp.Application.Services.Dto;
using GraphQL.Types;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Types
{
    public class UserPagedResultGraphType : ObjectGraphType<PagedResultDto<UserDto>>
    {
        public UserPagedResultGraphType()
        {
            Field(x => x.TotalCount);
            Field(x => x.Items, type: typeof(ListGraphType<UserType>));
        }
    }
}