using System;
using System.Collections.Generic;

namespace F01 {
    internal class Program {
        // Függvények deklarálása C#-ban:
        // static <típus> <függvénynév>(<paraméter típus> <paraméter név>, ...) 

        // Mivel függvényeket használunk, ezért a változókat kinnt is elérhetővé kell tennünk. Ehhez a Main függvény előtt definiáljuk a változókat figyelve arra, hogy a static kulcsszó ne maradjon le róla

        static int n;
        static int[] x;

        public static void beolvas() {
            string bemenet;
            string[] darabok;

            bemenet = Console.ReadLine();
            n = int.Parse(bemenet);

            x = new int[n + 1];

            for(int i = 1; i <= n; ++i) {
                bemenet = Console.ReadLine();
                x[i] = int.Parse(bemenet);
            }
        }

        public static int terulet(int i) {
            return x[i] * x[i];
        }
        
        public static void Main() {
            beolvas();

            int s;
            s = 0;
            for(int i = 1; i <= n; ++i) {
                s = s + terulet(i);
            }

            Console.WriteLine(s);
        }
    }
}