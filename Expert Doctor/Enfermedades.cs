using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using System.Runtime.InteropServices;

namespace Expert_Doctor
{
    public partial class Enfermedades : Form
    {
        public Enfermedades()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Enfermedades_Load(object sender, EventArgs e)
        {
            listar();
        }

        void listar()
        {
            dataListaEnfermedades.DataSource = Utilidades.llenarDatosConsulta("NombreEnfermedad","Enfermedades").Tables[0];
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBuscar.Text) == false)
            {
                try
                {

                   

                    string cmd = string.Format("select NombreEnfermedad from Enfermedades where NombreEnfermedad LIKE('%" + textBuscar.Text + "%')", textBuscar.Text);

                    DataSet ds = Utilidades.Ejecutar(cmd);
                    dataListaEnfermedades.DataSource = ds.Tables[0];
                }
                catch (Exception ee)
                {

                    MessageBox.Show("No se encontro enfermedad "+ee);
                }


            }
            else
            {
                listar();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string EnfermedadSeleccionada= dataListaEnfermedades.Rows[dataListaEnfermedades.CurrentRow.Index].Cells[0].Value.ToString();
            try
            {
                string cmd = string.Format("select * from Enfermedades where NombreEnfermedad='{0}'", EnfermedadSeleccionada);

                DataSet ds = Utilidades.Ejecutar(cmd);
                int codigo = int.Parse(ds.Tables[0].Rows[0]["Codenf"].ToString());
                lblEnfermedad.Text = ds.Tables[0].Rows[0]["NombreEnfermedad"].ToString();
                Descripcion.Text = ds.Tables[0].Rows[0]["Descripción"].ToString();
                string cmd2 = "select count(*) as cantidad from Síntomas where Codenf="+codigo;
                DataSet ds2 = Utilidades.Ejecutar(cmd2);
                int can =int.Parse( ds2.Tables[0].Rows[0]["cantidad"].ToString());
                
                Conexion.Utilidades.con.Open();
                string cmd3 = string.Format("select NombreSíntomas from Síntomas where Codenf='{0}'", codigo);
                SqlCommand comando3 = new SqlCommand(cmd3, Conexion.Utilidades.con);
                 SqlDataReader lector3 = comando3.ExecuteReader();
                string[] sintomas = new string[can];
                int i = 0;
                 while (lector3.Read())
                 {
                     sintomas[i] = lector3.GetValue(0).ToString();
                    i++;

                 }
                 Conexion.Utilidades.con.Close();
                foreach (var item in sintomas)
                {
                    riSintomas.Text = "*"+string.Join("\n"+ "*" , sintomas);
                }

            }
            catch (Exception error)
            {

                MessageBox.Show("Error "+error);
            }
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
    }
}
