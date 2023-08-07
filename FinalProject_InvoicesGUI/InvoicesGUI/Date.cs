using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesGUI {
    public class Date : IComparable {
        private int[] dayList = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int _year, _month, _day;
        public Date(int Month, int Day, int Year) {
            this.Month = Month;
            this.Year = Year;
            this.Day = Day;
        }
        public int Year {
            get { return _year; }
            set {
                // if the user enters a 2 digit year, assume it is 2000+
                if(value >= 0 && value < 100)
                    _year = value + 2000;
                else
                    _year = value;
            }
        }
        public int Month {
            get { return _month; }
            set {
                // check for a valid month
                if(value >= 1 && value <= 12)
                    _month = value;

                // default to 1
                else {
                    _month = 1;
                }
            }
        }
        public int Day {
            get { return _day; }
            set {
                // check the days in Feb for leap years
                if(Month == 2) {

                    // if it is a leap year Feb has 29 days
                    if(DateTime.IsLeapYear(Year)) {
                        if(value > 0 && value <= 29)
                            _day = value;

                        // default to 1
                        else {
                            _day = 1;
                        }
                    }

                    // if not a leap year Feb has 28 days
                    else {
                        if(value > 0 && value <= 28)
                            _day = value;

                        // default to 1
                        else {
                            _day = 1;
                        }
                    }

                }

                // all other months check dayList
                else if(value >= 1 && value <= (dayList[Month - 1]))
                    _day = value;

                // default to 1
                else {
                    _day = 1;
                }
            }
        }
        public override string ToString() {
            return $"{Month}/{Day}/{Year}";
        }
        public Date IncrementDay() {
            // Dec 31, roll over the year
            if(Month == 12 && Day == 31) {
                Day++;
                Month++;
                Year++;
            }
            // Feb needs to check for leap years and roll over month on last day
            else if(Month == 2) {
                if(DateTime.IsLeapYear(Year)) {
                    if(Day == 29) {
                        Day++;
                        Month++;
                    }
                    else { Day++; }
                }
                else {
                    if(Day == 28) {
                        Day++;
                        Month++;
                    }
                    else { Day++; }
                }
            }
            // Every month but Feb roll over on last day
            else if(Day == (dayList[Month - 1])) {
                Day++;
                Month++;
            }
            else {
                Day++;
            }
            return this;
        }
        int IComparable.CompareTo(object obj) {
            return this.CompareTo(obj as Date);
        }
        public int CompareTo(object obj) {
            // return 1 if this date is later (larger)
            try {
                Date temp = (Date)obj;
                // compare the year
                if(this.Year > temp.Year)
                    return 1;
                else if(this.Year < temp.Year)
                    return -1;
                else {
                    // if the year is the same compare the month
                    if(this.Month > temp.Month)
                        return 1;
                    else if(this.Month < temp.Month)
                        return -1;
                    else {
                        // if the month is the same compare the day
                        if(this.Day > temp.Day)
                            return 1;
                        else if(this.Day < temp.Day)
                            return -1;
                        else
                            return 0;
                    }
                }
            }
            catch(Exception) {
                throw new Exception("Cannot compare these items...");
            }
        }
        public static Date operator +(Date thisDate, int numDays) {
            // when using the + operator increment the day by the integer added
            for(int i = 0; i < numDays; i++)
                thisDate.IncrementDay();

            return thisDate;
        }
    }
}
