using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EvenandOddIterators
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Even and Odd Iterators by Brandon Phillips");

            Stack<int> theStack = new Stack<int>();
            // add items to stack
            for (int number = 0; number <= 10; number++)
                theStack.Push(number);




            WriteLine("Display contents using named iterator TopToBottom");
            foreach (int number in theStack.TopToBottom)
                Write($"{number}  ");
            WriteLine("\n");

            WriteLine("Display contents using named iterator BottomToTop");
            foreach (int number in theStack.BottomToTop)
                Write($"{number}  ");
            WriteLine("\n");

            // display even numbers
            WriteLine("Display contents using named iterator GetEvens");
            foreach (int number in theStack.GetEvens)
                Write($"{number}  ");
            WriteLine("\n");

            // display odd numbers
            WriteLine("Display contents using named iterator GetOdds");
            foreach (int number in theStack.GetOdds)
                Write($"{number}  ");
            WriteLine("\n");

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
