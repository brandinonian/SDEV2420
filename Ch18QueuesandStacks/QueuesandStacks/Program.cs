using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesandStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queues and Stacks by Brandon Phillips\n");

            List<string> names = new List<string>{ "Brandon", "Ana", "Roger", "Tasha" };

            //
            //
            //
            //
            //
            // Part 1, Queue
            Queue<string> queue = new Queue<string>();

            // add names to queue
            Console.WriteLine("-----Queue-----");
            foreach (string name in names)
            {
                Console.WriteLine($"Adding {name} to queue");
                queue.Enqueue(name);
            }

            // display each name in the queue
            Console.WriteLine("\n-----The queue contains these names-----");
            foreach (string name in queue)
            {
                Console.WriteLine(name);
            }

            // remove each name from the queue
            Console.WriteLine("\n-----Removing names from queue-----");
            while (queue.Count > 0)
            {
                string name = queue.Dequeue();
                Console.WriteLine($"{name} removed from queue");
            }


            //
            //
            //
            //
            //
            // Part 2, Stack
            Stack<string> stack = new Stack<string>();

            // add names to stack
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\n-----Stack-----");
            foreach (string name in names)
            {
                Console.WriteLine($"Adding {name} to stack");
                stack.Push(name);
            }

            // display each name in the stack
            Console.WriteLine("\n-----The stack contains these names-----");
            foreach (string name in stack)
            {
                Console.WriteLine(name);
            }

            // remove each name from the stack
            Console.WriteLine("\n-----Removing names from stack-----");
            while (stack.Count > 0)
            {
                string name = stack.Pop();
                Console.WriteLine($"Just removed {name} from stack");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
