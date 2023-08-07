using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateClass
{
    public class Date
    {
        private int[] dayList = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int _year, _month, _day;

        public Date(int Month, int Day, int Year)
        {
            this.Month = Month;
            this.Year = Year;
            this.Day = Day;
        }

        public int Year
        {
            get { return _year; }
            set
            {
                // if the user enters a 2 digit year, assume it is 2000+
                if (value >= 0 && value < 100)
                    _year = value + 2000;
                else if (value >= 1800 && value <= 2200)
                    _year = value;
                else
                {
                    Console.WriteLine($"Year out of bounds, using 2001");
                    _year = 2001;
                }
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                else
                {
                    Console.WriteLine($"Month out of bounds, using January (1)");
                    _month = 1;
                }
            }
        }

        public int Day
        {
            get { return _day; }
            set
            {
                if (Month == 2)
                {
                    if (DateTime.IsLeapYear(Year))
                    {
                        if (value > 0 && value <= 29)
                            _day = value;
                        else
                        {
                            Console.WriteLine($"Day out of bounds, using 1");
                            _day = 1;
                        }
                    }
                    else
                    {
                        if (value > 0 && value <= 28)
                            _day = value;
                        else
                        {
                            Console.WriteLine($"Day out of bounds, using 1");
                            _day = 1;
                        }
                    }

                }
                else if (value >= 1 && value <= (dayList[Month - 1]))
                    _day = value;
                else
                {
                    Console.WriteLine($"Day out of bounds, using 1");
                    _day = 1;
                }
            }
        }

        public override string ToString()
        {
            return $"{Month}/{Day}/{Year}";
        }

        public Date IncrementDay()
        {
            // Dec 31, roll over the year
            if (Month == 12 && Day == 31)
            {
                Day++;
                Month++;
                Year++;
            }
            // Feb needs to check for leap years and roll over month on last day
            else if (Month == 2)
            {
                if (DateTime.IsLeapYear(Year))
                {
                    if (Day == 29)
                    {
                        Day++;
                        Month++;
                    }
                    else { Day++; }
                }
                else
                {
                    if (Day == 28)
                    {
                        Day++;
                        Month++;
                    }
                    else { Day++; }
                }
            }
            // Every month but Feb roll over on last day
            else if (Day == (dayList[Month - 1]))
            {
                Day++;
                Month++;
            }
            else
            {
                Day++;
            }
            Console.WriteLine(ToString());
            return this;
        }
    }
}
