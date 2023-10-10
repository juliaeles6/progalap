namespace elmelet
{
    internal class Program
    {
        // Függvények

        // Függvényeket a Main függvényen kívül lehet írni, a következő módon:
        // static <visszatérési típus> <függvény neve> (<paraméterlista>)
        // a static kulcsszó azért kell, hogy lehessen a Main függvényben is használni (bővebben az osztályszintű adattagokról és metódusokról következő félévben lesz szó)
        // a visszatérési típus kb bármi lehet: int, string, egy rekord vagy tömb is
        // paraméterlista: sorban a paraméterek típussal és névvel

        // pld: legyen lnko(a, b) egy olyan függvény, ami visszaadja két számnak az lnko-ját:

        static int lnko(int a, int b) { // egészet ad vissza, két paramétere van: a és b, mindkettő egész
            // függvény törzse 
            while(a != b) {
                if(a < b) {
                    a -= b;
                }
                else {
                    b -= a;
                }
            }

            return a; // visszatérési értéke a függvénynek
        }

        // van olyan függvény, aminek nincs visszatérési értéke - ezeket eljárásoknak hívjuk. A C#-ban ezek "visszatérési típusa" a void
        // pld: legyen köszönt(név) egy olyan függvény, ami a neveden köszönt (a neved a paraméter)

        static void köszönt(string név) {
            Console.WriteLine("Szia, " + név + "!");
            // nincs visszatérési érték
            // lehetne egy db return-t írni:
            return;
        }

        // Bizonyos függvényekben a feladatban beolvasott tömböket szeretnénk használni (lásd mai gyakorlat feladata), viszont ezeket eddig a Main függvényben hoztuk létre, amiből nem látszódnak ki.
        // Lehetőség van a Main függvényen kívül is bejelenteni ezeket a változókat, a következő módon:
        // static <típus> <név>;
        // itt a static kulcsszót is kb ugyanazért kell használni, mint a függvényeknél
        static int x; // ezt már tudod a függvényekben is és a Main függvényben is használni

        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a neved!");
            string név = Console.ReadLine(); // Mici 
            köszönt(név); // Szia, Mici!

            x = lnko(3, 6); // x ekkor 3 lesz

            Console.WriteLine(x); 
        }
    }
}