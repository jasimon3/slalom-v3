using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slalom_v3
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            Random rand = new Random();
            Console.CursorVisible = false;
            int skierX = 50;
            int skierY = 0;
            int gateX = 40;
            int gateX_increment = 1;
            int gateY = 0;
            int slopeLength = 300;
            int slopeProgress = 0;
            int score = 0;

            Console.WriteLine("It's a beautiful sunny day. 'So lucky' you think to yourself standing on top of a mountain.\nTime to test those new skis!");
            Console.ReadLine();
            Console.Clear();

            while (slopeProgress < slopeLength)
            {
                gateX += gateX_increment;
                Console.SetCursorPosition(gateX, gateY);
                Console.WriteLine("|                    |");
                gateY++;

                //gateX = gateX + rand.Next(-2, 3);


                if (rand.Next(0, 6) == 0)
                    gateX_increment = -gateX_increment;
                if (gateX == 20)
                    gateX_increment += 1;
                if (gateX == 80)
                    gateX_increment += -1;

                Console.SetCursorPosition(skierX, skierY);
                Console.Write(" ");
                Console.Write("o");
                Console.Write(" ");
                skierY++;

                if (skierX <= gateX || skierX >= gateX+20)
                {
                    Console.WriteLine("Missed");
                    score++;
                    if (score > 20)
                    {
                        YouLost(score);
                    }    
                }

                System.Threading.Thread.Sleep(70);

                while (Console.KeyAvailable)
                    cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    skierX += -1;
                }
                if (cki.Key == ConsoleKey.RightArrow)
                {
                    skierX += 1;
                }

                slopeProgress++;
            }

            Console.SetCursorPosition(gateX, gateY);
            Console.WriteLine("|        FINISH      |");
            gateY++;

            Console.SetCursorPosition(skierX, skierY);
            Console.Write(" ");
            Console.Write("o");
            Console.Write(" ");
            skierY++;

            for (int i = 0; i < 9; i++)
                {
                    System.Threading.Thread.Sleep(140 +50*i);

                    Console.SetCursorPosition(gateX, gateY);
                    Console.WriteLine("|                    |");
                    gateY++;

                    Console.SetCursorPosition(skierX, skierY);
                    Console.Write(" ");
                    Console.Write("o");
                    Console.Write(" ");
                    skierY++;
            }


            YouWon(score);
            //Console.WriteLine("You got off the slope {0} times", score);
            Console.ReadLine();
        }


        public static void YouLost(int score)
        {
            Console.Clear();
            Console.WriteLine("It turns out your skill is no match for the slope. \nYou have crashed {0} times eventually loosing grip and falling off the slope", score);

            Console.WriteLine(@"            +---\");
            Console.WriteLine(@"\           _o /");
             Console.WriteLine(@"\     +---/ \");
              Console.WriteLine(@"\           \__ |");
               Console.WriteLine(@"\         \ \ \|");
                Console.WriteLine(@"\         \/  |");
                 Console.WriteLine(@"\         \  |");
                  Console.WriteLine(@"\         \");
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You decide you will recover and face it another day. For now press any key to exit.");
            Console.ReadLine();

            Environment.Exit(0);
                               
        }

        public static void YouWon(int score)
        {
            Console.Clear();
            Console.WriteLine("The slope was difficult, conditions were harsh but still you managed to keep on track reaching a low score of {0}", score);
            Console.WriteLine("");

            Console.WriteLine("                 /----|       .         .");
            Console.WriteLine("                /     [   .        .         .");
            Console.WriteLine(@"         ______|---- _|__     .        .");
            Console.WriteLine(@".     _--    --\_<\_//   \-----           .");
            Console.WriteLine(@"     _  _--___   \__/     ___  -----_ **     *");
            Console.WriteLine(@"*  _- _-      --_         /  [ ----__  --_  *");
            Console.WriteLine("*/__-      .    [           _[  *** --_  [*");
            Console.WriteLine("  [*/ .          __[/-----__/   [**     [*/");
            Console.WriteLine("        .     /--  /            /");
            Console.WriteLine("     .        /   /   /[----___/        .");
            Console.WriteLine("             /   /*[  !   /==/              .");
            Console.WriteLine("  .         /   /==[   |/==/      .");
            Console.WriteLine("          _ /   /=/ | _ |=/   .               .");
            Console.WriteLine("         / _   //  / _ _//              .");
            Console.WriteLine(" .       [ '//    |__//    .    .            .");
            Console.WriteLine("        /==/  .  /==/                .");
            Console.WriteLine("      /==/     /==/                       .");
            Console.WriteLine("    /==/     /==/       .       .    .");
            Console.WriteLine(" _ /==/    _/==/            .");
            Console.WriteLine(" [|*      [|*                   ");
        }


    }
}
