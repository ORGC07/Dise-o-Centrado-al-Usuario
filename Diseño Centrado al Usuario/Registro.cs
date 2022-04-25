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
using System.Runtime.InteropServices;

namespace Diseño_Centrado_al_Usuario
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string NUEVO = "INSERT INTO TablaDCU  VALUES " +
                "('" + NombreTxt.Text + "'," +
                "'" + UsuarioTxt.Text + "'," +
                "'" + Passwordtxt.Text + "'," +
                "'" + EmailTxt.Text + "'," +
                "'" + TelefonoTxt.Text + "'," +
                "'" + DateTime.Now.ToShortDateString() + "')";


            SqlCommand cmd = new SqlCommand(NUEVO, Conexion.conectar());

            cmd.ExecuteNonQuery();
            MessageBox.Show(" Los datos fueron Guardados  correctamente ");
        }

        private void label6_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
