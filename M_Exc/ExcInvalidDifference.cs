using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_statki.M_Exc {
    class ExcInvalidDifference : Exception {
        public ExcInvalidDifference() { }
        public ExcInvalidDifference(int difference, string ship)
            : base(String.Format("Masz podać dane dla {0}, a wprowadziłeś wartości dla {1}-masztowca!", ship, difference++)) {

        }
    }
}
