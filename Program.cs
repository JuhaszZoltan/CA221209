namespace CA221209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(20, 10);

            Ember e1 = new();
            e1.Hely = (X: 12, Y: 3);
            e1.szin = ConsoleColor.Green;
            e1.Nev = "Béla";

            Ember e2 = new();
            e2.Hely = (X: 2, Y: 7);
            e2.szin = ConsoleColor.Blue;
            e2.Nev = "M";

            List<Ember> emberek = new() { e1, e2 };

            e1.Nev = "Ágnes";
            emberek[0].szin = ConsoleColor.Magenta;

            Console.WriteLine(e1.Hely.X);


            foreach (var e in emberek)
            {
                e.Megjelenit();
            }

            Console.ReadKey();
        }
    }
}