using System;
using System.Linq;

namespace AlgorithmsMandatoryExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string indArray = Console.ReadLine();
            int[] input = indArray.Split(' ').Select(str => int.Parse(str)).ToArray();
        }
    }
}