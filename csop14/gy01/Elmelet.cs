namespace feladat {
    internal class Program {
        static void Main(string[] args) {
            // Változók: 

	        // Minden változót, amit használtok, be kell jelenteni. Ez a következőképpen történik:
            // <változó típusa> <változó neve>;
            // pl.
            // string s = "Hello"; -> szöveg
            // int n = 3;    -> egész (nincs külön természetes típus) 
            // double f = 3.14; -> valós 
            // bool b = true;   -> logikai (true / false)
            // char c = 'r';   -> karakter
            // Bizonyos esetekben szükségünk van olyan változóra is, aminek az értéke a program alatt nem változik. Ezt a const szóval jelöljük meg, és azonnal értéket is adunk neki:
            //     const int MAX = 999999999;
            // Ha az első értékadás után próbáljuk meg az értékét megváltoztatni, akkor hibát kapunk.
            
            string s;
            double f;
            int n;

            // Beolvasás:
	        // Ebben a félévben a console-ról olvasunk be. Ezt a Console.ReadLine() függvénnyel célszerű elvégezni.
	        // Ez a függvény a console-ról 1 teljes sort olvas be, és visszaadja azt egy string (szöveg) formájában

            s = Console.ReadLine();
            
            // Kiírás:
            // Kiírni a Console.WriteLine(<valami>); függvénnyel fogunk. Ez kiírja azt, amit megadunk neki paraméterként, majd a következő sorra lép (új sort ír ki)
            // Van, amikor még szeretnénk a sort folytatni. Ekkor a Console.Write() függvényt használjuk.

            Console.WriteLine(s);

            // A beolvasott adatot gyakran nem szövegként szeretnénk kezelni, hanem számként. Ekkor át kell alakítani a stringet számmá Ezt a Parse függvénnyel tehetjük meg, mégpedig a következő módon:

            f = double.Parse(s); // f `double` típusú, tehát `double`-é kell alakítani
            n = int.Parse(s);    // n `int` típusú, tehát `int`-té kell alakítani

            // A Parse megpróbálja a szöveget számmá alakítani, és ha nem sikerül neki, akkor kivételt dob (következő félévben lesz szó erről). Később megnézzük, hogy hogyan tudjuk másképp ellenőrizni azt, hogy sikeres volt-e az átalakítás

            // Elágazás:
            // if (felt) {
            //     dolgok, ha igaz
            // }
            // else { - opcionális
            //     dolgok, ha hamis
            // }

            if (n > 3) {
                return;
            }

            if (f < 0) {
                Console.WriteLine("Negatív");
            }
            else {
                Console.WriteLine("Nemnegatív");
            }

            // Feltételek összetevése:
            // Ha több feltételt szeretnénk összetenni, akkor azt megtehetjük a következő 3 operátor segítségével:
            // !  -> tagadás
            // && -> és
            // || -> vagy
            // pl.
            // n < 3 || n > 6      -> n kisebb, mint 3 vagy n nagyobb, mint 6
            // n * m <= 3 && n < 8 -> n * m legfennebb 6 és n kisebb, mint 8
            // ! (n < 0)           -> n nem kisebb, mint 0
        }
    }
}
