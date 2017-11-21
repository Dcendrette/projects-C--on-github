namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(46, 24);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(21, 13);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "N1";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(12, 129);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(55, 13);
            this.lbl_res.TabIndex = 1;
            this.lbl_res.Text = "Resultado";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(46, 53);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(21, 13);
            this.lbl_n2.TabIndex = 2;
            this.lbl_n2.Text = "N2";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(74, 24);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 3;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(74, 50);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 4;
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(74, 126);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(100, 20);
            this.txt_res.TabIndex = 5;
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(67, 86);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(24, 23);
            this.btn_soma.TabIndex = 6;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.Location = new System.Drawing.Point(97, 86);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(24, 23);
            this.btn_subtrair.TabIndex = 7;
            this.btn_subtrair.Text = "-";
            this.btn_subtrair.UseVisualStyleBackColor = true;
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(127, 86);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(24, 23);
            this.btn_multiplicar.TabIndex = 8;
            this.btn_multiplicar.Text = "x";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(157, 86);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(24, 23);
            this.btn_dividir.TabIndex = 9;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 175);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_subtrair;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_dividir;
    }
}

