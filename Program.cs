using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static modul5_103022300101.PemrosesData;

namespace modul5_103022300101
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 10;
            float b = 30;
            float c = 22;

            PemrosesData dp = new PemrosesData();
            dp.DapatkanNilaiTerbesar(a, b, c);

            SimpleDataBase<float> data = new SimpleDataBase<float>();
            data.addNewData(a);
            data.addNewData(b);
            data.addNewData(c);
            data.PrintAllData();
        }
    }
    public class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            dynamic A = (dynamic)a;
            dynamic B = (dynamic)b;
            dynamic C = (dynamic)c;

            if (A > B && A > C)
            {
                Console.WriteLine($"Nilai {A} lebih besar dari pada nilai {B} dan {C}");
            }
            else if (B > C && B > A)
            {
                Console.WriteLine($"Nilai {B} lebih besar dari pada nilai {A} dan {C}");
            }
            else if (C > A && C > B)
            {
                Console.WriteLine($"Nilai {C} lebih besar dari pada nilai {A} dan {C}");
            }
        }
        public class SimpleDataBase<T>
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
}
