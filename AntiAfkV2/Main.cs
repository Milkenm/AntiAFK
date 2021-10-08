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
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			SendKeys.Send("{SCROLLLOCK}");
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			notifyIcon.Visible = false;
			this.Close();
		}
	}
}
