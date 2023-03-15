namespace ДР_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("one", 1);
            dictionary.Add("two", 2);
            dictionary.Add("three", 3);
            dictionary.Add("fourth", 4);

            Console.WriteLine(dictionary["one"]);
            Console.WriteLine(dictionary["two"]);
            Console.WriteLine(dictionary["three"]);
            Console.WriteLine(dictionary["fourth"]);
            Console.WriteLine("\nCount: " + dictionary.Count);

            Console.ReadKey();
        }
    }
}