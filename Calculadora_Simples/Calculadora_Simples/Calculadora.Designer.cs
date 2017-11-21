namespace Calculadora_Simples
{
    partial class Calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lbl_texto_confirma;
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.txt_N2 = new System.Windows.Forms.TextBox();
            this.txt_N1 = new System.Windows.Forms.TextBox();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            lbl_texto_confirma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_texto_confirma
            // 
            lbl_texto_confirma.AutoSize = true;
            lbl_texto_confirma.BackColor = System.Drawing.Color.Transparent;
            lbl_texto_confirma.Enabled = false;
            lbl_texto_confirma.ForeColor = System.Drawing.Color.DarkGreen;
            lbl_texto_confirma.Location = new System.Drawing.Point(59, 143);
            lbl_texto_confirma.Name = "lbl_texto_confirma";
            lbl_texto_confirma.Size = new System.Drawing.Size(128, 13);
            lbl_texto_confirma.TabIndex = 10;
            lbl_texto_confirma.Text = "Executado com Sucesso!";
            lbl_texto_confirma.Visible = false;
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(78, 72);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(25, 23);
            this.btn_soma.TabIndex = 0;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.Location = new System.Drawing.Point(109, 72);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(25, 23);
            this.btn_subtrair.TabIndex = 1;
            this.btn_subtrair.Text = "-";
            this.btn_subtrair.UseVisualStyleBackColor = true;
            this.btn_subtrair.Click += new System.EventHandler(this.btn_subtrair_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(140, 72);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(25, 23);
            this.btn_dividir.TabIndex = 2;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(171, 72);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(25, 23);
            this.btn_multiplicar.TabIndex = 3;
            this.btn_multiplicar.Text = "X";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // txt_N2
            // 
            this.txt_N2.Location = new System.Drawing.Point(62, 46);
            this.txt_N2.Name = "txt_N2";
            this.txt_N2.Size = new System.Drawing.Size(118, 20);
            this.txt_N2.TabIndex = 4;
            // 
            // txt_N1
            // 
            this.txt_N1.Location = new System.Drawing.Point(62, 20);
            this.txt_N1.Name = "txt_N1";
            this.txt_N1.Size = new System.Drawing.Size(118, 20);
            this.txt_N1.TabIndex = 5;
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_n1.Location = new System.Drawing.Point(35, 23);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(21, 13);
            this.lbl_n1.TabIndex = 6;
            this.lbl_n1.Text = "N1";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(35, 49);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(21, 13);
            this.lbl_n2.TabIndex = 7;
            this.lbl_n2.Text = "N2";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(62, 111);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(118, 20);
            this.txt_resultado.TabIndex = 8;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(1, 114);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 9;
            this.lbl_resultado.Text = "Resultado";
            // 
            // btn_clear
            // 
            this.btn_clear.ForeColor = System.Drawing.Color.Red;
            this.btn_clear.Location = new System.Drawing.Point(47, 72);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(25, 23);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 178);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(lbl_texto_confirma);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.txt_N1);
            this.Controls.Add(this.txt_N2);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.btn_soma);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_subtrair;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.TextBox txt_N2;
        private System.Windows.Forms.TextBox txt_N1;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_clear;
    }
}

