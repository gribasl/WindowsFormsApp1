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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = true;
            btnFechar.Enabled = true;
            btnLocalizar.Enabled = false;
            btnFechar.Enabled = false;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = false;
            btnFechar.Enabled = false;
            btnLocalizar.Enabled = true;
            btnFechar.Enabled = true;
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            
        }
    }
    }

