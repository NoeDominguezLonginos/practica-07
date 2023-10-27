namespace practica_07
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            valor = new TextBox();
            Resultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(91, 72);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 1;
            label2.Text = "ingresa valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 133);
            label3.Name = "label3";
            label3.Size = new Size(273, 23);
            label3.TabIndex = 2;
            label3.Text = "Opciones de conversion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 289);
            label4.Name = "label4";
            label4.Size = new Size(246, 23);
            label4.TabIndex = 3;
            label4.Text = "Resultado en grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(91, 345);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 4;
            label5.Text = "Equivalente en grados";
            // 
            // valor
            // 
            valor.Location = new Point(206, 72);
            valor.Name = "valor";
            valor.Size = new Size(134, 23);
            valor.TabIndex = 5;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(288, 343);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(117, 23);
            Resultado.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(38, 174);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 7;
            button1.Text = "fahrenheit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(206, 174);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 8;
            button2.Text = "centigrados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(130, 231);
            button3.Name = "button3";
            button3.Size = new Size(117, 37);
            button3.TabIndex = 9;
            button3.Text = "borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(525, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Resultado);
            Controls.Add(valor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversiones ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox valor;
        private TextBox Resultado;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}