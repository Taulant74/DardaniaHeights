namespace DardaniaHeights.Models
{      
    using System;

    public class Payment
    {
        public int PaymentID { get; set; }
        public int InvoiceID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }



}
