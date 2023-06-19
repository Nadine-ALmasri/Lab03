internal static class ProgramHelpersHelpers
{
    public static int ProductOfThreeNumbers()
    {
        Console.WriteLine("Please Enter Three Numbers seperated by space : ");
        string given = Console.ReadLine();
        string[] numbers = given.Split(' ');
     
            if (numbers.Length < 3)
            {
                Console.WriteLine("Invalid Input Please Try Again");
                return 0;
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
                    else
                    {
                        result *= 1;
                    }
                }

                Console.WriteLine($"If We Multiply The Three Numbers We Get: {result}");
                return result;
            }

            // This line is unreachable, but it's needed to satisfy the return type of the method
            return 0;
        }
    }

