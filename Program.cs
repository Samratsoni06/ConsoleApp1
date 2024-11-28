using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public void ReverseNum()
        {
            int n = 125;
            int result = 0;

            while (n > 0)
            {
                int r = n % 10;
                result = (result * 10) + r;
                n /= 10;
            }
            Console.WriteLine("Reverse Number =  " + result);
        }

        public void Palindrom()
        {
            int num = 124;
            int result = 0, r;

            int temp = num;

            while (num > 0)
            {
                r = num % 10;
                result = (result * 10) + r;
                num /= 10;
            }
            if (temp == result)
            {
                Console.WriteLine("Number is Palandrom =" + result);
            }
            else
            {
                Console.WriteLine("Number is Not Palandrom =" + result);
            }
        }

        public void Replace()
        {
            int a = 3, b = 4;

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            //a = a + b;
            //b = a - b;
            //a = a - b;

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);

        }

        public void Febonic(int len)
        {
            int a = 0, b = 1, c = 0;


            Console.WriteLine("Febonic");
            Console.Write(a);

            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" ,{0} ", c);
                a = b; ;
                b = c;
            }

            Console.WriteLine();
        }

        public void Sorting()
        {
            //int[] arr1 = new int[10];
            //arr1[0] = 0;
            //arr1[1] = 3;
            //arr1[2] = 4;
            //arr1[3] = 5;

            int[] arr = { 5, 3, 2, 7, 6, 8, 9, 1 };
            int temp = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorting Array ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

        }

        public void StringCount()
        {
            string input = "dhfdytyewyuvvvvvsdgchv";

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic[c] = 1;
                }
            }

            Console.WriteLine("Char Count ");
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " => " + item.Value);
            }

        }

        public void Count()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // List to store character counts
            List<KeyValuePair<char, int>> charCounts = new List<KeyValuePair<char, int>>();

            foreach (char c in input)
            {
                bool found = false;

                // Check if the character already exists in the list
                for (int i = 0; i < charCounts.Count; i++)
                {
                    if (charCounts[i].Key == c)
                    {
                        // Increment the count for the character
                        charCounts[i] = new KeyValuePair<char, int>(c, charCounts[i].Value + 1);
                        found = true;
                        break;
                    }
                }

                // If character not found, add it with an initial count of 1
                if (!found)
                {
                    charCounts.Add(new KeyValuePair<char, int>(c, 1));
                }
            }

            // Display character counts
            Console.WriteLine("\nCharacter counts:");
            foreach (var pair in charCounts)
            {
                Console.WriteLine($"Character '{pair.Key}' => {pair.Value} times.");
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.ReverseNum();
            program.Palindrom();
            program.Replace();
            program.Febonic(12);
            program.Sorting();
            program.StringCount();
            program.Count();


            Console.WriteLine("");
        }
    }
}
