using System.ComponentModel;

namespace EX01LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue; //-най-малкото възможно число, което може да бъде побрано в  типа int
            int sumOfAll = 0;


            for (int i = 0; i < n; i = i + 1)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > biggestNumber)
                    biggestNumber = number;

                sumOfAll += number;
            } // -тук цикълът приключва, като вече има натрупани стойност и към промнеливите sumOfAll, biggestNumber.

            sumOfAll = sumOfAll - biggestNumber;//вече натрупаните стойности на sumOfAll, biggestNumber

            if (sumOfAll == biggestNumber)

            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOfAll}");
            }
            else 
            {
                int diff = Math.Abs(sumOfAll - biggestNumber); //Math.Abs - "връща" винаги положителна - абсолютната стойност
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }

            

        }
    }
}