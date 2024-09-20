namespace F02 {
    internal class Program {
        public static void Main(string[] args) {
            // ===Áttekintés===

            // While ciklus: 
            // while(feltétel)  {
            //     dolgok
            // }

            // Parse() vs TryParse()
            // Mindkettő a megfelelő típusra konvertálja át a megadott szöveget, azonban ha nem sikerül, akkor a Parse() kivételt dob és a program elszáll, a TryParse() viszont csak visszatér egy hamissal. Emiatt ez utóbbit fogjuk használni.

            // TryParse() használata:
            // típus.TryParse(szöveg, out eredmény)
            //      -> a metódus megpróbálja a szöveg változóban lévő szöveget átalakítani:
            //          -> ha sikerül, akkor beteszi az eredmény változóba, és igazzal tér vissza
            //          -> ha nem, az eredmény változót kinullázza (vagy valami nulla-szerű értéket tesz bele) és hamissal tér vissza
        
            // ===1. feladat===
            
            string bemenet;
            double a, b, c;

            bemenet = Console.ReadLine(); // kérünk egy bemenetet
            while(!(double.TryParse(bemenet, out a) && a > 0)) { // azt a feltételt fogalmazzuk meg, amikor a megadott bemenet nem jó. Ezt írhattuk volna úgy is, hogy !double.TryParse(bemenet, out a) || a <= 0
                bemenet = Console.ReadLine(); // új bemenetet kérünk
            }

            bemenet = Console.ReadLine(); 
            while(!(double.TryParse(bemenet, out b) && b > 0)) { 
                bemenet = Console.ReadLine(); 
            }

            bemenet = Console.ReadLine(); 
            while(!(double.TryParse(bemenet, out c) && c > 0)) { 
                bemenet = Console.ReadLine();
            }

            bool dr;

            if(a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b) {
                dr = true;
            }
            else {
                dr = false;
            }

            if(dr) { // <- jelentése: ha dr igaz
                Console.WriteLine("Derékszögű");
            }
            else {
                Console.WriteLine("Nem derékszögű");
            }

            // ===2. feladat===
            int x, y;
            
            bemenet = Console.ReadLine();
            while(!(int.TryParse(bemenet, out x) && x >= 0)) { // x >= 0 nincs explicit benne az előfeltételben, de mivel a C#-ban nincs külön természetes szám típus, ezért ilyenkor ezt is le szoktuk ellenőrizni 
                bemenet = Console.ReadLine();
            }

            bement = Console.ReadLine();
            while(!(int.TryParse(bemenet, out y) && y > 0)) {
                bemenet = Console.ReadLine();
            }

            int m;

            while(x <= y) {
                x = x - y;
            }

            m = x;
            Console.WriteLine(m);

            // a 3. feladathoz (a tömbös) még egyszer elmondom kövi órán
        }
    }
}