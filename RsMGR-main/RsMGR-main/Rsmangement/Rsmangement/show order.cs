﻿using System;
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
    public partial class show_order : Form
    {
        public show_order()
        {
            InitializeComponent();
            
        }

        private void show_order_Load(object sender, EventArgs e)
        {
            Mgr mgr = new Mgr();
            mgr.showorder(dataGridView1);

        }
       
    }
}
