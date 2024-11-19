namespace TrabalhoWagnerBiblioteca
{
    partial class Biblioteca
    {
        private System.ComponentModel.IContainer components = null;

        // Declaração dos controles
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DateTimePicker dtpAnoPublicacao;
        private System.Windows.Forms.Button btnAddLivro;
        private System.Windows.Forms.Button btnEditLivro;
        private System.Windows.Forms.Button btnDeleteLivro;
        private System.Windows.Forms.TextBox txtNovoAutor;
        private System.Windows.Forms.Button btnAddAutor;
        private System.Windows.Forms.TextBox txtNovaCategoria;
        private System.Windows.Forms.Button btnAddCategoria;

        /// <summary>
        ///  Limpeza de recursos usados.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método obrigatório para suporte ao Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dgvLivros = new DataGridView();
            txtTitulo = new TextBox();
            cmbAutor = new ComboBox();
            cmbCategoria = new ComboBox();
            dtpAnoPublicacao = new DateTimePicker();
            btnAddLivro = new Button();
            btnEditLivro = new Button();
            btnDeleteLivro = new Button();
            txtNovoAutor = new TextBox();
            btnAddAutor = new Button();
            txtNovaCategoria = new TextBox();
            btnAddCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            SuspendLayout();
            // 
            // dgvLivros
            // 
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivros.Location = new Point(12, 12);
            dgvLivros.Name = "dgvLivros";
            dgvLivros.Size = new Size(760, 200);
            dgvLivros.TabIndex = 0;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 230);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Título";
            txtTitulo.Size = new Size(200, 23);
            txtTitulo.TabIndex = 1;
            // 
            // cmbAutor
            // 
            cmbAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutor.Location = new Point(220, 230);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(200, 23);
            cmbAutor.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(430, 230);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(200, 23);
            cmbCategoria.TabIndex = 3;
            // 
            // dtpAnoPublicacao
            // 
            dtpAnoPublicacao.Location = new Point(640, 230);
            dtpAnoPublicacao.Name = "dtpAnoPublicacao";
            dtpAnoPublicacao.Size = new Size(200, 23);
            dtpAnoPublicacao.TabIndex = 4;
            // 
            // btnAddLivro
            // 
            btnAddLivro.Location = new Point(12, 270);
            btnAddLivro.Name = "btnAddLivro";
            btnAddLivro.Size = new Size(100, 30);
            btnAddLivro.TabIndex = 5;
            btnAddLivro.Text = "Adicionar Livro";
            btnAddLivro.UseVisualStyleBackColor = true;
            btnAddLivro.Click += BtnAddLivro_Click;
            // 
            // btnEditLivro
            // 
            btnEditLivro.Location = new Point(120, 270);
            btnEditLivro.Name = "btnEditLivro";
            btnEditLivro.Size = new Size(100, 30);
            btnEditLivro.TabIndex = 6;
            btnEditLivro.Text = "Editar Livro";
            btnEditLivro.UseVisualStyleBackColor = true;
            btnEditLivro.Click += BtnEditLivro_Click;
            // 
            // btnDeleteLivro
            // 
            btnDeleteLivro.Location = new Point(230, 270);
            btnDeleteLivro.Name = "btnDeleteLivro";
            btnDeleteLivro.Size = new Size(100, 30);
            btnDeleteLivro.TabIndex = 7;
            btnDeleteLivro.Text = "Excluir Livro";
            btnDeleteLivro.UseVisualStyleBackColor = true;
            btnDeleteLivro.Click += BtnDeleteLivro_Click;
            // 
            // txtNovoAutor
            // 
            txtNovoAutor.Location = new Point(12, 320);
            txtNovoAutor.Name = "txtNovoAutor";
            txtNovoAutor.PlaceholderText = "Novo Autor";
            txtNovoAutor.Size = new Size(200, 23);
            txtNovoAutor.TabIndex = 8;
            // 
            // btnAddAutor
            // 
            btnAddAutor.Location = new Point(220, 320);
            btnAddAutor.Name = "btnAddAutor";
            btnAddAutor.Size = new Size(100, 30);
            btnAddAutor.TabIndex = 9;
            btnAddAutor.Text = "Adicionar Autor";
            btnAddAutor.UseVisualStyleBackColor = true;
            btnAddAutor.Click += BtnAddAutor_Click;
            // 
            // txtNovaCategoria
            // 
            txtNovaCategoria.Location = new Point(12, 360);
            txtNovaCategoria.Name = "txtNovaCategoria";
            txtNovaCategoria.PlaceholderText = "Nova Categoria";
            txtNovaCategoria.Size = new Size(200, 23);
            txtNovaCategoria.TabIndex = 10;
            // 
            // btnAddCategoria
            // 
            btnAddCategoria.Location = new Point(220, 360);
            btnAddCategoria.Name = "btnAddCategoria";
            btnAddCategoria.Size = new Size(100, 30);
            btnAddCategoria.TabIndex = 11;
            btnAddCategoria.Text = "Adicionar Categoria";
            btnAddCategoria.UseVisualStyleBackColor = true;
            btnAddCategoria.Click += BtnAddCategoria_Click;
            // 
            // Biblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 411);
            Controls.Add(btnAddCategoria);
            Controls.Add(txtNovaCategoria);
            Controls.Add(btnAddAutor);
            Controls.Add(txtNovoAutor);
            Controls.Add(btnDeleteLivro);
            Controls.Add(btnEditLivro);
            Controls.Add(btnAddLivro);
            Controls.Add(dtpAnoPublicacao);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbAutor);
            Controls.Add(txtTitulo);
            Controls.Add(dgvLivros);
            Name = "Biblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Livros";
            Load += Biblioteca_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
