using MySql.Data.MySqlClient;

namespace ImageStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Escolha a imagem (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picImagem.Image = Image.FromFile(dialog.FileName);
                    txtNomeImagem.Text = dialog.SafeFileName;
                    btnInserirImagem.Enabled = true;
                    txtNomeImagem.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                labelResultado.Text = $"Erro ao tentar carregar a imagem escolhida. \n {ex.Message}";
                labelResultado.ForeColor = Color.Red;
            }
        }
    }
}
