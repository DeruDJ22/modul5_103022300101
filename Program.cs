using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300101
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 10;
            float b = 30;
            float c = 22;

            SimpleDataBase<float> data = new SimpleDataBase<float>();
            data.addNewData(a);
            data.addNewData(b);
            data.addNewData(c);
            data.PrintAllData();
        }
    }
    public class SimpleDataBase <T>
    {
        private List<T> storedData;
        private List<DateTime> inputData;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputData = new List<DateTime>();
        }

        public void addNewData(T data)
        {
            storedData.Add(data);
            inputData.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i} berisi {storedData[i]} yang disimpan pada waktu UTC: {inputData[i]}");
            }
        }
    }
}
