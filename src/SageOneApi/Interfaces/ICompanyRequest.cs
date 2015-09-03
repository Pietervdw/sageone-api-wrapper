using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface ICompanyRequest
    {
        /// <summary>
        /// Retrieves the current Company.
        /// </summary>
        /// <returns>A <see cref="Company"/> object</returns>
        ResultRoot<Company> Current();
    }
}