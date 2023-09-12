namespace feladat09 {
    internal class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            int x;
	    x = int.Parse(s);
		
            if (x < 1 || x > 20) {
                return;
            }

            string u;
	    if (x <= 10) {
	    	u = "Bukott";
            }
	    else {
		u = "Átment";
	    }
	
            Console.WriteLine(x);
	    Console.WriteLine(u);
        }
    }
}
