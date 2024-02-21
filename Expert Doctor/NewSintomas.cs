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
    public partial class NewSintomas : Form
    {
        public NewSintomas()
        {
            InitializeComponent();
           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void llenar()
        {
            dataEnfermedades.DataSource = Utilidades.llenarDatosConsulta("NombreEnfermedad","Enfermedades").Tables[0];
        }
        int codigoEnfermedad;
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                string enfermedad = dataEnfermedades.Rows[dataEnfermedades.CurrentRow.Index].Cells[0].Value.ToString();
                lblNombreEnfermedad.Text = enfermedad;
                string cmd = string.Format("Select Codenf from Enfermedades where NombreEnfermedad='{0}'", enfermedad);
                DataSet ds = Utilidades.Ejecutar(cmd);
                 codigoEnfermedad =int.Parse( ds.Tables[0].Rows[0]["Codenf"].ToString());
                
            }
            catch (Exception)
            {

                throw;
            }
            

        }
      
        private void NewSintomas_Load(object sender, EventArgs e)
        {
            llenar();
            
        }

        private void txtnombreenfermedad_Enter(object sender, EventArgs e)
        {

        }

        private void txtnombreenfermedad_Leave(object sender, EventArgs e)
        {

        }

        private void txtsintomas_Enter(object sender, EventArgs e)
        {

        }

        private void txtsintomas_Leave(object sender, EventArgs e)
        {

        }

        private void NewSintomas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguarda_Click(object sender, EventArgs e)
        {
            
            if (txtsintomas.Text!="" && lblNombreEnfermedad.Text!="")
            {
                try
                {

                    string cmd = string.Format("Exec insertarsíntomas '{0}', '{1}' ", txtsintomas.Text, codigoEnfermedad);
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado correctamente!");
                    txtsintomas.Clear();

                }

                catch (Exception error)
                {
                    MessageBox.Show(" Ha ocurrido un error!" + error.Message);


                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los campos","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
