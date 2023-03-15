using System;
using System.Collections;

namespace ДР_11_3
{
    /* Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть клас ArrayList. Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу ArrayList із простору імен System.Collections. 
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Count: " + arrayList.Count);

            arrayList.Add(123);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);

            Console.WriteLine("\nCount: " + arrayList.Count + "\n");

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            arrayList.Add("Hello");

            Console.WriteLine("\nCount: " + arrayList.Count);
            Console.WriteLine("Item at index 4: " + arrayList[4]);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            arrayList.Clear();

            Console.WriteLine("\nCount: " + arrayList.Count);

            Console.WriteLine("Item at index 0: " + arrayList[0]);

            Console.ReadKey();
        }
    }
}