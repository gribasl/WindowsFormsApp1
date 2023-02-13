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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnFechar.Enabled = true;
            txtNome.Enabled = false;
            txtDt.Enabled = false;
            txtEmail.Enabled = false;
            txtCelular.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnFechar.Enabled = false;
            txtNome.Enabled = true;
            txtDt.Enabled = true;
            txtEmail.Enabled = true;
            txtCelular.Enabled = true;
            txtRg.Enabled = true;
            txtCpf.Enabled = true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }
    }
}
