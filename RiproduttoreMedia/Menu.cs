using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiproduttoreMedia
{
    internal class Menu
    {
        public static void StartMenu()
        { 
            Console.WriteLine("per far partire un brano digita 'V', per iniziare un film digita 'M'");
        }

        public static void SelectContent()
        {
            Console.WriteLine("seleziona il numero del contenuto da riprodurre");
        }

        public static void MediaRunning()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("per il prossimo contenuto premi 'F'");
            Console.WriteLine("per il precedente contenuto premi 'B'");
            Console.WriteLine("per il prossimo contenuto premi 'P'");
            Console.WriteLine("per il prossimo contenuto premi 'S'");
        }
    }
}
