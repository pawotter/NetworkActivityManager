using UIKit;

namespace Pawotter.NetworkActivityManager
{
    public sealed class NetworkActivityIndicator : IIndicator
    {
        readonly UIApplication application;

        internal NetworkActivityIndicator(UIApplication application)
        {
            this.application = application;
        }

        void IIndicator.Activate()
        {
            application.NetworkActivityIndicatorVisible = true;
        }

        void IIndicator.Inactivate()
        {
            application.NetworkActivityIndicatorVisible = false;
        }
    }
}
