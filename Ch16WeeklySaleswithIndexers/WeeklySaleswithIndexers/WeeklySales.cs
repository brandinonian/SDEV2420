using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklySaleswithIndexers
{
    public class WeeklySales
    {
        public double[] Sales = { 0, 0, 0, 0, 0 };
        public double this[string day]
        {
            get
            {
                switch (day.ToLower())
                {
                    case "mon": return Sales[0];
                    case "tue": return Sales[1];
                    case "wed": return Sales[2];
                    case "thu": return Sales[3];
                    case "fri": return Sales[4];
                    default: return -1;
                }
            }
            set
            {
                switch (day.ToLower())
                {
                    case "mon":
                        Sales[0] = value;
                        break;
                    case "tue":
                        Sales[1] = value;
                        break;
                    case "wed":
                        Sales[2] = value;
                        break;
                    case "thu":
                        Sales[3] = value;
                        break;
                    case "fri":
                        Sales[4] = value;
                        break;
                    default: break;
                }
            }
        }
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return Sales[0];
                    case 1: return Sales[1];
                    case 2: return Sales[2];
                    case 3: return Sales[3];
                    case 4: return Sales[4];
                    default: return -1;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        Sales[0] = value;
                        break;
                    case 1:
                        Sales[1] = value;
                        break;
                    case 2:
                        Sales[2] = value;
                        break;
                    case 3:
                        Sales[3] = value;
                        break;
                    case 4:
                        Sales[4] = value;
                        break;
                    default: break;
                }
            }
        }
        public override string ToString()
        {
            return $"Mon\tTue\tWed\tThu\tFri\n" +
                $"{Sales[0]}\t{Sales[1]}\t{Sales[2]}\t{Sales[3]}\t{Sales[4]}";
        }
    }
}
