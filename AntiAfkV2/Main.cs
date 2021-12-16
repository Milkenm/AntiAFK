using AntiAfkV2.Properties;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using static AntiAfkV2.Lib;

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
			Settings.Default.SettingChanging += this.Default_SettingChanging;

			this.Hide();
			enabledToolStripMenuItem.Checked = true;
			this.LoadSettings();
			timer.Start();

			if (Settings.Default.CheckForUpdates)
			{
				GitHubUpdate.CheckNewVersion();
			}
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

		private readonly List<Schedule> ranSchedulesList = new List<Schedule>();

		private void LoadSettings()
		{
			timer.Interval = Convert.ToInt32(Settings.Default.Delay * Math.Pow(60, (int)Settings.Default.TimeUnit)) * 1000;
		}

		private void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
		{
			this.LoadSettings();
		}

		private void timer_schedulers_Tick(object sender, EventArgs e)
		{
			SystemTime st = this.GetSystemTime();
			foreach (Schedule schedule in Settings.Default.SchedulesList)
			{
				if (schedule.DaysOfWeek.Contains(st.DayOfWeek) && schedule.ActivationHour == st.Hours && schedule.ActivationMinute == st.Minutes)
				{
					if (!ranSchedulesList.Contains(schedule))
					{
						enabledToolStripMenuItem.Checked = schedule.EnabledState;
						if (schedule.LockWindows)
						{
							LockWorkStation();
						}
						ranSchedulesList.Add(schedule);
					}
				}
				else if (ranSchedulesList.Contains(schedule))
				{
					ranSchedulesList.Remove(schedule);
				}
			}
		}

		private class SystemTime
		{
			public SystemTime(int hours, int minutes, DayOfWeek dayOfWeek)
			{
				this.Hours = hours;
				this.Minutes = minutes;
				this.DayOfWeek = dayOfWeek;
			}

			public int Hours { get; set; }
			public int Minutes { get; set; }
			public DayOfWeek DayOfWeek { get; set; }
		}

		private SystemTime GetSystemTime()
		{
			return new SystemTime(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.DayOfWeek);
		}
	}
}
