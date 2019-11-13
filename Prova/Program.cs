using LibreriaArray;
using System;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            GestioneArray.LeggiArray(array);
            GestioneArray.StampaArray(array);
            Console.ReadLine();
            
        }
    }
}
