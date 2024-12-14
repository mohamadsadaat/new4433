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
	public partial class Add : Form
	{
		public Add()
		{
			InitializeComponent();
		}

		private void tx_MealName_TextChanged(object sender, EventArgs e)
		{

		}

		private void bt_add_Click(object sender, EventArgs e)
		{
			
			
				Mgr.Addmeal(tx_MealName.Text, tx_price.Text, tx_disc.Text);
				tx_disc.Text = "";
				tx_MealName.Text = "";
				tx_price.Text = "";
			
		}

		private void bt_show_Click(object sender, EventArgs e)
		{
			Show s=new Show();
			this.Hide();
			s.ShowDialog();
			this.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Add_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
		}
	}
}
