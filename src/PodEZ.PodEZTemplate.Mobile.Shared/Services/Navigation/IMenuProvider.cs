using System.Collections.Generic;
using MvvmHelpers;
using PodEZ.PodEZTemplate.Models.NavigationMenu;

namespace PodEZ.PodEZTemplate.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}