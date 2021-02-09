using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int a;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int hinne = rnd.Next(1, 5);
            Console.WriteLine("Hinne: {0}", hinne);
            Console.ReadLine();
            string tekst="???";
            switch (hinne)
            {
                case 1: tekst = "õpi veeli";break;
                case 2: tekst = "õpi natuke veeli"; break;
                case 3: tekst = "rahuldav"; break;
                case 4: tekst = "hea"; break;
                case 5: tekst = "väga hea"; break;

                default:
                    tekst = "viga";
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine(tekst);
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                nupp=Console.ReadKey();

            } while (nupp.Key!=ConsoleKey.Backspace);


            Console.ReadLine();
            Console.WriteLine("Töö failidega");
            string a;
            Console.WriteLine("Y-on vaj slvestada failisse");
            Console.WriteLine("N-on vaja lugeda failist");
            nupp = Console.ReadKey();
            if (nupp.Key==ConsoleKey.Y)
            {
                StreamWriter file = new StreamWriter(@"..\..\texts.txt", true);
                file.WriteLine(hinne + " " + tekst);
                file.Close();
                a = hinne + " " + tekst;
                Console.WriteLine("Failisee oli salvestatud:{0}", a);


            }
            else if (nupp.Key == ConsoleKey.N)
            {
                Console.WriteLine("Failisee oli järgmine informatsion");
                StreamReader filist = new StreamReader(@"..\..\texts.txt");
                a = filist.ReadToEnd();
                Console.WriteLine(a);


            }

       


            Console.ReadLine();
        
        }
    }
}
