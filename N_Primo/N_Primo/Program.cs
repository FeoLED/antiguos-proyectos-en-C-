using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Primo
{
    class Program
    {
        
        static Int16 intvalue, Flag = 0,numero=0;
        static bool valor;
        static void Main(string[] args)
        {
            while (Flag == 0)
            {
                Console.WriteLine("Ingrese un n°:");
                numero = IntNumber(Console.ReadLine());
            }
            
            bool primo = isPrime(numero);
            if (primo==true)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }
            Console.ReadKey();

        }

        static Int16 IntNumber(string UserInput)
        {
                if (Int16.TryParse(UserInput, out intvalue))
                {
                    Console.WriteLine("El valor es " + intvalue);
                    Flag = 1;//Sale del ciclo
                }
                else
                {
                    Console.WriteLine("Error con el tipo de dato. Vuelva a ingresar");
                }
            return intvalue;
        }
        
        static bool isPrime(Int16 num)
        {
            if (num ==0)
            {
                valor = false;
            }else if (num == 1)
            {
                valor= true;
            }
            else if(num>=2)
            {
                for(int i = 2; i < num; i++)
                {
                    float resto = num % i;
                    if (resto == 0)
                    {
                     valor= false;
                        break;
                    }
                    else
                    {
                       valor= true;
                    }
                }
            }
            return valor;
        }
    }
}