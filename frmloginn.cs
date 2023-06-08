using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace Proyecto_s_p1
{
    public partial class frmloginn : Form
    {
        BD bd = new BD();
        frmBienvenida bv = new frmBienvenida();
        int Intentos = 0;



        public frmloginn()
        {
            InitializeComponent();
        }
        private void cmdCancelar2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
       
        private void CmdAceptar2_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string Modulo = cboxMódulo.SelectedItem?.ToString();

        }

          































































        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 10;
            txtUsuario.ForeColor = Color.Blue;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.MaxLength = 10;
            txtContraseña.PasswordChar = '#';
        }

        
        
        private void frmloginn_Load(object sender, EventArgs e)
        {

        }

        private void CmdAceptar2_MouseEnter(object sender, EventArgs e)
        {
            CmdAceptar2.ForeColor = Color.Black;
        }

        private void CmdAceptar2_MouseLeave(object sender, EventArgs e)
        {
            CmdAceptar2.ForeColor = Color.Lime;
        }

        private void cmdCancelar2_MouseEnter(object sender, EventArgs e)
        {
            cmdCancelar2.ForeColor = Color.Black;
        }

        private void cmdCancelar2_MouseLeave(object sender, EventArgs e)
        {
            cmdCancelar2.ForeColor = Color.Red;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
