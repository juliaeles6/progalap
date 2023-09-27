namespace Elmélet
{
    // Ide nem jöhet struct
    internal class Program
    {
        // Ide jöhet struct
        public struct Ido {
            public int ora;
            public int perc;
            public string nap;
        }

        static void Main(string[] args)
        {
            // Ide nem jöhet struct
            // (Konstans) Tömbök:
            // Előző órán láttuk, hogyan lehet tömböket létrehozni. Ennek egy másik verziója az, ha mi kézzel adjuk meg a tömb elemeit, felsorolva azokat:

            int[] x = {1, 2, 3, 4, 5, 6, 7};
            // Ebben az esetben nem kell megadni a tömb méretét, a fordító kitalálja azt magának

            // Rekordok
            // C#-ban a rekordokat struktúráknak hívják, és a struct kulcsszóval lehet őket definiálni.
            // Fontos, hogy a definiálás a Main függvényen kívül történjen, de az ... class Program-on belül
            // A következő formában történik egy rekord definiálása:
            // public struct Név { 
            //     public típus1 mező1;
            //     public típus2 mező2;
            //     ...
            // }

            // példát lásd fennt

            // Ezután a létrehozott struct-tal mint típussal tudsz dolgozni. pl.

            Ido ido;
            ido.ora = 11;
            ido.perc = 59;
            ido.nap = "szerda";

            // Még ide sem jöhet struct
        }

        // Ide is jöhet struct
    }

    // Ide sem jöhet struct
}