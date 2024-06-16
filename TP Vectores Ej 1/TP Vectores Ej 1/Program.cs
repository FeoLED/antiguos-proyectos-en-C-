using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Vectores_Ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un vector con n valores varios generados de manera er}
            var rand= new Random();

            double[] V = new double [10];
            for(int i = 0; i < V.Length; i++)
            {
                V[i] = rand.Next(1,20);
                Console.WriteLine(" "+V[i]);
            }

            double suma=0,prom=0;
            for (var j = 0; j < 5; j++)
            {
                suma += V[j];
            }
            prom = suma / 5;
            Console.WriteLine("La suma de los 1° 5 elementos es " + suma + ". Promedio de los 1° 5 elementos es " + prom);

            suma = prom = 0;
            for(int k = 5; k < 10; k++)
            {
                suma += V[k];
            }
            prom = suma / 5;
            Console.WriteLine("La suma de los últimos 5 elementos es " + suma + ". Promedio de dichos elementos: " + prom);
            Console.ReadKey();
        }
    }
}
