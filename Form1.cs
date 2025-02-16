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

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost; User id=root; password=; database=imagens_db;";
            //Faz conexão com a base de dados
            MySqlConnection conn = new MySqlConnection(conexao);
            //Cria comando que será executado
            MySqlCommand comando;
            //Guarda o arquivo na base de dados
            MemoryStream memoryStream = new MemoryStream();

            try
            {
                picImagem.Image.Save(memoryStream, picImagem.Image.RawFormat);
                byte[] data = memoryStream.ToArray();

                string sql = "INSERT INTO tabela_imagens (nome, imagem) VALUES (@nome, @imagem)";

                conn.Open();
                comando = new MySqlCommand(sql, conn);
                comando.Parameters.Add("@nome", MySqlDbType.String);
                comando.Parameters.Add("@imagem", MySqlDbType.Blob);
                comando.Parameters["@nome"].Value = txtNomeImagem.Text;
                comando.Parameters["@imagem"].Value = data;

                if (comando.ExecuteNonQuery() == 1)
                {
                    labelResultado.Text = "Imagem inserida com sucesso!";
                    labelResultado.ForeColor = Color.Green;
                }

            }
            catch (Exception ex)
            {

                labelResultado.Text = $"Erro ao conectar. \n {ex.Message}";
                labelResultado.ForeColor = Color.Red;
            }
            finally
            {
                conn.Close();
                memoryStream.Dispose();
            }

            picImagem.Image = null;
            txtNomeImagem.Text = null;
            btnInserirImagem.Enabled = false;
            txtNomeImagem.Enabled = false;
        }

        private void btnRecuperarImagem_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new Form2()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
