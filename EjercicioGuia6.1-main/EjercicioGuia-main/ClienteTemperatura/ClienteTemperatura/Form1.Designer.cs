
namespace ClienteTemperatura
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
            this.Celsius = new System.Windows.Forms.RadioButton();
            this.Fahrenheit = new System.Windows.Forms.RadioButton();
            this.Temperatura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ejecutar
            // 
            this.Ejecutar.Location = new System.Drawing.Point(264, 278);
            this.Ejecutar.Name = "Ejecutar";
            this.Ejecutar.Size = new System.Drawing.Size(198, 72);
            this.Ejecutar.TabIndex = 0;
            this.Ejecutar.Text = "Iniciar";
            this.Ejecutar.UseVisualStyleBackColor = true;
            this.Ejecutar.Click += new System.EventHandler(this.Ejecutar_Click);
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(200, 147);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(263, 24);
            this.Celsius.TabIndex = 1;
            this.Celsius.TabStop = true;
            this.Celsius.Text = "Pasame de Celsius a Fahrenheit";
            this.Celsius.UseVisualStyleBackColor = true;
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(200, 178);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(263, 24);
            this.Fahrenheit.TabIndex = 2;
            this.Fahrenheit.TabStop = true;
            this.Fahrenheit.Text = "Pasame de Fahrenheit a Celsius";
            this.Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // Temperatura
            // 
            this.Temperatura.Location = new System.Drawing.Point(174, 98);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(164, 26);
            this.Temperatura.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.Ejecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ejecutar;
        private System.Windows.Forms.RadioButton Celsius;
        private System.Windows.Forms.RadioButton Fahrenheit;
        private System.Windows.Forms.TextBox Temperatura;
    }
}

