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
	public partial class JanelaSplash : Form
	{
		public JanelaSplash()
		{
			InitializeComponent();
		}

		private void JanelaAplash_Load(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value < 100)
			{
				progressBar1.Value = progressBar1.Value + 2;
			}
			else{
			Close();
			}


		}
	}
}
