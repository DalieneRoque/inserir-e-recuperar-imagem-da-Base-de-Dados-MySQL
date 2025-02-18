using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32.SafeHandles;

namespace ImageStore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string conexao = "server=localhost; User id=root; password=; database=imagens_db;";
            //Faz conexão com a base de dados
            MySqlConnection conn = new MySqlConnection(conexao);
            string sql = "SELECT * FROM tabela_imagens";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                if (adapter.Fill(dt) < 1)
                {
                    labelResultado.Text = "A base de dados ainda não contém registros";
                    labelResultado.Visible = true;
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        listaImagem.Rows.Add(dr.ItemArray);
                    }

                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                labelResultado.Text = $"Erro ao recuperar os registros. \n {ex.Message}";
                labelResultado.Visible = true;
            }
            finally
            {
                conn.Close();
                adapter.Dispose();
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void listaImagem_SelectionChanged(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            labelResultado.Visible = false;

            string conexao = "server=localhost; User id=root; password=; database=imagens_db;";
            //Faz conexão com a base de dados
            MySqlConnection conn = new MySqlConnection(conexao);
            string sql = "SELECT * FROM tabela_imagens";

            try
            {
                string id = listaImagem.SelectedRows[0].Cells[0].Value.ToString();
                string sqll = $"SELECT * FROM tabela_imagens WHERE id LIKE {id}";

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqll, conn);
                conn.Open();
                adapter.Fill(dt);
                byte[] image = (byte[])dt.Rows[0][2];
                MemoryStream ms = new MemoryStream(image);
                picImagem.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                labelResultado.Text = $"Erro ao recuperar a imagem do registro. \n {ex.Message}";
                labelResultado.Visible = true;
            }
            finally 
            {
                conn.Close();
            }
        }
    }
}
