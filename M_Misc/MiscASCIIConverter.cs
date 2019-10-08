using System.Text;

namespace Gra_w_statki.M_Misc {
    class MiscASCIIConverter {

        public string UnicodeToChar(int unicode) {

            char character = (char)unicode;
            string text = character.ToString();

            return text;
        }

        public byte CharToUnicode(string character, int value) {
            string checkUnicode = character[value].ToString();
            byte[] unicodeTab = Encoding.ASCII.GetBytes(checkUnicode);
            return unicodeTab[0];
        }
    }
}

