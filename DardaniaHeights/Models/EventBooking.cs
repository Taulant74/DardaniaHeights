namespace DardaniaHeights.Models
{
    using System;

    public class EventBooking
    {
        public int EventBookingID { get; set; }
        public int EventID { get; set; }
        public int GuestID { get; set; }
        public DateTime BookingDate { get; set; }
    }

        
}
