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
	public partial class Delete : Form
	{
		public Delete()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Delete_Load(object sender, EventArgs e)
		{this.FormBorderStyle = FormBorderStyle.None;
			Mgr.showAll(comboBox1);
		}

		private void bt_delete_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedValue == null)
			{
				MessageBox.Show("أختر وجبة ");
			}
			else
			{
				int h = (int)comboBox1.SelectedValue;
				Mgr.Delaetemeal(h);
				Mgr.showAll(comboBox1);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
