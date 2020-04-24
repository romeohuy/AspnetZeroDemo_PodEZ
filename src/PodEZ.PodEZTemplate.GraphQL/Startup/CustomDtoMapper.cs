using AutoMapper;
using PodEZ.PodEZTemplate.Authorization.Users;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Startup
{
    public static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<User, UserDto>()
                .ForMember(dto => dto.Roles, options => options.Ignore())
                .ForMember(dto => dto.OrganizationUnits, options => options.Ignore());
        }
    }
}