using LibreriaArray;
using System;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            
            GestioneArray.LeggiArray(array);
            GestioneArray.StampaArray(array);
            int []array2=GestioneArray.CopiaArray(array);
            GestioneArray.StampaArray(array2);
            Console.ReadLine();
            
        }
    }
}
