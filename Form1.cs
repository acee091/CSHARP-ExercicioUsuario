namespace Exercício_Usuário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] usuario = new string[7] { "Mônica", "Magali", "Bidu", "Cascão", "Cebolinha", "Anjinho", "Chico Bento" };
        string nome;

        private void btnValidar_Click(object sender, EventArgs e)
        {
           nome = txtUsuario.Text;
           for (int i = 0; i < usuario.Length ; i++)
            {

                if (nome == usuario[i])
                {
                    string foto = "C:\\fotos\\" + usuario[i] + ".jpg";
                    pictFoto.ImageLocation = foto;
                }
                else 
                {
                    MessageBox.Show("Esse usuário não existe ou não foi escrito corretamente.", "Erro: Nome de usuário!");
                    break;
                }
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}