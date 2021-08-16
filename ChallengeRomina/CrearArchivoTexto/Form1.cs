using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ProyectoChallengeRomina

{
    public partial class frmCreadorArchivo : Form
    {
        public frmCreadorArchivo()
        {
            InitializeComponent();
        }

        private void frmCreadorArchivo_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + "\\CarpetaQueNoExistia\\Archivo.txt";
                File.WriteAllBytes(path, Encoding.ASCII.GetBytes(txtContent.Text));
                MessageBox.Show($"Archivo guardado: {path}");
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }

        private void LimpiarTexto()
        {
            txtContent.Text = string.Empty;
        }

    }
}
