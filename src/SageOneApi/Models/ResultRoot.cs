using System;
using System.CodeDom;
using System.Collections.Generic;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace SageOneApi.Models
{
    public class ResultRoot<T>
    {
        public int TotalResults { get; set; }
        public int ReturnedResults { get; set; }
        public List<T> Results { get; set; }
    }

}