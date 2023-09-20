namespace feladat {
    internal class Program {
        static void Main(string[] args) {
		    // ##### Split #####
            
            // Előző órán megnéztük, hogy hogyan lehet beolvasni egy sort, és azt igény szerint átalakítani
            // Van olyan eset, amikor több adat is van egy sorban, pl
            // 3 78 1

            // Ilyen esetben a beolvasott sort szét kell választani bizonyos karakterek mentén. Erre a Split() függvényt használjuk, ami meghatározott karakterek mentén vágja szét a szöveget, és azt stringek tömbjeként adja vissza 
            // Használata: szöveg.Split("karakterek") vagy szöveg.Split(), ha szóközök mentén akarjuk a szöveget szétválasztani
            string[] s = Console.ReadLine().Split();

            // s = ["3", "78", "1"]

            // innentől az első adat a sorban az s[0]-ban, a második az s[1]-ben stb. van 

            int a, b, c;
            a = int.Parse(s[0]); // a = 3
            b = int.Parse(s[1]); // b = 78
            c = int.Parse(s[2]); // c = 1

            // ##### Operátor rövidítések #####
            // C#-ban (és még sok más nyelvben) lehetőség van operátorok rövidítésére:
            // rövidítés                    jelentés
            // a += b                       a = a + b
            // a -= b                       a = a - b
            // a *= b                       a = a * b
            // a /= b                       a = a / b
            // a %= b                       a = a % b (maradék)
            // a++ vagy ++a                 a += 1; a = a + 1
            // a-- vagy --a                 a -= 1; a = a - 1
            
            // ##### Tömbök #####

            // Tömböket a következőképpen jelentünk be (erről bővebben a következő félévben objektumelvű programozásból lesz szó, hogy miért):
            // típus[] név = new típus[méret]
            // pl. 
            int[] x = new int[a + 1]; // x egy 4 hosszú, egészeket tároló tömb

            // C#-ban a tömböket 0-tól indexelik. Ez nem éppen követi a megszokott 1-től indexelést, ezért gyakran a 0. elemet nem szoktuk használni, hanem inkább 1-gyel nagyobbra csináljuk a tömböt.

            // ##### Ciklusok #####

            // #### Előltesztelős ciklus ####
            
            // C#-ban az előltesztelős ciklust a while (feltétel) szerkezettel valósítjuk meg. pl.
            while (b > 10) {
                b /= 10;
            }   

            // #### Lépegetős ciklus #### 
            
            // C#-ban a lépegetős ciklust a for (A;B;C) szerkezettel valósítjuk meg, ahol:
            //      A: honnan indul a ciklusváltozó pl. i = 1 vagy e = 45
            //      B: egy megállási feltétel, általában, hogy meddig menjen a ciklusváltozó pl. i <= n vagy e < 100
            //      C: mennyivel léptetjük a ciklusváltozót pl. i++ vagy e += 7
            // pl

            for (i = 1; i <= c; ++i) {
                Console.WriteLine(i);
            }

            // for ciklus esetében lehetőség van a ciklusváltozót bejelenteni. Fontos, hogy ilyen esetben csak az adott for ciklusban használhatjuk azt a változót. pl.

            for (int j = 0; j < 10; ++j) {
                Console.WriteLine(j);
            }

            // Console.WriteLine(j); <- hiba, j-t csak a for ciklusban látom
        }
    }
}
