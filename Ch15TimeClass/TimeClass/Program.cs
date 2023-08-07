using static System.Console;
namespace TimeClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Time Class by Brandon Phillips");


            // Part 1
            WriteLine("\nPart 1: Creating objects with 3 parameters");

            WriteLine("\nAssigning time with 9, 10, and 58");
            Time time1 = new Time(9, 10, 58);
            WriteLine(time1);
            WriteLine("\nChanging hours to 99");
            time1.Hours = 99;
            WriteLine(time1);

            WriteLine("\nAssigning time with 14, 30, and 17");
            Time time2 = new Time(14, 30, 17);
            WriteLine(time2);
            WriteLine("\nChanging minutes to 130");
            time2.Minutes = 130;
            WriteLine(time2);

            WriteLine("\nAssigning time with 20, 24, 40");
            Time time3 = new Time(14, 30, 17);
            WriteLine(time3);
            WriteLine("\nChanging seconds to 123");
            time3.Seconds = 123;
            WriteLine(time3);

            WriteLine("\nInstatiating Invalid Objects");

            WriteLine("\nCreating 3 parameter object with invalid hours: 25, 15, 30");
            Time time4 = new Time(25, 15, 30);
            WriteLine(time4);

            WriteLine("\nCreating 3 parameter object with invalid minutes: 18, 105, 45");
            Time time5 = new Time(18, 105, 45);
            WriteLine(time5);

            WriteLine("\nCreating 3 parameter object with invalid seconds: 11, 5, 99");
            Time time6 = new Time(11, 5, 99);
            WriteLine(time6);

            WriteLine("\nCreating 3 parameter object with all invalid data: 100, 100, 100");
            Time time7 = new Time(100, 100, 100);
            WriteLine(time7);
            WriteLine("\nChanging seconds to 34, minutes to 12, hours to 5");
            time7.Seconds = 34;
            time7.Minutes = 12;
            time7.Hours = 5;
            WriteLine(time7);

            // Part 2
            WriteLine("\nPart 2: Instatiating Incomplete Objects using THIS constructor");

            WriteLine("\nInstantiating 1 parameter object with 11");
            Time time8 = new Time(11);
            WriteLine(time8);

            WriteLine("\nInstantiating 2 parameter object with 5, 25");
            Time time9 = new Time(5, 25);
            WriteLine(time9);

            WriteLine("\nInstantiating 1 parameter object with 30");
            Time time10 = new Time(30);
            WriteLine(time10);
            WriteLine("Changing hours to 2");
            time10.Hours = 2;
            WriteLine(time10);

            WriteLine("\nInstantiating 2 parameter object with 48, 120");
            Time time11 = new Time(40, 120);
            WriteLine(time11);
            WriteLine("Changing hours to 4 and minutes to 45");
            time11.Hours = 4;
            time11.Minutes = 45;
            WriteLine(time11);

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}