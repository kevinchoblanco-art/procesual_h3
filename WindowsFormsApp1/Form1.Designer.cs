namespace WindowsFormsApp1
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
            this.nuevoRegistro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mostNotaMasBaja = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mostREprobados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mostAprobados = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.tablaDeEstudiantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.mostPromGral = new System.Windows.Forms.TextBox();
            this.busqCodigo = new System.Windows.Forms.TextBox();
            this.mostNotaMasAlta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoRegistro
            // 
            this.nuevoRegistro.Location = new System.Drawing.Point(112, 374);
            this.nuevoRegistro.Name = "nuevoRegistro";
            this.nuevoRegistro.Size = new System.Drawing.Size(230, 69);
            this.nuevoRegistro.TabIndex = 0;
            this.nuevoRegistro.Text = "REGISTRAR NUEVO ESTUDAINTE";
            this.nuevoRegistro.UseVisualStyleBackColor = true;
            this.nuevoRegistro.Click += new System.EventHandler(this.newForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "S. C. R. A. E.";
            // 
            // mostNotaMasBaja
            // 
            this.mostNotaMasBaja.Location = new System.Drawing.Point(840, 204);
            this.mostNotaMasBaja.Name = "mostNotaMasBaja";
            this.mostNotaMasBaja.Size = new System.Drawing.Size(57, 20);
            this.mostNotaMasBaja.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(741, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "NOTA MAS BAJA";
            // 
            // mostREprobados
            // 
            this.mostREprobados.Location = new System.Drawing.Point(287, 312);
            this.mostREprobados.Name = "mostREprobados";
            this.mostREprobados.Size = new System.Drawing.Size(57, 20);
            this.mostREprobados.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ESTUDIANTES REPROBADOS";
            // 
            // mostAprobados
            // 
            this.mostAprobados.Location = new System.Drawing.Point(287, 262);
            this.mostAprobados.Name = "mostAprobados";
            this.mostAprobados.Size = new System.Drawing.Size(57, 20);
            this.mostAprobados.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ESTUDIANTES APROBADOS";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Crimson;
            this.salir.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salir.Location = new System.Drawing.Point(110, 480);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(232, 65);
            this.salir.TabIndex = 18;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = false;
            // 
            // tablaDeEstudiantes
            // 
            this.tablaDeEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeEstudiantes.Location = new System.Drawing.Point(410, 262);
            this.tablaDeEstudiantes.Name = "tablaDeEstudiantes";
            this.tablaDeEstudiantes.Size = new System.Drawing.Size(654, 295);
            this.tablaDeEstudiantes.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "SISTEMA DE CONTROL DE RENDIMIENTO ACADEMICO ESTUDIANTIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "BUSCAR ESTUDIANTE POR CODIGO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "PROMEDIO GENERAL DEL CURSO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "NOTA MAS ALTA";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(822, 141);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 24;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // mostPromGral
            // 
            this.mostPromGral.Location = new System.Drawing.Point(384, 204);
            this.mostPromGral.Name = "mostPromGral";
            this.mostPromGral.Size = new System.Drawing.Size(57, 20);
            this.mostPromGral.TabIndex = 8;
            // 
            // busqCodigo
            // 
            this.busqCodigo.Location = new System.Drawing.Point(384, 143);
            this.busqCodigo.Name = "busqCodigo";
            this.busqCodigo.Size = new System.Drawing.Size(429, 20);
            this.busqCodigo.TabIndex = 6;
            // 
            // mostNotaMasAlta
            // 
            this.mostNotaMasAlta.Location = new System.Drawing.Point(653, 204);
            this.mostNotaMasAlta.Name = "mostNotaMasAlta";
            this.mostNotaMasAlta.Size = new System.Drawing.Size(57, 20);
            this.mostNotaMasAlta.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 618);
            this.Controls.Add(this.mostNotaMasAlta);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaDeEstudiantes);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.mostREprobados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mostAprobados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mostNotaMasBaja);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mostPromGral);
            this.Controls.Add(this.busqCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nuevoRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuevoRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mostNotaMasBaja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mostREprobados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mostAprobados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.DataGridView tablaDeEstudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox mostPromGral;
        private System.Windows.Forms.TextBox busqCodigo;
        private System.Windows.Forms.TextBox mostNotaMasAlta;
    }
}

