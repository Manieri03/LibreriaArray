using System;

namespace LibreriaArray
{
    public class GestioneArray
    {
        public static void LeggiArray(int[] array)
        {
            for(int i =0;i<array.Length; i++)
            {
                Console.WriteLine($"Inserisci l numero in posizione {i}");
                int a = int.Parse(Console.ReadLine());
                array[i] = a;
            }

        }
        public static void StampaArray(int[] array)
        {
            Console.WriteLine("I valori sono: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

        }

    }
}
