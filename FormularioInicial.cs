using WindowsFormsApp1;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Código para abertura do formulário de cadastro de cargo
            var cargo = new Frmcargo();
            cargo.ShowDialog();

        }






        private void categoriasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Código para abertura do formulário de cadastro de cargo
            var cargo = new categoria();
            cargo.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Código para abertura do formulário de cadastro de cargo
            var Cargo = new Clientes();
            Cargo.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Código para abertura do formulário de cadastro de cargo
            var Cargo = new Fornecedor();
            Cargo.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }


        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Código para abertura do formulário de cadastro de cargo
            var Cargo = new Funcionarios();
            Cargo.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			//para abrir a janela splash
			var janela = new JanelaSplash();
			janela.ShowDialog();

			//Código para abertura do formulário de cadastro de cargo
			var Cargo = new FrmLogin();
			Cargo.ShowDialog();
		}
           
            

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
    