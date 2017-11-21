namespace Calculadora_POO
{
    partial class CalculadoraS
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
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_operacao = new System.Windows.Forms.Label();
            this.lbl_valorB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_valor.Location = new System.Drawing.Point(38, 22);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(53, 20);
            this.lbl_valor.TabIndex = 0;
            this.lbl_valor.Text = "Valor A";
            // 
            // lbl_operacao
            // 
            this.lbl_operacao.AutoSize = true;
            this.lbl_operacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_operacao.Location = new System.Drawing.Point(25, 47);
            this.lbl_operacao.Name = "lbl_operacao";
            this.lbl_operacao.Size = new System.Drawing.Size(68, 20);
            this.lbl_operacao.TabIndex = 1;
            this.lbl_operacao.Text = "Operação";
            // 
            // lbl_valorB
            // 
            this.lbl_valorB.AutoSize = true;
            this.lbl_valorB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_valorB.Location = new System.Drawing.Point(38, 73);
            this.lbl_valorB.Name = "lbl_valorB";
            this.lbl_valorB.Size = new System.Drawing.Size(53, 20);
            this.lbl_valorB.TabIndex = 2;
            this.lbl_valorB.Text = "Valor B";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btn_calc
            // 
            this.btn_calc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_calc.Location = new System.Drawing.Point(27, 116);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(57, 21);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Location = new System.Drawing.Point(90, 116);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(57, 21);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sair.Location = new System.Drawing.Point(153, 116);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(57, 21);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // CalculadoraS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(255, 191);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_valorB);
            this.Controls.Add(this.lbl_operacao);
            this.Controls.Add(this.lbl_valor);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "CalculadoraS";
            this.Text = "CalculadoraS";
            this.Load += new System.EventHandler(this.CalculadoraS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_operacao;
        private System.Windows.Forms.Label lbl_valorB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_sair;
    }
}

