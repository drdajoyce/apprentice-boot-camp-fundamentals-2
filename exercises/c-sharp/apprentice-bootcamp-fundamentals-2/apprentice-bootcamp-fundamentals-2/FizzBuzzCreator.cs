using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class FizzBuzzCreator
    {
        private const int MAX_COUNT = Byte.MaxValue - 155;
        private const int THREE = 0b11;
        private const string HEX_BUZZ = "42757a7a";
        private const string HEX_FIZZ = "46697a7a";
        private int fizzCount;
        private int buzzCount = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string FullFizzBuzzResult()
        {
            string fizzBuzzOutput = "";
            for (int i = 0 ; i < MAX_COUNT ; i++) fizzBuzzOutput += SingleFizzBuzzResult(i) + " ";
            return RemoveLastCharacter(fizzBuzzOutput);
        }

        private static string RemoveLastCharacter(string input)
        {
            return input.Substring(0, input.Length - 1);
        }

        private string SingleFizzBuzzResult(int index)
        {
            fizzCount++;
            buzzCount--;

            string numberToString = GetNumberFromIndex(index);
            bool divisibleByThree = fizzCount == THREE;
            bool divisibleByFive = buzzCount == 0;
            string numberToFizzBuzz = divisibleByThree || divisibleByFive
                            ? ""
                            : numberToString;
            if (divisibleByThree) numberToFizzBuzz += Fizz();
            if (divisibleByFive) numberToFizzBuzz += Buzz();
            return numberToFizzBuzz;
        }

        private static string GetNumberFromIndex(int index)
        {
            return (index + 1).ToString();
        }

        private string Buzz()
        {
            buzzCount = new int[] { 0, 0, 0, 0, 0 }.Length;
            string buzz = HexToString(HEX_BUZZ);
            return buzz;
        }      

        private string Fizz()
        {
            fizzCount = 0;
            string fizz = HexToString(HEX_FIZZ);
            return fizz;
        }

        private static string HexToString(string hexValue)
        {
            return DataTypeConverter.ParseHexBinary(hexValue);
        }
    }
}
