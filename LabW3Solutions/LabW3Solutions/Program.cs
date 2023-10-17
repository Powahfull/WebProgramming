internal class Program
{
    private static void Main(string[] args)
    {
        static void main(string[] args)
        {

            Console.WriteLine(IfYearIsLeap(2020));

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


        }
    }
}