using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch21LINQPayroll
{
    public class HoursWorked
    {
        public int Id { get; set; }

        public double MondayHours { get; set; }

        public double TuesdayHours { get; set; }

        public double WednesdayHours { get; set; }

        public double ThursdayHours { get; set; }

        public double FridayHours { get; set; }

        public HoursWorked(int id, double mondayHours, double tuesdayHours, double wednesdayHours, double thursdayHours, double fridayHours)
        {
            Id = id;
            MondayHours = mondayHours;
            TuesdayHours = tuesdayHours;
            WednesdayHours = wednesdayHours;
            ThursdayHours = thursdayHours;
            FridayHours = fridayHours;
        }
    }
}
