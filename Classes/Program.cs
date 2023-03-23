 namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create an instance
            Car myCar = new Car();

            //dot notation
            myCar.Make = "Honda CRV";
            myCar.Model = "EX Sport Hybrid";
            myCar.Year = 2023;

            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
        }
    }
}
