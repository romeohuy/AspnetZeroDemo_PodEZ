using PodEZ.PodEZTemplate.Models.Users;
using PodEZ.PodEZTemplate.ViewModels;
using Xamarin.Forms;

namespace PodEZ.PodEZTemplate.Views
{
    public partial class UsersView : ContentPage, IXamarinView
    {
        public UsersView()
        {
            InitializeComponent();
        }

        public async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((UsersViewModel) BindingContext).LoadMoreUserIfNeedsAsync(e.Item as UserListModel);
        }
    }
}