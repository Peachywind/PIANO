using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Linq;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n F1:1 Октава от Q-P \n F2:2 Октава от A-D \n F3:3 Октава от Z-M");
            player1(player1_:"");
        }
        static void player1(string player1_)
        {
            while (true)
            {
                vol1(vol1_: "");
            }
        }
        static void player2(string player2_)
        {
            while (true)
            {
                vol2(vol2_: "");
            };
        }
        static void player3(string player3_)
        {
            while(true)
            {
                vol3(vol3_: "");
            }
        }
        static void choice_octave(string co)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {
                if (key.Key == ConsoleKey.F2)
                {
                    player1(player1_: "");
                }

                if (key.Key == ConsoleKey.F3)
                {
                    player2(player2_: "");
                }

                if (key.Key == ConsoleKey.F4)
                {
                    player3("");
                }
            }
        }
        static void vol1(string vol1_)
        {
            int[] f_note = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440 };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    Console.Beep(f_note[0], 150);
                }

                if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(f_note[1], 150);
                }

                if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(f_note[2], 150);
                }

                if (key.Key == ConsoleKey.R)
                {
                    Console.Beep(f_note[3], 150);
                }

                if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(f_note[4], 150);
                }

                if (key.Key == ConsoleKey.Y)
                {
                    Console.Beep(f_note[5], 150);
                }

                if (key.Key == ConsoleKey.U)
                {
                    Console.Beep(f_note[6], 150);
                }

                if (key.Key == ConsoleKey.I)
                {
                    Console.Beep(f_note[7], 150);
                }

                if (key.Key == ConsoleKey.O)
                {
                    Console.Beep(f_note[8], 150);
                }

                if (key.Key == ConsoleKey.P)
                {
                    Console.Beep(f_note[9], 150);
                }

                if (key.Key == ConsoleKey.F3)
                {
                    player2(player2_:"");
                }

                if (key.Key == ConsoleKey.F4)
                {
                    player3(player3_:"");
                }
        }
        static void vol2(string vol2_)
        {
            int[] t_note = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830 };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(t_note[0], 150);
                }

                if (key.Key == ConsoleKey.S)
                {
                    Console.Beep(t_note[1], 150);
                }

                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(t_note[2], 150);
                }

                if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(t_note[3], 150);
                }

                if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(t_note[4], 150);
                }

                if (key.Key == ConsoleKey.H)
                {
                    Console.Beep(t_note[5], 150);
                }

                if (key.Key == ConsoleKey.J)
                {
                    Console.Beep(t_note[6], 150);
                }

                if (key.Key == ConsoleKey.K)
                {
                    Console.Beep(t_note[7], 150);
                }

                if (key.Key == ConsoleKey.L)
                {
                    Console.Beep(t_note[8], 150);
                }

                if (key.Key == ConsoleKey.F2)
                {
                   player1(player1_:""); 
                }

                if (key.Key == ConsoleKey.F4)
                {
                    player3(player3_:"");
                }
        }
        static void vol3(string vol3_)
            {
                int[] t_note = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480 };
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Z)
                    {
                        Console.Beep(t_note[0], 200);
                    }

                    if (key.Key == ConsoleKey.X)
                    {
                        Console.Beep(t_note[1], 200);
                    }

                    if (key.Key == ConsoleKey.C)
                    {
                        Console.Beep(t_note[2], 200);
                    }

                    if (key.Key == ConsoleKey.V)
                    {
                        Console.Beep(t_note[3], 200);
                    }

                    if (key.Key == ConsoleKey.B)
                    {
                        Console.Beep(t_note[4], 200);
                    }

                    if (key.Key == ConsoleKey.N)
                    {
                        Console.Beep(t_note[5], 200);
                    }

                    if (key.Key == ConsoleKey.M)
                    {
                        Console.Beep(t_note[6], 200);
                    }

                    if (key.Key == ConsoleKey.F2)
                    {
                        player1(player1_:"");
                    }

                    if (key.Key == ConsoleKey.F3)
                    {
                        player2(player2_:"");
                    }
            }
    }
}
