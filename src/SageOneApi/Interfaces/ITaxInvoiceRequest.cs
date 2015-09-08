using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
	public interface ITaxInvoiceRequest
	{
		/// <summary>
		/// Gets a single tax invoice by ID.
		/// </summary>
		/// <param name="id">The ID of the tax invoice.</param>
		/// <returns>A <see cref="TaxInvoice"/> object</returns>
		/// 
		TaxInvoice Get(int id);

		/// <summary>
		/// Gets a collection of tax invoices.
		/// </summary>
		/// <param name="includeDetail">if set to <c>true</c> include the lines.</param>
		/// <param name="includeCustomerDetails">if set to <c>true</c> the Customer is included.</param>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		/// <returns></returns>
		PagingResponse<TaxInvoice> Get(bool includeDetail=false,bool includeCustomerDetails=false,string filter = "");

		/// <summary>
		/// Saves the specified tax invoice.
		/// </summary>
		/// <param name="invoice">The tax invoice.</param>
		/// <returns>A <see cref="TaxInvoice"/> object, populated with updated/new values</returns>
		TaxInvoice Save(TaxInvoice invoice);

		/// <summary>
		/// Calculates the specified tax invoice total fields
		/// </summary>
		/// <param name="invoice">The invoice.</param>
		/// <returns>A <see cref="TaxInvoice"/> object, populated with updated total fields.</returns>
		TaxInvoice Calculate(TaxInvoice invoice);


		///// <summary>
		///// Emails the specified Tax Invoice.
		///// </summary>
		///// <param name="email">The email request.</param>
		///// <returns>True if successfully sent, otherwise false</returns>
		//bool Email(EmailRequest email);
	}
}