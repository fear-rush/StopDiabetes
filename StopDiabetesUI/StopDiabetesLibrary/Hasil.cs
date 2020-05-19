using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopDiabetesLibrary
{
    public class Hasil
    {
        string hasil;
        public bool rendah, tinggi, normal;
        public string outputHasil(Calculate calculate)
        {
            if (calculate.kondisi1 == true)
            {
                hasil = "Gula darah Anda normal";
                normal = true;
                return hasil;
            }
            else if (calculate.kondisi2 == true)
            {
                hasil = "Gula darah Anda normal";
                normal = true;
                return hasil;
            }
            else if (calculate.kondisi3 == true)
            {
                hasil = "Gula darah anda sangat rendah";
                rendah = true;
                return hasil;
            }
            else if (calculate.kondisi4 == true)
            {
                hasil = "Gula darah anda normal, berada di batas bawah darah rendah";
                normal = true;
                return hasil;
            }
            else if (calculate.kondisi5 == true)
            {
                hasil = "Gula darah anda normal";
                normal = true;
                return hasil;
            }
            else if (calculate.kondisi6 == true)
            {
                hasil = "Waspada! Gula darah anda tinggi";
                tinggi = true;
                return hasil;
            }
            else
            {
                hasil = "Berbahaya! Gula darah Anda sangat tinggi";
                tinggi = true;
                return hasil;
            }


        }
    }
}
