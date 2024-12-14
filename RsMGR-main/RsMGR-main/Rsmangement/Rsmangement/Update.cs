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
	public partial class Update : Form
	{
		public Update()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			Mgr.UpdateMeale(tx_MealName.Text,tx_price.Text,tx_disc.Text,tx_id.Text);
			tx_disc.Text = "";
			tx_id.Text = "";
			tx_MealName.Text = "";
			tx_price.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Show s = new Show();
			this.Hide();
			s.ShowDialog();
			this.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Update_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
		}

        private void tx_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
