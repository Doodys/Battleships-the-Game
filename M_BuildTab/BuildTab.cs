using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gra_w_statki.M_Misc;

namespace Gra_w_statki.M_BuildTab {
    class BuildTab {
        public void BuildBlankTab(string[,] tab) {

            FillFirstColumn(tab);
            FillFirstRow(tab);

            for (int i = 0; i < tab.GetLength(0); i++) {

                for (int j = 0; j < tab.GetLength(1); j++) {

                    Console.Write(tab[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
        private void FillFirstRow(string[,] tab) {

            for (int i = 1; i < tab.GetLength(0); i++) {

                tab[0, i] = i.ToString();
            }
        }
        private void FillFirstColumn(string[,] tab) {

            MiscASCIIConverter unicodeToChar = new MiscASCIIConverter();

            int unicode = 65;

            for (int i = 1; i < tab.GetLength(1); i++) {
                tab[i, 0] = unicodeToChar.UnicodeToChar(unicode);
                ++unicode;
            }
        }
    }
}
