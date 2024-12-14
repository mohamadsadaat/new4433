namespace Rsmangement
{
	partial class Delete
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
			this.bt_delete = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bt_delete
			// 
			this.bt_delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.bt_delete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_delete.Location = new System.Drawing.Point(342, 123);
			this.bt_delete.Name = "bt_delete";
			this.bt_delete.Size = new System.Drawing.Size(192, 64);
			this.bt_delete.TabIndex = 6;
			this.bt_delete.Text = "حذف الوجبة";
			this.bt_delete.UseVisualStyleBackColor = false;
			this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(318, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 31);
			this.label1.TabIndex = 4;
			this.label1.Text = "اختر الوجبة المراد حذفها";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 60);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(300, 21);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = global::Rsmangement.Properties.Resources.close_1_;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(548, -1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(28, 27);
			this.button1.TabIndex = 12;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Delete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Rsmangement.Properties.Resources._614;
			this.ClientSize = new System.Drawing.Size(574, 325);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.bt_delete);
			this.Controls.Add(this.label1);
			this.Name = "Delete";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete";
			this.Load += new System.EventHandler(this.Delete_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_delete;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
	}
}