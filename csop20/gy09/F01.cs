using System;
using System.Collections.Generic;

namespace allatkertcsop25 {
    internal class Program {
        static int n;
        static Bejegyzes[] b;
        static List<int> y = new List<int>();

        struct Bejegyzes {
            public int kkod;
            public int tkod;
            public int ev;
            public int darab;
        }

        struct Tema {
            public int tkod;
            public int darab;
        }

        static void beolvas() {
            string bemenet;
            string[] darab;

            bemenet = Console.ReadLine();
            n = int.Parse(bemenet);

            b = new Bejegyzes[n + 1];

            for(int i = 1; i <= n; ++i) {
                bemenet = Console.ReadLine();
                darab = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                b[i].kkod = int.Parse(darab[0]);
                b[i].tkod = int.Parse(darab[1]);
                b[i].ev = int.Parse(darab[2]);
                b[i].darab = int.Parse(darab[3]);
            }
        }

        static int beszerzettek(int i) {
            int s;
            s = 0;

            for(int j = 1; j <= n; ++j) {
                if (b[j].ev == b[i].ev){
                    s = s + b[j].darab;
                }
            }

            return s;
        }

		static bool nemVoltMeg(int i) {
			int j;
			j = 1;
			while(j <= i - 1 && b[i].ev != b[j].ev) {
				j = j + 1;
			}

			return j > i - 1;
		}

		static int beszerzettKonyv(int i) {
			int s;
			s = 0;
			for(int j = 1; j <= n; ++j) {
				if(b[j].kkod == b[i].kkod) {
					s = s + b[j].darab;
				}
			}

			return s;
		}

        static bool temaNemVoltMeg(int i) {
            int j;
            j = 1;
            while(j <= i - 1 && b[i].tkod != b[j].tkod) {
                j = j + 1;
            }

            return j > i - 1;
        }

        static Tema temaKonyvDb(int i) {
            Tema t;
            int s;
            s = 0;

            for(int j = 1; j <= n; ++j) {
                if (b[j].tkod == y[i - 1]) {
                    s = s + b[j].darab;
                }
            }

            t.tkod = y[i - 1];
            t.darab = s;

            return t;
        }

        static void Main(string[] args) {
            beolvas();
            // a)
            Console.WriteLine("#");
            int minind, minert, legkisebbEv;

            minind = 1;
            minert = beszerzettek(1);

            for(int i = 2; i <= n; ++i) {
                if(beszerzettek(i) < minert) {
                    minert = beszerzettek(i);
                    minind = i;
                }
            }

            legkisebbEv = b[minind].ev;
            Console.WriteLine(legkisebbEv);

            Console.WriteLine("#");

			int evDb;
			List<int> evek = new List<int>();

			evDb = 0;
			for(int i = 1; i <= n; ++i) {
				if(nemVoltMeg(i)) {
					evDb = evDb + 1;
					evek.Add(b[i].ev);
				}
			}

			Console.WriteLine(evDb);
			Console.WriteLine(string.Join(" ", evek));
			
            Console.WriteLine("#");

			int maxind, maxert, legtobbKonyv;

			maxind = 1;
			maxert = beszerzettKonyv(1);

			for(int i = 2; i <= n; ++i) {
				if(beszerzettKonyv(i) > maxert) {
					maxert = beszerzettKonyv(i);
					maxind = i;
				}
			} 

			legtobbKonyv = b[maxind].kkod;

			Console.WriteLine(legtobbKonyv);

            Console.WriteLine("#");

			bool van;
			int nemBeszerzettE, nemBeszerzettV;
			
			van = false;
			for(int i = 1; i < n; ++i) {
				if(b[i + 1].ev - b[i].ev < 2) {
					
				}
				else if(b[i + 1].ev - b[i].ev >= 2 && van) {
					if(b[i + 1].ev - b[i].ev > maxert) {
						maxert = b[i + 1].ev - b[i].ev;
						maxind = i;
					}
				}
				else if(b[i + 1].ev - b[i].ev >= 2 && !van) {
					maxert = b[i + 1].ev - b[i].ev;
					maxind = i;
					van = true;
				}
			}

			if(van) {
				nemBeszerzettE = b[maxind].ev + 1;
				nemBeszerzettV = b[maxind + 1].ev - 1;
			}
			else {
				nemBeszerzettE = -1;
				nemBeszerzettV = -1;
			}

			Console.WriteLine(nemBeszerzettE + " " + nemBeszerzettV);
			
            Console.WriteLine("#");
            int temaDb = 0;

            for(int i = 1; i <= n; ++i) {
                if(temaNemVoltMeg(i)) {
                    temaDb += 1;
                    y.Add(b[i].tkod);
                }
            }

            Tema[] temak = new Tema[temaDb + 1];

            for(int i = 1; i <= temaDb; ++i) {
                temak[i] = temaKonyvDb(i);
            }

            Console.WriteLine(temaDb);
            for(int i = 1; i <= temaDb; ++i) {
                Console.WriteLine(temak[i].tkod + " " + temak[i].darab);
            }
        }
    }
}
