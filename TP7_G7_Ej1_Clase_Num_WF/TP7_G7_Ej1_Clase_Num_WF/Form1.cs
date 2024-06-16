using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7_G7_Ej1_Clase_Num_WF
{   //Tenemos este problema donde se ingresa una cantidad de n°, 
	//se ponen los n°, y el programa determina cual de ellos es 
	//positivo, negativo o cero, y al final muestra las cantidades
	//de pos., neg., y de porcentaje de ceros
	
	public partial class Form1 : Form
	{
		//Declaración de variables
		int cant, Ceros=0,Negativos=0,Positivos=0;
		static string numero;//variable que usaré para el ingreso de datos del InputBox
		static double Num;
		public Form1()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		//EL CODIGO DIDE BUTTON1, PERO ES EL BOTÓN CARGAR, QUE LE DI 
		//DOBLE CLICK PARA ENTRAR AL CÓDIGO Y NO ME FIJE QUE LOS BOTONES NO TENIAN LOS NOMBRES
		private void button1_Click(object sender, EventArgs e)
		{
			//1° guarda la cantidad ingresada en el numericUD 
			cant = Convert.ToInt16(NUDCantidad.Value);//como cant es de tipo int, se convierte el valor
													//del numericUD a dicho tipo
			
			//Ahora solicita al usuario que ingrese el valor de cada n°
			//Para ello recurre a un ciclo for, que tiene un n° de iteraciones
			//igual a la cantidad de n°
			for(int i = 0; i < cant; i++)
			{
				//lo que sigue es que el usuario ingrese n°
				//COMO SOLO QUIERO QUE INGRESEN N°,  PONGO EL INGRESO DE DATOS DENTRO DE UN WHILE
				//Este ciclo tiene un "interruptor" FLAG, que permite que uno pueda salir del ciclo
				int Flag = 1;//	SI FLAG ES 1, EL CICLO PUEDE PEDIR Y VALIDAR EL N°, PERO A LA VEZ,
							//FLAG SE VUELVE 0 PARA SALIR DEL CICLO. Y SIN ESTA DECLARACIÓN, EL VALOR 
							//SEGUIRÁ COMO CERO, SIN PODER PEDIR MÁS N°
				while (Flag==1)
				{
					//aquí sigue el ingreso de n°
					//por lo que recurro a un InputBox, que funciona al estilo del Input de RAPTOR
					//para ello agrego la referencia de Microsoft.VisualBasic
					string orden = "Ingrese el n° " +( i+1)+ ":";
					numero=Microsoft.VisualBasic.Interaction.InputBox(orden, "Ingreso de datos", "1");
					//ARRIBA DE ESTA LINEA ESTA EL INPUTBOX. DENTRO DE LOS PARENTESIS PONE ENTRE
					//COMILLAS 1°: LA INSTRUCCIÓN DE INGRESO, 2°: TITULO DEL INPUTBOX, 3°: EL VALOR QUE QUEDA
					//POR DEFECTO
					//LO QUE INGRESE EL USUARIO SE GUARDA EN EL STRING NUMERO

					//En el siguiente ciclo if recurro a otra función de Microsoft.VisualBasic---> IsNumeric
					//que verifica si un valor es numerico. SI EL VALOR ES NUMERICO, SE CONSIDERA TRUE
					//Y SE EJECUTAN LAS INSTRUCCIONES DENTRO DEL IF, SINO, SE CONSIDERA FALSE, Y SE
					//EJECUTAN LAS INSTRUCCIONES DEL ELSE
					if (Microsoft.VisualBasic.Information.IsNumeric(numero))
					{
						Num = Convert.ToDouble(numero);//Convierte el valor ingresado al tipo double y 
													   //se guarda en la variable Num
													   //Como ya tengo el n°, Flag se vuelve 0 para poder salir del ciclo WHILE
						Flag = 0;
					}
					else
					{	//Si en vez de un n° se pone otro elemento, aparece un mensaje de error
						MessageBox.Show("ERROR, TIENE QUE INGRESAR UN NÚMERO", "ERROR TIPO DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}//si se ejecuta else{}, el ciclo while vuelve a empezar, pidiendo datos y demás
				}

				//Una vez que while obtiene un n°, procede a clasificarlo en un nuevo ciclo IF
				//1° evalua si el n° es cero
				if(Num==0){
					Ceros = Ceros + 1;//En tal caso, se incrementa una unidad el contador asignado
				}
				//De no ser así, evalua si es positivo
				else if(Num>0)
				{
					Positivos = Positivos + 1;// si es positivo, incrementa el contador asignado
				}
				else
				{
					Negativos = Negativos + 1;//Si no es ninguno de esos casos, el n° es negativo,
											//y se incrementa el contador correspondiente	
				}

				//Tras clasificar el n°, muestro ese valor en el ComboBox de Valores
				CBBValores.Items.Add(Num);
				
			}
			//Al final del ciclo for , ya se clasificaron los datos, tenemos los contadores, y solo falta el 
			//porcentaje de ceros. Como los valores son enteros y porcentaje es double, los convierto a double para calcular porcentaje
			double porcentaje = (Convert.ToDouble(Ceros) / Convert.ToDouble(cant)) * 100;

			//Una vez que dispone de los resultados, se muestran en los textbox de resultados
			//para eso convierto dichos valores a la variable string
			TBPositivos.Text = Convert.ToString(Positivos);
			TBNegativos.Text = Convert.ToString(Negativos);
			TBPorcentaje.Text = Convert.ToString(porcentaje);

			//Finalizadas las operaciones, se inhabilita el botón
			BTNCargar.Enabled = false;
		}

		private void BTNLimpiar_Click(object sender, EventArgs e)
		{
			NUDCantidad.Value = 1;//reinicia del NumericUD
			//deja  los textbox de resultados en blanco
			TBNegativos.Text = "";
			TBPorcentaje.Text = "";
			TBPositivos.Text = "";
			CBBValores.Items.Clear();//Limpia el comboBox
			 //Vuelve a habilitar el botón Cargar
			BTNCargar.Enabled = true;
		}

		private void BTNSalir_Click(object sender, EventArgs e)
		{
			DialogResult Wie;
			
			Wie = MessageBox.Show("¿Realmente quiere salir de la aplicación?", "Salir del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if( Wie == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
