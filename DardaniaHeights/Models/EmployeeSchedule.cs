namespace DardaniaHeights.Models
{
    using System;
    public class EmployeeSchedule
    {
        public int ScheduleID { get; set; }
        public int StaffID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

}
