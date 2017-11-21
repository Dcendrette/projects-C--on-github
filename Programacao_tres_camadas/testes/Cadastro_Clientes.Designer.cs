namespace testes
{
    partial class Cadastro_Clientes
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
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.Btn_Incluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(60, 47);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.ReadOnly = true;
            this.Txt_ID.Size = new System.Drawing.Size(76, 20);
            this.Txt_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(60, 73);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(262, 20);
            this.txt_Nome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(60, 99);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(262, 20);
            this.txt_Email.TabIndex = 7;
            // 
            // Btn_Incluir
            // 
            this.Btn_Incluir.Location = new System.Drawing.Point(60, 126);
            this.Btn_Incluir.Name = "Btn_Incluir";
            this.Btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Incluir.TabIndex = 9;
            this.Btn_Incluir.Text = "Incluir";
            this.Btn_Incluir.UseVisualStyleBackColor = true;
            this.Btn_Incluir.Click += new System.EventHandler(this.Btn_Incluir_Click);
            // 
            // Cadastro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 176);
            this.Controls.Add(this.Btn_Incluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_ID);
            this.Name = "Cadastro_Clientes";
            this.Text = "Frm_Cadastro_Clientes";
            this.Load += new System.EventHandler(this.Cadastro_Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button Btn_Incluir;
    }
}

