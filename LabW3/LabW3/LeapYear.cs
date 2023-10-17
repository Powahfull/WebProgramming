Console.WriteLine("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());
if (year % 4 == 0 && year % 100 != 0)
{
    Console.WriteLine("It's a leap year!");
}
else if (year % 400 == 0)
{
    Console.WriteLine("It's a leap year");
}
else
{
    Console.WriteLine("It's not a leap year");
}

