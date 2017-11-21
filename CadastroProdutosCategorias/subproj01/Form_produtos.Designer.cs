namespace subproj01
{
    partial class Form_produtos
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
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.btn_novo_form_produtos = new System.Windows.Forms.Button();
            this.btn_cadastrar_form_produtos = new System.Windows.Forms.Button();
            this.btn_excluir_form_produto = new System.Windows.Forms.Button();
            this.btn_cancelar_form_produto = new System.Windows.Forms.Button();
            this.dataGridView_form_produtos = new System.Windows.Forms.DataGridView();
            this.lbl_categoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_form_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_valor
            // 
            this.lbl_valor.Location = new System.Drawing.Point(0, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(100, 23);
            this.lbl_valor.TabIndex = 11;
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(84, 28);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(154, 20);
            this.txt_produto.TabIndex = 1;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(291, 28);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(78, 20);
            this.txt_valor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Location = new System.Drawing.Point(461, 26);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(121, 21);
            this.comboBox_categoria.TabIndex = 5;
            // 
            // btn_novo_form_produtos
            // 
            this.btn_novo_form_produtos.Location = new System.Drawing.Point(96, 81);
            this.btn_novo_form_produtos.Name = "btn_novo_form_produtos";
            this.btn_novo_form_produtos.Size = new System.Drawing.Size(75, 23);
            this.btn_novo_form_produtos.TabIndex = 6;
            this.btn_novo_form_produtos.Text = "Novo";
            this.btn_novo_form_produtos.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar_form_produtos
            // 
            this.btn_cadastrar_form_produtos.Location = new System.Drawing.Point(201, 81);
            this.btn_cadastrar_form_produtos.Name = "btn_cadastrar_form_produtos";
            this.btn_cadastrar_form_produtos.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar_form_produtos.TabIndex = 7;
            this.btn_cadastrar_form_produtos.Text = "Cadastrar";
            this.btn_cadastrar_form_produtos.UseVisualStyleBackColor = true;
            this.btn_cadastrar_form_produtos.Click += new System.EventHandler(this.btn_cadastrar_form_produtos_Click);
            // 
            // btn_excluir_form_produto
            // 
            this.btn_excluir_form_produto.Location = new System.Drawing.Point(303, 81);
            this.btn_excluir_form_produto.Name = "btn_excluir_form_produto";
            this.btn_excluir_form_produto.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_form_produto.TabIndex = 8;
            this.btn_excluir_form_produto.Text = "Excluir";
            this.btn_excluir_form_produto.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar_form_produto
            // 
            this.btn_cancelar_form_produto.Location = new System.Drawing.Point(409, 81);
            this.btn_cancelar_form_produto.Name = "btn_cancelar_form_produto";
            this.btn_cancelar_form_produto.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_form_produto.TabIndex = 9;
            this.btn_cancelar_form_produto.Text = "Cancelar";
            this.btn_cancelar_form_produto.UseVisualStyleBackColor = true;
            // 
            // dataGridView_form_produtos
            // 
            this.dataGridView_form_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_form_produtos.Location = new System.Drawing.Point(12, 130);
            this.dataGridView_form_produtos.Name = "dataGridView_form_produtos";
            this.dataGridView_form_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_form_produtos.Size = new System.Drawing.Size(568, 240);
            this.dataGridView_form_produtos.TabIndex = 10;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(12, 31);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_categoria.Size = new System.Drawing.Size(58, 17);
            this.lbl_categoria.TabIndex = 12;
            this.lbl_categoria.Text = "Produto";
            this.lbl_categoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.dataGridView_form_produtos);
            this.Controls.Add(this.btn_cancelar_form_produto);
            this.Controls.Add(this.btn_excluir_form_produto);
            this.Controls.Add(this.btn_cadastrar_form_produtos);
            this.Controls.Add(this.btn_novo_form_produtos);
            this.Controls.Add(this.comboBox_categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.lbl_valor);
            this.Name = "Form_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_produtos";
            this.Load += new System.EventHandler(this.Form_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_form_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.Button btn_novo_form_produtos;
        private System.Windows.Forms.Button btn_cadastrar_form_produtos;
        private System.Windows.Forms.Button btn_excluir_form_produto;
        private System.Windows.Forms.Button btn_cancelar_form_produto;
        private System.Windows.Forms.DataGridView dataGridView_form_produtos;
        private System.Windows.Forms.Label lbl_categoria;
    }
}