using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAMerverPoo
{
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La aplicacion se cerrara.");
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBMerverSADataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dBMerverSADataSet.Usuario);

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            //Creamos las variables para los textbox correspondientes
            int vIdUsuario, vTelefono;
            string vNombreUsuario, vContraseña, vNacimiento, vCorreo;

            vIdUsuario = int.Parse(idUsuarioTextBox.Text);
            vTelefono = (int)long.Parse(telefonoTextBox.Text);
            //Asignamos los textbox
            vNombreUsuario = nombreUsuarioTextBox.Text;
            vContraseña = contraseñaTextBox.Text;
            vNacimiento = fechaNacimientoTextBox.Text;
            vCorreo = correoElectronicoTextBox.Text;

            //Iniciamos insercion
            this.usuarioTableAdapter.Insert(vIdUsuario, vNombreUsuario, vContraseña, vTelefono, vNacimiento, vCorreo);

            MessageBox.Show("Cuenta creada con exito!!!");


        }
    }
}
