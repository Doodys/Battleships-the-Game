using System;
using System.Collections.Generic;
using Gra_w_statki.M_Misc;
using Gra_w_statki.M_Exc;
using Gra_w_statki.M_BuildTab;

namespace Gra_w_statki.M_Ships {
    class CreateShips {
        public List<List<string>> ShipsInput() {

            bool goBack = true;
            string cellBow = "", cellStern = "";
            byte maxMinValue = 0;
            byte maxMinChar = 0;
            string[] ShipsTypeList = new string[] { "czteromasztowca", "trójmasztowca", "dwumasztowca", "jednomasztowca" };
            List<List<string>> ShipsList = new List<List<string>>();

            MiscASCIIConverter ASCII = new MiscASCIIConverter();
            BuildTabMyShips cellValidation = new BuildTabMyShips();

            for (int i = 0; i < 10; i++) {
                switch (i) {
                    case 0:
                        while (goBack) {
                            try {
                                Console.Clear();
                                Console.Write("Podaj komórkę dzioba " + ShipsTypeList[0] + ": ");
                                cellBow = Console.ReadLine();

                                maxMinValue = Convert.ToByte(cellBow.Substring(1));
                                maxMinChar = ASCII.CharToUnicode(cellBow, 0);

                                if (maxMinValue > 10 || maxMinValue <= 0 || maxMinChar < 65 || maxMinChar > 74) throw new ExcInvalidCellInput(cellBow);

                                MiscConfig.CheckCellInputRegex(cellBow);

                                Console.Write("Podaj komórkę rufy " + ShipsTypeList[0] + ": ");
                                cellStern = Console.ReadLine();

                                maxMinValue = Convert.ToByte(cellStern.Substring(1));
                                maxMinChar = ASCII.CharToUnicode(cellStern, 0);

                                if (maxMinValue > 10 || maxMinValue <= 0 || maxMinChar < 65 || maxMinChar > 74) throw new ExcInvalidCellInput(cellStern);

                                MiscConfig.CheckCellInputRegex(cellStern);

                                string diffCell = MiscConfig.CheckCellDiff(cellBow, cellStern);

                                if (!Convert.ToInt32(diffCell.Substring(2)).Equals(3)) {
                                    throw new ExcInvalidDifference(Convert.ToInt32(diffCell.Substring(2)), ShipsTypeList[0]);
                                }

                                List<string> fourMasts = new List<string>(CreateMiddleCells(diffCell, cellBow));
                                
                                cellValidation.CellNeighbours(ReturnSubList(fourMasts));

                                ShipsList.Add(fourMasts);
                                goBack = false;

                            } catch (ExcInvalidCellInput ex) {
                                Console.WriteLine("\n" + ex.Message);
                                Console.ReadKey();
                            } catch (ExcInvalidCellPositioning ex) {
                                Console.WriteLine("\n" + ex.Message);
                                Console.ReadKey();
                            } catch (ExcInvalidDifference ex) {
                                Console.WriteLine("\n" + ex.Message);
                                Console.ReadKey();
                            }
                        }
                        break;
                    case int n when (n == 1 || n == 2):
                        Console.WriteLine("Podaj komórkę dzioba " + ShipsTypeList[1] + ": ");
                        break;
                    case int n when (n >= 3 && n <= 5):
                        Console.WriteLine("Podaj komórkę dzioba " + ShipsTypeList[2] + ": ");
                        break;
                    case int n when (n >= 6 && n <= 9):
                        Console.WriteLine("Podaj komórkę " + ShipsTypeList[3] + ": ");
                        break;
                    default:
                        break;
                }
            }
            return ShipsList;
        }

        private List<string> CreateMiddleCells(string diff, string bow) {

            MiscASCIIConverter ASCII = new MiscASCIIConverter();
            int effect = 0;
            List<string> shipCells = new List<string>() { bow };

            if (diff.Contains("-C")) {
                for(int i = 0; i < Convert.ToInt16(diff.Substring(2)); i++) {
                    effect = ASCII.CharToUnicode(bow, 0) - (i + 1);
                    shipCells.Add(ASCII.UnicodeToChar(effect) + bow.Substring(1));
                }
            } else if (diff.Contains("+C")) {
                for (int i = 0; i < Convert.ToInt16(diff.Substring(2)); i++) {
                    effect = ASCII.CharToUnicode(bow, 0) + (i + 1);
                    shipCells.Add(ASCII.UnicodeToChar(effect) + bow.Substring(1));
                }
            } else if (diff.Contains("-I")) {
                for (int i = 0; i < Convert.ToInt16(diff.Substring(2)); i++) {
                    effect = Convert.ToInt16(bow.Substring(1)) - (i + 1);
                    shipCells.Add(bow[0] + effect.ToString());
                }
            } else if (diff.Contains("+I")) {
                for (int i = 0; i < Convert.ToInt16(diff.Substring(2)); i++) {
                    effect = Convert.ToInt16(bow.Substring(1)) + (i + 1);
                    shipCells.Add(bow[0] + effect.ToString());
                }
            }

            return shipCells;
        }

        public List<string> ReturnSubList(List<string> sublist) {
            return sublist;
        }
    }
}
