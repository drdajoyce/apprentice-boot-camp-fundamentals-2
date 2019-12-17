using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class FizzBuzzCreator
    {
        private const int MAX_COUNT = Byte.MaxValue - 155;
        private const int THREE = 0b11;
        private const string HEX_BUZZ = "42757a7a";
        private const string HEX_FIZZ = "46697a7a";
        private int count;
        private int fizzCount;
        private int buzzCount = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string FullFizzBuzzResult()
        {
            string fizzBuzzOutput = "";
            for (; count < MAX_COUNT; count++) fizzBuzzOutput += SingleFizzBuzzResult(count) + " ";
            string trimmedResult = fizzBuzzOutput.Substring(0, fizzBuzzOutput.Length - 1);
            return trimmedResult;
        }

        private string SingleFizzBuzzResult(int number)
        {
            fizzCount++;
            buzzCount--;

            int fizzFactor = THREE;

            string numberToString = (number + 1).ToString();
            bool divisibleByThree = fizzCount == fizzFactor;
            bool divisibleByFive = buzzCount == 0;
            string numberToFizzBuzz = divisibleByThree || divisibleByFive
                ? "" 
                : numberToString;
            if (divisibleByThree) numberToFizzBuzz += Fizz();
            if (divisibleByFive) numberToFizzBuzz += Buzz();
            return numberToFizzBuzz;
        }

        private string Buzz()
        {
            buzzCount = new int[] { 0, 0, 0, 0, 0 }.Length;
            string buzz = DataTypeConverter.ParseHexBinary(HEX_BUZZ);
            return buzz;
        }

        private string Fizz()
        {
            fizzCount = 0;
            string fizz = DataTypeConverter.ParseHexBinary(HEX_FIZZ);
            return fizz;
        }
    }
}
