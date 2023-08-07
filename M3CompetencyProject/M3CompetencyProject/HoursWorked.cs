using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3CompetencyProject
{
    public class HoursWorked
    {
        public int Id { get; set; }

        public double MondayHours { get; set; }

        public double TuesdayHours { get; set; }

        public double WednesdayHours { get; set; }

        public double ThursdayHours { get; set; }

        public double FridayHours { get; set; }

        public double GetTotalHours()
        {
            return MondayHours + TuesdayHours + WednesdayHours + ThursdayHours + FridayHours;
        }

        public HoursWorked(int Id, double MondayHours, double TuesdayHours, double WednesdayHours, double ThursdayHours, double FridayHours)
        {
            this.Id = Id;
            this.MondayHours = MondayHours;
            this.TuesdayHours = TuesdayHours;
            this.WednesdayHours = WednesdayHours;
            this.ThursdayHours = ThursdayHours;
            this.FridayHours = FridayHours;
        }
    }
}
