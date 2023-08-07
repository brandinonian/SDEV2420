using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch23RollingDice {
    internal class Program {
        static void Main(string[] args) {
            WriteLine("Ch 23 Rolling Dice by Brandon Phillips");

            //DoWork();
            DoWorkParallel();

            // identifier output
            WriteLine("Does this wait to print after the DoWork method is called?");

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }

        public static void DoWork() {
            // ask the user how many rolls
            Write("How many rolls? ");
            int rollCount = int.Parse(ReadLine());

            // roll the dice sequentially
            RollDice(rollCount);
            RollDice(rollCount * 10);
            RollDice(rollCount * 100);

            // identifier output
            WriteLine("Inside DoWork, does it wait for the tasks to complete?");
        }

        public static void DoWorkParallel() {
            // ask the user how many rolls
            Write("How many rolls? ");
            int rollCount = int.Parse(ReadLine());

            // roll the dice with tasks
            Task firstTask = Task.Run(() => RollDice(rollCount));
            Task secondTask = Task.Run(() => RollDice(rollCount * 10));
            Task thirdTask = Task.Run(() => RollDice(rollCount * 100));

            // identifier output
            WriteLine("Inside DoWorkParallel, does it wait for the tasks to complete?");
        }

        public static void RollDice(int rollCount) {
            // array to track rolls, results from 2-12
            int[] rolls = new int[11];

            // track the total number of rolls executed
            int totalRolls = 0;

            // new random number generator
            Random rng = new Random();

            // roll dice loop
            for(int i = 0; i < rollCount; i++) {
                // generate random rolls
                int d1, d2, total;
                d1 = rng.Next(1, 7);
                d2 = rng.Next(1, 7);
                total = d1 + d2;

                // update rolls array to track results
                rolls[total - 2]++;

                // count total rolls executed
                totalRolls++;
            }

            // display results
            for(int i = 0; i < rolls.Length; i++) {
                WriteLine($"Value {i + 2} rolled {rolls[i]} times");
            }

            // display total number of rolls (input param)
            WriteLine($"Total number of rolls: {totalRolls:N0}");
            WriteLine();
        }
    }
}
