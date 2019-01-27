using System;

namespace MetodoRicorsivo_CalcoloFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserisci un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Il fattoriale di {n} è {Fattoriale(n)}");
            Console.ReadLine();

        }

        static int Fattoriale(int n)
        {
            //il fattoriale di 0 è 1, quindi questo fungerà da escape del loop in cui andrebbe il metodo ricorsivo, infatti n a furia di essere sottratto di 1, diventerà 0
            if (n == 0)
            {
                return 1;
            }
            else
            {   //fattoriale è il risultato di numero moltiplicato per tutti i numeri interi positivi minori o uguali a tale numero
                //esempio: fattoriale di 5 = 5 * 4 * 3 * 2 * 1
                //Fattoriale è qui un metodo ricorsivo, ossia che richiama se stesso
                int risultato = n * Fattoriale(n - 1);
                return risultato;
            }
        }

    }
}
