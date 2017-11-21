namespace subproj01
{
    partial class Form_categorias
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
            this.dataGridView_form_categorias = new System.Windows.Forms.DataGridView();
            this.btn_cancelar_form_categorias = new System.Windows.Forms.Button();
            this.btn_excluir_form_categorias = new System.Windows.Forms.Button();
            this.btn_cadastrar_form_categorias = new System.Windows.Forms.Button();
            this.btn_novo_form_categorias = new System.Windows.Forms.Button();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_form_categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_form_categorias
            // 
            this.dataGridView_form_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_form_categorias.Location = new System.Drawing.Point(9, 135);
            this.dataGridView_form_categorias.Name = "dataGridView_form_categorias";
            this.dataGridView_form_categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_form_categorias.Size = new System.Drawing.Size(568, 240);
            this.dataGridView_form_categorias.TabIndex = 21;
            // 
            // btn_cancelar_form_categorias
            // 
            this.btn_cancelar_form_categorias.Location = new System.Drawing.Point(406, 86);
            this.btn_cancelar_form_categorias.Name = "btn_cancelar_form_categorias";
            this.btn_cancelar_form_categorias.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_form_categorias.TabIndex = 20;
            this.btn_cancelar_form_categorias.Text = "Cancelar";
            this.btn_cancelar_form_categorias.UseVisualStyleBackColor = true;
            // 
            // btn_excluir_form_categorias
            // 
            this.btn_excluir_form_categorias.Location = new System.Drawing.Point(300, 86);
            this.btn_excluir_form_categorias.Name = "btn_excluir_form_categorias";
            this.btn_excluir_form_categorias.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_form_categorias.TabIndex = 19;
            this.btn_excluir_form_categorias.Text = "Excluir";
            this.btn_excluir_form_categorias.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar_form_categorias
            // 
            this.btn_cadastrar_form_categorias.Location = new System.Drawing.Point(198, 86);
            this.btn_cadastrar_form_categorias.Name = "btn_cadastrar_form_categorias";
            this.btn_cadastrar_form_categorias.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar_form_categorias.TabIndex = 18;
            this.btn_cadastrar_form_categorias.Text = "Cadastrar";
            this.btn_cadastrar_form_categorias.UseVisualStyleBackColor = true;
            // 
            // btn_novo_form_categorias
            // 
            this.btn_novo_form_categorias.Location = new System.Drawing.Point(93, 86);
            this.btn_novo_form_categorias.Name = "btn_novo_form_categorias";
            this.btn_novo_form_categorias.Size = new System.Drawing.Size(75, 23);
            this.btn_novo_form_categorias.TabIndex = 17;
            this.btn_novo_form_categorias.Text = "Novo";
            this.btn_novo_form_categorias.UseVisualStyleBackColor = true;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(81, 33);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(154, 20);
            this.txt_categoria.TabIndex = 12;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(4, 33);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(69, 17);
            this.lbl_categoria.TabIndex = 11;
            this.lbl_categoria.Text = "Categoria";
            this.lbl_categoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 407);
            this.Controls.Add(this.dataGridView_form_categorias);
            this.Controls.Add(this.btn_cancelar_form_categorias);
            this.Controls.Add(this.btn_excluir_form_categorias);
            this.Controls.Add(this.btn_cadastrar_form_categorias);
            this.Controls.Add(this.btn_novo_form_categorias);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Name = "Form_categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_categorias";
            this.Load += new System.EventHandler(this.Form_categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_form_categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_form_categorias;
        private System.Windows.Forms.Button btn_cancelar_form_categorias;
        private System.Windows.Forms.Button btn_excluir_form_categorias;
        private System.Windows.Forms.Button btn_cadastrar_form_categorias;
        private System.Windows.Forms.Button btn_novo_form_categorias;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label lbl_categoria;
    }
}