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
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (enabledToolStripMenuItem.Checked)
			{
				try
				{
					SendKeys.Send("{SCROLLLOCK}");
				}
				catch { }
			}
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			notifyIcon.Visible = false;
			this.Close();
		}
	}
}
