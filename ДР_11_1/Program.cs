namespace ДР_11_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> collection = new CarCollection<Car>();

            Car car1 = new Car { Name = "Car1", Year = 2000 };
            Car car2 = new Car { Name = "Car2", Year = 2005 };
            Car car3 = new Car { Name = "Car3", Year = 2010 };

            collection.AddNewCar(car1);
            collection.AddNewCar(car2);
            collection.AddNewCar(car3);

            Console.WriteLine("Count: " + collection.Count + "\n");

            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i].Name + " " + collection[i].Year);
            }

            collection.Clear();

            Console.WriteLine("\nCount after clear: " + collection.Count);

            Console.ReadKey();
        }
    }
}