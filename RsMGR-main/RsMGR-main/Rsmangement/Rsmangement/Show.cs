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
	public partial class Show : Form
	{
		public Show()
		{
			InitializeComponent();
		}

		private void Show_Load(object sender, EventArgs e)
		{

			Mgr.showAll(dataGridView1);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
