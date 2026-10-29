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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nuevoRegistro = new System.Windows.Forms.Button();
            this.mostNotaMasBaja = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mostREprobados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mostAprobados = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.tablaDeEstudiantes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.mostPromGral = new System.Windows.Forms.TextBox();
            this.busqCodigo = new System.Windows.Forms.TextBox();
            this.mostNotaMasAlta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoRegistro
            // 
            this.nuevoRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nuevoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nuevoRegistro.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoRegistro.Location = new System.Drawing.Point(37, 374);
            this.nuevoRegistro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nuevoRegistro.Name = "nuevoRegistro";
            this.nuevoRegistro.Size = new System.Drawing.Size(268, 69);
            this.nuevoRegistro.TabIndex = 0;
            this.nuevoRegistro.Text = "REGISTRO";
            this.nuevoRegistro.UseVisualStyleBackColor = true;
            this.nuevoRegistro.Click += new System.EventHandler(this.newForm_Click);
            // 
            // mostNotaMasBaja
            // 
            this.mostNotaMasBaja.BackColor = System.Drawing.Color.White;
            this.mostNotaMasBaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostNotaMasBaja.Cursor = System.Windows.Forms.Cursors.Default;
            this.mostNotaMasBaja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostNotaMasBaja.Location = new System.Drawing.Point(931, 202);
            this.mostNotaMasBaja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mostNotaMasBaja.Name = "mostNotaMasBaja";
            this.mostNotaMasBaja.Size = new System.Drawing.Size(66, 18);
            this.mostNotaMasBaja.TabIndex = 12;
            this.mostNotaMasBaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(810, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "NOTA MAS BAJA  :";
            // 
            // mostREprobados
            // 
            this.mostREprobados.BackColor = System.Drawing.Color.White;
            this.mostREprobados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostREprobados.Cursor = System.Windows.Forms.Cursors.Default;
            this.mostREprobados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostREprobados.Location = new System.Drawing.Point(266, 318);
            this.mostREprobados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mostREprobados.Name = "mostREprobados";
            this.mostREprobados.Size = new System.Drawing.Size(66, 18);
            this.mostREprobados.TabIndex = 17;
            this.mostREprobados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(58, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "ESTUDIANTES REPROBADOS    :";
            // 
            // mostAprobados
            // 
            this.mostAprobados.BackColor = System.Drawing.Color.White;
            this.mostAprobados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostAprobados.Cursor = System.Windows.Forms.Cursors.Default;
            this.mostAprobados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostAprobados.Location = new System.Drawing.Point(269, 260);
            this.mostAprobados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mostAprobados.Name = "mostAprobados";
            this.mostAprobados.Size = new System.Drawing.Size(66, 18);
            this.mostAprobados.TabIndex = 15;
            this.mostAprobados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(61, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "ESTUDIANTES APROBADOS     :";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.White;
            this.salir.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.Black;
            this.salir.Location = new System.Drawing.Point(35, 480);
            this.salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(271, 65);
            this.salir.TabIndex = 18;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // tablaDeEstudiantes
            // 
            this.tablaDeEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDeEstudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaDeEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeEstudiantes.Location = new System.Drawing.Point(385, 262);
            this.tablaDeEstudiantes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaDeEstudiantes.Name = "tablaDeEstudiantes";
            this.tablaDeEstudiantes.Size = new System.Drawing.Size(763, 295);
            this.tablaDeEstudiantes.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(121, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "BUSCAR ESTUDIANTE POR CODIGO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "PROMEDIO GENERAL DEL CURSO   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(493, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "NOTA MAS ALTA   :";
            // 
            // buscar
            // 
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buscar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(1035, 143);
            this.buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(88, 23);
            this.buscar.TabIndex = 24;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // mostPromGral
            // 
            this.mostPromGral.BackColor = System.Drawing.Color.White;
            this.mostPromGral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostPromGral.Cursor = System.Windows.Forms.Cursors.Default;
            this.mostPromGral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostPromGral.Location = new System.Drawing.Point(257, 202);
            this.mostPromGral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mostPromGral.Name = "mostPromGral";
            this.mostPromGral.Size = new System.Drawing.Size(66, 18);
            this.mostPromGral.TabIndex = 8;
            this.mostPromGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // busqCodigo
            // 
            this.busqCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.busqCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busqCodigo.Location = new System.Drawing.Point(354, 143);
            this.busqCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.busqCodigo.Name = "busqCodigo";
            this.busqCodigo.Size = new System.Drawing.Size(673, 22);
            this.busqCodigo.TabIndex = 6;
            // 
            // mostNotaMasAlta
            // 
            this.mostNotaMasAlta.BackColor = System.Drawing.Color.White;
            this.mostNotaMasAlta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostNotaMasAlta.Cursor = System.Windows.Forms.Cursors.Default;
            this.mostNotaMasAlta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostNotaMasAlta.Location = new System.Drawing.Point(618, 202);
            this.mostNotaMasAlta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mostNotaMasAlta.Name = "mostNotaMasAlta";
            this.mostNotaMasAlta.Size = new System.Drawing.Size(66, 18);
            this.mostNotaMasAlta.TabIndex = 25;
            this.mostNotaMasAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "SISTEMA DE CONTROL DE RENDIMIENTO ACADEMICO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 131);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "ESTUDIANTIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostNotaMasAlta);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.nuevoRegistro);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "UNIFRNAZ - S.C.R.A.E";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuevoRegistro;
        private System.Windows.Forms.TextBox mostNotaMasBaja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mostREprobados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mostAprobados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.DataGridView tablaDeEstudiantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox mostPromGral;
        private System.Windows.Forms.TextBox busqCodigo;
        private System.Windows.Forms.TextBox mostNotaMasAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

