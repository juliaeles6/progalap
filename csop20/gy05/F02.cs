using System;
using System.Collections.Generic;

namespace F02 {
public class Program {
		public struct Pont {
			public int r;
			public int cs1;
			public int cs2;
			public int ef;
		}
	
		public static void Main(string[] args) {
			string bemenet;
			string[] darabok;

			int n;
			bemenet = Console.ReadLine();
			n = int.Parse(bemenet);

			Pont[] pontok = new Pont[n + 1];

			for(int i = 1; i <= n; ++i) {
				bemenet = Console.ReadLine();
				darabok = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);
				pontok[i].r = int.Parse(darabok[0]);
				pontok[i].cs1 = int.Parse(darabok[1]);
				pontok[i].cs2 = int.Parse(darabok[2]);
				pontok[i].ef = int.Parse(darabok[3]);
			}

			// Kiválogatásnál nem tudjuk előre a kiválogatott elemek számát, így nem is tudjuk lefoglalni a tömböt előre
			// Így ilyenkor használhatunk List-et, amihez hozzá tudunk adni és elvenni elemeket.
			// List használata C#-ban:
			//     - bejelentés: List<típus> a = new List<típus> ()
			//     - elem hozzáadása: a.Add(elem)
			//     - hossz lekérdezése: a.Count
			// A List a System.Collections.Generic namespace-ben van, így amikor Bíróra/Mesterre töltjük fel, akkor az "using System;" sor mellé fel kell venni az "using System.Collections.Generic;" sort is

			int db = 0;
			List<int> irhat = new List<int>();

			for(int i = 1; i <= n; ++i) {
				if(pontok[i].r >= 10 && (pontok[i].cs1 == 0 || pontok[i].cs2 == 0 || pontok[i].ef == 0)) {
					db++;
					irhat.Add(i);
				}
			}

			Console.WriteLine(db);
			// tömb/lista elemeinek kiiratása 1 sorba

			// 1. verzió: for ciklussal (FIGYELEM: a lista 0-tól van indexelve): 
			for(int i = 0; i < db; ++i) {
				Console.Error.Write(irhat[i] + " ");
			}
			Console.Error.WriteLine(); // mindig zárjuk le a sort egy sortöréssel

			// 2. verzió: foreach ciklussal (a változó a tömb/lista elemein megy végig):
			foreach(int e in irhat) {
				Console.Error.Write(e + " ");
			}
			Console.Error.WriteLine();

			// foreach ciklus használata: foreach(típus változó in tömb/lista)

			// 3. verzió: a String.Join() függvénnyel
			// 2 paramétere van: az első egy szöveg vagy karakter, a második egy tömb/lista
			// a második paraméterben megadott elemeket köti össze az első paraméterrel megadott karaterrel/szöveggel

			Console.WriteLine(String.Join(" ", irhat));
	 	}
	}
}
