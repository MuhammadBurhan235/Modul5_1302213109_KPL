using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302213109
{
    internal class SimpleDataBase <T, Date>
    {
        private List<T> storedData;
        private List<Date> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<Date>();
        }

        public AddNewData(T data)
        {
            storedData = data;
        }

        public void PrintAllData()
        {
            Console.WriteLine("Data 1 berisi: " + storedData + " yang disimpan pada waktu UTC: " + inputDates);
        }
    }
}
