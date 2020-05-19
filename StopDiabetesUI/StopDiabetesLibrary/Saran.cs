using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopDiabetesLibrary
{
    public class Saran
    {
        string saran;
        public string outputSaran(Calculate calculate)
        {
            if (calculate.kondisi1 == true)
            {
                saran = "Pertahankan pola makan dan aktivitas kebugaran Anda";
                return saran;
            }
            else if (calculate.kondisi2 == true)
            {
                saran = "Pertahankan pola makan dan aktivitas kebugaran Anda";
                return saran;
            }
            else if (calculate.kondisi3 == true)
            {
                saran = "Segera periksa ke dokter!";
                return saran;
            }
            else if (calculate.kondisi4 == true)
            {
                saran = "Lakukan olahraga ringan 1-2 jam setelah makan, Kelola beban pikiran, " +
                    "perbanyak makanan yang dapat meningkatkan gula darah ";
                return saran;
            }
            else if (calculate.kondisi5 == true)
            {
                saran = "Pertahankan pola makan dan aktivitas kebugaran Anda";
                return saran;
            }
            else if (calculate.kondisi6 == true)
            {
                saran = "Batasi asupan gula dalam tubuh, hindari makanan cepat saji, kontrol karbohidrat dalam tubuh,istirahat yang cukup (7-9 jam sehari )";
                return saran;
            }
            else
            {
                saran = "Segera periksa ke dokter!";
                return saran;
            }


        }
    }
}
