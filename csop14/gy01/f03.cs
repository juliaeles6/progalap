namespace feladat03 {
    internal class Program {
        static void Main(string[] args) {
            const int limit = 500;

            string s = Console.ReadLine();
            double x;
            x = double.Parse(s);

            if(x < limit) {
                return;
            }

            Console.WriteLine(x);
        }
    }
}