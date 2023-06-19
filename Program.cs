using System.ComponentModel;
using System.Numerics;
using System;
using System.IO;
using System.Linq;
using System.Transactions;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;

namespace Lab03
{
    public class Program
    {

        static void ProductOfThreeNumbers()
        {
            Console.WriteLine("Please Enter Three Numbers seperated by space : ");
            string given = Console.ReadLine();
            string[] numbers = given.Split(' ');

            if (numbers.Length < 3)
            {
                Console.WriteLine("Invalid Input Please Try Again");

            }
            else if (numbers.Length >= 3)
            {
                int result = 1;
                for (int i = 0; i < 3; i++)
                {
                    if (int.TryParse(numbers[i], out int number))
                    {
                        result *= number;

                    }

                    result *= 1;

                }
                Console.WriteLine($"If We Multiplay The Three Numbers We Get: " + result);
            }
        }
        static void RandomAverage()
        {
            Console.WriteLine("Please Enter a Number between 2-10");
            string num = Console.ReadLine();

            int count;
            while (!int.TryParse(num, out count) || count < 2 || count > 10)
            {
                Console.WriteLine("Invalid Input. Please enter a valid number between 2-10:");
                num = Console.ReadLine();
            }

            double sum = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Enter {i} of {count} should be non-negative number:");
                string TheNumber = Console.ReadLine();

                double number;
                while (!double.TryParse(TheNumber, out number) || number < 0)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid non-negative number:");
                    TheNumber = Console.ReadLine();
                }

                sum += number;
            }

            double avg = sum / count;
            Console.WriteLine($"The Average of the Inputs is: {avg}");
        }
        static void Stars()
        {
            Console.WriteLine("     *");
            Console.WriteLine(" ");
            Console.WriteLine("    ***");
            Console.WriteLine(" ");
            Console.WriteLine("   *****");
            Console.WriteLine(" ");
            Console.WriteLine("  *******");
            Console.WriteLine(" ");
            Console.WriteLine(" *********");
            Console.WriteLine(" ");
            Console.WriteLine(" *********");
            Console.WriteLine(" ");
            Console.WriteLine("  *******");
            Console.WriteLine(" ");
            Console.WriteLine("   *****");
            Console.WriteLine(" ");
            Console.WriteLine("    ***");
            Console.WriteLine("     *");
        }
        static int CountForFrequent(int[] array)
        {
            int mostFrequentNumber = array[0];
            int maxCount = 1;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                int currentCount = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == currentNumber)
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    mostFrequentNumber = currentNumber;
                }
            }

            return mostFrequentNumber;
        
    }
        static int maximumValueInTheArray(int[] array2)
        {
            int maximumValue = array2[0];
           


                for (int j = 1; j < array2.Length; j++)
                {
                    if (array2[j] >= maximumValue)
                    {
                        maximumValue = array2[j];
                    }
                }

               return maximumValue;
            

            

        

    }
        static void WriteInTheFileContent(string path)
        {
            Console.WriteLine("Please Enter  Line To Save In The File");
           string newLine = Console.ReadLine();

            File.WriteAllText(path, newLine);
        }
        static void ReadFileText(string path)
        {
            string dataFromFile = File.ReadAllText(path);
            Console.WriteLine("The Text Writen In That File Is :");

            Console.WriteLine(dataFromFile);
        }
        static void ModifyTheFile( string path ,string deletedWord)
        {
            string dataFromFile = File.ReadAllText(path);
            Console.WriteLine("The Text exist In That File Is :");

            Console.WriteLine(dataFromFile);
            Console.WriteLine("The Text After Deleting a Word From The File");
            string modifiedData = dataFromFile.Replace(deletedWord, string.Empty);
            Console.WriteLine(modifiedData);
            Console.WriteLine("The Text After Returning the deletedWord ");
            File.WriteAllText(path, deletedWord);
            Console.WriteLine(dataFromFile);
        }
        static void GetSentanceLength()
        {
            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string[] result = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int length = word.Length;
                result[i] = $"{word}: {length}";
                
            }
            Console.WriteLine("The Resulting Array :");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                
                if (i < result.Length - 1)
                {
                    Console.Write(",");

                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The first challange\n");
            ProductOfThreeNumbers();
            RandomAverage();
            Stars();
            int[] array = {10, 11, 22, 12, 13, 33, 13, 11, 21, 15, 5, 16, 70, 18, 12, 11, 1 };
            int mostFrequentNumber = CountForFrequent(array);
            Console.WriteLine("The most frequent number in this array is: " + mostFrequentNumber);
            int[] array2 = { 100, 110, 220 ,120, 130, 330, 13, 110, 210, 150, 50, 160, 700, 180, 120, 110, 10 };
            int maximumValue = maximumValueInTheArray(array2);
            Console.WriteLine("The maximum Value in this array is: " + maximumValue);
            string path = "../../../words.txt";
            WriteInTheFileContent(path);
            ReadFileText(path);
            string deletedWord = "world!";
            ModifyTheFile (path, deletedWord);
            GetSentanceLength();

        }
    }
}
    