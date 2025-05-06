    public class Tesla
    {
        private int numberOfSeats;  
        public Tesla(int seats) => numberOfSeats = seats; 
        public int GetNumberOfTeslaSeats() => numberOfSeats;
    }
    public class Audi
    {
        private int numberOfSeats;
        public Audi(int seats) => numberOfSeats = seats;
        public int GetNumberOfAudiSeats() => numberOfSeats;
    }
    public class Toyota
    {
        private int numberOfSeats;
        public Toyota(int seats) => numberOfSeats = seats;
        public int GetNumberOfToyotaSeats() => numberOfSeats;
    }
    public class Honda
    {
        private int numberOfSeats;
        public Honda(int seats) => numberOfSeats = seats;
        public int GetNumberOfHondaSeats() => numberOfSeats;
    }
class Program
{
    static void Main(string[] args)
    {
        var cars = new List<object> { new Tesla(7), new Audi(2),  new Toyota(5),  new Honda(5)};
        PrintCarSeats(cars);
    }
    static void PrintCarSeats(List<object> cars)
    {
        foreach (var car in cars)
        {
            if (car is Tesla tesla)   {Console.WriteLine($"Tesla: {tesla.GetNumberOfTeslaSeats()}"); continue;}
            if (car is Audi audi)     {Console.WriteLine($"Audi: {audi.GetNumberOfAudiSeats()}");    continue;}
            if (car is Toyota toyota) {Console.WriteLine($"Toyota: {toyota.GetNumberOfToyotaSeats()}"); continue;}
            if (car is Honda honda)   {Console.WriteLine($"Honda: {honda.GetNumberOfHondaSeats()}");  continue;
            }
        }
    }
}
