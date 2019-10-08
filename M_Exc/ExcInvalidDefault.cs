using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_statki.M_Exc {
    class ExcInvalidDefault : Exception {
        public ExcInvalidDefault() : base(String.Format("Wprowadzono błędne dane!")) { }
    }
}
