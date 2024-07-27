namespace DardaniaHeights.Models
{
    using System;

    public class MaintenanceRequest
    {
        public int RequestID { get; set; }
        public int HotelID { get; set; }
        public string Description { get; set; }
        public DateTime RequestDate { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
    }

}
