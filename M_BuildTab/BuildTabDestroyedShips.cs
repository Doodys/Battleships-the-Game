using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gra_w_statki.M_Misc;

namespace Gra_w_statki.M_BuildTab
{
    class BuildTabDestroyedShips
    {
        MiscConfigValues value = new MiscConfigValues();
        BuildTab buildTabShips = new BuildTab();
        public void CreateTab() {
            string[,] tabDestroShips = new string[value.ArrayHeight, value.ArrayWidth];
            buildTabShips.BuildBlankTab(tabDestroShips);
        }
    }
}
