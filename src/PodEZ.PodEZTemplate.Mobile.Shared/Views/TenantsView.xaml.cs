using PodEZ.PodEZTemplate.Models.Tenants;
using PodEZ.PodEZTemplate.ViewModels;
using Xamarin.Forms;

namespace PodEZ.PodEZTemplate.Views
{
    public partial class TenantsView : ContentPage, IXamarinView
    {
        public TenantsView()
        {
            InitializeComponent();
        }

        private async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((TenantsViewModel)BindingContext).LoadMoreTenantsIfNeedsAsync(e.Item as TenantListModel);
        }
    }
}