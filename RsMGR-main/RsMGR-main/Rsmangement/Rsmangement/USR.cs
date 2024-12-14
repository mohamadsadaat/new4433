using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rsmangement
{
	public partial class USR : Form
	{
		public USR()
		{
			InitializeComponent();
		}

		private void USR_Load(object sender, EventArgs e)
		{
			
		}
       


        private void button1_Click(object sender, EventArgs e)
        {
            IN s = new IN();
            this.Close();
            s.Show();
			
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            @out @out=new @out();
            @out.Show();
        }
    }
}
