using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;
            Console.SetCursorPosition(50, 20);
            Console.Beep(1500, 100);

            Console.WriteLine(@"╔╦╗┌─┐┌┐┌┌┐┌┬┌─┐
                                 ║ ├┤ │││││││└─┐
                                 ╩ └─┘ ┘ ┘ └ └─ └ └  ");


            Thread.Sleep(2750);

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Please Player number name");
            String A1 = Console.ReadLine();
            Console.WriteLine("Please Player number name");
            String A2 = Console.ReadLine();

            Console.Clear();

            Random N = new Random();
            var Witch = N.Next(1, 3);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Beep(1000, 1000);

            if (Witch == 1)
            {
                Console.SetCursorPosition(25, 8);
                Console.Write(A1);
                Console.WriteLine("Start The Game");
                Console.SetCursorPosition(25, 10);
                Console.WriteLine("click right key");
            }

            else
            {
                Console.SetCursorPosition(25, 8);
                Console.Write(A1);
                Console.WriteLine("Start The Game");
                Console.SetCursorPosition(25, 10);
                Console.WriteLine("click right key");
            }

            Thread.Sleep(2750);
            Console.Clear();

            int set1 = 0;
            int set2 = 0;
            
            while (true)
            {
                int i1 = 0;
                int i2 = 0;

                while (true)
                {
                    Console.Beep(2000, 100);
                    var pressedkey = Console.ReadKey().Key;

                    if (pressedkey == ConsoleKey.RightArrow)
                    {
                        i1++;
                        Console.WriteLine("i1=" + i1);
                    }
                    else if (pressedkey == ConsoleKey.LeftArrow)
                    {
                        i2++;
                        Console.WriteLine("i2=" + i2);
                    }

                    if (i1 >i2+1 && i1 == 3 && i1 != i2)
                    {
                        Console.Beep(4000, 50);
                        game1++;
                        Console.WriteLine("game1=" + game1);
                        break;
                    }
                    else if (i2 > i1+1 && i2 == 3 && i1 != i2)
                    {
                        Console.Beep(4000, 50);
                        game2++;
                        Console.WriteLine("game2=" + game2);
                        break;
                    }

                    int point1 = 0;
                    int point2 = 0;
                    while (i1 == i2 && i2 == 3)
                    {
                        Console.Beep(800, 250);
                        if (point1 <= point2+2 || point2 < point1+2)
                        {
                            var pressekey = Console.ReadKey().Key;
                            if (pressedkey == ConsoleKey.RightArrow)
                            {
                                point1++;
                                Console.WriteLine("point1=" + point1);
                            }
                            else if (pressedkey == ConsoleKey.LeftArrow)
                            {
                                point2++;
                                Console.WriteLine("game1=" + game1);
                                i1 = 0;
                                i2 = 0;
                                break;
                            }

                            else if (point2 > point1 && point2 == point1 + 2)
                            {
                                Console.Beep(960, 1875);
                                game2++;
                                Console.WriteLine("game2=" + game2);
                                i1 = 0;
                                i2 = 0;
                                break;
                            }

                            if (game1 > game2 && game1 + game2 >= 6 && game1 >= game2 + 1)
                            {
                                Console.Beep(900, 1000);
                                set1++;
                                Console.WriteLine("set1=" + set1);
                                break;
                            }
                            else if (game2 > game1 && game1 + game2 >= 6 && game2 >= game1 + 1)
                            {
                                Console.Beep(900, 1000);
                                set2++;
                                Console.WriteLine("set2=" + set2);
                                break;
                            }
                            
                            if (set1 == 3)
                            {
                                Console.Beep(1000, 2000);
                                Console.WriteLine(A1 + "A2" + "Is Winner");
                                break;
                            }
                        }
                    }
                }

            }

            Console.ReadKey();

        }
    }
}
