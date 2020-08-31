using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Threading;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Console.WriteLine("Please spin the wheel to play");
            Console.WriteLine("Press enter to spin the wheel");
            Console.ReadLine();

            Random rnd = new Random();
            int rn = rnd.Next(36);

            Console.WriteLine("You rolled a: {0}", rn);
            Console.WriteLine("The winning bets for your roll are: ");
            Console.WriteLine("Number: {0}", rn);

            int[] right = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] middle = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] left = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

            int[] red = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            if ((rn % 2 == 0) || rn == 0)
            {
                Console.WriteLine("Even");
            }
            else if (rn % 2 == 1)
            {
                Console.WriteLine("Odds");
            }

            if (red.Contains(rn))
            {
                Console.WriteLine("Red");
            }
            else if (black.Contains(rn))
            {
                Console.WriteLine("Black");
            }

            if (rn <= 18)
            {
                Console.WriteLine("Lows");
            }
            else if (rn >= 19)
            {
                Console.WriteLine("Highs");
            }

            if (0 < rn && rn <= 12)
            {
                Console.WriteLine("Dozens: Lower Thirds");
            }
            else if (rn >= 13 && rn <= 24)
            {
                Console.WriteLine("Dozens: Middle Thirds");
            }
            else if (rn >= 25 && rn <= 36)
            {
                Console.WriteLine("Dozens: Upper Thirds");
            }

            if (left.Contains(rn))
            {
                Console.WriteLine("Columns: 1st");
                Console.WriteLine($"Street: {rn}, {rn + 1}, {rn + 2}");
                if (rn == 1)
                {
                    Console.WriteLine("Split: 1/2, 1/4");
                }
                else if (rn == 34)
                {
                    Console.WriteLine("Split: 34/35, 31/34");
                }
                else
                {
                    Console.WriteLine($"Split: {rn}/{rn + 1}, {rn}/{rn - 3}, {rn}/{rn + 3}");
                }

            }
            else if (middle.Contains(rn))
            {
                Console.WriteLine("Columns: 2nd");
                Console.WriteLine($"Street: {rn - 1}, {rn}, {rn + 1}");
                if (rn == 2)
                {
                    Console.WriteLine("Split: 1/2, 2/3, 2/5");
                }
                else if (rn == 35)
                {
                    Console.WriteLine("Split: 34/35, 35/36, 35/32");
                }
                else
                {
                    Console.WriteLine($"Split: {rn}/{rn - 1}, {rn}/{rn + 1}, {rn}/{rn + 3}, {rn}/{rn - 3}");
                }
            }
            else if (right.Contains(rn))
            {
                Console.WriteLine("Columns: 3rd");
                Console.WriteLine($"Street: {rn - 2}, {rn - 1}, {rn}");
                if (rn == 3)
                {
                    Console.WriteLine("Split: 2/3, 3/6");
                }
                else if (rn == 36)
                {
                    Console.WriteLine("Split: 35/36, 33/36");
                }
                else
                {
                    Console.WriteLine($"Split: {rn}/{rn - 1}, {rn}/{rn - 3}, {rn}/{rn + 3}");
                }
            }

            if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine("Corners: 1,2,5,4");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine("Corners: 34,31,32,35");
            }
            else if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"Corners: {rn},{rn - 3},{rn - 2},{rn + 1}");
                Console.WriteLine($"Corners: {rn},{rn + 1},{rn + 4}, {rn + 3}");
            }

            if (middle.Contains(rn) && rn == 2)
            {
                Console.WriteLine("Corners: 1,2,4,5");
                Console.WriteLine("Corners: 2,3,5,6");
            }
            else if (middle.Contains(rn) && rn == 35)
            {
                Console.WriteLine("Corners: 31,32,34,35");
                Console.WriteLine("Corners: 32,33,35,36");
            }
            else if (middle.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"Corners: {rn - 4},{rn - 3},{rn},{rn - 1}");
                Console.WriteLine($"Corners: {rn - 3},{rn - 2},{rn},{rn + 1}");
                Console.WriteLine($"Corners: {rn + 1},{rn + 4},{rn},{rn + 3}");
                Console.WriteLine($"Corners: {rn - 1},{rn},{rn + 3},{rn + 2}");
            }

            if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine("Corners: 2,3,5,6");
            }
            else if (right.Contains(rn) && rn == 36)
            {
                Console.WriteLine("Corners: 32,33,35,36");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"Corners: {rn - 4},{rn - 3},{rn - 1},{rn}");
                Console.WriteLine($"Corners: {rn - 1},{rn},{rn + 2},{rn + 3}");
            }

            if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine("6 Numbers: 1,2,3,4,5,6");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine("6 Numbers: 31,32,33,34,35,36");
            }
            else if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"6 Numbers: {rn - 3},{rn - 2},{rn - 1},{rn},{rn + 1},{rn + 2} " +
                    "\r\n" + $"{rn},{rn + 1},{rn + 2},{rn + 3},{rn + 4},{rn + 5}");
            }

            if (middle.Contains(rn) && rn == 2)
            {
                Console.WriteLine("6 Numbers: 1,2,3,4,5,6");
            }
            else if (middle.Contains(rn) && rn == 35)
            {
                Console.WriteLine("6 Numbers: 31,32,33,34,35,36");
            }
            else if (middle.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"6 Numbers: {rn - 4},{rn - 3},{rn - 2},{rn - 1},{rn},{rn + 1} " +
                    "\r\n" + $"{rn - 1},{rn},{rn + 1},{rn + 2},{rn + 3},{rn + 4}");
            }

            if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine("6 Numbers: 1,2,3,4,5,6");
            }
            else if (right.Contains(rn) && rn == 36)
            {
                Console.WriteLine("6 Numbers: 31,32,33,34,35,36");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"6 Numbers: {rn - 5},{rn - 4},{rn - 3},{rn - 2},{rn - 1},{rn} " + 
                    "\r\n" + $"{rn - 2},{rn - 1},{rn},{rn + 1},{rn + 2},{rn + 3}");
            }
            
        }
    }
}