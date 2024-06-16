using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_G7_Ej1_Clases_De_Num
{
	   /*Este programa tiene por objeto recibir una cierta cantidad de n°,
	determinar cuales son positivos, negativos y ceros,
	y decir la cantidad de positivos y negativos, y el porcentaje de 
	ceros respecto al total.*/
	class Program
	{
		//Declaro variables estáticas para poder usarlas dentro y fuera del ciclo While
		static int Cant;
		static double Num;

		static void Main(string[] args)
		{
			//Declaración de variables a utilizar	
			string cantidad;
			int Negativos = 0, Positivos = 0, Ceros = 0, i, Flag;
			double Porcentaje;

			//Presentación del problema
			Console.WriteLine("Ingresar N números.");
			Console.WriteLine("Imprimir cantidad de positivos,cantidad de negativos");
			Console.WriteLine(" y porcentaje de ceros sobre el total de números ingresados");

			Flag = 0;//Indicador Flag para salir del ciclo While
					 //Si se ingresa el valor correcto, Flag se vuelve 1 y permite salir del ciclo
			while (!(Flag == 1))
			{
				//Se pide la cantidad de n°
				Console.WriteLine("¿Cuantos n° va a ingresar?");
				cantidad = Console.ReadLine();  //El valor ingresado en consola se 
												//guarda en la 	variable string/texto cantidad

				//Ciclo SI para ver si el valor ingresado se puede convertir al tipo INT

				if (int.TryParse(cantidad, out Cant))   /*Tengo int.TryParse, que pretende
															convertir el valor CANTIDAD, valga
															la redundancia, al tipo INT/entero.
															si logra convertirlo, guarda el nuevo
															dato en la variable CANT (out Cant).
															SI SE LOGRA CONVERTIR, EL TRY-PARSE
															TUVO EXITO Y PARA IF CUENTA COMO TRUE*/
				{
					//Lo siguiente es comprobar que se ingreso un valor POSITIVO,
					//con un condicional anidado
					if (Cant > 0)
					{
						Console.WriteLine("Cantidad de n° : " + Cant);//Se muestra esa cantidad en consola
						Flag = 1;   //Como el valor es un n° entero positivo, Flag se vuelve 1, permitiendo
									//salir del ciclo 
					}
					else  //Si el valor es cero o negativo, saldrá un mensaje de error
					{
						Console.WriteLine("LA CANTIDAD ES UN VALOR POSITIVO. INTENTE DE NUEVO");
					}

				}
				else   //Si Try-Parse falla, aparece un mensaje de error
				{
					Console.WriteLine("ERROR. ASEGURESE DE INGRESAR UN N°");
				}

			}
			//Fin del ciclo While

			//Ahora que tenemos la cantidad, hay que cargar esa cantidad de n°, 
			//evaluar cada uno, y cargar los contadores.
			//Para ello usamos otro ciclo While

			i = 0;//Indicador i; sirve de contador para la cantidad de n° a cargar

			//El ciclo while hace un recorrido/iteración por vez
			while (!(i == Cant))
			{
				Flag = 0;   //Indicador Flag para salir del ciclo While
				while (!(Flag == 1))    //Hasta que no se cumplan las condiciones
										//Flag es 0, y no se sale del ciclo
				{
					//Se pide ingreso de datos
					Console.WriteLine("Ingrese el n°" + (i+1) +":");
					string numero = Console.ReadLine(); //El valor ingresado en consola se
														//guarda en la variable tipo texto/string
														//numero
														//Ciclo SI para ver si el valor es numérico
					if (double.TryParse(numero, out Num))   //Try-Parse intenta convertir el valor string
															// al tipo double. Si lo logra, se guarda el 
															//nuevo valor en la variable Num
					{   //si Try-Parse tiene exito,
						//cuenta como true para el condicional if
						//y por eso se cambia el valor de Flag a 1
						Flag = 1;   //Esto hace que podamos salir del ciclo While
					}
					//Si el valor no se puede convertir, no es numérico,
					//por lo que se mostrará un mensaje de error:
					else
					{
						Console.WriteLine("ERROR. TIENE QUE INTRODUCIR UN N°");
					}
				}//FIN CICLO PARA VERIFICAR N°	

				//Cuando tenemos un n°, procede a clasificarlo
				//El primer condicional verifica si el n° es 0
				if (Num == 0)
				{
					Ceros = Ceros + 1;  //Si el n° es 0, crece el contador
				}
				//En caso de ser un n° distinto a 0, verifica si es positivo...
				else
				{
					if (Num > 0)
					{
						Positivos = Positivos + 1;//Si el n° es positivo crece su respectivo contador
					}
					//...o se verifica si es negativo
					else
					{
						Negativos = Negativos + 1;//De ser negativo, crece su contador asignado
					}
				}
				i = i + 1;  //Tras verificar el n°, se cumple una iteración
							//del ciclo, por lo que el contador crece 1 valor
			}

			//Lo último por calcular es el porcentaje de ceros. Como porcentaje es 
			//una variable double, el cálculo se hace convirtiendo los valores de
			//Ceros y Cant de int a double
			Porcentaje = (Convert.ToDouble(Ceros) / Convert.ToDouble(Cant)) * 100;

			//Ya hechos los cálculos, se muestran los resultados en consola
			Console.WriteLine("Cantidad de positivos: " + Positivos);
			Console.WriteLine("Cantidad de negativos: " + Negativos);
			Console.WriteLine("Cantidad de ceros: " + Ceros);
			Console.WriteLine("Porcentaje de ceros: " + Porcentaje + " %");

			//Se da una instrucción para cerrar el programa
			Console.WriteLine("Presione una tecla para cerra el programa");
			Console.ReadKey();
		}
	}
}
