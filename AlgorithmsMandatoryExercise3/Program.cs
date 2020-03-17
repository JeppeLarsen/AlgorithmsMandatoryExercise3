using System;
using System.Linq;

namespace AlgorithmsMandatoryExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChristmasLightChain();
            CombustingConcoctions();
        }

        static void ChristmasLightChain()
        {
            int length = int.Parse(Console.ReadLine());
            string indArray = Console.ReadLine();
            int[] input = indArray.Split(' ').Select(str => int.Parse(str)).ToArray();
            Array.Sort(input);
            //Console.WriteLine(string.Join(' ', input));

            int maxCons = 0;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] - 1 == input[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > maxCons) maxCons = currentCount;
            }

            Console.WriteLine(maxCons == 1 ? 0 : maxCons);
        }

        static void CombustingConcoctions()
        {
            int length = int.Parse(Console.ReadLine());
            string indArray = Console.ReadLine();
            int[] input = indArray.Split(' ').Select(str => int.Parse(str)).ToArray();
        }
    }
}