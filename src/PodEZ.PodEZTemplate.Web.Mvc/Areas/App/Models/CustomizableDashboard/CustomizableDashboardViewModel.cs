using PodEZ.PodEZTemplate.DashboardCustomization;
using PodEZ.PodEZTemplate.DashboardCustomization.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.CustomizableDashboard
{
    public class CustomizableDashboardViewModel
    {
        public DashboardOutput DashboardOutput { get; }

        public Dashboard UserDashboard { get; }

        public CustomizableDashboardViewModel(
            DashboardOutput dashboardOutput,
            Dashboard userDashboard)
        {
            DashboardOutput = dashboardOutput;
            UserDashboard = userDashboard;
        }
    }
}