/* 
 * A komplex beadandóban szükséges a bemenetet ellenőrizni. Erre néztünk már módszert (Console.Error.WriteLine), viszont ez lassítja a futást. Bár már a Bírón kapott 80 ponttól maxpontot lehet kapni a beadandóra, de lehet szükség lesz gyorsításra.
 *
 * Ezt makrók definiálásával fogjuk elérni (mint C-ben): ha egy makró definiálva van, akkor nem végezzük el az ellenőrzést, ha nincs, akkor meg elvégezzük. 
 *
 * További infókért lásd a tárgy honlapján a komplex beadandóhoz fűzött dokumentumot
 */

#define BIRO

using System;

namespace Komplex {
    internal class Program {
        public static void Main() {
		#if BIRO // C-ben ez az ifndef ellentettje
			// ide írd az ellenőrzés nélküli beolvasást 
		#else
			// ide írd az ellenőrzéses beolvasást
		#endif
		
		/*
		 * Hasznos még a következő függvény: int.TryParse();
		 * 
		 * Abban különbözik a sima Parse függvénytől, hogy míg az előbbi kivételt dob, ha nem sikerül az átalakítás, addig a TryParse hamisat ad vissza. 2 paramétere van:
		 * 	* egy string, amit át akarunk alakítani
		 * 	* egy out int, amibe megkapjuk az eredményt (ha sikerült parse-olni, különben pedig nem változik)
		 *
		 * Használata:
		 */	 
	 	
	       	int n = 0;

		if(int.TryParse(Console.ReadLine(), out n)) {
			Console.WriteLine($"n = {n}");
		}
		else {
			Console.WriteLine("Nem sikerült a parse-olás");
		}
		
       		Console.WriteLine(n);		
    	}
    }
}
