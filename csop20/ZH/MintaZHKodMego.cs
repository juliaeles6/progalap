// MintaZH megoldás

// Ez csak iránymutató, a kód szerkezete, a kimenet formátuma lehet más. A lényeg, hogy struktúrált legyen és forduljon!

namespace MintaZHKodMego {
	public class Program {
		static int n;
		static int m;
		static int[,] ar;

		static void Beolvas() {
			string bemenet;
			string[] darabok;

			Console.WriteLine("Add meg a sorok és az oszlopok számát szóközzel elválasztva: ");
			bemenet = Console.ReadLine();
			darabok = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);

			while(darabok.Length != 2 || 
				!int.TryParse(darabok[0], out n) || n < 1 || n > 20 ||
				!int.TryParse(darabok[1], out m) || m < 1 || m > 30) {
					Console.WriteLine("Hibás bemeneti adatok! Add meg újra:");
					bemenet = Console.ReadLine();
					darabok = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);
				}

			ar = new int[n + 1, m + 1];
			
			for(int i = 1; i <= n; ++i) {
				bool joBemenet = false;
				Console.WriteLine("Add meg a mátrix " + i + "-dik sorát. A sorban pontosan " + m + " szám szerepeljen!");
				
				do {	
					bemenet = Console.ReadLine();
					darabok = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);

					if(darabok.Length != m) {
						joBemenet = false;
					}
					else {
						for(int j = 1; j <= m; ++j) {
							if(!int.TryParse(darabok[j - 1], out ar[i, j]) || ar[i, j] < 1_000 || ar[i, j] > 10_000) {
								joBemenet = false;
							}
						}
					}

					if(!joBemenet) {
						Console.WriteLine("Hibás bemenet. Add meg újra!");
					}
				}
				while(!joBemenet);
			}
		}
		
		static int osszeg(int i) {
			int s;
			s = 0;

			for(int j = 1; j <= m; ++j) {
				s = s + ar[i, j];
			}

			return s;
		}

		static int legnagyobb(int i) {
			int maxert;
			maxert = ar[i, 1];
			
			for(int j = 2; j <= m; ++j) {
				if(ar[i, j] > maxert) {
					maxert = ar[i, j];
				}
			}

			return maxert;
		}

		static int legkisebb(int i) {
			int minert;
			minert = ar[i, 1];
			
			for(int j = 2; j <= m; ++j) {
				if(ar[i, j] < minert) {
					minert = ar[i, j];
				}
			}

			return minert;
		}

		static int kulonbseg(int i) {
			return legnagyobb(i) - legkisebb(i);
		}


		public static void Main() {
			Beolvas();

			// a)
			int osszPenz;
			osszPenz = 0;

			for(int i = 1; i <= n; ++i) {
				osszPenz = osszPenz + osszeg(i);
			}

			Console.WriteLine("a)\nLegalább " + osszPenz + " kell nálam legyen, hogy minden árustól minden termékből tudjak 1-et venni.");

			// b)
			int[] kulonbsegek = new int[n + 1];
			for(int i = 1; i <= n; ++i) {
				kulonbsegek[i] = kulonbseg(i);
			}

			Console.WriteLine("b)\nA különbségek:");
			for(int i = 1; i <= n; ++i) {
				Console.WriteLine(i + ". árus:" + kulonbsegek[i]);
			}
		}
	}
}
