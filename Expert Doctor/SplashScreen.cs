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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        PictureBox[] pict; //declaracion de matrices

        int count = 0;

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pict = new PictureBox[5] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 5)
            {
                pict[count].BackgroundImage = Expert_Doctor.Properties.Resources.Circle2;
                count++;
                label1.Text = "Cargando al " + (count * 20) + " %";
            }
            else
            {
                timer1.Enabled = false;
               // MessageBox.Show("Carga Completa!!!" + "\n" + " Psdt: Nunca te Rindas, si caes levántate hasta llegar a la Meta :) ", "The Soft Team", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu men = new Menu();
                men.Show();
            }
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
           

        }
    }
}
