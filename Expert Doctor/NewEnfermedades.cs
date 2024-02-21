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
using System.Runtime.InteropServices;

namespace Expert_Doctor
{
    public partial class NewEnfermedades : Form
    {
        public NewEnfermedades()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (txtnomenfermedad.Text!="Nombre de la Enfermedad" && txtdescripcion.Text!= "Descripción")
            {
                try
                {
                    string cmd = string.Format("Exec insertarenfermedad '{0}', '{1}' ", txtnomenfermedad.Text.Trim(), txtdescripcion.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado correctamente!");
                    txtnomenfermedad.Clear();
                    txtdescripcion.Clear();

                }

                catch (Exception error)
                {
                    MessageBox.Show(" Ha ocurrido un error!" + error.Message);


                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los campos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtnomenfermedad_Enter(object sender, EventArgs e)
        {
            if (txtnomenfermedad.Text == "Nombre de la Enfermedad")
            {
                txtnomenfermedad.Text = "";
                txtnomenfermedad.ForeColor = Color.LightGray;
            }


        }

        private void txtdescripcion_Leave(object sender, EventArgs e)
        {
            if (txtdescripcion.Text == "")
            {
                txtdescripcion.Text = "Descripción";
                txtdescripcion.ForeColor = Color.DimGray;
            }
        }

        private void txtnomenfermedad_Leave(object sender, EventArgs e)
        {
            if (txtnomenfermedad.Text == "")
            {
                txtnomenfermedad.Text = "Nombre de la Enfermedad";
                txtnomenfermedad.ForeColor = Color.DimGray;
            }
        }

        private void txtdescripcion_Enter(object sender, EventArgs e)
        {
            if (txtdescripcion.Text == "Descripción")
            {
                txtdescripcion.Text = "";
                txtdescripcion.ForeColor = Color.LightGray;
            }

        }
        private void NewEnfermedades_Load(object sender, EventArgs e)
        {

        }

        private void NewEnfermedades_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
