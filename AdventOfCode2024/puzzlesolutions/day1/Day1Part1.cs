using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.puzzlesolutions.day1
{
    class Day1Part1
    {
        public void printAnswer()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "puzzlesolutions\\day1\\day1part1.txt");
            string input = File.ReadAllText(path);
            Console.WriteLine(input);
        }
    }
}
