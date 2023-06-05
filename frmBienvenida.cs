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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void cmdcerrar_click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();

        }

        private void cmdCerrar_MouseEnter(object sender, EventArgs e)
        {
            cmdCerrar.ForeColor = Color.Black;
        }

        private void cmdCerrar_MouseLeave(object sender, EventArgs e)
        {
            cmdCerrar.ForeColor = Color.Red;
        }

        private void frmBienvenida_load(object sender, EventArgs e)
        {

        }
    }
}
