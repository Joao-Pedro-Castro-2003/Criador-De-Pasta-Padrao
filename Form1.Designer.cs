namespace CriadorDePastaPadrao
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
            components = new System.ComponentModel.Container();
            Título = new Label();
            txtNomePasta = new TextBox();
            SelecionaPasta = new FolderBrowserDialog();
            labelNomePasta = new Label();
            labelCaminho = new Label();
            txtCaminho = new TextBox();
            btnSelecionarPasta = new Button();
            btnCriar = new Button();
            errorProvider = new ErrorProvider(components);
            selecionarArquivos = new OpenFileDialog();
            btnSelecionarArquivos = new Button();
            labelSelecionarArquivos = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // Título
            // 
            Título.AutoSize = true;
            Título.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Título.Location = new Point(268, 9);
            Título.Name = "Título";
            Título.Size = new Size(424, 37);
            Título.TabIndex = 0;
            Título.Text = "Criador de Pastas Padrão - MRC";
            // 
            // txtNomePasta
            // 
            txtNomePasta.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNomePasta.Location = new Point(364, 207);
            txtNomePasta.Name = "txtNomePasta";
            txtNomePasta.PlaceholderText = "Nomeie a sua pasta";
            txtNomePasta.Size = new Size(217, 21);
            txtNomePasta.TabIndex = 1;
            txtNomePasta.TextChanged += txtNomePasta_TextChanged;
            // 
            // labelNomePasta
            // 
            labelNomePasta.AutoSize = true;
            labelNomePasta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNomePasta.Location = new Point(401, 185);
            labelNomePasta.Name = "labelNomePasta";
            labelNomePasta.Size = new Size(124, 19);
            labelNomePasta.TabIndex = 2;
            labelNomePasta.Text = "Nome da Pasta";
            // 
            // labelCaminho
            // 
            labelCaminho.AutoSize = true;
            labelCaminho.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCaminho.Location = new Point(380, 69);
            labelCaminho.Name = "labelCaminho";
            labelCaminho.Size = new Size(177, 19);
            labelCaminho.TabIndex = 3;
            labelCaminho.Text = "Caminho Selecionado";
            // 
            // txtCaminho
            // 
            txtCaminho.BackColor = SystemColors.ButtonHighlight;
            txtCaminho.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCaminho.Location = new Point(364, 91);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.PlaceholderText = "Escolha a pasta de destino";
            txtCaminho.ReadOnly = true;
            txtCaminho.Size = new Size(217, 21);
            txtCaminho.TabIndex = 4;
            txtCaminho.TextChanged += txtCaminho_TextChanged;
            // 
            // btnSelecionarPasta
            // 
            btnSelecionarPasta.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecionarPasta.Location = new Point(407, 118);
            btnSelecionarPasta.Name = "btnSelecionarPasta";
            btnSelecionarPasta.Size = new Size(130, 21);
            btnSelecionarPasta.TabIndex = 5;
            btnSelecionarPasta.Text = "Selecionar Pasta";
            btnSelecionarPasta.UseVisualStyleBackColor = true;
            btnSelecionarPasta.Click += btnSelecionarPasta_Click;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = SystemColors.MenuHighlight;
            btnCriar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.HighlightText;
            btnCriar.Location = new Point(401, 389);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(136, 27);
            btnCriar.TabIndex = 6;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // selecionarArquivos
            // 
            selecionarArquivos.FileName = "openFileDialog1";
            // 
            // btnSelecionarArquivos
            // 
            btnSelecionarArquivos.Location = new Point(364, 307);
            btnSelecionarArquivos.Name = "btnSelecionarArquivos";
            btnSelecionarArquivos.Size = new Size(217, 21);
            btnSelecionarArquivos.TabIndex = 9;
            btnSelecionarArquivos.Text = "Selecione os arquivos";
            btnSelecionarArquivos.TextAlign = ContentAlignment.MiddleLeft;
            btnSelecionarArquivos.UseVisualStyleBackColor = true;
            btnSelecionarArquivos.Click += btnSelecionarArquivos_Click;
            // 
            // labelSelecionarArquivos
            // 
            labelSelecionarArquivos.AutoSize = true;
            labelSelecionarArquivos.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelecionarArquivos.Location = new Point(391, 286);
            labelSelecionarArquivos.MaximumSize = new Size(250, 0);
            labelSelecionarArquivos.Name = "labelSelecionarArquivos";
            labelSelecionarArquivos.Size = new Size(166, 18);
            labelSelecionarArquivos.TabIndex = 10;
            labelSelecionarArquivos.Text = "Selecione os arquivos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 480);
            Controls.Add(labelSelecionarArquivos);
            Controls.Add(btnSelecionarArquivos);
            Controls.Add(btnCriar);
            Controls.Add(btnSelecionarPasta);
            Controls.Add(txtCaminho);
            Controls.Add(labelCaminho);
            Controls.Add(labelNomePasta);
            Controls.Add(txtNomePasta);
            Controls.Add(Título);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Título;
        private TextBox txtNomePasta;
        private FolderBrowserDialog SelecionaPasta;
        private Label labelNomePasta;
        private Label labelCaminho;
        private TextBox txtCaminho;
        private Button btnSelecionarPasta;
        private Button btnCriar;
        private ErrorProvider errorProvider;
        private OpenFileDialog selecionarArquivos;
        private Label labelSelecionarArquivos;
        private Button btnSelecionarArquivos;
    }
}
