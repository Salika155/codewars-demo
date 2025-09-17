using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_solutions
{
    public static class Kata
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }

        //esta hay que rehacerla
        public static string BooleanToString(bool b)
        {
            return b.ToString();
        }

        public static int StringToNumber(String str)
        {
            int result = 0;
            bool isNegative = false;
            int startIndex = 0;

            // Comprobar si el número es negativo
            if (str[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }

            for (int i = startIndex; i < str.Length; i++)
            {
                char c = str[i];
                int digit = c - '0';
                result = result * 10 + digit;
            }

            return isNegative ? -result : result;
        }

        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == true)
                    count++;
            }
            return count;
        }

        public static int DoubleInteger(int n)
        {
            return n * 2;
        }

        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int diff = dadYears - 2 * sonYears;
            return diff < 0 ? -diff : diff;
        }

        public static int SumMix(object[] x)
        {
            int sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += Convert.ToInt32(x[i]);
            }

            return sum;
        }

        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }

        public static string Rps(string p1, string p2)
        {
            if (p1 == p2)
                return "Draw!";

            if ((p1 == "rock" && p2 == "scissors") ||
                     (p1 == "scissors" && p2 == "paper") ||
                     (p1 == "paper" && p2 == "rock"))
                return "Player 1 won!";
            else
                return "Player 2 won!";
        }

        public static int Multiply(int x)
        {
            int result = 0;
            if (x % 2 == 0)
                result = x * 8;
            else if (x % 2 != 0)
                result = x * 9;
            return result;
        }

        public static int Litres(double time)
        {
            return (int)Math.Floor(time * 0.5);
        }

        public static double GetVolumeOfCuboid(double length, double width, double height)
        {
            return length * width * height;
        }

        public static string Smash(string[] words)
        {
            string phrase = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (i == words.Length - 1)
                    phrase += words[i];
                else
                    phrase += words[i] + " ";
            }
            return phrase;
        }

        public static string AreYouPlayingBanjo(string name)
        {
            if (name[0] == 'R' || name[0] == 'r')
            {
                return name + " plays banjo";
            }
            else
            {
                return name + " does not play banjo";
            }
        }

        public static double basicOp(char operation, double value1, double value2)
        {
            if (operation == '+')
                return value1 + value2;
            else if (operation == '-')
                return value1 - value2;
            else if (operation == '*')
                return value1 * value2;
            else if (operation == '/')
                return value1 / value2;
            return -1;
        }

        public static int PositiveSum(int[] arr)
        {
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    sum += arr[i];
            }
            return sum;
        }

        public static int SquareSum(int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i] * numbers[i];
            }
            return sum;
        }

        public static bool Check(object[] a, object x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != null && a[i].Equals(x))
                    return true;
            }
            return false;
        }

        public static string EvenOrOdd(int number)
        {
            string Even = "Even";
            string Odd = "Odd";
            if (number % 2 == 0)
                return Even;
            else
                return Odd;
        }


    }

}
