/*
 * Ez olyan anyag, ami nem a tárgy követelménye, viszont a következő félévek tárgyaiban fogtok ehhez hasonlóakkal találkozni
 * 
 * ZH-n nem ajánlom, hogy ezzel töltsétek az időt, de beadandóban szívesen látom (nem követelmény így megcsinálni), az viszont követelmény lesz, hogy függvényekre bontsátok a feladatot. 
 * 
 * Cél: olyan függvények létrehozása, amik tetszőlegesen felparaméterezhetők a progamozási mintáknak megfelelően
 * 
 * Előzetes tudnivalók:
 *  * Func osztály: függvényeket leíró osztály, általában lambda kifejezésekkel használjuk (Haskell <3). Felépítése a következő: Func<T1, T2, ..., Tn>, ami egy olyan függvényt jelöl, aminek van egy T1 típusú paramétere, egy T2 típusú paramétere... és egy Tn típusú dologgal tér vissza (tehát nem void, arra az Action osztály van). Bővebben: https://learn.microsoft.com/en-us/dotnet/api/system.func-1?view=net-8.0. Ez harmadik félévben EVA-n fog biztosan megjelenni.
 *  * Generikusság: ez már tényleg a következő félévre tartozik, röviden: megadhatok egy általános T típusparamétert, ami helyére, amikor használom, egy konkrét típus fog kerülni. (Java-ban sok ilyet fogtok írni, ha jól emlékszem, OEP-en is lesz)
 *  
 *  A kódban a SZUMMA, MAX és KIVÁLOGAT függvények vannak megvalósítva, gyakorlásképp meg lehet a többit is csinálni. 
 *  
 *  A kódban elvétve láthattok ?-et meg !-et típusok, változók neve mellett. Nektek nem kell ezzel foglalkozni, a jelentés röviden a következő:
 *      * ? típus mellett: olyan típus, ami lehet null is (van amiben enélkül is lehet, de így külön figyel rá a fordító)
 *      * ! változónév mellett: az adott változó biztos nem null, vagyis van érték, amivel dolgozhatunk (ezt nem nagyon szokás használni, én most kitettem, mert idegesített a csomó warning :)) )
 */

namespace Mintak {
    internal class Program {
        //  mintaadatok, csak hogy legyen min bemutatni
        static int n;
        static int[]? x;
        static string[]? t;
        static void Beolvas() {
            string s = Console.ReadLine()!;
            n = int.Parse(s);
            x = new int[n + 1];

            s = Console.ReadLine()!;
            string[] sor = s.Split().Where(s => s.Length > 0).ToArray();

            for (int i = 0; i < n; ++i) {
                x[i + 1] = int.Parse(sor[i]);
            }


            s = Console.ReadLine()!;
            t = s.Split(' ');
        }

        /*
         * Specifikációban:
         * e, u egészek, f : [e..u] -> H és feltételes összegzés esetén T : [e..u] -> L
         * Mi most egészeken fogunk összegezni
         * 
         * A T függvény opcionális paraméter (imperatív programozásból ismerős lehet), aminek kezdőértékként null-t adunk meg (a null azt jelenti, hogy semmi nincs benne). Ha sima összegzést használunk, akkor T a konstans igaz függvény kell legyen, viszont a C# fordítónak ez nem fog tetszeni, ugyanis nem lehet fordítási időben biztosra megmondani, hogy mi lesz az eredmény (sajna ennyire nem okos a fordító). Így ezzel külön kell foglalkozni
         * 
         * Továbbgondolni: tetszőleges halmazon összegezni (kell egy semleges elem és egy összegző függvény), akár feltételesen.
         */
        static int SZUMMA(int e, int u, Func<int, int> f, Func<int, bool>? T = null) {
            if (T == null) { // Ha nem kaptunk mi feltételt, akkor az a konstans igaz lesz. Rövidebben: T ??= _ => true;
                T = _ => true;
            }

            // klasszikus összegzés
            int s = 0;
            for (int i = e; i <= u; ++i) {
                if (T(i)) {
                    s += f(i);
                }
            }

            return s;
        }

        /*
         * Specifikációban:
         * e, u egészek, f : [e..u] -> H és a H halmazon értelmezve kell legyen egy teljes rendezési reláció (bármelyik 2 elemről meg kell tudni mondani, hogy melyik a kisebb vagy egyenlő).
         * Mi most egészeken fogunk maximumot keresni, a reláció megvan
         * 
         * Vannak olyan programozási minták, amelyek több értéket adnak vissza egyszerre. Ezekre van a Tuple.
         * 
         * Továbbgondolni: tetszőleges halmazon maximumkeresés úgy, hogy mi adjuk meg a rendezési relációt (pl felveszünk pontokat a síkban, és melyik van a legtávolabb az origótól)
         */

        static (int, int) MAX(int e, int u, Func<int, int> f) {
            int maxErt = f(e);
            int maxInd = e;

            for (int i = e + 1; i <= u; ++i) {
                if (f(i) > maxErt) {
                    maxErt = f(i);
                    maxInd = i;
                }
            }

            return (maxInd, maxErt);
        }

        /*
         * Specifikációban:
         * e, u egészek, f : [e..u] -> H és T : [e..u] -> L
         * 
         * Generikust írni úgy lehet, ha a függvény neve mellé <>-ben írod a típusparaméter nevét. Ezt innen konkrét típusként tudod használni. 
         * 
         * Továbbgondolni: ugyanazt az eredményt állítja elő tömbként is és listaként is - majd a használatkor eldobjuk azt, ami nem kell (a C# támogatja az overload-ot, vagyis ugyanazzal a névvel, de különböző típusokkal adod meg a függvényt, talán imperatívon előjött)
          */

        static (int, List<H>) KIVÁLOGAT<H>(int e, int u, Func<int, bool> T, Func<int, H> f) {
            int db = 0;
            List<H> y = new List<H>();

            for (int i = e; i <= u; ++i) {
                if (T(i)) {
                    ++db;
                    y.Add(f(i));
                }
            }

            return (db, y);
        }

        static void Main() {
            Beolvas();

            int összeg = SZUMMA(1, n, i => x![i]); // sima összegzés
            int párosÖsszeg = SZUMMA(1, n, i => x![i], i => x![i] % 2 == 0); // feltételes összegzés
            int maxind = 0, maxert = 0;

            (maxind, maxert) = MAX(1, n, i => x![i]); // maximumkeresés

            List<int> p;

            // Függvény visszatérési értéke esetén amilyen információra nincs szükségünk, azt a _ operátorral eldobhatjuk
            (_, p) = KIVÁLOGAT(1, n, i => x![i] < 5, i => i); // kiválogatás

            List<string> aValKezdodnek;
            int db = 0;

            // Bár a függvényünk generikus, de ki tudja magától találni, hogy a H helyére milyen típus kell kerüljön (ehhez képest a konstans igaz függvény nem megy neki). Viszont ki lehet írni: KIVÁLOGAT<string>. Generikus típus használatakor (pl List) viszont mindig írjátok ki, mert akkor egy olyan Listát hoztok létre, amiben bármi lehet, és annak sok buktatója van, és kb semmit sem lehet vele kezdeni.
            (db, aValKezdodnek) = KIVÁLOGAT(1, n, i => t![i][0] == 'a', i => t![i]);
        }
    }
}