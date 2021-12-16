using AntiAfkV2.Properties;

using System;
using System.Windows.Forms;

namespace AntiAfkV2
{
	public partial class Main : Form
	{
		public Main()
		{
			this.InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			this.Hide();
			enabledToolStripMenuItem.Checked = true;

			this.LoadSettings();
			timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (enabledToolStripMenuItem.Checked)
			{
				try
				{
					SendKeys.Send(Settings.Default.Key);
				}
				catch { }
			}
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			notifyIcon.Visible = false;
			this.Close();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Options options = Options.GetInstance();
			options.FormClosed += this.Options_FormClosed;
			options.Show();
		}

		private void Options_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.LoadSettings();
		}

		private void LoadSettings()
		{
			timer.Interval = Convert.ToInt32(Settings.Default.Delay * Math.Pow(60, (int)Settings.Default.TimeUnit)) * 1000;
			Settings.Default.SettingChanging += this.Default_SettingChanging;
		}

		private void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
		{
			MessageBox.Show("settings changed");
		}
	}
}
