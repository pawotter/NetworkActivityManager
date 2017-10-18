using System.Net.Http;

namespace Pawotter.NetworkActivityManager
{
    public class HttpNetworkActivityDelegatingHandler : DelegatingHandler
    {
        protected async override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            NetworkActivityManager.Instance.Attach();
            try
            {
                return await base.SendAsync(request, cancellationToken);
            }
            finally
            {
                NetworkActivityManager.Instance.Detach();
            }
        }
    }
}
