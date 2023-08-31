namespace Exercício_Usuário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] usuarios = new string[7] { "Mônica", "Magali", "Bidu", "Cascão", "Cebolinha", "Anjinho", "Chico Bento" };

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string foto = string.Empty;
            int i = 0;

           for (i = 0; i < usuarios.Length; i++)
            {
                if (usuario == usuarios[i])
                {
                    foto = "C:\\fotos\\" + usuario + ".jpg";
                    break;
                }
                else 
                {
                    if(i == usuario.Length -1) {
                        MessageBox.Show("Esse usuário não existe ou não foi escrito corretamente.", "Erro: Nome de usuário!");
                        break;
                    }
                }
            }
            pictFoto.ImageLocation = foto;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
