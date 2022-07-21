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
    public partial class FrmContraOlvidada : Form
    {
        public FrmContraOlvidada()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando aplicacion.");
            Application.Exit();
        }
    }
}
