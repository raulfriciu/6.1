
namespace ServidorEjercicio_4._1
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
            this.Ejecutar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.NombrePalindro = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Altura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alto = new System.Windows.Forms.RadioButton();
            this.Conectar = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ejecutar
            // 
            this.Ejecutar.Location = new System.Drawing.Point(278, 278);
            this.Ejecutar.Name = "Ejecutar";
            this.Ejecutar.Size = new System.Drawing.Size(193, 70);
            this.Ejecutar.TabIndex = 0;
            this.Ejecutar.Text = "Iniciar";
            this.Ejecutar.UseVisualStyleBackColor = true;
            this.Ejecutar.Click += new System.EventHandler(this.Ejecutar_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(137, 82);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(160, 26);
            this.nombre.TabIndex = 1;
            // 
            // NombrePalindro
            // 
            this.NombrePalindro.AutoSize = true;
            this.NombrePalindro.Location = new System.Drawing.Point(137, 154);
            this.NombrePalindro.Name = "NombrePalindro";
            this.NombrePalindro.Size = new System.Drawing.Size(329, 24);
            this.NombrePalindro.TabIndex = 2;
            this.NombrePalindro.TabStop = true;
            this.NombrePalindro.Text = "Saber si el nombre introducido es palindro";
            this.NombrePalindro.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(137, 194);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(177, 24);
            this.Bonito.TabIndex = 3;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(137, 236);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(179, 24);
            this.Longitud.TabIndex = 4;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Longitud del nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(509, 81);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(100, 26);
            this.Altura.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Altura";
            // 
            // alto
            // 
            this.alto.AutoSize = true;
            this.alto.Location = new System.Drawing.Point(544, 154);
            this.alto.Name = "alto";
            this.alto.Size = new System.Drawing.Size(144, 24);
            this.alto.TabIndex = 8;
            this.alto.TabStop = true;
            this.alto.Text = "Dime si soy alto";
            this.alto.UseVisualStyleBackColor = true;
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(66, 372);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(181, 50);
            this.Conectar.TabIndex = 9;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(484, 372);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(204, 50);
            this.Desconectar.TabIndex = 10;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.alto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Longitud);
            this.Controls.Add(this.Bonito);
            this.Controls.Add(this.NombrePalindro);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.Ejecutar);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ejecutar;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.RadioButton NombrePalindro;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton alto;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Desconectar;
    }
}

