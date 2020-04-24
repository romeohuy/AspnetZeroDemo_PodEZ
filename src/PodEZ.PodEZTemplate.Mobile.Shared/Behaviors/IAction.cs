using Xamarin.Forms.Internals;

namespace PodEZ.PodEZTemplate.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}