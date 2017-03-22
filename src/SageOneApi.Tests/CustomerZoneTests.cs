using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SageOneApi.Tests
{
    [TestClass]
    public class CustomerZoneTests :TestBase
    {
        [TestMethod]
        public void GetCustomerZoneInvoiceUrl()
        {
            var customerId = 3899984;
            var invoiceId = 79274967;

            //var customer = Api.CustomerRequest.Get(customerId);
            //customer.EnableCustomerZone = true;
            //Api.CustomerRequest.Save(customer);

            var url = Api.CustomerZoneRequest.GetCustomerZoneInvoiceUrl(invoiceId,customerId);
        }

        [TestMethod]
        public void GetCustomerZoneQuoteUrl()
        {
            var url = Api.CustomerZoneRequest.GetCustomerZoneQuoteUrl(0, 0);
        }
    }
}