
namespace AntiAfkV2
{
	partial class Options
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
			this.numeric_delay = new System.Windows.Forms.NumericUpDown();
			this.label_delay = new System.Windows.Forms.Label();
			this.comboBox_timeUnit = new System.Windows.Forms.ComboBox();
			this.label_key = new System.Windows.Forms.Label();
			this.textBox_key = new System.Windows.Forms.TextBox();
			this.button_save = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_default = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numeric_delay)).BeginInit();
			this.SuspendLayout();
			// 
			// numeric_delay
			// 
			this.numeric_delay.Location = new System.Drawing.Point(85, 35);
			this.numeric_delay.Name = "numeric_delay";
			this.numeric_delay.Size = new System.Drawing.Size(112, 20);
			this.numeric_delay.TabIndex = 0;
			this.numeric_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label_delay
			// 
			this.label_delay.AutoSize = true;
			this.label_delay.Location = new System.Drawing.Point(42, 37);
			this.label_delay.Name = "label_delay";
			this.label_delay.Size = new System.Drawing.Size(37, 13);
			this.label_delay.TabIndex = 1;
			this.label_delay.Text = "Delay:";
			// 
			// comboBox_timeUnit
			// 
			this.comboBox_timeUnit.FormattingEnabled = true;
			this.comboBox_timeUnit.Items.AddRange(new object[] {
            "seconds",
            "minutes",
            "hours"});
			this.comboBox_timeUnit.Location = new System.Drawing.Point(203, 34);
			this.comboBox_timeUnit.Name = "comboBox_timeUnit";
			this.comboBox_timeUnit.Size = new System.Drawing.Size(121, 21);
			this.comboBox_timeUnit.TabIndex = 2;
			// 
			// label_key
			// 
			this.label_key.AutoSize = true;
			this.label_key.Location = new System.Drawing.Point(51, 82);
			this.label_key.Name = "label_key";
			this.label_key.Size = new System.Drawing.Size(28, 13);
			this.label_key.TabIndex = 3;
			this.label_key.Text = "Key:";
			// 
			// textBox_key
			// 
			this.textBox_key.Location = new System.Drawing.Point(85, 79);
			this.textBox_key.Name = "textBox_key";
			this.textBox_key.Size = new System.Drawing.Size(112, 20);
			this.textBox_key.TabIndex = 4;
			this.textBox_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_save
			// 
			this.button_save.Location = new System.Drawing.Point(198, 153);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(75, 23);
			this.button_save.TabIndex = 5;
			this.button_save.Text = "Save";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(279, 153);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(75, 23);
			this.button_cancel.TabIndex = 6;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_default
			// 
			this.button_default.Location = new System.Drawing.Point(12, 153);
			this.button_default.Name = "button_default";
			this.button_default.Size = new System.Drawing.Size(75, 23);
			this.button_default.TabIndex = 7;
			this.button_default.Text = "Default";
			this.button_default.UseVisualStyleBackColor = true;
			this.button_default.Click += new System.EventHandler(this.button_default_Click);
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 188);
			this.Controls.Add(this.label_delay);
			this.Controls.Add(this.numeric_delay);
			this.Controls.Add(this.comboBox_timeUnit);
			this.Controls.Add(this.label_key);
			this.Controls.Add(this.textBox_key);
			this.Controls.Add(this.button_default);
			this.Controls.Add(this.button_save);
			this.Controls.Add(this.button_cancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Options";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
			this.Load += new System.EventHandler(this.Settings_Load);
			((System.ComponentModel.ISupportInitialize)(this.numeric_delay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numeric_delay;
		private System.Windows.Forms.Label label_delay;
		private System.Windows.Forms.ComboBox comboBox_timeUnit;
		private System.Windows.Forms.Label label_key;
		private System.Windows.Forms.TextBox textBox_key;
		private System.Windows.Forms.Button button_save;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_default;
	}
}