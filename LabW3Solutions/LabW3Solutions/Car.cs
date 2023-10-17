public interface IVehicle
{
    void Drive();
    bool Refuel(int amount);
}

public class Car : IVehicle
{
    public int Fuel { get; set; }

    public Car(int fuel)
    {
        Fuel = fuel;   
    }

    public void Drive()
    {
        if (Fuel > 0)
        {
            Console.WriteLine("Driving");
            Console.WriteLine(Fuel);
        }
        else
        {
            Console.WriteLine("No fuel");
        }
    }

    public bool Refuel(int amount)
    {
        Fuel += amount;
        return true;
    }
}