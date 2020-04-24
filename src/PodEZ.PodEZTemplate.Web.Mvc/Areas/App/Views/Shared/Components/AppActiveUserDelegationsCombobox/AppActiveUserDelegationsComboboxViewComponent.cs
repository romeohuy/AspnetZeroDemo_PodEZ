using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.Authorization.Delegation;
using PodEZ.PodEZTemplate.Authorization.Users.Delegation;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Layout;
using PodEZ.PodEZTemplate.Web.Views;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Views.Shared.Components.AppActiveUserDelegationsCombobox
{
    public class AppActiveUserDelegationsComboboxViewComponent : PodEZTemplateViewComponent
    {
        private readonly IUserDelegationAppService _userDelegationAppService;
        private readonly IUserDelegationConfiguration _userDelegationConfiguration;

        public AppActiveUserDelegationsComboboxViewComponent(
            IUserDelegationAppService userDelegationAppService, 
            IUserDelegationConfiguration userDelegationConfiguration)
        {
            _userDelegationAppService = userDelegationAppService;
            _userDelegationConfiguration = userDelegationConfiguration;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var activeUserDelegations = await _userDelegationAppService.GetActiveUserDelegations();
            var model = new ActiveUserDelegationsComboboxViewModel
            {
                UserDelegations = activeUserDelegations,
                UserDelegationConfiguration = _userDelegationConfiguration
            };

            return View(model);
        }
    }
}
