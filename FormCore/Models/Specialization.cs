using System;
using System.Collections.Generic;

namespace FormCore.Models
{
    public partial class Specialization
    {
        public Specialization()
        {
            this.DisplayAppointments = new List<DisplayAppointment>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DisplayAppointment> DisplayAppointments { get; set; }
    }
}
