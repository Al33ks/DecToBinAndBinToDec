using System;

namespace DecToBinAndBinToDec
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap Binary to Decimal (B), or Decimal to Binary (D)?");
            string answer = Console.ReadLine();
            

            if (answer == "B" || answer == "b")
            {
                Console.Write("Insert Binary Number: ");
                string Binaries = Console.ReadLine();
                int Binary = int.Parse(Binaries);
                Console.WriteLine("This number in Decimal equals: " + Convert.ToInt32(Binaries, 2));
                
            }
            else if (answer == "D" || answer == "d")
            {
                Console.Write("Insert Decimal Number: ");
                string input = Console.ReadLine();
                int Decimal = int.Parse(input);
                Console.WriteLine("This number in Binary equals: " + Convert.ToString(Decimal, 2));
            }
            else
            {
                Console.WriteLine("Blunder in the Matrix. Try again!");
            }
            Console.ReadKey();
        }
    }
}