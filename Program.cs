/*
Sum digits in string

Given a string, write a method which returns sum of all digits in that string.
Assume that string contains only single digits.

Expected input and output
    SumDigitsInString("1q2w3e") → 6 
    SumDigitsInString("L0r3m.1p5um") → 9
    SumDigitsInString("") → 0
*/

namespace ChallengeLab_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "1q2w3e";
            Console.WriteLine($"Sum of all digits in the string \"{input}\": " + SumDigitsInString(input));

            input = "L0r3m.1p5um";
            Console.WriteLine($"\nSum of all digits in the string \"{input}\": " + SumDigitsInString(input));

            input = "";
            Console.WriteLine($"\nSum of all digits in the string \"{input}\": " + SumDigitsInString(input));
        }

        static int SumDigitsInString(string input)
        {
            int sum = 0;

            //// Test with TryParse
            //foreach (char character in input)
            //{
            //    int tempNumber = 0;
            //    int.TryParse(character.ToString(),out tempNumber);
            //    sum += tempNumber;
            //}

            //// Test with IsNumber()
            //foreach (char character in input)
            //{
            //    if (Char.IsNumber(character))
            //    {
            //        sum += int.Parse(character.ToString());
            //        Console.WriteLine(int.Parse(character.ToString()));
            //    }
            //}

            // Test with GetNumericValue()
            foreach (char character in input)
            {
                if(Char.IsNumber(character))
                    sum += Convert.ToInt32(Char.GetNumericValue(character));
            }

            return sum;
        }
    }
}
