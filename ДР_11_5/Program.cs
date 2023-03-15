namespace ДР_11_5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int test = MyClass<int>.FactoryMethod();

            Console.WriteLine(test.GetType().Name);

            Program test2 = MyClass<Program>.FactoryMethod(); 

            Console.WriteLine(test2.GetType().Name);

            Console.ReadKey();
        }
    }
}