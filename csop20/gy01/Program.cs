namespace gy01 
{
	internal class Program
	{
		static void Main(string[] args) 
		{
			/*
				Alap típusok:
				int, long - egész
				float, double - "valós"
				bool - logikai (true, false)
				char - karakter
				string - szöveg
			*/

			/*
			 	Kiírás:
				Console.WriteLine(); -tesz új sort a végére
				Console.Write(); - nem tesz új sort a végére
			*/

			/*
				Beolvasás:
				Console.ReadLine(); - beolvas egy egész sort, és visszaadja string-ként
			*/

			/*
				Átalakító művelet: Parse()
				Használat: típusnév.Parse(szöveg); 
			*/

			/*
				Feltételek:
				if(felt)
				{
					Dolgok, ha felt teljesül	
				} 
				else if(felt1) - opcionális
				{
					Dolgok, ha felt nem teljesül, de felt1 igen
				}
				else - opcionális, de mindig a végén van
				{
					Dolgok, ha semmi sem teljesül
				} 
			*/

			/*
				Feltételek összakapcsolása:
				&& - és
				|| - vagy
				! - tagadás
			*/

			// 1. feladat:
			double d, s, v;
			string bemenet;

			bemenet = Console.ReadLine();
			d = double.Parse(bemenet);

			bemenet = Console.ReadLine();
			s = double.Parse(bemenet);

			if(d >= 0 && s > 0) 
			{
				v = s / t;
				Console.WriteLine("Sebesség = " + v);
			}
			else 
			{
				Console.WriteLine("Rossz adat");
			}

			// 2. feladat:
			double c, f;
			// string bemenet; <- mivel már egyszer bejelentettük, ezért nem kell még egyszer
			
			bemenet = Console.ReadLine();
			c = double.Parse(bemenet);

			if(c >= 273.15) 
			{
				f = c * 1.8 + 32;
				Console.WriteLine("Fahrenheit = " + f);
			}
			else 
			{
				Console.WriteLine("Rossz adat");
			}
		}
	}
}
