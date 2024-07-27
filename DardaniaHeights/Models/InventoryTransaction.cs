namespace DardaniaHeights.Models
{

    using System;

    public class InventoryTransaction
    {
        public int TransactionID { get; set; }
        public int InventoryID { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
    }



}
