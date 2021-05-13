using Xamarin.Forms.Internals;

namespace Ngt.Center.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}