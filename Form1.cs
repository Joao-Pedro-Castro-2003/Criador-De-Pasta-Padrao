using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CriadorDePastaPadrao
{
    public partial class Form1 : Form
    {
        private string[] arquivosSelecionados;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arquivosSelecionados = Array.Empty<string>();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            GerarPasta();
        }
        private bool ValidarCampos()
        {
            errorProvider.Clear();
            if (string.IsNullOrEmpty(txtCaminho.Text))
            {
                errorProvider.SetError(txtCaminho, "Selecione a pasta de destino.");
                return false;
            }
            if (string.IsNullOrEmpty(txtNomePasta.Text))
            {
                errorProvider.SetError(txtNomePasta, "Digite o nome da pasta que deseja criar.");
                return false;
            }
            if (arquivosSelecionados == null || arquivosSelecionados.Length == 0)
            {
                errorProvider.SetError(btnSelecionarArquivos, "Selecione arquivos.");
                return false;
            }
            return true;
        }

        private void GerarPasta()
        {
            string caminhoBase = Path.Combine(txtCaminho.Text, txtNomePasta.Text);
            try
            {
                string pastaApp = Path.Combine(caminhoBase, "APP");
                string pastaDb = Path.Combine(caminhoBase, "DB");

                if (!Directory.Exists(pastaApp) && !Directory.Exists(pastaDb))
                {
                    foreach (var arquivo in arquivosSelecionados)
                    {
                        string extensao = Path.GetExtension(arquivo).ToLower();
                        string destino;

                        if (extensao == ".sql")
                        {
                            Directory.CreateDirectory(pastaDb);
                            destino = Path.Combine(pastaDb, Path.GetFileName(arquivo));
                        }
                        else
                        {
                            Directory.CreateDirectory(pastaApp);
                            destino = Path.Combine(pastaApp, Path.GetFileName(arquivo));
                        }

                        File.Copy(arquivo, destino, true);
                    }

                    MessageBox.Show($"Arquitetura de pasta criada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na criação da pasta - Método - Gerar Pasta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSelecionarPasta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Selecione a pasta de destino";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtCaminho.Text = dialog.SelectedPath;
                }
            }
        }
        private void ResetaCampos()
        {
            txtCaminho.Clear();
            txtNomePasta.Clear();
            arquivosSelecionados = Array.Empty<string>();
            btnSelecionarArquivos.Text = "Selecionar Arquivos";
        }
        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCaminho, string.Empty);
        }
        private void txtNomePasta_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNomePasta, string.Empty);
        }
        private void btnSelecionarArquivos_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Selecione os arquivos",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "Todos os arquivos (*.*)|*.*",
                Multiselect = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] arquivos = dialog.FileNames;
                arquivosSelecionados = arquivos;
                btnSelecionarArquivos.Text = $"{arquivos.Length} arquivo(s) selecionado(s)";
                errorProvider.SetError(btnSelecionarArquivos, string.Empty);
            }
        }
    }
}
