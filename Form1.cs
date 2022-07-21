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

namespace WAMerverPoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("server=LAPTOP-6R78LGLH\SQLEXPRES ; database = sistemaMerver ; INTREGATED SECURITY = true ");
        private void btnMin_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
            btnCerrar.BackColor = Color.FromArgb(13, 99, 191);
            btnMax.BackColor = Color.FromArgb(13, 99, 191);
            btnMin.BackColor = Color.FromArgb(13, 99, 191);


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando aplicacion.");
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                btnMax.BackgroundImage = Image.FromFile("stop-outline.png");
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.BackgroundImage = Image.FromFile("copy-outline.png");
            }
            

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta crearCuenta = new FrmCrearCuenta();
            this.Hide();
            crearCuenta.Show();
        }

        private void btnNotPass_Click(object sender, EventArgs e)
        {
            FrmContraOlvidada notPass = new FrmContraOlvidada();
            this.Hide();
            notPass.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand("SELECT nombreUsuario, contrasena FROM tablaUsuario WHERE nombreUsuario = @vAdmin AND contrasena = @vlinceUn", connection);
            comando.Parameters.AddWithValue("@vAdmin", txtCorreo.Text);
            comando.Parameters.AddWithValue("@vlinceUn", txtPass.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                connection.Close();
                FrmCrearCuenta frmCrear = new FrmCrearCuenta();
                frmCrear.Show();
            }
        }
    }
}
