using AntiAfkV2.Properties;

using System;
using System.Collections.Generic;
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
			this.SetTooltips();
		}

		private void SetTooltips()
		{
			List<string> daysOfWeek = new List<string>();
			foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
			{
				daysOfWeek.Add(dayOfWeek.ToString());
			}

			foreach (string dayOfWeek in daysOfWeek)
			{
				Label label = (Label)this.Controls.Find($"label_{dayOfWeek.ToLower()}", true)[0];
				ToolTip tt = new ToolTip();
				tt.SetToolTip(label, dayOfWeek);
			}
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			this.ClearInputs();
			numeric_delay.Value = Settings.Default.Delay;
			comboBox_timeUnit.SelectedIndex = (int)Settings.Default.TimeUnit;
			textBox_key.Text = Settings.Default.Key;
			schedulesList = Settings.Default.SchedulesList;
			foreach (Schedule schedule in schedulesList)
			{
				listBox_schedulers.Items.Add(schedule.Name);
			}
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

		private List<Schedule> schedulesList = new List<Schedule>();

		private void button_save_Click(object sender, EventArgs e)
		{
			if (numeric_delay.Value <= 0 || comboBox_timeUnit.SelectedIndex < 0 || comboBox_timeUnit.SelectedIndex > 2 || string.IsNullOrEmpty(textBox_key.Text))
			{
				this.ShowErrorMessage("Invalid settings.");
				return;
			}

			Settings.Default.SchedulesList = schedulesList;

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

		private void button_add_Click(object sender, EventArgs e)
		{
			List<DayOfWeek> selectedDaysOfWeek = this.GetSelectedDaysOfWeek();
			if (selectedDaysOfWeek.Count == 0)
			{
				this.ShowErrorMessage("Select some days of week.");
				return;
			}
			else if (this.DoesNameAlreadyExist(textBox_name.Text))
			{
				this.ShowErrorMessage("A schedule with that name already exists.");
				return;
			}
			Schedule schedule = new Schedule();
			schedule.Name = textBox_name.Text;
			schedule.ActivationHour = (int)numeric_hours.Value;
			schedule.ActivationMinute = (int)numeric_minutes.Value;
			schedule.DaysOfWeek = selectedDaysOfWeek;
			schedule.EnabledState = radio_enable.Checked;
			schedule.LockWindows = checkBox_lockWindows.Checked;

			if (EditingIndex == null)
			{
				schedulesList.Add(schedule);
				listBox_schedulers.Items.Add(schedule.Name);
				this.ClearInputs();
			}
			else
			{
				schedulesList[(int)EditingIndex] = schedule;
				listBox_schedulers.Items[(int)EditingIndex] = schedule.Name;
				this.ToggleEditing();
			}
		}

		private bool DoesNameAlreadyExist(string name)
		{
			int indexOf = listBox_schedulers.Items.IndexOf(name);
			return !(EditingIndex != null && indexOf == EditingIndex) || (EditingIndex == null && indexOf != -1);
		}

		private List<DayOfWeek> GetSelectedDaysOfWeek()
		{
			List<DayOfWeek> selectedDaysOfWeek = new List<DayOfWeek>();

			foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
			{
				CheckBox cb = (CheckBox)this.Controls.Find($"checkBox_{dayOfWeek}", true)[0];
				if (cb.Checked)
				{
					selectedDaysOfWeek.Add(dayOfWeek);
				}
			}

			return selectedDaysOfWeek;
		}

		public void SetInputValues(string name, int activationHours, int activationMinutes, List<DayOfWeek> selectedDaysOfWeek, bool enabledState, bool lockWindows)
		{
			textBox_name.Text = name;
			numeric_hours.Value = activationHours;
			numeric_minutes.Value = activationMinutes;
			foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
			{
				CheckBox cb = (CheckBox)this.Controls.Find($"checkBox_{dayOfWeek}", true)[0];
				cb.Checked = selectedDaysOfWeek.Contains(dayOfWeek);
			}
			if (enabledState)
			{
				radio_enable.Checked = true;
			}
			else
			{
				radio_disable.Checked = true;
			}
			checkBox_lockWindows.Checked = lockWindows;
		}

		private void ClearInputs()
		{
			this.SetInputValues("", 0, 0, new List<DayOfWeek>(), true, false);
		}

		private int? EditingIndex = null;

		private void button_edit_Click(object sender, EventArgs e)
		{
			if (EditingIndex == null)
			{
				if (listBox_schedulers.SelectedIndex >= 0)
				{
					Schedule schedule = schedulesList[listBox_schedulers.SelectedIndex];
					this.SetInputValues(schedule.Name, schedule.ActivationHour, schedule.ActivationMinute, schedule.DaysOfWeek, schedule.EnabledState, schedule.LockWindows);
					this.ToggleEditing();
				}
			}
			else
			{
				this.ToggleEditing();
			}
		}

		private void ToggleEditing()
		{
			if (EditingIndex == null)
			{
				EditingIndex = listBox_schedulers.SelectedIndex;
				listBox_schedulers.Enabled = false;
				button_edit.Text = "Cancel";
			}
			else
			{
				this.ClearInputs();
				EditingIndex = null;
				listBox_schedulers.Enabled = true;
				button_edit.Text = "Edit";
			}
		}

		private void button_remove_Click(object sender, EventArgs e)
		{
			if (listBox_schedulers.SelectedIndex >= 0)
			{
				schedulesList.RemoveAt(listBox_schedulers.SelectedIndex);
				listBox_schedulers.Items.RemoveAt(listBox_schedulers.SelectedIndex);
			}
		}

		private void ShowErrorMessage(string message)
		{
			MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
