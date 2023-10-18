using System;

namespace f01 {
    internal class Program {

        static int indul(int s) {
            if(s <= 50) {
                return 0;
            }
            else if(s > 90) {
                return 45;
            }
            else if(51 <= s && s <= 90) {
                return ((s - 1) / 5 - 9) * 5; // kicsit kellett ezen a képleten csiszolni... van ennél biztosa sokkal szebb és jobb is :D
            }


            return -1;
        }
        static void Main(string[] args) {
            string s = Console.ReadLine();

            int n;
            n = int.Parse(s);

            int[] e = new int[n + 1];
            for (int i = 1; i <= n; ++i)  {
                s = Console.ReadLine();
                e[i] = int.Parse(s);
            }

            int[] start = new int[n + 1];
            for(int i = 1; i <= n; ++i) {
                start[i] = indul(e[i]);
            }

            for(int i = 1; i <= n; ++i) {
                Console.WriteLine(start[i]);
            }
        }
    }
}
