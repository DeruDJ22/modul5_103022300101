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
            float c = 02;

            PemrosesData dp = new PemrosesData();
            dp.DapatkanNilaiTerbesar(a, b, c);
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
            } else if (B > C && B > A)
            {
                Console.WriteLine($"Nilai {B} lebih besar dari pada nilai {A} dan {C}");
            } else if (C > A && C > B)
            {
                Console.WriteLine($"Nilai {C} lebih besar dari pada nilai {A} dan {C}");
            }
        }
    }
}
