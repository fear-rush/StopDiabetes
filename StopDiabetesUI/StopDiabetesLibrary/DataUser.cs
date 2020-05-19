using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopDiabetesLibrary
{
    public abstract class DataUser
    {
        protected int Sugar { get; set; }
        protected int Age { get; set; }

        public abstract string displayError();
       
        



    }
}
