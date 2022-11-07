using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProject
{
    internal class SudokuGrid
    {
        private List<List<int>> grid;
        private List<List<int>> playerGuessGrid;
        private string path;
        private string file;
        private Stopwatch stopWatch;
        private List<List<int>> placementOrderTopLeft;
        private List<List<int>> placementOrderTopMiddle;
        private List<List<int>> placementOrderTopRight;
        private List<List<int>> placementOrderMiddleLeft;
        private List<List<int>> placementOrderMiddleMiddle;
        private List<List<int>> placementOrderMiddleRight;
        private List<List<int>> placementOrderBottomLeft;
        private List<List<int>> placementOrderBottomMiddle;
        private List<List<int>> placementOrderBottomRight;

        //КОНСТРУКТОР для сітки (ігрового поля). Створює, а потім зберігає сітку, виконуючи перевірку дійсності
        public SudokuGrid(string pathName, string fileName)
        {
            path = pathName;
            file = fileName;
            stopWatch = Stopwatch.StartNew();
            grid = createEmptyGrid();
        }

        //КОНСТРУКТОР для завантаження сітки
        public SudokuGrid(List<int> gridList)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> col1 = new List<int>();
            List<int> col2 = new List<int>();
            List<int> col3 = new List<int>();
            List<int> col4 = new List<int>();
            List<int> col5 = new List<int>();
            List<int> col6 = new List<int>();
            List<int> col7 = new List<int>();
            List<int> col8 = new List<int>();
            List<int> col9 = new List<int>();

            for (int i = 0; i < 73; i += 9)
            {
                col1.Add(gridList[i]);
            }

            for (int i = 1; i < 74; i += 9)
            {
                col2.Add(gridList[i]);
            }

            for (int i = 2; i < 75; i += 9)
            {
                col3.Add(gridList[i]);
            }

            for (int i = 3; i < 76; i += 9)
            {
                col4.Add(gridList[i]);
            }

            for (int i = 4; i < 77; i += 9)
            {
                col5.Add(gridList[i]);
            }

            for (int i = 5; i < 78; i += 9)
            {
                col6.Add(gridList[i]);
            }

            for (int i = 6; i < 79; i += 9)
            {
                col7.Add(gridList[i]);
            }

            for (int i = 7; i < 80; i += 9)
            {
                col8.Add(gridList[i]);
            }

            for (int i = 8; i < 81; i += 9)
            {
                col9.Add(gridList[i]);
            }

            result.Add(col1);
            result.Add(col2);
            result.Add(col3);
            result.Add(col4);
            result.Add(col5);
            result.Add(col6);
            result.Add(col7);
            result.Add(col8);
            result.Add(col9);
            grid = result;
            playerGuessGrid = createEmptyGrid();
            
        }
        public int getValueOfButtonInGrid(string nameOfButton)
        {
            char[] nameSplit = nameOfButton.ToCharArray();
            string row = nameSplit[0].ToString();
            string col = nameSplit[1].ToString();
            return grid[int.Parse(row)][int.Parse(col)];
        }

        //Створення пустої сітки 9 на 9 (великої сітки)
        private List<List<int>> createEmptyGrid()
        {
            List<List<int>> blankGrid = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                List<int> column = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    column.Add(0);
                }
                blankGrid.Add(column);
            }
            return blankGrid;
        }
        //Створення сітки у блоках великої сітки
        private List<List<int>> blank3x3Box()
        {
            List<List<int>> miniBox = new List<List<int>>();
            for (int iBox = 0; iBox < 3; iBox++)
            {
                List<int> column = new List<int>();
                for (int jBox = 0; jBox < 3; jBox++)
                {
                    column.Add(0);
                }
                miniBox.Add(column);
            }
            return miniBox;
        }

        //Налаштування для розміщення цифр по комірках
        public void setUpPlacementOrders()
        {
            // Створення дев'яти порожніх замовлень для розміщення цифр 
            placementOrderTopLeft = createBlankPlacementOrder();
            placementOrderTopMiddle = createBlankPlacementOrder();
            placementOrderTopRight = createBlankPlacementOrder();
            placementOrderMiddleLeft = createBlankPlacementOrder();
            placementOrderMiddleMiddle = createBlankPlacementOrder();
            placementOrderMiddleRight = createBlankPlacementOrder();
            placementOrderBottomLeft = createBlankPlacementOrder();
            placementOrderBottomMiddle = createBlankPlacementOrder();
            placementOrderBottomRight = createBlankPlacementOrder();
        }

        //Виконання заповнення початкового розміщення
        public void doInitialPlacementFill(int boxPos)
        {
            int sleepTime = 150;
            Thread oThread = new Thread(() => placementFill(boxPos));
            oThread.Start();
            while (!oThread.IsAlive) ;
            Thread.Sleep(sleepTime);
            oThread.Abort();
        }

        //Виконання заповнення одного місця розташування
        public void doSinglePlacementFill(int boxPos, int posInBox)
        {
            int sleepTime = 50;
            Thread oThread = new Thread(() => singlePlacementFill(boxPos, posInBox));
            oThread.Start();
            while (!oThread.IsAlive) ;
            Thread.Sleep(sleepTime);
            oThread.Abort();
        }

        //Заповнення розташування цифр у кожній комірці
        public void singlePlacementFill(int boxPos, int posInBox)
        {
            List<int> list1 = new List<int>();
            for (int i = 0; i < 9; i++)
                list1.Add(i);
            Random rnd = new Random();
            int count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list1[k];
                list1[k] = list1[count];
                list1[count] = value;
            }

            switch (boxPos)
            {
                case 0:
                    placementOrderTopLeft[posInBox] = list1;
                    break;
                case 1:
                    placementOrderTopMiddle[posInBox] = list1;
                    break;
                case 2:
                    placementOrderTopRight[posInBox] = list1;
                    break;
                case 3:
                    placementOrderMiddleLeft[posInBox] = list1;
                    break;
                case 4:
                    placementOrderMiddleMiddle[posInBox] = list1;
                    break;
                case 5:
                    placementOrderMiddleRight[posInBox] = list1;
                    break;
                case 6:
                    placementOrderBottomLeft[posInBox] = list1;
                    break;
                case 7:
                    placementOrderBottomMiddle[posInBox] = list1;
                    break;
                case 8:
                    placementOrderBottomRight[posInBox] = list1;
                    break;
            }
        }
        //Розміщення заповнених комірок
        public void placementFill(int boxPos)
        {
            List<int> list1 = new List<int>();
            for (int i = 0; i < 9; i++)
                list1.Add(i);
            Random rnd = new Random();
            int count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list1[k];
                list1[k] = list1[count];
                list1[count] = value;
            }

            List<int> list2 = new List<int>();
            for (int i = 0; i < 9; i++)
                list2.Add(i);
            count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list2[k];
                list2[k] = list2[count];
                list2[count] = value;
            }

            List<int> list3 = new List<int>();
            for (int i = 0; i < 9; i++)
                list3.Add(i);
            count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list3[k];
                list3[k] = list3[count];
                list3[count] = value;
            }

            List<int> list4 = new List<int>();
            for (int i = 0; i < 9; i++)
                list4.Add(i);
            count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list4[k];
                list4[k] = list4[count];
                list4[count] = value;
            }

            List<int> list5 = new List<int>();
            for (int i = 0; i < 9; i++)
                list5.Add(i);
            count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list5[k];
                list5[k] = list5[count];
                list5[count] = value;
            }

            List<int> list6 = new List<int>();
            for (int i = 0; i < 9; i++)
                list6.Add(i);
            count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list6[k];
                list6[k] = list6[count];
                list6[count] = value;
            }

            List<int> list7 = new List<int>();
            for (int i = 0; i < 9; i++)
                list7.Add(i);
            count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list7[k];
                list7[k] = list7[count];
                list7[count] = value;
            }

            List<int> list8 = new List<int>();
            for (int i = 0; i < 9; i++)
                list8.Add(i);
            count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list8[k];
                list8[k] = list8[count];
                list8[count] = value;
            }

            List<int> list9 = new List<int>();
            for (int i = 0; i < 9; i++)
                list9.Add(i);
            count = 9;
            while (count > 1)
            {
                count--;
                int k = rnd.Next(count + 1);
                int value = list9[k];
                list9[k] = list9[count];
                list9[count] = value;
            }

            switch (boxPos)
            {
                case 0:
                    placementOrderTopLeft[0] = list1;
                    placementOrderTopLeft[1] = list2;
                    placementOrderTopLeft[2] = list3;
                    placementOrderTopLeft[3] = list4;
                    placementOrderTopLeft[4] = list5;
                    placementOrderTopLeft[5] = list6;
                    placementOrderTopLeft[6] = list7;
                    placementOrderTopLeft[7] = list8;
                    placementOrderTopLeft[8] = list9;
                    break;
                case 1:
                    placementOrderTopMiddle[0] = list1;
                    placementOrderTopMiddle[1] = list2;
                    placementOrderTopMiddle[2] = list3;
                    placementOrderTopMiddle[3] = list4;
                    placementOrderTopMiddle[4] = list5;
                    placementOrderTopMiddle[5] = list6;
                    placementOrderTopMiddle[6] = list7;
                    placementOrderTopMiddle[7] = list8;
                    placementOrderTopMiddle[8] = list9;
                    break;
                case 2:
                    placementOrderTopRight[0] = list1;
                    placementOrderTopRight[1] = list2;
                    placementOrderTopRight[2] = list3;
                    placementOrderTopRight[3] = list4;
                    placementOrderTopRight[4] = list5;
                    placementOrderTopRight[5] = list6;
                    placementOrderTopRight[6] = list7;
                    placementOrderTopRight[7] = list8;
                    placementOrderTopRight[8] = list9;
                    break;
                case 3:
                    placementOrderMiddleLeft[0] = list1;
                    placementOrderMiddleLeft[1] = list2;
                    placementOrderMiddleLeft[2] = list3;
                    placementOrderMiddleLeft[3] = list4;
                    placementOrderMiddleLeft[4] = list5;
                    placementOrderMiddleLeft[5] = list6;
                    placementOrderMiddleLeft[6] = list7;
                    placementOrderMiddleLeft[7] = list8;
                    placementOrderMiddleLeft[8] = list9;
                    break;
                case 4:
                    placementOrderMiddleMiddle[0] = list1;
                    placementOrderMiddleMiddle[1] = list2;
                    placementOrderMiddleMiddle[2] = list3;
                    placementOrderMiddleMiddle[3] = list4;
                    placementOrderMiddleMiddle[4] = list5;
                    placementOrderMiddleMiddle[5] = list6;
                    placementOrderMiddleMiddle[6] = list7;
                    placementOrderMiddleMiddle[7] = list8;
                    placementOrderMiddleMiddle[8] = list9;
                    break;
                case 5:
                    placementOrderMiddleRight[0] = list1;
                    placementOrderMiddleRight[1] = list2;
                    placementOrderMiddleRight[2] = list3;
                    placementOrderMiddleRight[3] = list4;
                    placementOrderMiddleRight[4] = list5;
                    placementOrderMiddleRight[5] = list6;
                    placementOrderMiddleRight[6] = list7;
                    placementOrderMiddleRight[7] = list8;
                    placementOrderMiddleRight[8] = list9;
                    break;
                case 6:
                    placementOrderBottomLeft[0] = list1;
                    placementOrderBottomLeft[1] = list2;
                    placementOrderBottomLeft[2] = list3;
                    placementOrderBottomLeft[3] = list4;
                    placementOrderBottomLeft[4] = list5;
                    placementOrderBottomLeft[5] = list6;
                    placementOrderBottomLeft[6] = list7;
                    placementOrderBottomLeft[7] = list8;
                    placementOrderBottomLeft[8] = list9;
                    break;
                case 7:
                    placementOrderBottomMiddle[0] = list1;
                    placementOrderBottomMiddle[1] = list2;
                    placementOrderBottomMiddle[2] = list3;
                    placementOrderBottomMiddle[3] = list4;
                    placementOrderBottomMiddle[4] = list5;
                    placementOrderBottomMiddle[5] = list6;
                    placementOrderBottomMiddle[6] = list7;
                    placementOrderBottomMiddle[7] = list8;
                    placementOrderBottomMiddle[8] = list9;
                    break;
                case 8:
                    placementOrderBottomRight[0] = list1;
                    placementOrderBottomRight[1] = list2;
                    placementOrderBottomRight[2] = list3;
                    placementOrderBottomRight[3] = list4;
                    placementOrderBottomRight[4] = list5;
                    placementOrderBottomRight[5] = list6;
                    placementOrderBottomRight[6] = list7;
                    placementOrderBottomRight[7] = list8;
                    placementOrderBottomRight[8] = list9;
                    break;
            }
        }

        //заповнення сітки
        private List<int> fillList(int start, int finish)
        {
            List<int> ourList = new List<int>();
            for (int i = start; i <= finish; i++)
            {
                ourList.Add(i);
            }
            return ourList;
        }

        //Функція для створення порожнього замовлення для розміщення цифр у комірках
        private List<List<int>> createBlankPlacementOrder()
        {
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                List<int> nullPlacementOrdersForOneNumber = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    nullPlacementOrdersForOneNumber.Add(-1);
                }
                result.Add(nullPlacementOrdersForOneNumber);
            }
            return result;
        }

        //Відображення розміщення цифр у сітці
        public void showPlacementOrdersForBox(int boxPos)
        {
            string result = "";
            result += "*-* Box: " + boxPos + " *-*\n";
            switch (boxPos)
            {
                case 0:
                    for (int i = 0; i < 9; i++)
                    {
                        result += "Num " + i + ": [";
                        for (int j = 0; j < 9; j++)
                        {
                            result += placementOrderTopLeft[i][j] + " ";
                        }
                        result += "]\n";
                    }
                    break;
                case 1:
                    for (int i = 0; i < 9; i++)
                    {
                        result += "Num " + i + ": [";
                        for (int j = 0; j < 9; j++)
                        {
                            result += placementOrderTopMiddle[i][j] + " ";
                        }
                        result += "]\n";
                    }
                    break;
                case 2:
                    for (int i = 0; i < 9; i++)
                    {
                        result += "Num " + i + ": [";
                        for (int j = 0; j < 9; j++)
                        {
                            result += placementOrderTopRight[i][j] + " ";
                        }
                        result += "]\n";
                    }
                    break;
                case 3:
                    for (int i = 0; i < 9; i++)
                    {
                        result += "Num " + i + ": [";
                        for (int j = 0; j < 9; j++)
                        {
                            result += placementOrderMiddleLeft[i][j] + " ";
                        }
                        result += "]\n";
                    }
                    break;
                case 4:
                    for (int i = 0; i < 9; i++)
                    {
                        result += "Num " + i + ": [";
                        for (int j = 0; j < 9; j++)
                        {
                            result += placementOrderMiddleMiddle[i][j] + " ";
                        }
                        result += "]\n";
                    }
                    break;
                case 5:
                    for (int i = 0; i < 9; i++)
                    {
                        result += "Num " + i + ": [";
                        for (int j = 0; j < 9; j++)
                        {
                            result += placementOrderMiddleRight[i][j] + " ";
                        }
                        result += "]\n";
                    }
                    break;
                case 6:
                    for (int i = 0; i < 9; i++)
                    {
                        result += "Num " + i + ": [";
                        for (int j = 0; j < 9; j++)
                        {
                            result += placementOrderBottomLeft[i][j] + " ";
                        }
                        result += "]\n";
                    }
                    break;
                case 7:
                    for (int i = 0; i < 9; i++)
                    {
                        result += "Num " + i + ": [";
                        for (int j = 0; j < 9; j++)
                        {
                            result += placementOrderBottomMiddle[i][j] + " ";
                        }
                        result += "]\n";
                    }
                    break;
                case 8:
                    for (int i = 0; i < 9; i++)
                    {
                        result += "Num " + i + ": [";
                        for (int j = 0; j < 9; j++)
                        {
                            result += placementOrderBottomRight[i][j] + " ";
                        }
                        result += "]\n";
                    }
                    break;
            }
            MessageBox.Show(result);
        }
    }
}
