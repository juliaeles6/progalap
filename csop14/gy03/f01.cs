namespace gy03f01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg egy honap sorszamat: ");

            string s = Console.ReadLine();
            int h = int.Parse(s);

            while(h < 1 || h > 12)
            {
                Console.WriteLine("Rossz bemenet!");
                Console.WriteLine("Add meg egy honap sorszamat: ");

                s = Console.ReadLine();
                h = int.Parse(s);
            }

            
            int[] NAP = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            string[] EVSZAK = { "tel", "tel", "tavasz", "tavasz", "tavasz", "nyar", "nyar", "nyar", "osz", "osz", "osz", "tel" };

            int nap = NAP[h - 1];
            string evszak = EVSZAK[h - 1];

            Console.WriteLine("Evszak: " + evszak);
            Console.WriteLine("Napok szama: " + nap);
        }
    }
}