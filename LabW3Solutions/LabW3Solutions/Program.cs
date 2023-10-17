using LabW3Solutions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(IfYearIsLeap(2021));
        Console.WriteLine(Factorial(7));
        Console.WriteLine(SumOfDigits(3169));

        Person myPerson = new Person();
        myPerson.Greet();
        Student myStudent = new Student();
        myStudent.ShowAge(18);
        Teacher myTeacher = new Teacher();
        myTeacher.SetAge(31);
        myTeacher.Explain();

        Car car = new Car(20);
        int fuel = int.Parse(Console.ReadLine());
        if (car.Refuel(fuel))
        {
            car.Drive();
        }

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

                for (int i = 1; i <= N; i++) //Changed i to 1 because if we multiply it with 0, result is 0
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

            static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10; //Get last digit  
                sum += digit; 
                number /= 10; //Remove the last digit
            }
            return sum;
        }

            


        }
    }
