using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ДР_11_2
{
    /* Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    * Створіть клас Dictionary. 
    * Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу Dictionary із простору імен System.Collections.Generic. 
    * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання пар елементів, 
    * індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості пар елементів. */
    internal class Dictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> items = new List<KeyValuePair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            items.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public TValue this[TKey key]
        {
            get
            {
                foreach (var item in items)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }
                throw new KeyNotFoundException();
            }
        }

        public int Count { get { return items.Count; } }
    }
}
