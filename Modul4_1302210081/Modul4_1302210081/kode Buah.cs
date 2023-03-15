using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302210081
{
    internal class kode_Buah
    {
        public enum buah {Apel, Buah, Alpukat, Pisang, Paprika, Kurma, Durian, Anggur, Melon, Semangka, Blackberry, Ceri, Kelapa, Jagung}
        String[] arr = { "A00", "B00", "C00", "D00", "E00", "K00", "L00", "M00", "N00", "O00", "F00", "H00", "I00", "J00" };
        
        public string getKode_Buah(buah namabuah) => arr[(int)namabuah];
    }
}
