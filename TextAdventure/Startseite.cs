using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    internal class Startseite
    {
        bool startedOnce = false;
        public string Execute(/*string currentState*/)
        {
            
                
                startedOnce = true;
                Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(100);
            Console.Write("Schreibe");
            Thread.Sleep(100);
            Console.Write(" \"Start\" ");
            Thread.Sleep(100);
            Console.Write(" um ");
            Thread.Sleep(100);
            Console.Write(" zu ");
            Thread.Sleep(100);
            Console.WriteLine("spielen");
            Thread.Sleep(100);
            string startRead = Console.ReadLine();
                if (startRead.Contains("Start"))
                {
                    
                    return "Gegenstandsauswahl";
                }
                else
                {
                    Console.WriteLine("Achte auf die Rechtschreibung!");
                    string Read = Console.ReadLine();
                    return "Gegenstandsauswahl";
                }
            

        }







    }
}
