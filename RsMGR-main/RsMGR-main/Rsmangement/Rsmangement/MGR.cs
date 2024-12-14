using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rsmangement
{
	public partial class MGR : Form
	{
		public MGR()
		{
			InitializeComponent();
		}

		private void MGR_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Show s=new Show();
			this.Hide();
			s.ShowDialog();
			this.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Add a=new Add();
			this.Hide();
			a.ShowDialog();
			this.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Delete d=new Delete(); 
			this.Hide();
			d.ShowDialog();
			this.Show();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Update a=new Update();
			this.Hide();
			a.ShowDialog();
			this.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("وداعا");
			this.Close();
			Form1 s=new Form1();
			s.Close();
		}

        private void button6_Click(object sender, EventArgs e)
        {
			show_order show_Order = new show_order();
			this.Hide(); show_Order.ShowDialog();
			this.Show();
        }
    }
}
