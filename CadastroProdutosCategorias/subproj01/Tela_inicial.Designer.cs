namespace subproj01
{
    partial class Cadastros
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_produto = new System.Windows.Forms.Button();
            this.btn_categorias = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // btn_produto
            // 
            this.btn_produto.BackColor = System.Drawing.Color.Transparent;
            this.btn_produto.BackgroundImage = global::subproj01.Properties.Resources.btn_cadastroproduto1;
            this.btn_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produto.Location = new System.Drawing.Point(39, 41);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(71, 81);
            this.btn_produto.TabIndex = 1;
            this.btn_produto.Text = "Cadastro Produto";
            this.btn_produto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_produto.UseVisualStyleBackColor = false;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // btn_categorias
            // 
            this.btn_categorias.BackColor = System.Drawing.Color.Transparent;
            this.btn_categorias.BackgroundImage = global::subproj01.Properties.Resources.btn_cadastrocategorias;
            this.btn_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categorias.Location = new System.Drawing.Point(116, 41);
            this.btn_categorias.Name = "btn_categorias";
            this.btn_categorias.Size = new System.Drawing.Size(71, 81);
            this.btn_categorias.TabIndex = 2;
            this.btn_categorias.Text = "Cadastro Categorias";
            this.btn_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_categorias.UseVisualStyleBackColor = false;
            this.btn_categorias.Click += new System.EventHandler(this.btn_categorias_Click_1);
            // 
            // Cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::subproj01.Properties.Resources.fundologin;
            this.ClientSize = new System.Drawing.Size(501, 300);
            this.Controls.Add(this.btn_categorias);
            this.Controls.Add(this.btn_produto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_produto;
        private System.Windows.Forms.Button btn_categorias;
    }
}

