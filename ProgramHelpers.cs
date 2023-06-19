internal static class ProgramHelpers
{
    public static int ProductOfThreeNumbers()
    {
     
        {
            Console.WriteLine("Please Enter Three Numbers : ");
            string given = Console.ReadLine();
            string[] numbers = given.Split(' ');
            Console.WriteLine(numbers); 
            int result = 1;
            if (numbers.Length < 3)
            {
                Console.WriteLine("Invalid Input Please Try Again");
                return 0;
            }
           
            else if (numbers.Length >= 3)
            {
                ;
                for (int i = 0; i < 3; i++)
                {
                    if (int.TryParse(numbers[i], out int number))
                    {
                        result *= number;
                        return result;
                    }
                }
            }
            else
            {
                result *= 1;
            }
            return result;
                    Console.WriteLine($"If We Multiplay The Three Numbers We Get: {result}");
                }
               
            }
        
}