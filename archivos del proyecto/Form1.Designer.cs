namespace CalculadoraCientifica_v3
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
            this.buffer = new System.Windows.Forms.TextBox();
            this.buttonParentesisAbierto = new System.Windows.Forms.Button();
            this.buttonParentesisCerrado = new System.Windows.Forms.Button();
            this.buttonLimpiarBuffer = new System.Windows.Forms.Button();
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonRestar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.buttonPunto = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buffer
            // 
            this.buffer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buffer.Location = new System.Drawing.Point(12, 12);
            this.buffer.Name = "buffer";
            this.buffer.Size = new System.Drawing.Size(258, 32);
            this.buffer.TabIndex = 1;
            this.buffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buffer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPresionadaEnElBuffer);
            // 
            // buttonParentesisAbierto
            // 
            this.buttonParentesisAbierto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParentesisAbierto.Location = new System.Drawing.Point(12, 50);
            this.buttonParentesisAbierto.Name = "buttonParentesisAbierto";
            this.buttonParentesisAbierto.Size = new System.Drawing.Size(60, 60);
            this.buttonParentesisAbierto.TabIndex = 2;
            this.buttonParentesisAbierto.Text = "(";
            this.buttonParentesisAbierto.UseVisualStyleBackColor = true;
            this.buttonParentesisAbierto.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // buttonParentesisCerrado
            // 
            this.buttonParentesisCerrado.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParentesisCerrado.Location = new System.Drawing.Point(78, 50);
            this.buttonParentesisCerrado.Name = "buttonParentesisCerrado";
            this.buttonParentesisCerrado.Size = new System.Drawing.Size(60, 60);
            this.buttonParentesisCerrado.TabIndex = 3;
            this.buttonParentesisCerrado.Text = ")";
            this.buttonParentesisCerrado.UseVisualStyleBackColor = true;
            this.buttonParentesisCerrado.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // buttonLimpiarBuffer
            // 
            this.buttonLimpiarBuffer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarBuffer.Location = new System.Drawing.Point(144, 50);
            this.buttonLimpiarBuffer.Name = "buttonLimpiarBuffer";
            this.buttonLimpiarBuffer.Size = new System.Drawing.Size(60, 60);
            this.buttonLimpiarBuffer.TabIndex = 4;
            this.buttonLimpiarBuffer.Text = "Limpiar";
            this.buttonLimpiarBuffer.UseVisualStyleBackColor = true;
            this.buttonLimpiarBuffer.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // buttonRetroceder
            // 
            this.buttonRetroceder.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetroceder.Location = new System.Drawing.Point(210, 50);
            this.buttonRetroceder.Name = "buttonRetroceder";
            this.buttonRetroceder.Size = new System.Drawing.Size(60, 60);
            this.buttonRetroceder.TabIndex = 5;
            this.buttonRetroceder.Text = "←";
            this.buttonRetroceder.UseVisualStyleBackColor = true;
            this.buttonRetroceder.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // buttonDividir
            // 
            this.buttonDividir.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDividir.Location = new System.Drawing.Point(210, 116);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(60, 60);
            this.buttonDividir.TabIndex = 9;
            this.buttonDividir.Text = "/";
            this.buttonDividir.UseVisualStyleBackColor = true;
            this.buttonDividir.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(144, 116);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(78, 116);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicar.Location = new System.Drawing.Point(210, 182);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(60, 60);
            this.buttonMultiplicar.TabIndex = 13;
            this.buttonMultiplicar.Text = "*";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            this.buttonMultiplicar.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(144, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(78, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // buttonRestar
            // 
            this.buttonRestar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestar.Location = new System.Drawing.Point(210, 248);
            this.buttonRestar.Name = "buttonRestar";
            this.buttonRestar.Size = new System.Drawing.Size(60, 60);
            this.buttonRestar.TabIndex = 17;
            this.buttonRestar.Text = "-";
            this.buttonRestar.UseVisualStyleBackColor = true;
            this.buttonRestar.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(144, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 16;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(78, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 15;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // buttonSumar
            // 
            this.buttonSumar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSumar.Location = new System.Drawing.Point(210, 314);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(60, 60);
            this.buttonSumar.TabIndex = 21;
            this.buttonSumar.Text = "+";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // buttonResultado
            // 
            this.buttonResultado.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultado.Location = new System.Drawing.Point(144, 314);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(60, 60);
            this.buttonResultado.TabIndex = 20;
            this.buttonResultado.Text = "=";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // buttonPunto
            // 
            this.buttonPunto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPunto.Location = new System.Drawing.Point(78, 314);
            this.buttonPunto.Name = "buttonPunto";
            this.buttonPunto.Size = new System.Drawing.Size(60, 60);
            this.buttonPunto.TabIndex = 19;
            this.buttonPunto.Text = ".";
            this.buttonPunto.UseVisualStyleBackColor = true;
            this.buttonPunto.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(12, 314);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 60);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Enter += new System.EventHandler(this.BotonPresionado);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 390);
            this.Controls.Add(this.buttonSumar);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.buttonPunto);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonRestar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonRetroceder);
            this.Controls.Add(this.buttonLimpiarBuffer);
            this.Controls.Add(this.buttonParentesisCerrado);
            this.Controls.Add(this.buttonParentesisAbierto);
            this.Controls.Add(this.buffer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Cientifica Basica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox buffer;
        private System.Windows.Forms.Button buttonParentesisAbierto;
        private System.Windows.Forms.Button buttonParentesisCerrado;
        private System.Windows.Forms.Button buttonLimpiarBuffer;
        private System.Windows.Forms.Button buttonRetroceder;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonRestar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.Button buttonPunto;
        private System.Windows.Forms.Button button0;
    }
}

