using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;

namespace Expert_Doctor
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }
        public bool yes = false;
        public string nombre = "";
        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontrasenia.Text == "CONTRASEÑA")
            {
                txtcontrasenia.Text = "";
                txtcontrasenia.ForeColor = Color.Black;
                txtcontrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select*FROM usuario WHERE NombreUsuario='{0}' AND Contraseña='{1}'", txtusuario.Text.Trim(), txtcontrasenia.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);
                nombre = ds.Tables[0].Rows[0]["NombreCompleto"].ToString();
                string cuenta = ds.Tables[0].Rows[0]["NombreUsuario"].ToString();
                string password = ds.Tables[0].Rows[0]["Contraseña"].ToString();

                if (cuenta == txtusuario.Text.Trim() && password == txtcontrasenia.Text.Trim())
                {
                    MessageBox.Show("Bienvenido " + nombre, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yes = true;


                    this.Hide();

                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("Cuenta o contraseña incorrecta " , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtcontrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
