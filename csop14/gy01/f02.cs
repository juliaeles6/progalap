namespace feladat02 {
    internal class Program {
        static void Main(string[] args) {
            string s;
            s = Console.ReadLine();

            double x;
            x = double.Parse(s);            

            if(x <= 0) {
                return;
            }

            double ki;
            ki = x / 30;

            Console.WriteLine(ki);
        }
    }
}