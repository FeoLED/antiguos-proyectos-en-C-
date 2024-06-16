namespace APROBO_REPROBO_Formulario
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtCalificacion1 = new System.Windows.Forms.TextBox();
			this.TxtCalificacion2 = new System.Windows.Forms.TextBox();
			this.TxtCalificacion3 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.BtnLimpiar = new System.Windows.Forms.Button();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.Resultados = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtPromedio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtAproboReprobo = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.Resultados.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(26, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(690, 53);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Determinar si un alumno aprueba o reprueba un curso, sabiendo que aprobará si su " +
    "promedio de tres calificaciones es mayor o igual a 70; reprueba en caso contrari" +
    "o";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtCalificacion3);
			this.groupBox1.Controls.Add(this.TxtCalificacion2);
			this.groupBox1.Controls.Add(this.TxtCalificacion1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(39, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(302, 187);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Calificaciones";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calificación 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Calificación 2 ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Calificación 3";
			// 
			// TxtCalificacion1
			// 
			this.TxtCalificacion1.Location = new System.Drawing.Point(164, 33);
			this.TxtCalificacion1.Name = "TxtCalificacion1";
			this.TxtCalificacion1.Size = new System.Drawing.Size(100, 26);
			this.TxtCalificacion1.TabIndex = 3;
			// 
			// TxtCalificacion2
			// 
			this.TxtCalificacion2.Location = new System.Drawing.Point(164, 78);
			this.TxtCalificacion2.Name = "TxtCalificacion2";
			this.TxtCalificacion2.Size = new System.Drawing.Size(100, 26);
			this.TxtCalificacion2.TabIndex = 4;
			// 
			// TxtCalificacion3
			// 
			this.TxtCalificacion3.Location = new System.Drawing.Point(164, 118);
			this.TxtCalificacion3.Name = "TxtCalificacion3";
			this.TxtCalificacion3.Size = new System.Drawing.Size(100, 26);
			this.TxtCalificacion3.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.BtnSalir);
			this.groupBox2.Controls.Add(this.BtnLimpiar);
			this.groupBox2.Controls.Add(this.BtnCalcular);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(376, 83);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(326, 187);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Procesos";
			// 
			// BtnCalcular
			// 
			this.BtnCalcular.Location = new System.Drawing.Point(92, 25);
			this.BtnCalcular.Name = "BtnCalcular";
			this.BtnCalcular.Size = new System.Drawing.Size(153, 31);
			this.BtnCalcular.TabIndex = 0;
			this.BtnCalcular.Text = "Calcular";
			this.BtnCalcular.UseVisualStyleBackColor = true;
			this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
			// 
			// BtnLimpiar
			// 
			this.BtnLimpiar.Location = new System.Drawing.Point(92, 75);
			this.BtnLimpiar.Name = "BtnLimpiar";
			this.BtnLimpiar.Size = new System.Drawing.Size(153, 32);
			this.BtnLimpiar.TabIndex = 1;
			this.BtnLimpiar.Text = "Limpiar";
			this.BtnLimpiar.UseVisualStyleBackColor = true;
			this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// BtnSalir
			// 
			this.BtnSalir.Location = new System.Drawing.Point(92, 121);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(153, 35);
			this.BtnSalir.TabIndex = 2;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.UseVisualStyleBackColor = true;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			// 
			// Resultados
			// 
			this.Resultados.Controls.Add(this.TxtAproboReprobo);
			this.Resultados.Controls.Add(this.label5);
			this.Resultados.Controls.Add(this.TxtPromedio);
			this.Resultados.Controls.Add(this.label4);
			this.Resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Resultados.Location = new System.Drawing.Point(39, 286);
			this.Resultados.Name = "Resultados";
			this.Resultados.Size = new System.Drawing.Size(663, 84);
			this.Resultados.TabIndex = 3;
			this.Resultados.TabStop = false;
			this.Resultados.Text = "Resultados";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "El promedio es";
			// 
			// TxtPromedio
			// 
			this.TxtPromedio.Location = new System.Drawing.Point(164, 37);
			this.TxtPromedio.Name = "TxtPromedio";
			this.TxtPromedio.Size = new System.Drawing.Size(100, 26);
			this.TxtPromedio.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(290, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "El alumno";
			// 
			// TxtAproboReprobo
			// 
			this.TxtAproboReprobo.Location = new System.Drawing.Point(409, 37);
			this.TxtAproboReprobo.Name = "TxtAproboReprobo";
			this.TxtAproboReprobo.Size = new System.Drawing.Size(152, 26);
			this.TxtAproboReprobo.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 377);
			this.Controls.Add(this.Resultados);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "DETERMINAR APROBADO/REPROBADO";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.Resultados.ResumeLayout(false);
			this.Resultados.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TxtCalificacion3;
		private System.Windows.Forms.TextBox TxtCalificacion2;
		private System.Windows.Forms.TextBox TxtCalificacion1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.Button BtnLimpiar;
		private System.Windows.Forms.Button BtnCalcular;
		private System.Windows.Forms.GroupBox Resultados;
		private System.Windows.Forms.TextBox TxtAproboReprobo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtPromedio;
		private System.Windows.Forms.Label label4;
	}
}

