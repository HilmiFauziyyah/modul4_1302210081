using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static Modul4_1302210081.PosisiKarakterGame;

namespace Modul4_1302210081
{
    internal class PosisiKarakterGame
    {
        public enum posisi { Jongkok, Berdiri, Terbang, Tengkurep }
        public enum tombol { tombolW, tombolX, tombolS }

        public class gantiposisi
        {
            public posisi sebelum, sesudah;
            public tombol triger;
            public gantiposisi(posisi sebelum, posisi sesudah, tombol triger)
            {
                this.sebelum = sebelum;
                this.sesudah = sesudah;
                this.triger = triger;
            }

        }
        gantiposisi[] arrgantiposisi =
    {
    new gantiposisi(posisi.Jongkok, posisi.Berdiri, tombol.tombolW),
    new gantiposisi(posisi.Berdiri, posisi.Terbang, tombol.tombolW),
    new gantiposisi(posisi.Terbang, posisi.Berdiri, tombol.tombolS),
    new gantiposisi(posisi.Berdiri, posisi.Jongkok, tombol.tombolS),
    new gantiposisi(posisi.Jongkok, posisi.Tengkurep, tombol.tombolS),
    new gantiposisi(posisi.Tengkurep, posisi.Jongkok, tombol.tombolW),
    new gantiposisi(posisi.Terbang, posisi.Jongkok, tombol.tombolX),
    };
        public posisi sekarang = posisi.Berdiri;
        public posisi langkah_berikut(posisi sebelum, posisi trigger)
        {

        }

    }
    

}

