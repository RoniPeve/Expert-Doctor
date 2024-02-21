using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expert_Doctor
{
    public partial class Mensaje : Form
    {
        public Mensaje( string enfermedaResultado)
        {
            InitializeComponent();
            lblMensaje.Text = "La enfermedad que presenta es \n" + enfermedaResultado;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
