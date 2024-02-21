using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Expert_Doctor
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnDiagnosticar_Click(object sender, EventArgs e)
        {
            Diagnosticar diago = new Diagnosticar();
            diago.ShowDialog();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            Diagnosticar di = new Diagnosticar();
            di.ShowDialog();
        }

        private void btnEnfermedades_Click(object sender, EventArgs e)
        {
            Enfermedades enfer = new Enfermedades();
            enfer.ShowDialog();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            Integrantes inte = new Integrantes();
            inte.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnNuevaEnfermedad.Visible = false;
            btnAgregarSintomas.Visible = false;
            btnEtiqueta.Visible = false;
            lbluser.Visible = false;
            lblCerrar.Visible = false;
            pCerrarSesion.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            IniciarSesion log = new IniciarSesion();
            log.ShowDialog();
            if (log.yes)
            {
                btnNuevaEnfermedad.Visible = true;
                btnAgregarSintomas.Visible = true;
                btnEtiqueta.Visible = true;
                lbluser.Visible = true;
                lbluser.Text = log.nombre;
                lblCerrar.Visible = true;
                pCerrarSesion.Visible = true;
                lblIniciar.Visible = false;
                pictureBox2.Visible = false;
                
                
            }
            
        }

        private void pCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Desea cerrar cesion?","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) ;
            if (result==DialogResult.Yes)
            {
                btnNuevaEnfermedad.Visible = false;
                btnAgregarSintomas.Visible = false;
                btnEtiqueta.Visible = false;
                lbluser.Visible = false;
                lblCerrar.Visible = false;
                pCerrarSesion.Visible = false;
                lblIniciar.Visible = true;
                pictureBox2.Visible = true;
            }
        }

        private void btnNuevaEnfermedad_Click(object sender, EventArgs e)
        {
            NewEnfermedades nuevo = new NewEnfermedades();
            nuevo.ShowDialog();
        }

        private void btnAgregarSintomas_Click(object sender, EventArgs e)
        {
            NewSintomas nue = new NewSintomas();
            nue.ShowDialog();
        }

        private void btnEtiqueta_Click(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.ShowDialog();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
