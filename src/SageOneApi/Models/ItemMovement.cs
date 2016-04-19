using System;

namespace SageOneApi.Models
{
    public class ItemMovement : BaseModel
    {
        public DateTime Date { get; set; }
        public string Reference { get; set; }
        public decimal Quantity { get; set; }
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
    }
}