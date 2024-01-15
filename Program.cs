using System;

namespace ejercicio7Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10, 45, 60, 6, 7, 3, 2, 10 };

            int longitud = Array.Length(numeros);

            int primerValor = numeros[0];
            int penultimoValor = numeros[Array.IndexOf(numeros, numeros.Last()) - 1];
            int ultimoValor = numeros[numeros.Length - 1];

            Array.Sort(numeros);

            numeros[numeros.Length - 1] = 100;
           
            Array.Reverse(numeros);

            int[] array2 = { 45, 56, 2, -1, 98, 34 };
            int longitudArray2 = Array.Length(array2);
            int penultimoValorArray2 = array2[array2.Length - 2];
            int primerValorArray2 = array2[0];
            int ultimoValorArray2 = array2[array2.Length - 1];


        }
    }
}