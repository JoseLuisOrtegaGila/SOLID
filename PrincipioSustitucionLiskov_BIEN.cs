namespace Liskov	
{
    public abstract class Vehicle
    {
        public int NumberOfSeats { get; }

        protected Vehicle(int numberOfSeats)
        {
            NumberOfSeats = numberOfSeats;
        }
        public int GetNumberOfSeats()
        {
            return NumberOfSeats;
        }
    }
    // Clases derivadas
   public class Tesla : Vehicle
    {
         public Tesla(int seats) : base(seats) { }
    }
    public class Audi : Vehicle
    {
        public Audi(int seats) : base(seats) { }
    }
    public class Toyota : Vehicle
    {
        public Toyota(int seats) : base(seats) { }
    }
    public class Honda : Vehicle
    {
        public Honda(int seats) : base(seats) { }
    }
    class Program
    {
        static void Main()
        {
            var cars = new List<Vehicle>  {new Tesla(7), new Audi(2), new Toyota(5), new Honda(5) };
            PrintCarSeats(cars);
        }   
        static void PrintCarSeats(List<Vehicle> cars)
        {
            foreach (var car in cars)  { Console.WriteLine($"{car.GetType().Name}, {car.GetNumberOfSeats()}"); }
        }
    }
}
