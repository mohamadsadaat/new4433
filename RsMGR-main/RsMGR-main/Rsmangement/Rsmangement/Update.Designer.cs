namespace Rsmangement
{
	partial class Update
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_disc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_MealName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(542, 406);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 177);
            this.button2.TabIndex = 11;
            this.button2.Text = "عرض الوجبات";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(778, 406);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 177);
            this.button1.TabIndex = 12;
            this.button1.Text = "تعديل الوجبة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_disc
            // 
            this.tx_disc.BackColor = System.Drawing.Color.DarkGray;
            this.tx_disc.Location = new System.Drawing.Point(40, 273);
            this.tx_disc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_disc.Multiline = true;
            this.tx_disc.Name = "tx_disc";
            this.tx_disc.Size = new System.Drawing.Size(409, 308);
            this.tx_disc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(466, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "الوصف";
            // 
            // tx_price
            // 
            this.tx_price.BackColor = System.Drawing.Color.DarkGray;
            this.tx_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_price.Location = new System.Drawing.Point(40, 199);
            this.tx_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_price.Multiline = true;
            this.tx_price.Name = "tx_price";
            this.tx_price.Size = new System.Drawing.Size(409, 46);
            this.tx_price.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(466, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "السعر";
            // 
            // tx_MealName
            // 
            this.tx_MealName.BackColor = System.Drawing.Color.DarkGray;
            this.tx_MealName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_MealName.Location = new System.Drawing.Point(40, 130);
            this.tx_MealName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_MealName.Multiline = true;
            this.tx_MealName.Name = "tx_MealName";
            this.tx_MealName.Size = new System.Drawing.Size(409, 46);
            this.tx_MealName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(466, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم الوجبة";
            // 
            // tx_id
            // 
            this.tx_id.BackColor = System.Drawing.Color.DarkGray;
            this.tx_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_id.Location = new System.Drawing.Point(40, 61);
            this.tx_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_id.Multiline = true;
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(409, 46);
            this.tx_id.TabIndex = 10;
            this.tx_id.TextChanged += new System.EventHandler(this.tx_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(466, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "رقم الوجبة المراد تعديلها";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Rsmangement.Properties.Resources.close_1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1000, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 41);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rsmangement.Properties.Resources._684;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 668);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_disc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_MealName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tx_disc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tx_price;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tx_MealName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tx_id;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
	}
}