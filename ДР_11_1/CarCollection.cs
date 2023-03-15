using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ДР_11_1
{
    internal class CarCollection <T> where T : Car
    {
        List<T> carList;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public CarCollection()
        {
            carList = new List<T>();
        }

        public T this[int index]
        {
            get { return carList[index]; }
        }
        public void AddNewCar(T car)
        {
            carList.Add(car);
            count++;
        }

        public void Clear()
        {
            carList = new List<T>();
            count = 0;
        }
    }
}
