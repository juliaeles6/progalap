using System;

namespace F02 {
	internal class Program {

		public static void Main(string[] args) {
			// beolvasás
			string bemenet;
			int k;

			bemenet = Console.ReadLine();
			k = int.Parse(bemenet);

			int[] x = new int[k + 1];

			for(int i = 1; i <= k; ++i) {
				bemenet = Console.ReadLine();
				x[i] = int.Parse(bemenet);
			}

			int s;

			// innen kezdődik az összegzés
			s = 0;

			for(int i = 1; i <= k; ++i) {
				s = s + x[i] * x[i];
			}

			// kiírás
			Console.WriteLine(s);

			// A Mester/Bíró csak azokat a kiírt adatokat ellenőrzi, amiket a Console.Write() vagy Console.WriteLine() metódussal írunk ki.
			// Ha szeretnénk saját üzeneteket kiírni, akkor használjunk Console.Error.Write()-ot és Console.Error.WriteLine()-t 
		}
	}
}