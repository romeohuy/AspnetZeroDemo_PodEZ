using System.Collections.Generic;
using PodEZ.PodEZTemplate.Authorization.Delegation;
using PodEZ.PodEZTemplate.Authorization.Users.Delegation.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
