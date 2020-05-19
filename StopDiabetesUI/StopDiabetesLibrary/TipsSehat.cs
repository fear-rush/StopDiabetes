using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopDiabetesLibrary
{
    public class TipsSehat
    {
        string tips;
        public string displayTips(Hasil hasil)
        {
            if(hasil.rendah == true)
            {
                tips = "Gula darah anda rendah. Tips hidup sehat bagi anda adalah : " +
                     Environment.NewLine + "1. Selalu bawa cemilan atau minuman manis" +
                     Environment.NewLine + "2. Kurangi konsumsi minuman beralkohol" +
                     Environment.NewLine + "3. Lakukan olahraga ringan" +
                     Environment.NewLine + "4. Konsumsi makanan berkarbohidrat" +
                     Environment.NewLine + "5. Makan secara teratur sesuai jadwal";
                return tips;
            }
            else if(hasil.tinggi == true)
            {
                tips = "Gula darah anda tinggi. Tips hidup sehat bagi anda adalah :"+ 
                    Environment.NewLine + "1. Perbanyak minum air putih" +
                    Environment.NewLine + "\n2. Batasi asupan gula" +
                    Environment.NewLine + "\n3. Olahraga secara teratur" +
                    Environment.NewLine + "\n4. Hindari Stress" +
                    Environment.NewLine + "\n5. Tidur cukup";
                return tips;
            }
            else
            {
                tips = "Gula darah anda normal, pertahankan. Tips hidup sehat bagi anda adalah :" +
                    Environment.NewLine + "1. Rencanakan pola makan sehat" +
                    Environment.NewLine + "2. Jangan lewatkan sarapan, makan siang, atau makan malam" +
                    Environment.NewLine + "3. Pilih makanan tinggi serat" +
                    Environment.NewLine + "4. Kelola stress";

                return tips;
            }
        }
    }
}
