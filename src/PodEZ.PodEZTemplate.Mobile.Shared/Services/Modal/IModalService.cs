using System.Threading.Tasks;
using PodEZ.PodEZTemplate.Views;
using Xamarin.Forms;

namespace PodEZ.PodEZTemplate.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
