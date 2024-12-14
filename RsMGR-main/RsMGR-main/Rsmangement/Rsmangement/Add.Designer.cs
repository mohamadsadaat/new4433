namespace Rsmangement
{
	partial class Add
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tx_disc = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tx_price = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tx_MealName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bt_show = new System.Windows.Forms.Button();
			this.bt_add = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tx_disc
			// 
			this.tx_disc.BackColor = System.Drawing.Color.DarkGray;
			this.tx_disc.Location = new System.Drawing.Point(12, 169);
			this.tx_disc.Multiline = true;
			this.tx_disc.Name = "tx_disc";
			this.tx_disc.Size = new System.Drawing.Size(388, 251);
			this.tx_disc.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(417, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "الوصف";
			// 
			// tx_price
			// 
			this.tx_price.BackColor = System.Drawing.Color.DarkGray;
			this.tx_price.Location = new System.Drawing.Point(12, 117);
			this.tx_price.Multiline = true;
			this.tx_price.Name = "tx_price";
			this.tx_price.Size = new System.Drawing.Size(388, 32);
			this.tx_price.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(417, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "سعر";
			// 
			// tx_MealName
			// 
			this.tx_MealName.BackColor = System.Drawing.Color.DarkGray;
			this.tx_MealName.Location = new System.Drawing.Point(12, 69);
			this.tx_MealName.Multiline = true;
			this.tx_MealName.Name = "tx_MealName";
			this.tx_MealName.Size = new System.Drawing.Size(388, 32);
			this.tx_MealName.TabIndex = 8;
			this.tx_MealName.TextChanged += new System.EventHandler(this.tx_MealName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(417, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "اسم الوجبة";
			// 
			// bt_show
			// 
			this.bt_show.BackColor = System.Drawing.Color.DarkGray;
			this.bt_show.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_show.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_show.ForeColor = System.Drawing.Color.White;
			this.bt_show.Location = new System.Drawing.Point(505, 268);
			this.bt_show.Name = "bt_show";
			this.bt_show.Size = new System.Drawing.Size(181, 152);
			this.bt_show.TabIndex = 9;
			this.bt_show.Text = "عرض الوجبات";
			this.bt_show.UseVisualStyleBackColor = false;
			this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
			// 
			// bt_add
			// 
			this.bt_add.BackColor = System.Drawing.Color.DarkGray;
			this.bt_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_add.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_add.ForeColor = System.Drawing.Color.White;
			this.bt_add.Location = new System.Drawing.Point(505, 69);
			this.bt_add.Name = "bt_add";
			this.bt_add.Size = new System.Drawing.Size(181, 152);
			this.bt_add.TabIndex = 10;
			this.bt_add.Text = "أضافة وجبة";
			this.bt_add.UseVisualStyleBackColor = false;
			this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = global::Rsmangement.Properties.Resources.close_1_;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(666, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(31, 30);
			this.button1.TabIndex = 11;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Add
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Rsmangement.Properties.Resources._684;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(698, 457);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bt_show);
			this.Controls.Add(this.bt_add);
			this.Controls.Add(this.tx_disc);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tx_price);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tx_MealName);
			this.Controls.Add(this.label2);
			this.Name = "Add";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add";
			this.Load += new System.EventHandler(this.Add_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tx_disc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tx_price;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tx_MealName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bt_show;
		private System.Windows.Forms.Button bt_add;
		private System.Windows.Forms.Button button1;
	}
}