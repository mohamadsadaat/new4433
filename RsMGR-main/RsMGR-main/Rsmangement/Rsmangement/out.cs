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
    public partial class @out : Form
    {
        public @out()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            usr usr = new usr();
            if (listBox1.SelectedItems.Count > 0 && numericUpDown1.Value > 0)
                dataGridView1.Rows.Add(listBox1.SelectedItems[0].ToString(), (int)numericUpDown1.Value, (int)numericUpDown1.Value * usr.clac(listBox1.SelectedItems[0].ToString()));
            else
                MessageBox.Show("  تاكد من اختيار وجبة وعدد قطع ");
            FillComboBoxWithFoodNames();
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
        private void out_Load(object sender, EventArgs e)
        {
            usr usr=new usr();
            usr.LoadDataIntoListBox(listBox1,listBox2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string foodNameToDelete = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(foodNameToDelete))
            {
                usr usr = new usr();
                usr.DeleteRowByFoodName(foodNameToDelete,dataGridView1);
                comboBox1.ResetText();
            }
            else
            {
                MessageBox.Show("يرجى اختيار اسم الأكلة المراد حذفها.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            usr usr = new usr();
            int number;
            if (int.TryParse(textBox3.Text, out number) && textBox1.Text!=" ")
            {
                usr.SaveData(0, textBox2.Text, number, dataGridView1, textBox1.Text);
                this.Close();
                USR uSR = new USR();
                uSR.Show();
            }
            else
            {
                MessageBox.Show("رقم الهاتف او العنوان غير موجود او غير صحيح");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            USR usr = new USR();
            usr.Show();
        }
    }
}
