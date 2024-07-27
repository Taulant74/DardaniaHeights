namespace DardaniaHeights.Models
{

    using System;

    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int ReservationID { get; set; }
        public decimal Amount { get; set; }
        public DateTime IssueDate { get; set; }
    }


}
