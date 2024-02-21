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
    public partial class Diagnosticar : Form
    {
        public Diagnosticar()
        {
            InitializeComponent();

            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int cantidadyes = 0;
        int cantidadno = 0;
        void llenar()
        {
            dataEnfermedades.DataSource = Utilidades.llenarDatosTabla("etiquetas").Tables[0];
        }
        int codigosintoma = 1;
        //array para guardar los codigos de enfermedades encontrados
        int[] encontrados;
        int[] codigoSintomas;
        int cantidadEntontrados = 0;
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
            
            cantidadyes = 0;
            cantidadno = 0;
            string enfermedad= dataEnfermedades.Rows[dataEnfermedades.CurrentRow.Index].Cells[0].Value.ToString();
            try
            {
                string buscar = string.Format("select count(*) as cantidadEncontrados from Síntomas where NombreSíntomas LIKE('%" + enfermedad + "%')", enfermedad);

                DataSet ds = Utilidades.Ejecutar(buscar);
                 cantidadEntontrados = int.Parse(ds.Tables[0].Rows[0]["cantidadEncontrados"].ToString());
               
                //MessageBox.Show("Cantidad encontrados"+ cantidadEntontrados.ToString());
                encontrados = new int[cantidadEntontrados];
                codigoSintomas = new int[cantidadEntontrados];
                Conexion.Utilidades.con.Open();
                string cadena = string.Format("select * from Síntomas where NombreSíntomas LIKE('%" + enfermedad + "%')", enfermedad);
                SqlCommand comandos = new SqlCommand(cadena, Conexion.Utilidades.con);
                SqlDataReader lector = comandos.ExecuteReader();
                int i = 0;
                while (lector.Read())
                {
                    codigoSintomas[i] = int.Parse(lector.GetValue(0).ToString());
                    encontrados[i] = int.Parse(lector.GetValue(2).ToString());
                    
                    i++;
                    

                }
                
                Conexion.Utilidades.con.Close();
                groupBox1.Visible = true;
                btnSeleccionar.Enabled = false;
                CodSintomas();
            }
            catch (Exception)
            {

                throw;
            }
            cambiar();
            
        }

        int[] CodigoPorSintoma;
         int tamaño = 0;
        int l = 0;
        int ultimoCodSintoma = 0;
        int j = 0;
        int cantidadDelSintoma = 0;
        public void CodSintomas()
        {
            if (j< cantidadEntontrados)
            {
                try
                {
                    string com = string.Format("select count(*) as cantidadEncontrados from Síntomas where Codenf='{0}' ", encontrados[j]);

                    DataSet ds = Utilidades.Ejecutar(com);
                    cantidadDelSintoma = int.Parse(ds.Tables[0].Rows[0]["cantidadEncontrados"].ToString());
                    CodigoPorSintoma = new int[cantidadDelSintoma];
                    //MessageBox.Show("tamaño del array "+CodigoPorSintoma.Length.ToString());

                    Conexion.Utilidades.con.Open();

                    string cadena2 = "Select CodSíntomas from Síntomas where Codenf =" + encontrados[j];
                    SqlCommand comando2 = new SqlCommand(cadena2, Conexion.Utilidades.con);
                    SqlDataReader lector2 = comando2.ExecuteReader();
                    int k = 0;
                    while (lector2.Read())
                    {

                        CodigoPorSintoma[k] = int.Parse(lector2.GetValue(0).ToString());

                        //MessageBox.Show("codigos "+ CodigoPorSintoma[k]);
                        k++;
                    }
                    Conexion.Utilidades.con.Close();
                    codigosintoma = CodigoPorSintoma[0];

                    tamaño = CodigoPorSintoma.Length;
                    ultimoCodSintoma = CodigoPorSintoma[tamaño - 1];

                    //sageBox.Show("Tamaño"+tamaño);
                }
                catch (Exception)
                {

                    throw;
                }

            }
            if (j> cantidadEntontrados)
            {
                MessageBox.Show("Ya no hay mas Sintomas \n no se ha encontrado diagnostico");
            }

        }

        
        string enfermedaResultado = "";
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdSI.Checked==false && rdNO.Checked==false)
            {
                MessageBox.Show("debe seleccionar un sintoma");
            }
            
            if (rdSI.Checked)
            {
                cambiar();
                cantidadyes++;
                rdSI.Checked = false;
                rdNO.Checked = false;
            }
            if (rdNO.Checked)
            {
                cambiar();
                cantidadno++;
                rdSI.Checked = false;
                rdNO.Checked = false;
            }
            if (cantidadyes>(tamaño*80/100))
            {
                try
                {
                    string com = string.Format("select * from Enfermedades where Codenf='{0}' ", encontrados[j]);

                    DataSet ds = Utilidades.Ejecutar(com);
                    enfermedaResultado = ds.Tables[0].Rows[0]["NombreEnfermedad"].ToString();
                    //MessageBox.Show("Usted tiene la enfermedad de "+enfermedaResultado);
                    Mensaje men = new Mensaje(enfermedaResultado);
                    men.ShowDialog();
                    groupBox1.Visible = false;
                    //Resultado resulta = new Resultado(enfermedaResultado, cantidadDelSintoma);
                    groupBox2.Visible = true;
                    resultado();
                }
                catch (Exception)
                {

                    //MessageBox.Show("No se ha encontrado resultado");;
                }



            }
            if (cantidadno> (tamaño * 50/ 100))
            {
                //MessageBox.Show("seigueitne codigo ");
                j++;
               
                cantidadno = 0;
                cantidadyes = 0;
                CodSintomas();
                cambiar();
                
            }

           
        }

        int codigoultimo = 0;
        
        public void cambiar()
        {
            //Conexion.Utilidades.con.Open();
           // string cadena = "SELECT TOP 1 * FROM Síntomas ORDER BY CodSíntomas DESC";

            try
            {
                if (codigosintoma <=ultimoCodSintoma)
                {
                    codigosintoma++;
                    llenarSintomas();
                }
                

            }

            catch (Exception)
            {

                throw;
            }
            Conexion.Utilidades.con.Close();
        }
        public void llenarSintomas()
        {
            string CMD = string.Format("Select*FROM Síntomas WHERE CodSíntomas='{0}'", codigosintoma-1);
            DataSet ds = Utilidades.Ejecutar(CMD);
            
            try
            {
                int codigo = int.Parse(ds.Tables[0].Rows[0]["CodSíntomas"].ToString());
                
                if (codigo == codigosintoma-1)
                {

                    lblEnfermedad.Text = ds.Tables[0].Rows[0]["NombreSíntomas"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Diagnosticar_Load(object sender, EventArgs e)
        {
            llenar();
            //llenarSintomas();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            
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

        string[] sintomas;
        void resultado() {

            //lblEnfermedad.Text = enfermedaResultado;
            try
            {
                lblResultado.Text = enfermedaResultado;
                Conexion.Utilidades.con.Open();
                string buscar = string.Format("select NombreSíntomas,Enfermedades.Descripción from Enfermedades inner join Síntomas on Enfermedades.Codenf=Síntomas.Codenf where Enfermedades.NombreEnfermedad='{0}'", enfermedaResultado);
                SqlCommand comando3 = new SqlCommand(buscar, Conexion.Utilidades.con);
                SqlDataReader lector3 = comando3.ExecuteReader();
                int i = 0;
                sintomas  = new string[cantidadDelSintoma];
                string descripcion = ""; ;
                while (lector3.Read())
                {
                    sintomas[i] = lector3.GetValue(0).ToString();
                    descripcion = lector3.GetValue(1).ToString();
                    i++;

                }
                Conexion.Utilidades.con.Close();
                Descripcion.Text = descripcion;
                foreach (var item in sintomas)
                {
                    riSintomas.Text ="*"+ string.Join("\n"+"*", sintomas);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
