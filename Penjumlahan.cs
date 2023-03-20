using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302213109
{
    internal class Penjumlahan <T>
    {
        public JumlahTigaAngka(T b, T s, T z)
        {
            dynamic hasil_penjumlahan = 0;
            hasil_penjumlahan += b;
            hasil_penjumlahan += s;
            hasil_penjumlahan += z;
            Console.WriteLine(hasil_penjumlahan);
        }
    }
}
