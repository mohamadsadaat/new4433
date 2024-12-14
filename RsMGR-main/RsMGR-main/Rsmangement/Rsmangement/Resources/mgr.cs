using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rsmangement {
	public class usr
	{
        public void DeleteRowByFoodName(string foodName,DataGridView dataGridView1)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Food"].Value?.ToString() == foodName)
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }
            }
        }
        public void LoadDataIntoListBox(ListBox listBox1,ListBox listBox2)
        {
            string query = "SELECT MealName FROM Meals";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.scrot))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["MealName"].ToString());
                }
                reader.Close();
            }
            query = "SELECT Price FROM Meals";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.scrot))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBox2.Items.Add(reader["Price"].ToString());
                }
                reader.Close();
            }
        }
        public static decimal clac(string food)
        {
            decimal result = 0;
            string query = "select price from Meals where MealName=@food";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.scrot))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@food", food);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetDecimal(0);
                }
                reader.Close();
            }
            return result;
        }
       
        public void SaveData(int t, string name, int number,DataGridView dataGridView1,string place)
        {
			IN iN=new IN();
            string q1 = "insert into Customers(FullName,PhoneNumber,Addres)values(@fullname,@Phone,'داخلي')";
            string q = " insert into Orders(mealname,Quantity,TablrNumber,CustomerID,OrderType,totalprice) values (@f,@Q,@tnum,(select CustomerID from Customers where PhoneNumber=@p and FullName=@namee),@place,@to)";

            if ( dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("لا توجد بيانات لحفظها.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.scrot))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(q1, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@fullname", name);
                        cmd.Parameters.AddWithValue("@phone", number);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم حفظ البيانات بنجاح.");
                    }
                    catch (Exception ex)
                    {
						MessageBox.Show("حدث خطا ما"+ex.Message);
                    }
                }
				decimal total_payment = 0;
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string food = row.Cells["food"].Value?.ToString();
                                int quantity = Convert.ToInt32(row.Cells["count"].Value);

                                decimal totalPrice = Convert.ToDecimal(row.Cells["total"].Value);
								total_payment = total_payment + totalPrice;
                                SqlCommand command = new SqlCommand(q, connection, transaction);

                                command.Parameters.AddWithValue("@f", food);
                                command.Parameters.AddWithValue("@Q", quantity);
                                command.Parameters.AddWithValue("@tnum", t);
                                command.Parameters.AddWithValue("@p", number);
                                command.Parameters.AddWithValue("@namee", name);
                                command.Parameters.AddWithValue("@to", totalPrice);
								command.Parameters.AddWithValue("@place", place);
                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
						MessageBox.Show("الفاتورة النهائية" + total_payment);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("حدث خطأ أثناء حفظ البيانات: " +ex.Message);
                    }
                }
            }
        }
    }
	public class Mgr
	{
        //public void SumQuantitiesAndShow(DataGridView dataGridView1)
        //{
        //    int totalQuantity = 0;

        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        if (!row.IsNewRow) // التأكد من تجاهل الصف الجديد (الصف الفارغ المخصص لإدخال البيانات)
        //        {
        //            totalQuantity += Convert.ToInt32(row.Cells["totalprice"].Value);
        //        }
        //    }

        //    MessageBox.Show( totalQuantity.ToString());
        //}
        public  void showorder(DataGridView v1)
        {
            string qure = "SELECT orderid,quantity,tablrnumber,customerid,ordertype,totalprice,mealname  FROM Orders;";
            SqlConnection con = new SqlConnection(Properties.Settings.scrot);
            SqlCommand cmd = new SqlCommand(qure, con);
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable t = new DataTable();
            a.Fill(t);
            v1.DataSource = t;
            con.Close();
        }

        public static void showAll(DataGridView v1)
		{
			string qure = "SELECT MealID,MealName,Price,Description FROM Meals;";
			SqlConnection con = new SqlConnection(Properties.Settings.scrot);
			SqlCommand cmd = new SqlCommand(qure, con);
			con.Open();
			SqlDataAdapter a = new SqlDataAdapter(cmd);
			DataTable t = new DataTable();
			a.Fill(t);
			v1.DataSource = t;
		}
		public static void showAll(System.Windows.Forms.ComboBox v1)
		{
			string qure = "SELECT MealID,MealName,Price,Description FROM Meals;";
			SqlConnection con = new SqlConnection(Properties.Settings.scrot);
			SqlCommand cmd = new SqlCommand(qure, con);
			con.Open();
			SqlDataAdapter a = new SqlDataAdapter(cmd);
			DataTable t = new DataTable();
			a.Fill(t);
			v1.DataSource = t;
			v1.DisplayMember = "MealName";
			v1.ValueMember = "MealID";
		}
		public static void Addmeal(string name,string price,string Descraption) {
			string qure = "INSERT INTO Meals (MealName,Price,Description)VALUES(@MealName,@Price,@Description)";
			SqlConnection con = new SqlConnection(Properties.Settings.scrot);
			using (SqlCommand cmd = new SqlCommand(qure, con))
			{
				cmd.Parameters.AddWithValue("@MealName", name);
				cmd.Parameters.AddWithValue("@Price", price);
				cmd.Parameters.AddWithValue("@Description", Descraption);
				try
				{
					con.Open();
					int r = cmd.ExecuteNonQuery();
					if (r > 0)
					{
						MessageBox.Show("تم أضافة الوجبة");
					}
					else
					{
						MessageBox.Show("حدث خطأ ما");
					}
				}
				catch (Exception)
				{
					MessageBox.Show("هناك حقل فارغ");
				}
			}
		}
		public static void Delaetemeal(int ID)
		{
			string qure = "	DELETE FROM Meals WHERE  MealID=@MealID";
			SqlConnection con = new SqlConnection(Properties.Settings.scrot);
			using (SqlCommand cmd = new SqlCommand(qure, con))
			{


				cmd.Parameters.AddWithValue("@MealID", ID);

				con.Open();
				int r = cmd.ExecuteNonQuery();
				if (r > 0)
				{
					MessageBox.Show("تم حذف الوجبة");

				}
				else
				{
					MessageBox.Show("حدث خطأ ما");
				}
			}
		}
		public static void UpdateMeale(string name, string price, string Descraption,string ID) {
			string qure = "UPDATE  Meals SET  MealName=@MealName,Price=@Price,Description=@Description WHERE MealID=@MealID";
			SqlConnection con = new SqlConnection(Properties.Settings.scrot);
			using (SqlCommand cmd = new SqlCommand(qure, con))
			{

				cmd.Parameters.AddWithValue("@MealName", name);
				cmd.Parameters.AddWithValue("@Price", price);
				cmd.Parameters.AddWithValue("@Description", Descraption);
				cmd.Parameters.AddWithValue("@MealID", ID);
				try
				{



					con.Open();
					int r = cmd.ExecuteNonQuery();
					if (r > 0)
					{
						MessageBox.Show("تم تعديل الوجبة");
					}
					else
					{
						MessageBox.Show("هناك حقل فارغ");
					}
				}
				catch (Exception)
				{

					MessageBox.Show("حدث خطأ ما");
				}
			}
		}
	}
}