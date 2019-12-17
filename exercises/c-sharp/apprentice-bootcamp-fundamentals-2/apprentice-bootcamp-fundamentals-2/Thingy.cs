using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class Thingy
    {
        private int maxCount = Byte.MaxValue - 155;
        private int count;
        private int fizzCount;
        private int buzzCount = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string FullFizzBuzzResult()
        {
            string fizzBuzzOutput = "";
            for (; count < maxCount; count++) fizzBuzzOutput += SingleFizzBuzzResult(count) + " ";
            string result = fizzBuzzOutput.Substring(0, fizzBuzzOutput.Length - 1);
            return result;
        }

        private string SingleFizzBuzzResult(int number)
        {
            fizzCount++;
            buzzCount--;

            const int three = 0b11;
            string numberToString = (number + 1).ToString();
            string numberToFizzBuzz = fizzCount == three || buzzCount == 0 
                ? "" 
                : numberToString;
            if (fizzCount == three) numberToFizzBuzz += Fizz();
            if (buzzCount == 0) numberToFizzBuzz += Buzz();
            return numberToFizzBuzz;
        }

        private string Buzz()
        {
            buzzCount = new int[] { 0, 0, 0, 0, 0 }.Length;
            string buzz = DataTypeConverter.ParseHexBinary("42757a7a");
            return buzz;
        }

        private string Fizz()
        {
            fizzCount = 0;
            string fizz = DataTypeConverter.ParseHexBinary("46697a7a");
            return fizz;
        }
    }
}
