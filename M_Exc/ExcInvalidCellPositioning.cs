using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_statki.M_Exc {
    class ExcInvalidCellPositioning : Exception {
        public ExcInvalidCellPositioning() { }
        public ExcInvalidCellPositioning(string inputBow, string inputStern)
            : base(String.Format("{0} lub {1} jest nieprawidłową komórką do stworzenia statku!", inputBow, inputStern)) {

        }
    }
}
