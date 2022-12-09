using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CA221209
{
    internal class Ember
    {
        private string nev;
        public string Nev
        {
            get => nev;
            set
            {
                if (value.Trim().Length < 1)
                    throw new Exception("minimu egy karakter hosszú kell, hogy legyen");
                nev = value;
            }
        }

        private (int x, int y) hely;
        public (int X, int Y) Hely
        {
            set
            {
                if (value.X < 0 || value.X >= Console.WindowWidth)
                    throw new Exception($"ez az érték csak [0; {Console.WindowWidth - 1}] között lehet!");
                if (value.Y < 0 || value.Y >= Console.WindowHeight)
                    throw new Exception($"ez az érték csak [0; {Console.WindowHeight - 1}] között lehet!");
                hely = value;
            }
            get => hely;
        }

        public ConsoleColor szin;
        

        public void Megjelenit()
        {
            Console.ForegroundColor = szin;

            Console.SetCursorPosition(
                left: hely.x,
                top: hely.y);
            Console.Write(Nev[0]);

            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
        }
    }
}
