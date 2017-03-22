using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    //
    public interface IQuoteRequest
    {
        /// <summary>
        /// Gets a single quote by ID.
        /// </summary>
        /// <param name="id">The ID of the quote.</param>
        /// <returns>A <see cref="Quote"/> object</returns>
        /// 
        Quote Get(int id);

        /// <summary>
        /// Gets a collection of quotes.
        /// </summary>
        /// <param name="includeDetail">if set to <c>true</c> include the lines.</param>
        /// <param name="includeCustomerDetails">if set to <c>true</c> the Customer is included.</param>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        /// <returns></returns>
        PagingResponse<Quote> Get(bool includeDetail = false, bool includeCustomerDetails = false, string filter = "",
            int skip = 0);

        /// <summary>
        /// Saves the specified quote.
        /// </summary>
        /// <param name="quote">The quote.</param>
        /// <returns>A <see cref="Quote"/> object, populated with updated/new values</returns>
        Quote Save(Quote quote);

        /// <summary>
        /// Calculates the specified quote total fields
        /// </summary>
        /// <param name="quote">The quote.</param>
        /// <returns>A <see cref="Quote"/> object, populated with updated total fields.</returns>
        Quote Calculate(Quote quote);

        /// <summary>
        /// Emails the specified quote.
        /// </summary>
        /// <param name="email">The email request.</param>
        /// <returns>True if successfully sent, otherwise false</returns>
        bool Email(EmailRequest email);

    }
}