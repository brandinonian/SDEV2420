using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClass
{
    public class Time
    {
        private int _hours, _minutes, _seconds;
        public Time(int Hours, int Mintues, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Mintues;
            this.Seconds = Seconds;
        }

        public Time(int Hours) : this(Hours, 0, 0) { }

        public Time(int Hours, int Minutes) : this(Hours, Minutes, 0) { }
        
        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value >= 0 && value <= 23)
                    _hours = value;
                else
                {
                    Console.Write($"The value of {value} is invalid, ");
                    Console.WriteLine("setting hours to 0");
                    _hours = 0;
                }
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value >= 0 && value <= 59)
                    _minutes = value;
                else
                {
                    Console.Write($"The value of {value} is invalid, ");
                    Console.WriteLine("setting minutes to 0");
                    _minutes = 0;
                }
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value >= 0 && value <= 59)
                    _seconds = value;
                else
                {
                    Console.Write($"The value of {value} is invalid, ");
                    Console.WriteLine("setting seconds to 0");
                    _seconds = 0;
                }
            }
        }

        public override string ToString()
        {
            return $"Time: {Hours}:{Minutes}:{Seconds}";
        }
    }
}
