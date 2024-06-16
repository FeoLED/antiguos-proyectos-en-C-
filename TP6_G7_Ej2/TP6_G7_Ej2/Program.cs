using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_G7_Ej2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declaración de variables a utilizar
			double c1, c2, c3, suma, promedio;
			string msje;

			//Presentación del programa
			Console.WriteLine("Determinar si un alumno aprueba o reprueba un curso,");
			Console.WriteLine("sabiendo que aprobará si su promedio de 3 calificaciones");
			Console.WriteLine("Es mayor o igual a 70; reprueba en caso contrario");

			//Tengo definida la función ValidarNum. Asignando a la varable msje la consigna
			//la uso como parametro de la función y obtengo los valores de las calificaciones
			//Si la función returna un N°, este se guarda en la variable de calificación
			Console.WriteLine("Las calificaciones tienen un rango del 0 al 100");//Advertencia del rango de calificaciones

			msje = "Ingrese la calificación 1";
			c1 = FunValidarNum(msje);
			

			msje = "Ingrese la calificación 2";
			c2 = FunValidarNum(msje);
			

			msje = "Ingrese la calificación 3";
			c3 = FunValidarNum(msje);
			

			//Procedo a calcular la suma y el promedio
			suma = c1 + c2 + c3;

			promedio = suma / 3;

			//Tras obtener el promedio, hay que evaluarlo:

			//INICIO CICLO SI
			if (promedio >= 70)//Si el promedio es mayor o igual a 70
			{
				//carga el mensaje de aprobado
				msje = "El promedio es " + promedio + ". El alumno aprobó.";
			}
			else//si no se cumple
			{
				//Carga el mensaje de reprobado
				msje= "El promedio es " + promedio + ". El alumno reprobó.";
			}
			//FIN CICLO SI

			//Solo nos queda mostrar los resultados
			Console.WriteLine(msje);// Se muestra el mensaje que se haya generado en el condicional
			Console.WriteLine("Pulse cualquier tecla para salir");
			Console.ReadKey();
		}

		static double NumReturn;	//variable que retorna la función ValidarNum

		//Función para validar n°, recibe un string msje
		static double FunValidarNum(string msje)
		{
			//Variables locales
			string strNumero;
			double Num;
			Boolean Bandera = true;//variable bandera para manejar el ciclo while

			while (Bandera)//ciclo while para ingresar datos
			{
				Console.WriteLine(msje);	//la variable mensaje tiene una instruccion que se 
											//muestra en pantalla
				strNumero = Console.ReadLine();	//a strNumero se le asigna el valor que haya ingresado el usuario

				//Ciclo if que verifica si lo ingresado es un n°
				if(Double.TryParse(strNumero, out Num))//TryParse intenta convertir strNumero a tipo double
														//si lo logra, lo guarda en la variable Num (out Num)
														//Si esto ocurre con exito, equivale a un verdadero

				{	//No solo necesito que se ingrese un n°, sino que este sea positivo y menor o igual a 100
					//Por lo que pongo un condicional anidado
					if((Num >=0)&&(Num<= 100))	//SI Num es mayor o igual a 0 Y menor o igual a 100
					{
						//Bandera se vuelve False, y podemos salir del ciclo while
						Bandera = false;
						NumReturn = Num;    //se asigna a numReturn el valor numerico correcto
					}
					else
					{//Si se ingresa un n° fuera de rango, aparecerá un mensaje notando el error
						Console.WriteLine("Tiene que ingresar un n° entre 0 y 100");	
					}
					//Fin del ciclo SI anidado
				}
				else//si no se ingreso un n°, tryParse falló, y bandera sigue siendo true
				{
					Bandera = true;
				}
				//Fin del ciclo SI

			}
			return NumReturn;
		}
	}
}