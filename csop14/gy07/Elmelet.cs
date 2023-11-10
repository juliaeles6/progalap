namespace elmelet {
    internal class Elmelet {
       
        static void Main(string[] args) {
            // Mátrixok C#-ban:
            // mátrixokat hasonlóan jelentünk be, mint tömböket:
            // típus[,] név = new típus[sorok száma, oszlopok száma]
            // például:
            int n = 5;
            int m = 7;

            string[,] szovegMatrix = new string[n, m]; // n soros, m oszlopos szövegből álló mátrix

            szovegMatrix[1, 3] = "Ez a mátrix 1. sorának 3. eleme";

            // Több adat beolvasása egy sorból:
            // Ugyanúgy a Split függvényt használjuk, csak a Mesteren/Bírón sajnos néha becsúsznak olyan sorok, ahol több szóköz van egymás mellett. Ilyenkor a Split függvény betesz egy üres szöveget a tömbbe - ami nekünk nyilván nem jó.
            // Ilyenkor a következőt tehetjük:

            string[] uresNelkul = "Itt   mar nem lesznek   ures    szovegek".Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Van amikor a fenti függvény nem akar így együttműködni velünk, de ez a következőképpen orvosolható:

            string[] uresNelkulv2 = "Itt   mar nem lesznek   ures    szovegek".Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            // Ennek oka: ez a verziója a Split függvénynek csak a 6.0-s verzióban került be. Azelőtt is lehet használni a StringSplitOptions.RemoveEmptyEntries opciót, csak rá kell kényszeríteni a fordítót, hogy azt ő ne felsorolásként értelmezze (ami tulajdonképpen int), hanem karakterként.

            // Több a Split függvényről: https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-7.0#system-string-split(system-char-system-stringsplitoptions

            // A következő órán megnézzük ennek egy másik alternatíváját, LINQ függvényekkel
        }
    }
}
