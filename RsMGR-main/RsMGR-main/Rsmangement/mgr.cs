using System;
using System.Windows.Forms;
namespace Rsmangement {
	public class Mgr
	{

		public static string strcon = "Data Source=yazan\\SQLEXPRESS;Initial Catalog=RestaurantDB;Integrated Security=True;";
		private static void showAll(DataGridView v1)
		{

			 
			string qure = "SELECT MealID,MealName,Price,Description FROM Meals;";
			SqlConnection con = new SqlConnection(strcon);
			SqlCommand cmd = new SqlCommand(qure, con);
			con.Open();
			SqlDataAdapter a = new SqlDataAdapter(cmd);
			DataTable t = new DataTable();
			a.Fill(t);
			v1.DataSource = t;
			v1.Columns["MealID"].HeaderText = "رقم الوجبة";
			v1.Columns["MealName"].HeaderText = "اسم";
			v1.Columns["Price"].HeaderText = "سعر";
			v1.Columns["Description"].HeaderText = "الوصف";

		}
		private static void Addmeal(string name,decimal price,string Descraption) {
			string qure = "INSERT INTO Meals (MealName,Price,Description)VALUES(@MealName,@Price,@Description)";
			SqlConnection con = new SqlConnection(strcon);
			using (SqlCommand cmd = new SqlCommand(qure, con))
			{

				cmd.Parameters.AddWithValue("@MealName", name);
				cmd.Parameters.AddWithValue("@Price", price);
				cmd.Parameters.AddWithValue("@Description", Descraption);
				con.Open();
				try
				{
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

					MessageBox.Show("حدث خطأ ما");
				}

			}
		}
		private static void Delaetemeal(int ID)
		{
			string qure = "	DELETE FROM Meals WHERE  MealID=@MealID";
			SqlConnection con = new SqlConnection(strcon);
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
		private static void UpdateMeale(string name, decimal price, string Descraption,int ID) {
			string qure = "UPDATE  Meals SET  MealName=@MealName,Price=@Price,Description=@Description WHERE MealID=@MealID";
			SqlConnection con = new SqlConnection(strcon);
			using (SqlCommand cmd = new SqlCommand(qure, con))
			{

				cmd.Parameters.AddWithValue("@MealName", name);
				cmd.Parameters.AddWithValue("@Price", price);
				cmd.Parameters.AddWithValue("@Description", Descraption);
				cmd.Parameters.AddWithValue("@MealID", ID);
				con.Open();
				int r = cmd.ExecuteNonQuery();
				if (r > 0)
				{
					MessageBox.Show("تم تعديل الوجبة");
				}
				else
				{
					MessageBox.Show("حدث خطأ ما");
				}
			}
		}
	}
}