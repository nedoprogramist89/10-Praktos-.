//namespace Hydra
//{
//    internal class Sklad_arrow
//    {
//        static public int y = 3;
//        static public int min = 2;
//        static public int arrov_max;
//        static public string arrow = "->";
//        static public int deep;
//        static public int page = 0;

//        static public void Draw_Arrow_Sklad()
//        {
//            Sklader skl = new();
//            while (true)
//            {
//                ConsoleKeyInfo key = Console.ReadKey(true);

//                switch (key.Key)
//                {
//                    case ConsoleKey.DownArrow:
//                        if (y < arrov_max)
//                        {
//                            Console.SetCursorPosition(0, y);
//                            Console.WriteLine(arrow.Replace("->", "  "));
//                            Console.SetCursorPosition(0, ++y);
//                            Console.WriteLine(arrow);
//                        }
//                        break;
//                    case ConsoleKey.UpArrow:
//                        if (y > min)
//                        {
//                            Console.SetCursorPosition(0, y);
//                            Console.WriteLine(arrow.Replace("->", "  "));
//                            Console.SetCursorPosition(0, --y);
//                            Console.WriteLine(arrow);
//                        }
//                        break;
//                    case ConsoleKey.Enter:
//                        if (page == 0)
//                        {
//                            switch (deep)
//                            {
//                                case 0:
//                                    Class_Log_in.Log_in(y);
//                                    break;
//                                case 1:
//                                    min = 3;
//                                    Sklader.Hello(y);
//                                    page = 1;
//                                    Console.Clear();
//                                    min = 2;
//                                    arrov_max = 5;
//                                    skl.Update(y);
//                                    break;
//                                case 2:
//                                    min = 2;
//                                    skl.Create(y);
//                                    break;
//                                case 3:
//                                    min = 3;
//                                    Sklader.Search(y);
//                                    break;
//                            }
//                        }
//                        else if (page == 1)
//                        {
//                            switch (deep)
//                            {
//                                case 4:
//                                    min = 2;
//                                    arrov_max = 5;
//                                    skl.Edit(y);
//                                    break;
//                                case 1:
//                                    Console.Clear();
//                                    min = 2;
//                                    arrov_max = 5;
//                                    skl.Update(y);
//                                    break;
//                            }
//                        }
//                        break;
//                    case ConsoleKey.Escape:
//                        deep = 1;
//                        min = 3;
//                        page = 0;
//                        Sklader.Hello(y);
//                        break;
//                    case ConsoleKey.F1:
//                        page = 0;
//                        deep = 2;
//                        min = 2;
//                        arrov_max = 6;
//                        Console.Clear();
//                        skl.Create(y);
//                        break;
//                    case ConsoleKey.F2:
//                        page = 0;
//                        deep = 3;
//                        min = 3;
//                        arrov_max = 6;
//                        Sklader.Search_Draw(y);
//                        break;
//                    case ConsoleKey.F10:
//                        deep = 4;
//                        min = 2;
//                        arrov_max = 5;
//                        skl.Edit(y);
//                        break;
//                    case ConsoleKey.Delete:
//                        skl.Delete();
//                        break;
//                    case ConsoleKey.S:
//                        Sklader.Update_save();
//                        Sklad_arrow.page = 0;
//                        Sklad_arrow.deep = 1;
//                        min = 3;
//                        Console.Clear();
//                        Sklader.Hello(y);
//                        break;
//                    case ConsoleKey.Home:
//                        Console.Clear();
//                        min = 2;
//                        arrov_max = 5;
//                        page = 0;
//                        deep = 0;
//                        Program.Start();
//                        break;
//                    default:

//                        break;
//                }
//            }
//        }
//    }
//}
