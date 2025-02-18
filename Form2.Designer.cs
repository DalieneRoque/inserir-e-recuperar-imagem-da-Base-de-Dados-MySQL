namespace ImageStore
{
    partial class Form2
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
            picImagem = new PictureBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnFechar = new Button();
            listaImagem = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            labelResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaImagem).BeginInit();
            SuspendLayout();
            // 
            // picImagem
            // 
            picImagem.BorderStyle = BorderStyle.FixedSingle;
            picImagem.Location = new Point(11, 12);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(598, 317);
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            picImagem.TabIndex = 1;
            picImagem.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(437, 335);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(172, 60);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(437, 401);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(172, 60);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(437, 467);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(172, 60);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // listaImagem
            // 
            listaImagem.AllowUserToAddRows = false;
            listaImagem.AllowUserToDeleteRows = false;
            listaImagem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaImagem.BackgroundColor = SystemColors.Control;
            listaImagem.BorderStyle = BorderStyle.None;
            listaImagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaImagem.ColumnHeadersVisible = false;
            listaImagem.Columns.AddRange(new DataGridViewColumn[] { id, nome });
            listaImagem.Location = new Point(12, 339);
            listaImagem.MultiSelect = false;
            listaImagem.Name = "listaImagem";
            listaImagem.ReadOnly = true;
            listaImagem.RowHeadersVisible = false;
            listaImagem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaImagem.Size = new Size(419, 184);
            listaImagem.TabIndex = 7;
            listaImagem.SelectionChanged += listaImagem_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nome
            // 
            nome.HeaderText = "NOME";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // labelResultado
            // 
            labelResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(22, 22);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(572, 293);
            labelResultado.TabIndex = 8;
            labelResultado.TextAlign = ContentAlignment.MiddleCenter;
            labelResultado.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 535);
            Controls.Add(labelResultado);
            Controls.Add(listaImagem);
            Controls.Add(btnFechar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(picImagem);
            Name = "Form2";
            Text = "Imagens na Base de Dados";
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaImagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImagem;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnFechar;
        private DataGridView listaImagem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private Label labelResultado;
    }
}