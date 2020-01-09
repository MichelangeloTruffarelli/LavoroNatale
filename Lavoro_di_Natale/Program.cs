using System;

namespace Lavoro_di_Natale
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            //viene stampato il numero massimo che un int può contenere
            Console.WriteLine(a); 
            if (a = int.MaxValue)
            {
                Console.WriteLine(a + 1); 
            }
            //viene assegnato un valore alla variabile b;
            int b = -128; 
            //alla variabile c viene assegnato il valore dell'opposto della variabile b;
            int c = -b;  
            //si converte in binario il valore della variabile b;
            Console.WriteLine(Convert.ToString(b, 2)); 
            //si converte in binario il valore della variabile c; 
            Console.WriteLine(Convert.ToString(c, 2)); 
            Console.WriteLine("Inserisci un numero intero: ");
            int value = 31;
            int somma = value;
            value = ~value + 1; 
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}"); 
            long number = 55555;
            //si converte in binario il valore della variabile number
            Console.WriteLine(Convert.ToString(number, 2)); 
            //il valore number da long si trasforma a short
            short number1 = (short)number; 
            //si stampa il valore di number1 
            //il valore è sbagliato perchè il numero long è 55555 mentre le variabili short vanno da da -32,768 a 32,767. 
            //Il codice trova un'eccezione e quindi va in overflow e stampa -9981.Numero negativo. 
            Console.WriteLine(number1); 
            Console.ReadLine();
        }
    }
}
