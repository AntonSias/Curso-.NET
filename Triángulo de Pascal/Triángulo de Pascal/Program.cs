using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triángulo_de_Pascal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] array = new int[1];
            //Mostramos un mensaje y apturamos el dato ingresado desde la consola
            Console.WriteLine("Ingrese el número e pisos");
            pisos = Convert.ToInt16(Console.ReadLine());
            /* Declaramos el primer ciclo for que va recorrer dependiendo
             del dato ingresado que está almacenado en la variable pisos*/

            for (int i = 0; i <= pisos; i++)
            {
                /*Colocamos un arreglo y colocamos la variable i del ciclo for  que será
                 el tamaño que tendrá el arreglo cada vez que el ciclo for
                se ejecute*/
                int[] pascal = new int[i];
                for (int j = pisos; j < i ; j++)
                {
                    Console.Write(" ");
                }
                //Ciclo for que genera la sumas de las cifras
                for (int k = 0; k < i; k++)
                {
                    //Condición que evalua la variable del ciclo for
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        //Sumamos los números que están en cada posición
                        //del array para formar el triángulo
                        pascal[k] = array[k] + array [k - 1];
                    }
                    Console.Write("[" + pascal[k] + "]");
                }
                array  = pascal;
                Console.WriteLine("");
            }
            Console.ReadLine();
    
        }
    }
}
