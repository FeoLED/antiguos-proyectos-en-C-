using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APROBO_REPROBO_Formulario
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void BtnSalir_Click(object sender, EventArgs e)
		{
			//Código del botón Salir

			DialogResult MiOpcion; //DResult es el 
			MiOpcion = MessageBox.Show("¿Desea cerrar el programa?", "Salir de la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

			if (MiOpcion == DialogResult.Yes)
			{
				Close(); //Se cierra la aplicación
			}
			
		}

		private void BtnCalcular_Click(object sender, EventArgs e)
		{
			//Variables a utilizar
			double c1, c2, c3, suma, promedio;
			string msje;

			//Asignamos a las variables de calificaciones los datos ingresados
			/*Convertimos al tipo Double el valor ingresado en el textBox de 
			las calificaciones, y estos los asignamos a las variables para
			calcular c1, c2, c3
			 */
			c1 = Convert.ToDouble(TxtCalificacion1.Text); /*lo que tenemos detro de los parentesis
														lo converntimos a Double, y una vez que fue
														convertido, guardamos el nuevo valor el la 
														variable c
													*/
			c2 = Convert.ToDouble(TxtCalificacion2.Text);
			c3 = Convert.ToDouble(TxtCalificacion3.Text);

			//Calculamos  el promedio
			suma = c1 + c2 + c3;
			promedio = suma / 3;

			//hacemos un condicional para determinar el mensaje de resultado
			if (promedio >= 70)
			{	//Si el promedio es mayor o igual a 70, el mensaje es de aprobado
				msje="Aprobó";
			}
			else
			{	//Sino, el mensaje es de reprobado
				msje = "Reprobó";
			}

			//Presentamos los resultados
			//Como promedio es de tipo numérico, tengo que convertirlo a string
			//antes de poder mostrarlo en el textBox de Promedio
			TxtPromedio.Text = Convert.ToString(promedio);

			//Además, coloco el mensaje generado para el textBox de AproboReprobo
			TxtAproboReprobo.Text = msje;


			//Una vez que realizó los calculos, se desactiva el botón Calcular
			BtnCalcular.Enabled = false;
		}

		private void BtnLimpiar_Click(object sender, EventArgs e)
		{//Codigo del botón Limpiar
			//Borra el contenido de los cuadros de texto
			TxtCalificacion1.Text = "";
			TxtCalificacion2.Text = "";
			TxtCalificacion3.Text = "";
			TxtPromedio.Text = "";
			TxtAproboReprobo.Text = "";

			BtnCalcular.Enabled = true;//Vuelve a validar el botón Calcular
		}

		

	}
}
