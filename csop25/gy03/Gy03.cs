namespace Gy03;

internal class Program {
	// struktúra (rekord) definiálása:
	// 
	// struct Nev {
	// 	   public tipus mezo;
	//     public tipus masik_mezo;
	// }

	struct Fajl {
		public string name;
		public int meret;
		public int ido;
	}

	public static void Main(string[] args) {
		// Tömbök:
		// tipus[] valtozo = new tipus[hossz] -> hossz hosszúságú tömb lefoglalása (0-tól indexelve)

		// Konstans tömbök
		// Újabb .NET verziókban: tipus[] nev = [ ertekek ]
		// Régebbiekben (értékelőrendszer): tipus[] nev = { ertekek }
		
		// 1. feladat

		string[] nap = {"", "hetfo", "kedd", "szerda", "csutortok", "pentek", "szombat", "vasarnap"}; 

		string bemenet;
		int k;

		bemenet = Console.ReadLine();
		while(!int.TryParse(bemenet, out k) || k < 1 || 31 < k) {
			bemenet = Console.ReadLine();
		}

		string nap;

		if(k % 7 == 0) {
			nap = napok[7];
		}
		else {
			nap = napok[k % 7];
		}

		Console.WriteLine(nap);

		// 2. feladat

		// Több adat beolvasása 1 sorból:
		// Egy szöveget bizonyos karakterek mentén a Split() függvénnyel tudunk felbontani, amiben megadjuk, hogy milyen karakterek mentén bontson fel
		// Az eredmény egy string-ekből álló tömb lesz.

		// pl. ha bemenet = "alma virag 1 15.0"
		// akkor bemenet.Split(" ") = ["alma", "virag", "1", "15.0"];

		// Ha több olyan karakter van egymás mellett, ami mentén felbontunk, akkor az üres stringeket is beteszi a tömbbe. 
		// Hogy ezt elkerüljük a Split függvény második paraméterének megadhatjuk a következőt: StringSplitOptions.RemoveEmptyEntries
		
		// Ennek használata:
		// bemenet.Split(" ", StringSplitOptions.RemoveEmptyEntries);
		// vagy
		// bemenet.Split(new char[' '], StringSplitOptions.RemoveEmptyEntries); <- van amikor csak ez a verzió működik

		Fajl fajl;
		string[] darabok;
		
		bemenet = Console.ReadLine();
		darabok = bemenet.Split(" ", StringSplitOptions.RemoveEmptyEntries);
		while(darabok.Length != 3 || // nem elég adatot adtunk meg
			  !int.TryParse(darabok[1], fajl.meret) || fajl.meret < 0 ||
			  !int.TryParse(darabok[2], fajl.ido) || fajl.ido < 0) {
			bemenet = Console.ReadLine();
			darabok = bemenet.Split(" ", StringSplitOptions.RemoveEmptyEntries);
		} 

		fajl.nev = darabok[0];

		int most;

		bemenet = Console.ReaadLine();
		while(!int.TryParse(bemenet, out most) || most < fajl.ido) {
			bemenet = Console.ReadLine();
		}

		int kul;
		kul = most - fajl.ido;

		Console.WriteLine(kul);

	}
}
