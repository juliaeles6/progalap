// Mester / középhaladó / Időjárás / 25
using System;

namespace F01 {
    internal class Program {
        static int[, ] h;
        static int n;
        static int m;

        static bool melegebb(int k, int j) {
            int i;
            i = 1;
            while (i <= n && h[i, k] < h[i, j]) {
                ++i;
            }

            return i > n;
        }

        static bool meleg(int j) {
            bool van;
            int k;

            van = false;
            k = 1;

            while (!van && k <= m) {
                if (melegebb(k, j)) {
                    van = true;
                }
                else {
                    ++k;
                }
            }

            return van;
        }

        static void Main() {
            string[] s = Console.ReadLine().Split();

            n = int.Parse(s[0]);
            m = int.Parse(s[1]);

            h = new int[n + 1, m + 1];
            for (int i = 1; i <= n; ++i) {
                s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 1; j <= m; ++j) {
                    h[i, j] = int.Parse(s[j - 1]);
                }
            }

            bool van;
            int ind;

            van = false;
            ind = 1;

            while (!van && ind <= m) {
                if (meleg(ind)) {
                    van = true;
                }
                else {
                    ++ind;
                }
            }

            if (!van) {
                ind = -1;
            }

            Console.WriteLine(ind);
        }

    }
}