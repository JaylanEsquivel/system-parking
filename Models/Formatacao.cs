using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace system_parking.Models
{
    public struct Formatacao
    {
        public void QuebraLinha() { 
                Console.WriteLine("");
                Console.WriteLine("Precione enter para prosseguir:");
                Console.ReadLine();
                Console.Clear();
        }
        public void PularLinha() { 
                Console.WriteLine("_____________________________________");
                Console.WriteLine("");
        }

    }
}