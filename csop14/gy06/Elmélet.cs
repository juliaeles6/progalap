using System;
using System.Collections.Generic;

namespace elmelet {
    internal class Program {
        static void Main(string[] args) {
            // Lista vs tömb

            // Az egyik legnagyobb különbség a kettő között az az, hogy a tömbnek végig állandó a hossza (amit akkor adunk meg általában, amikor bejelentjük), a lista hossza viszont futás közben változik.

            // A kiválogatás minta esetében a specifikációban megfigyeltő, hogy a kimeneti tömbnek nem tudjuk előre a hosszát, mivel azt is a mintában számítjuk ki. A kódban 2 lehetőség van ennek kezelésére:

            // 1. megoldás:

            // Akkora tömböt jelentünk be eredménytömbnek, amiben biztosan elfér - ekkor követhetjük az algoritmusmintát

            // 2. megoldás:

            // Listát használunk eredménytömb helyett - ekkor mindig hozzáfűzzük a végére

            // Lista használata:

            // A Mesternek / Bírónak be kell írni a program elejére az using System.Collections.Generic sort
            // Bejelenteni a következőképpen kell: List<tipus> nev = new List<tipus>();

            // pl.

            List<int> sorszamok = new List<int>();
            // itt üres a lista

            // Függvények, amiket általában használunk listákra:
            // Add(valami) - a végére fűz valamit
            // Clear()     - kiüríti a listát (gyakorlaton nem jött elő)

            sorszamok.Add(2);
            sorszamok.Add(1);
            sorszamok.Add(2);
            sorszamok.Add(3);
            // a lista ezen a ponton: [2, 1, 2, 3]
            sorszamok.Clear();
            // megint üres a lista

            // Le lehet kérdezni a listának a hosszát is:
            
            Console.WriteLine(sorszamok.Count); // a COunt után nem kell (), mivel ez nem egy függvény, hanem egy ún. property (bővebben ezekről OEP-en).

            
        }
    }
}
