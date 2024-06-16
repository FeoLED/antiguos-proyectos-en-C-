namespace TP7_G7_Ej1_Clase_Num_WF
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.BTNCargar = new System.Windows.Forms.Button();
			this.BTNLimpiar = new System.Windows.Forms.Button();
			this.BTNSalir = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.TBPositivos = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TBNegativos = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.TBPorcentaje = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.CBBValores = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Gold;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 92);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Situación Problemática";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.NUDCantidad);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Gold;
			this.groupBox2.Location = new System.Drawing.Point(12, 120);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(417, 106);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ingreso de Datos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cantidad de números";
			// 
			// NUDCantidad
			// 
			this.NUDCantidad.Location = new System.Drawing.Point(246, 40);
			this.NUDCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NUDCantidad.Name = "NUDCantidad";
			this.NUDCantidad.Size = new System.Drawing.Size(100, 30);
			this.NUDCantidad.TabIndex = 1;
			this.NUDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.Gold;
			this.groupBox3.Location = new System.Drawing.Point(12, 232);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(417, 141);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Números Ingresados";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.CBBValores);
			this.groupBox4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.Gold;
			this.groupBox4.Location = new System.Drawing.Point(0, 20);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(417, 121);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.BTNSalir);
			this.groupBox6.Controls.Add(this.BTNLimpiar);
			this.groupBox6.Controls.Add(this.BTNCargar);
			this.groupBox6.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox6.ForeColor = System.Drawing.Color.Gold;
			this.groupBox6.Location = new System.Drawing.Point(435, 120);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(353, 253);
			this.groupBox6.TabIndex = 3;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Procedimientos";
			// 
			// BTNCargar
			// 
			this.BTNCargar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BTNCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNCargar.Location = new System.Drawing.Point(52, 40);
			this.BTNCargar.Name = "BTNCargar";
			this.BTNCargar.Size = new System.Drawing.Size(264, 52);
			this.BTNCargar.TabIndex = 0;
			this.BTNCargar.Text = "Cargar";
			this.BTNCargar.UseVisualStyleBackColor = false;
			this.BTNCargar.Click += new System.EventHandler(this.button1_Click);
			// 
			// BTNLimpiar
			// 
			this.BTNLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BTNLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNLimpiar.Location = new System.Drawing.Point(52, 112);
			this.BTNLimpiar.Name = "BTNLimpiar";
			this.BTNLimpiar.Size = new System.Drawing.Size(264, 52);
			this.BTNLimpiar.TabIndex = 1;
			this.BTNLimpiar.Text = "Limpiar";
			this.BTNLimpiar.UseVisualStyleBackColor = false;
			this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
			// 
			// BTNSalir
			// 
			this.BTNSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNSalir.Location = new System.Drawing.Point(52, 185);
			this.BTNSalir.Name = "BTNSalir";
			this.BTNSalir.Size = new System.Drawing.Size(264, 52);
			this.BTNSalir.TabIndex = 2;
			this.BTNSalir.Text = "Salir";
			this.BTNSalir.UseVisualStyleBackColor = false;
			this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(754, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Ingresar N números. Imprimir cantidad de positivos,cantidad de negativos";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(599, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "y porcentaje de ceros sobre el total de números ingresados.";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.label10);
			this.groupBox7.Controls.Add(this.TBPorcentaje);
			this.groupBox7.Controls.Add(this.label9);
			this.groupBox7.Controls.Add(this.TBNegativos);
			this.groupBox7.Controls.Add(this.label8);
			this.groupBox7.Controls.Add(this.TBPositivos);
			this.groupBox7.Controls.Add(this.label7);
			this.groupBox7.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox7.ForeColor = System.Drawing.Color.Gold;
			this.groupBox7.Location = new System.Drawing.Point(12, 379);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(776, 106);
			this.groupBox7.TabIndex = 4;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Resultados";
			// 
			// TBPositivos
			// 
			this.TBPositivos.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBPositivos.Location = new System.Drawing.Point(258, 22);
			this.TBPositivos.Name = "TBPositivos";
			this.TBPositivos.Size = new System.Drawing.Size(66, 30);
			this.TBPositivos.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(233, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "Cantidad de positivos:";
			// 
			// TBNegativos
			// 
			this.TBNegativos.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBNegativos.Location = new System.Drawing.Point(258, 62);
			this.TBNegativos.Name = "TBNegativos";
			this.TBNegativos.Size = new System.Drawing.Size(66, 30);
			this.TBNegativos.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(13, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(239, 23);
			this.label8.TabIndex = 5;
			this.label8.Text = "Cantidad de negativos:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(372, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(212, 23);
			this.label9.TabIndex = 7;
			this.label9.Text = "Porcentaje de ceros:";
			// 
			// TBPorcentaje
			// 
			this.TBPorcentaje.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBPorcentaje.Location = new System.Drawing.Point(605, 36);
			this.TBPorcentaje.Name = "TBPorcentaje";
			this.TBPorcentaje.Size = new System.Drawing.Size(66, 30);
			this.TBPorcentaje.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(692, 39);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(26, 23);
			this.label10.TabIndex = 9;
			this.label10.Text = "%";
			// 
			// CBBValores
			// 
			this.CBBValores.FormattingEnabled = true;
			this.CBBValores.Location = new System.Drawing.Point(17, 43);
			this.CBBValores.Name = "CBBValores";
			this.CBBValores.Size = new System.Drawing.Size(291, 31);
			this.CBBValores.TabIndex = 1;
			this.CBBValores.Text = "Valores";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 497);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Determinar Positivos, Negativos, Ceros";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown NUDCantidad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button BTNSalir;
		private System.Windows.Forms.Button BTNLimpiar;
		private System.Windows.Forms.Button BTNCargar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TextBox TBNegativos;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TBPositivos;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox TBPorcentaje;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox CBBValores;
	}
}

