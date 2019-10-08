using System;

namespace Gra_w_statki.M_Exc {
    [Serializable]
    class ExcInvalidCellInput : Exception {
        public ExcInvalidCellInput() { }
        public ExcInvalidCellInput(string inputCell)
            : base(String.Format("{0} jest nieprawidłowym formatem wejściowym komórki!", inputCell)) {

        }
    }
}