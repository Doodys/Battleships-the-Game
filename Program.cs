using System;
using Gra_w_statki.M_BuildTab;
using Gra_w_statki.M_Misc;
using Gra_w_statki.M_Ships;

namespace Gra_w_statki {
    class Program {
        static void Main(string[] args) {
            MiscConfig config = new MiscConfig();
            //CreateShips create = new CreateShips();
            config.ShowRules();
            //create.ShipsInput();
            MiscConfigValues value = new MiscConfigValues();
            //string[,] tabDestroShips = new string[value.ArrayHeight, value.ArrayWidth];
            //string[,] tabMyShips = new string[value.ArrayHeight, value.ArrayWidth];
            

            Console.Title = value.Title;
            Console.SetWindowSize(value.WindowWidth, value.WindowHeight);

            //BuildTab buildTabShips = new BuildTab();

            Console.WriteLine();
            //buildTabShips.BuildBlankTab(tabMyShips);
            Console.WriteLine();
            //buildTabShips.BuildBlankTab(tabDestroShips);


            Console.ReadKey();
        }
    }
}
