using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopDiabetesLibrary
{
    public class Calculate : DataUser
    {


        public bool kondisi1, kondisi2, kondisi3, kondisi4, kondisi5, kondisi6, kondisi7;

        public void calculate(int sugar, int age)
        {
            if (sugar >= 80 && sugar <= 170 && age >= 6 && age <= 12)
            {

                kondisi1 = true;

            }
            else if (sugar >= 70 && sugar <= 150 && age >= 13 && age <= 19)
            {

                kondisi2 = true;

            }
            else if (sugar <= 65 && age >= 20)
            {

                kondisi3 = true;
            }
            else if (sugar >= 66 && sugar <= 80 && age >= 20)
            {

                kondisi4 = true;
            }
            else if (sugar >= 81 && sugar <= 140 && age >= 20)
            {

                kondisi5 = true;
            }
            else if (sugar >= 141 && sugar <= 170 && age >= 20)
            {

                kondisi6 = true;
            }
            else
            {

                kondisi7 = true;
            }
           
        }
        public override string displayError()
        {
            string error = "Silakan isi kadar gula darah dan umur anda";
            return error;
        }
        

        }





    }

