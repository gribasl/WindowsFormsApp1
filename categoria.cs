using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class categoria : Form
    {
        public categoria()
        {
            InitializeComponent();
        }

        private void categoria_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            txtCódigo.Enabled = true;
            btnLocalizar.Enabled = false;
            btnNovo.Enabled = false;
            txtCategoria.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            txtCódigo.Enabled = false;
            btnLocalizar.Enabled = true;
            btnNovo.Enabled = true;
            txtCategoria.Enabled = false;
        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
