using System.Collections.Generic;

namespace SageOneApi.Models
{
    public class PagingResponse<T>
    {
        public int TotalResults { get; set; }
        public int ReturnedResults { get; set; }
        public List<T> Results { get; set; }
    }

}