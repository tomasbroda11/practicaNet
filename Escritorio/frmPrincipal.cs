using Broda.Escritorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broda.Escritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnStripListado_Click(object sender, EventArgs e)
        {
            this.Hide();

            new frmListado().ShowDialog();
        }

        private void btnStripRecuperar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRecuperar().ShowDialog();
        }
    }
}
