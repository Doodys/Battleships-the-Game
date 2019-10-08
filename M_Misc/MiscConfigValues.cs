using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_statki.M_Misc {
    class MiscConfigValues {

        private static Dictionary<string, string> ReadConfig() {

            Dictionary<string, string> configList = new Dictionary<string, string>();
            string path = "../../config.txt";

            var query = (
                from line in File.ReadAllLines(path)
                let values = line.Split('=')
                select new { Key = values[0], Value = values[1] }
                );

            foreach (var kvp in query) {
                configList[kvp.Key] = kvp.Value;
            }

            return configList;
        }

        public static string AddValues(string name) {
            string value = "";

            foreach (KeyValuePair<string, string> pair in ReadConfig()) {
                if (pair.Key == name) value = pair.Value;
            }
            return value;
        }

        internal string Title = AddValues("Title");
        internal int WindowWidth = Convert.ToInt16(AddValues("WindowWidth"));
        internal int WindowHeight = Convert.ToInt16(AddValues("WindowHeight"));
        internal int ArrayWidth = Convert.ToInt16(AddValues("ArrayWidth"));
        internal int ArrayHeight = Convert.ToInt16(AddValues("ArrayHeight"));      
        internal string patternCell = AddValues("patternCell");

        internal string Rules = "Witaj w grze w statki stworzonej przez Michała Dudys!" +
            "\n\nTwoim przeciwnikiem będzie specjalnie przygotowany, komputerowy gracz." +
            "\n\nDo dowolnego rozłożenia masz:" +
            "\n- Jeden czteromasztowiec" +
            "\n- Dwa trójmasztowce" +
            "\n- Trzy dwumasztowce" +
            "\n- Cztery jednomasztowce" +
            "\n\nPamiętaj, że statki muszą być proste!" +
            "\nWprowadzaj położenie statków oraz wybór atakowanej komórki w formacie 'A1', 'J9' etc." +
            "\n\nBaw się dobrze!" +
            "\n\nWciśnij dowolny przycisk, by kontynuować...";
    }
}
