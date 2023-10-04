using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalePuntato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] decimalePuntato= new int[4];
            bool[] binario= new bool[32];    
            for (int i = 0; i<decimalePuntato.Length; i++)
            {
                Console.WriteLine($"Inserisci il {i+1}° numero in decimale puntato");
                decimalePuntato[i]=Convert.ToInt32(Console.ReadLine());
            }
            binario= ConvertDpToBin(decimalePuntato);
            for (int i = 0;i<binario.Length;i++)
            {
                Console.Write(Convert.ToInt32(binario[i]));
            }

            Console.WriteLine();
            Console.ReadLine();
        }
        static bool[] ConvertDpToBin(int[] a)
        {
            bool[] booleano = new bool[32];
            int j = booleano.Length - 1;  

            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i];
                for (int y = 0; y < 8; y++)
                {
                    booleano[j] = n % 2 == 1;  
                    n /= 2;
                    j--;
                }
            }
            return booleano;
        }
    }
}
