using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class Thingy
    {
        private int count;
        private int fizzCount;
        private int buzzCount = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string FullFizzBuzzResult()
        {
            string fizzBuzzToString = "";
            for (; count < Byte.MaxValue - 155; count++) fizzBuzzToString += SingleFizzBuzzResult(count) + " ";
            return fizzBuzzToString.Substring(0, fizzBuzzToString.Length - 1);
        }

        private string SingleFizzBuzzResult(int number)
        {
            fizzCount++;
            buzzCount--;

            string numberToFizzBuzz = fizzCount == 0b11 || buzzCount == 0 ? "" : (number + 1).ToString();
            if (fizzCount == 0b11) numberToFizzBuzz += Fizz();
            if (buzzCount == 0) numberToFizzBuzz += Buzz();
            return numberToFizzBuzz;
        }

        private string Buzz()
        {
            buzzCount = new int[] { 0, 0, 0, 0, 0 }.Length;
            return DataTypeConverter.ParseHexBinary("42757a7a");
        }

        private string Fizz()
        {
            fizzCount = 0;
            return DataTypeConverter.ParseHexBinary("46697a7a");
        }
    }
}
