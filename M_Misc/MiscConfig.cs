using System;
using System.Text.RegularExpressions;
using Gra_w_statki.M_Exc;

namespace Gra_w_statki.M_Misc {
    class MiscConfig {
        static MiscConfigValues value = new MiscConfigValues();
        static MiscASCIIConverter ASCII = new MiscASCIIConverter();
        public void ShowRules() {
            Console.Title = value.Title;
            Console.WriteLine(value.Rules);
            Console.ReadKey();
            Console.Clear();
        }
        public static void CheckCellInputRegex(string input) {

            Regex matchCell = new Regex(value.patternCell);
            if (!matchCell.IsMatch(input)) {
                throw new ExcInvalidCellInput(input);
            }
        }
        public static string CheckCellDiff(string bow, string stern) {
            if (ASCII.CharToUnicode(bow, 0) > ASCII.CharToUnicode(stern, 0) && bow.Substring(1) == stern.Substring(1)) {

                return "-C" + (ASCII.CharToUnicode(bow, 0) - ASCII.CharToUnicode(stern, 0)); //roznica ASCII dla dzioba większego od rufy
            } else if (ASCII.CharToUnicode(stern, 0) > ASCII.CharToUnicode(bow, 0) && bow.Substring(1) == stern.Substring(1)) {

                return "+C" + (ASCII.CharToUnicode(stern, 0) - ASCII.CharToUnicode(bow, 0)); //roznica ASCII dla rufy wiekszej od dzioba
            } else if (Convert.ToInt16(bow.Substring(1)) > Convert.ToInt16(stern.Substring(1)) && bow[0] == stern[0]) {

                return "-I" + (Convert.ToInt16(bow.Substring(1)) - Convert.ToInt16(stern.Substring(1))).ToString(); //roznica wartosci numerycznej dla dzioba wiekszego od rufy
            } else if (Convert.ToInt16(stern.Substring(1)) > Convert.ToInt16(bow.Substring(1)) && bow[0] == stern[0]) {

                return "+I" + (Convert.ToInt16(stern.Substring(1)) - Convert.ToInt16(bow.Substring(1))).ToString(); //roznica wartosci numerycznej dla rufy wiekszej od dzioba
            } else { throw new ExcInvalidCellPositioning(bow, stern); }
        }
    }
}
