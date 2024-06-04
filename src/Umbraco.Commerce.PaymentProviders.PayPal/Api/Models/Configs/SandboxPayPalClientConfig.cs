
namespace Umbraco.Commerce.PaymentProviders.PayPal.Api.Models
{
    public class SandboxPayPalClientConfig : PayPalClientConfig
    {
        /// <summary>
        /// Read more about negative testing: https://developer.paypal.com/tools/sandbox/negative-testing/
        /// </summary>
        public bool IsNegativeTestingEnabled { get; set; }
    }
}
