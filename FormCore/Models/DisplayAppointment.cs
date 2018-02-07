using System;
using System.Collections.Generic;

namespace FormCore.Models
{
    public partial class DisplayAppointment
    {
        public int Id { get; set; }
        public string StartAppointmentTime { get; set; }
        public string EndAppointmentDate { get; set; }
        public int ClinicId { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public int DayID { get; set; }
        public virtual Specialization Specialization { get; set; }
    }
}
