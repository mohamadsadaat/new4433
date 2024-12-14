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
using System.Xml.Linq;

namespace Rsmangement
{
	public partial class Form1 : Form
	{
        public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			using (SqlConnection conn = new SqlConnection(Properties.Settings.scrot))
			{
				conn.Open();
				
				string query = "SELECT * FROM Users WHERE UserName=@UserName AND Password=@Password;";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{

					cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
					cmd.Parameters.AddWithValue("@Password", textBox2.Text);
					SqlDataReader redaer = cmd.ExecuteReader();
					string Qure = "SELECT UserType FROM Users WHERE UserName=@UserName";
					SqlCommand cmdd = new SqlCommand(Qure, conn);
					cmdd.Parameters.AddWithValue("@UserName", textBox1.Text);


					if (redaer.HasRows)
					{
                        if (redaer.Read())
						{
                            string userType = redaer["UserType"].ToString();

                            if (userType == "MGR")
							{

                                MGR m = new MGR();
								this.Hide();
								m.ShowDialog();
							}
							else 
							{
								USR f = new USR();
								this.Hide();
								f.ShowDialog();
							}
						}
						
					}
					else
					{
						MessageBox.Show("اسم المستخدم او كامة السر غير صحيحة");
					}
				}


			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle=FormBorderStyle.None;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
