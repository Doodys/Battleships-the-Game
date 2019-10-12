using Gra_w_statki.M_Misc;
using Gra_w_statki.M_Ships;
using System;
using System.Collections.Generic;

namespace Gra_w_statki.M_BuildTab {
    class BuildTabMyShips {
        public List<string> InsertShipsToMainTab(List<string> list) {
            //zamin litere na cyfre
            //skojarz po tym polozenie w glownej tablicy
            //sprawdz, czy dookoła nic nie ma (granica, inna komorka)
            // ALE jednoczesnie to coś dookoła może istnieć, jeśli zawiera się w liscie list
            //ustaw ASCII kwadracik w tablicy
            //zwroc glowna tablice z uzupelnionym statkiem
            return list;
        }

        MiscConfigValues value = new MiscConfigValues();
        BuildTab buildTabShips = new BuildTab();
        CreateShips create = new CreateShips();
        public void CreateTab() {
            create.ShipsInput();
            string[,] tabMyShips = new string[value.ArrayHeight, value.ArrayWidth];
            buildTabShips.BuildBlankTab(tabMyShips);
        }
        public void CellNeighbours(List<string> sublist) {

        }
    }
}
