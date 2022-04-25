
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;



namespace Diseño_Centrado_al_Usuario
{
    public partial class Login : Padre
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            



        }

        private void Usuariotb_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registrobtn_Click(object sender, EventArgs e)
        {
            Registro Re = new Registro();
            Re.Show();
        }

        private void Aceptarbtn_Click(object sender, EventArgs e)
        {

            Conexion.conectar();
            string BUSCAR = "SELECT * FROM TablaDCU " +
                "WHERE UserNameDCU='" + UsuarioTx.Text + "' AND PasswordDCU='" + PasswordTx.Text + "'";

            SqlCommand cmd = new SqlCommand(BUSCAR, Conexion.conectar());

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                GlobVar.Usuario = dr.GetString(1);
                GlobVar.Telefono = dr.GetString(4);
                GlobVar.Email = dr.GetString(3);

                Menuprincipal VPrin = new Menuprincipal();
                VPrin.Show();
                VPrin.FormClosed += LogOut;
                this.Hide();
                MessageBox.Show("Acceso Permitido , esta accion puede ser vista por Los supervisores y entidades superiores.");
            }
            else
            {
                MessageBox.Show(" Credenciales Incorrectas");
            }
            
        }

        private void LogOut(Object Sender, FormClosedEventArgs e)
        {
            UsuarioTx.Text = "";
            PasswordTx.Text = "";
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
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