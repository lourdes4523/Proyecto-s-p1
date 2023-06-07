using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_s_p1
{
    
    
    
    
    
    public partial class frmLogin : Form
    {
        BD bd = new BD();
        frmBienvenida bv = new frmBienvenida();
        int Intentos = 0;

        
        
        public frmLogin()
        {
            InitializeComponent();
        }
        private void cmdCancelar2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void cmdAceptar2_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string Modulo = cboxMódulo.SelectedItem?.ToString();


        }
        if(!string.IsNullOrEmpty(Modulo))
            
        
                    
    }
}
