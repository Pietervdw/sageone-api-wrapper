using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
	public interface ISalesRepresentativeRequest
	{
		/// <summary>
		/// Gets a single sales representative by ID.
		/// </summary>
		/// <param name="id">The ID of the sales representative.</param>
		/// <returns>A <see cref="SalesRepresentative"/> object</returns>
		/// 
		SalesRepresentative Get(int id);

		/// <summary>
		/// Gets a collection of sales representative.
		/// </summary>
		/// <returns>An List collection of <see cref="SalesRepresentative"/> objects</returns>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		PagingResponse<SalesRepresentative> Get(string filter = "");

		/// <summary>
		/// Saves the specified sales representative.
		/// </summary>
		/// <param name="customer">The sales representative.</param>
		/// <returns>A <see cref="SalesRepresentative"/> object, populated with updated/new values</returns>
		SalesRepresentative Save(SalesRepresentative customer);

		/// <summary>
		/// Deletes a sales representative
		/// </summary>
		/// <param name="id">The ID of the sales representative to delete</param>
		/// <returns>True if successfully deleted, otherwise false</returns>
		bool Delete(int id);

		/// <summary>
		/// Determines whether the specified sales representative has activity.
		/// </summary>
		/// <param name="id">The ID of the sales representative to delete</param>
		/// <returns>True if the sales representative has activity, otherwise false</returns>
		bool HasActivity(int id);
	}
}