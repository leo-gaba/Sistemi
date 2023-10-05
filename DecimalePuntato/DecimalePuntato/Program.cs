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
            //dichiarazione variabili
            int[] decimalePuntato= new int[4];
            bool[] binario= new bool[32];

            //ciclo for per inserire i numeri in decimale puntato
            for (int i = 0; i<decimalePuntato.Length; i++)
            {
                Console.WriteLine($"Inserisci il {i+1}° numero in decimale puntato");
                decimalePuntato[i]=Convert.ToInt32(Console.ReadLine());
            }

            //invocazione e stampa del metodo per convertire da decimale puntato in binario
            binario= ConvertDpToBin(decimalePuntato);
            for (int i = 0;i<binario.Length;i++)
            {
                Console.Write(Convert.ToInt32(binario[i]));
            }
            Console.WriteLine();
            Console.WriteLine();
            //invocazione e stampa del metodo per convertire da decimale puntato in intero
            Console.Write("Conversione da decimale puntato a intero: ");
            Console.Write(ConvertDpToIntero(decimalePuntato));
            
            Console.WriteLine();
            Console.WriteLine();
            //invocazione e stampa del metodo per convertire da binario in intero
            Console.Write("Conversione da binario a intero:");
            Console.Write(ConvertBinToIntero(binario));

            Console.WriteLine();
            Console.WriteLine();
            //invocazione e stampa del metodo per convertire da binario in decimale
            Console.Write("Conversione da binario a decimale:");
            Console.Write(ConvertBinToDec(binario));


            Console.ReadLine();
        }
        //metodo per convertire da decimale puntato a binario
        static bool[] ConvertDpToBin(int[] a)
        {
            bool[] booleano = new bool[32];
            int pos = booleano.Length - 1;  

            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i];
                for (int y = 0; y < 8; y++)
                {
                    booleano[pos] = n % 2 == 1;  
                    n /= 2;
                    pos--;
                }
            }
            return booleano;
        }
        //metodo per convertire da decimale puntato a intero
        static int ConvertDpToIntero(int[] a)
        {
            int dec = 0, pos=3;
            for (int i = 0; i < a.Length; i++)
            {
                dec += a[i] * (int)Math.Pow(256, pos--);
            }
            return dec;
        }
        //metodo per convertire da binario a intero
        static int ConvertBinToIntero(bool[] a)
        {
            int pos = a.Length - 1;
            int intero = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i])
                {
                    intero += (int)Math.Pow(2, pos);
                }
                pos--;
            }
            return intero;
        }
        //metodo per convertire da binario a decimale
        static int ConvertBinToDec(bool[] a)
        {
            int dec = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i])
                {
                    dec += (int)Math.Pow(2, a.Length - 1 - i);
                }
            }
            return dec;
        }
    }
}
