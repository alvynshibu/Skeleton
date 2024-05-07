using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StockId { get; set; }
        public int ItemName { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public int SupplierId { get; set; }
        public bool Available { get; set; }
    }
}