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
            Console.WriteLine("");

        }
        public static int[] CopiaArray(int[] array)
        {
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
               

            return array2;
        }
        public static bool RicercaArray(int [] array, int elemento)
        {
            bool ricerca = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    ricerca = true;
            }
            return ricerca;
        }
        public static bool SonoUguali(int [] array1, int [] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risultato = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    risultato = false;
            }
            return risultato;
        }
        public static int CercaMax(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public static int CercaMin(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        public static bool Crescente (int [] array)
        {
            bool risposta = true;
            for ( int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                    risposta = false;
            }
            return risposta;
        }
        public static bool Decrescente(int[] array)
        {
            bool risultato = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                    risultato = false;
            }
            return risultato;
            
        }
        public static void RiempiArray(int [] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(); ;
            }

        }
        public static int[] UnisciArray(int[] array1, int[] array2)
        {
            int []Merge = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                Merge[i] = array1[i];
            }
            for (int i = array1.Length+1; i < Merge.Length; i++)
            {
                Merge[i] = array2[i-array1.Length];
            }
            return Merge ;

        }
    }
}
