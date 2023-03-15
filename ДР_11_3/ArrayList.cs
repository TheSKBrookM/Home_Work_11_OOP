using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_11_3
{
    internal class ArrayList
    {
        private object[] items;
        private int count;
        public int Count
        {
            get { return count; }
        }

        public ArrayList()
        {
            items = new object[1];
            count = 0;
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    return "No item";
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public void Add(object value)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count] = value;
            count++;
        }

        public void Clear()
        {
            items = new object[1];
            count = 0;
        }
    }
}
