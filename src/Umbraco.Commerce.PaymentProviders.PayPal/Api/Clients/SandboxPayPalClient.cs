using Flurl.Http;
using Umbraco.Commerce.PaymentProviders.PayPal.Api.Models;

namespace Umbraco.Commerce.PaymentProviders.PayPal.Api.Clients
{
    public class SandboxPayPalClient : PayPalClient
    {
        private readonly SandboxPayPalClientConfig _config;

        protected override string BaseApiUrl => "https://api.sandbox.paypal.com";

        public SandboxPayPalClient(SandboxPayPalClientConfig config) : base(config)
        {
            _config = config;
        }

        protected override IFlurlRequest WithClientSpecificHeaders(IFlurlRequest request)
        {
            var configuredRequest = base.WithClientSpecificHeaders(request);

            if (_config.IsNegativeTestingEnabled)
            {
                configuredRequest = configuredRequest.WithHeader("PayPal-Mock-Response", "{{\"mock_application_codes\": \"DUPLICATE_INVOICE_ID\"}}");
            }

            return configuredRequest;
        }
    }
}
