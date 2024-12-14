using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Rsmangement
{
    public partial class IN : Form
    {
        public IN()
        {
            InitializeComponent();
        }
        private void IN_Load(object sender, EventArgs e)
        {
            this.mealsTableAdapter.Fill(this.restaurantDBDataSet.Meals);
            usr usr = new usr();
            usr.LoadDataIntoListBox(listBox1, listBox2);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0 && numericUpDown1.Value > 0)
                dataGridView1.Rows.Add(listBox1.SelectedItems[0].ToString(), (int)numericUpDown1.Value, (int)numericUpDown1.Value * usr.clac(listBox1.SelectedItems[0].ToString()) );
            else
                MessageBox.Show("  تاكد من اختيار وجبة وعدد قطع ");
            FillComboBoxWithFoodNames();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string foodNameToDelete = comboBox1.SelectedItem?.ToString(); 
            if (!string.IsNullOrEmpty(foodNameToDelete))
            {
                usr usr1 = new usr();
                usr1.DeleteRowByFoodName(foodNameToDelete, dataGridView1);
                FillComboBoxWithFoodNames();
                comboBox1.ResetText();
            }
            else
            {
                MessageBox.Show("يرجى اختيار اسم الأكلة المراد حذفها.");
            }
        }

        private void FillComboBoxWithFoodNames()
        {
            comboBox1.Items.Clear();
            numericUpDown1.Value = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string food = row.Cells["Food"].Value?.ToString();
                    if (food != null)
                        comboBox1.Items.Add(food);
                }
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            usr usr= new usr();
            int number;
            int num_table;
            if (int.TryParse(textBox3.Text, out number)&& int.TryParse(textBox1.Text, out num_table))
            {
                usr.SaveData(num_table, textBox2.Text, number,dataGridView1,"داخلي");
                this.Close();
                USR uSR = new USR();
                uSR.Show();
            }
            else
            {
                MessageBox.Show("رقم الهاتف او رقم الطاولة غير موجود او غير صحيح");
            }

          
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            USR usr = new USR();
            usr.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
} 
        
    


