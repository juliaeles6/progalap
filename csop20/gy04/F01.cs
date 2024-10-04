using System;

namespaceAd F01 {
	internal class Program {

		public static void Main(string[] args) {
			// beolvasás
			string bemenet;
			int n;

			bemenet = Console.ReadLine();
			n = int.Parse(bemenet);

			int[] h = new int[n + 1];

			for(int i = 1; i <= n; ++i) {
				bemenet = Console.ReadLine();
				h[i] = int.Parse(bemenet);
			}

			int maxInd, maxert;

			// innen kezdődik a maximum kiválasztás

			maxert = h[1];
			maxInd = 1;

			for(int i = 2; i <= n; ++i) {
				if(h[i] > maxert) {
					maxert = h[i];
					maxInd = i;
				}
			}

			// kiírás
			Console.WriteLine(maxInd);

			// A Mester/Bíró csak azokat a kiírt adatokat ellenőrzi, amiket a Console.Write() vagy Console.WriteLine() metódussal írunk ki.
			// Ha szeretnénk saját üzeneteket kiírni, akkor használjunk Console.Error.Write()-ot és Console.Error.WriteLine()-t 
		}
	}
}