using Umbraco.Commerce.PaymentProviders.PayPal.Api.Models.Configs;

namespace Umbraco.Commerce.PaymentProviders.PayPal.Api.Clients
{
    public class LivePayPalClient : PayPalClient
    {
        protected override string BaseApiUrl => "https://api.paypal.com";

        public LivePayPalClient(LivePayPalClientConfig config) : base(config)
        {
        }
    }
}
