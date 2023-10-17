internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(IfYearIsLeap(2021));
        Console.WriteLine(Factorial(7));

            static bool IfYearIsLeap(int year)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            static int Factorial(int N)
        {
            if (N >= 0)
            {
                int result = 1; 

                for (int i = 1; i <= N; i++)
                {
                    result *= i;
                }
                return result;
            }
            else
            {
                return 0;
            }
        }



        }
    }
