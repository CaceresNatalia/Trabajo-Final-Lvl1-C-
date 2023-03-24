using System;

namespace TPFinal_Caceres
{
    class Program
    {
        static void Main(string[] args)
        {
        //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
        //A partir de dichos datos informar:

        // a. El mayor de los números pares.
        // b. La cantidad de números impares.
        // c. El menor de los números primos.

        // Nota: evaluar el uso de una función que analice si un número dado
        //es primo o no y que devuelva true o false según corresponda.

        int n, maxPar=0, conImpar=0, menorPrimo=0;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());

        while (n != 0){
            maxPar = n;
            if (n % 2 == 0){
                if(n > maxPar)
                    maxPar = n;
            } else
                    conImpar++;
        
            if (esPrimo(n)){
                if (menorPrimo == 0)
                    menorPrimo = n;
                else if (n < menorPrimo)
                    menorPrimo = n;
                }
            
            
            
            Console.WriteLine("Ingrese otro número o cero para finalizar: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("El mayor de los números pares es " + maxPar);
        Console.WriteLine("La cantidad de números impares es " + conImpar);
        if(menorPrimo == 0)
            Console.WriteLine("No hay números primos");
        else
            Console.WriteLine("El menor de los números primos es " + menorPrimo);


         }

         static bool esPrimo(int a){
            int con=0;
            for (int x = 1; x <= a; x++){
                if (a % x == 0)
                    con++;
            }

            if (con == 2)
                return true;
            else
                return false;
         }
    }
}
