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

namespace Diseño_Centrado_al_Usuario
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void Datos()
        {
            Userlabel.Text = " " + GlobVar.Usuario
                + " | " + GlobVar.Telefono
                + " | " + GlobVar.Email
                + " | ";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            TssHora.Text = DateTime.Now.ToShortTimeString();
            TssFecha.Text = DateTime.Now.ToShortDateString();
            Datos();
        }

        private void archivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AB = new About();
            AB.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About AB = new About();
            AB.Show();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        

        

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DatosUsuariostripmenuItem_Click(object sender, EventArgs e)
        {
            DatosUsuario Du = new DatosUsuario();
            Du.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
