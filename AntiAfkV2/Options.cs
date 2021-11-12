using AntiAfkV2.Properties;

using System;
using System.Windows.Forms;

namespace AntiAfkV2
{
	public partial class Options : Form
	{
		private static Options instance;

		public static Options GetInstance()
		{
			return instance ?? new Options();
		}

		public Options()
		{
			this.InitializeComponent();
			instance = this;
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			numeric_delay.Value = Settings.Default.Delay;
			comboBox_timeUnit.SelectedIndex = (int)Settings.Default.TimeUnit;
			textBox_key.Text = Settings.Default.Key;
		}

		public enum TimeUnit
		{
			Seconds,
			Minutes,
			Hours
		}

		private void button_default_Click(object sender, EventArgs e)
		{
			numeric_delay.Value = 5;
			comboBox_timeUnit.SelectedIndex = 0;
			textBox_key.Text = "{SCROLLLOCK}";
		}

		private void button_save_Click(object sender, EventArgs e)
		{
			if (numeric_delay.Value <= 0 || comboBox_timeUnit.SelectedIndex < 0 || comboBox_timeUnit.SelectedIndex > 2 || string.IsNullOrEmpty(textBox_key.Text))
			{
				MessageBox.Show("Invalid settings.");
				return;
			}

			Settings.Default.Delay = Convert.ToInt32(numeric_delay.Value);
			Settings.Default.TimeUnit = (TimeUnit)comboBox_timeUnit.SelectedIndex;
			Settings.Default.Key = textBox_key.Text;
			Settings.Default.Save();

			this.Close();
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Options_FormClosed(object sender, FormClosedEventArgs e)
		{
			instance = null;
		}
	}
}
