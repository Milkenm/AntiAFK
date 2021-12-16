
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
			this.button_save = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_default = new System.Windows.Forms.Button();
			this.tableLayout_main = new System.Windows.Forms.TableLayoutPanel();
			this.panel_buttons = new System.Windows.Forms.Panel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage_settings = new System.Windows.Forms.TabPage();
			this.label_delay = new System.Windows.Forms.Label();
			this.numeric_delay = new System.Windows.Forms.NumericUpDown();
			this.comboBox_timeUnit = new System.Windows.Forms.ComboBox();
			this.label_key = new System.Windows.Forms.Label();
			this.textBox_key = new System.Windows.Forms.TextBox();
			this.checkBox_checkForUpdates = new System.Windows.Forms.CheckBox();
			this.tabPage_scheduler = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel_settings = new System.Windows.Forms.Panel();
			this.label_name = new System.Windows.Forms.Label();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.label_activationTime = new System.Windows.Forms.Label();
			this.numeric_hours = new System.Windows.Forms.NumericUpDown();
			this.label_hours = new System.Windows.Forms.Label();
			this.numeric_minutes = new System.Windows.Forms.NumericUpDown();
			this.label_minutes = new System.Windows.Forms.Label();
			this.panel_weekDays = new System.Windows.Forms.Panel();
			this.label_sunday = new System.Windows.Forms.Label();
			this.checkBox_sunday = new System.Windows.Forms.CheckBox();
			this.label_monday = new System.Windows.Forms.Label();
			this.checkBox_monday = new System.Windows.Forms.CheckBox();
			this.label_tuesday = new System.Windows.Forms.Label();
			this.checkBox_tuesday = new System.Windows.Forms.CheckBox();
			this.label_wednesday = new System.Windows.Forms.Label();
			this.checkBox_wednesday = new System.Windows.Forms.CheckBox();
			this.label_thursday = new System.Windows.Forms.Label();
			this.checkBox_thursday = new System.Windows.Forms.CheckBox();
			this.label_friday = new System.Windows.Forms.Label();
			this.checkBox_friday = new System.Windows.Forms.CheckBox();
			this.label_saturday = new System.Windows.Forms.Label();
			this.checkBox_saturday = new System.Windows.Forms.CheckBox();
			this.label_action = new System.Windows.Forms.Label();
			this.panel_action = new System.Windows.Forms.Panel();
			this.radio_enable = new System.Windows.Forms.RadioButton();
			this.radio_disable = new System.Windows.Forms.RadioButton();
			this.checkBox_lockWindows = new System.Windows.Forms.CheckBox();
			this.tableLayout_schedulerList = new System.Windows.Forms.TableLayoutPanel();
			this.listBox_schedulers = new System.Windows.Forms.ListBox();
			this.panel_schedulerButtons = new System.Windows.Forms.Panel();
			this.button_add = new System.Windows.Forms.Button();
			this.button_edit = new System.Windows.Forms.Button();
			this.button_remove = new System.Windows.Forms.Button();
			this.tabPage_about = new System.Windows.Forms.TabPage();
			this.label_by = new System.Windows.Forms.Label();
			this.link_milkenm = new System.Windows.Forms.LinkLabel();
			this.link_github = new System.Windows.Forms.LinkLabel();
			this.link_issues = new System.Windows.Forms.LinkLabel();
			this.label_version = new System.Windows.Forms.Label();
			this.button_checkUpdate = new System.Windows.Forms.Button();
			this.tableLayout_main.SuspendLayout();
			this.panel_buttons.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage_settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_delay)).BeginInit();
			this.tabPage_scheduler.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel_settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_hours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_minutes)).BeginInit();
			this.panel_weekDays.SuspendLayout();
			this.panel_action.SuspendLayout();
			this.tableLayout_schedulerList.SuspendLayout();
			this.panel_schedulerButtons.SuspendLayout();
			this.tabPage_about.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_save
			// 
			this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_save.Location = new System.Drawing.Point(181, 3);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(75, 23);
			this.button_save.TabIndex = 5;
			this.button_save.Text = "Save";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(262, 3);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(75, 23);
			this.button_cancel.TabIndex = 6;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_default
			// 
			this.button_default.Location = new System.Drawing.Point(8, 173);
			this.button_default.Name = "button_default";
			this.button_default.Size = new System.Drawing.Size(70, 23);
			this.button_default.TabIndex = 7;
			this.button_default.Text = "Default";
			this.button_default.UseVisualStyleBackColor = true;
			this.button_default.Click += new System.EventHandler(this.button_default_Click);
			// 
			// tableLayout_main
			// 
			this.tableLayout_main.ColumnCount = 1;
			this.tableLayout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayout_main.Controls.Add(this.panel_buttons, 0, 1);
			this.tableLayout_main.Controls.Add(this.tabControl, 0, 0);
			this.tableLayout_main.Cursor = System.Windows.Forms.Cursors.Default;
			this.tableLayout_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayout_main.Location = new System.Drawing.Point(0, 0);
			this.tableLayout_main.Name = "tableLayout_main";
			this.tableLayout_main.RowCount = 2;
			this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayout_main.Size = new System.Drawing.Size(344, 261);
			this.tableLayout_main.TabIndex = 9;
			// 
			// panel_buttons
			// 
			this.panel_buttons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel_buttons.Controls.Add(this.button_save);
			this.panel_buttons.Controls.Add(this.button_cancel);
			this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_buttons.Location = new System.Drawing.Point(0, 229);
			this.panel_buttons.Margin = new System.Windows.Forms.Padding(0);
			this.panel_buttons.Name = "panel_buttons";
			this.panel_buttons.Size = new System.Drawing.Size(344, 32);
			this.panel_buttons.TabIndex = 10;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage_settings);
			this.tabControl.Controls.Add(this.tabPage_scheduler);
			this.tabControl.Controls.Add(this.tabPage_about);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(344, 229);
			this.tabControl.TabIndex = 11;
			// 
			// tabPage_settings
			// 
			this.tabPage_settings.Controls.Add(this.label_delay);
			this.tabPage_settings.Controls.Add(this.numeric_delay);
			this.tabPage_settings.Controls.Add(this.comboBox_timeUnit);
			this.tabPage_settings.Controls.Add(this.label_key);
			this.tabPage_settings.Controls.Add(this.textBox_key);
			this.tabPage_settings.Controls.Add(this.checkBox_checkForUpdates);
			this.tabPage_settings.Controls.Add(this.button_default);
			this.tabPage_settings.Location = new System.Drawing.Point(4, 22);
			this.tabPage_settings.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage_settings.Name = "tabPage_settings";
			this.tabPage_settings.Size = new System.Drawing.Size(336, 203);
			this.tabPage_settings.TabIndex = 0;
			this.tabPage_settings.Text = "Settings";
			this.tabPage_settings.UseVisualStyleBackColor = true;
			// 
			// label_delay
			// 
			this.label_delay.AutoSize = true;
			this.label_delay.Location = new System.Drawing.Point(26, 49);
			this.label_delay.Name = "label_delay";
			this.label_delay.Size = new System.Drawing.Size(37, 13);
			this.label_delay.TabIndex = 1;
			this.label_delay.Text = "Delay:";
			// 
			// numeric_delay
			// 
			this.numeric_delay.Location = new System.Drawing.Point(72, 50);
			this.numeric_delay.Name = "numeric_delay";
			this.numeric_delay.Size = new System.Drawing.Size(112, 20);
			this.numeric_delay.TabIndex = 0;
			this.numeric_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// comboBox_timeUnit
			// 
			this.comboBox_timeUnit.FormattingEnabled = true;
			this.comboBox_timeUnit.Items.AddRange(new object[] {
            "seconds",
            "minutes",
            "hours"});
			this.comboBox_timeUnit.Location = new System.Drawing.Point(190, 49);
			this.comboBox_timeUnit.Name = "comboBox_timeUnit";
			this.comboBox_timeUnit.Size = new System.Drawing.Size(121, 21);
			this.comboBox_timeUnit.TabIndex = 2;
			// 
			// label_key
			// 
			this.label_key.AutoSize = true;
			this.label_key.Location = new System.Drawing.Point(35, 94);
			this.label_key.Name = "label_key";
			this.label_key.Size = new System.Drawing.Size(28, 13);
			this.label_key.TabIndex = 3;
			this.label_key.Text = "Key:";
			// 
			// textBox_key
			// 
			this.textBox_key.Location = new System.Drawing.Point(72, 94);
			this.textBox_key.Name = "textBox_key";
			this.textBox_key.Size = new System.Drawing.Size(112, 20);
			this.textBox_key.TabIndex = 4;
			this.textBox_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// checkBox_checkForUpdates
			// 
			this.checkBox_checkForUpdates.AutoSize = true;
			this.checkBox_checkForUpdates.Location = new System.Drawing.Point(72, 134);
			this.checkBox_checkForUpdates.Name = "checkBox_checkForUpdates";
			this.checkBox_checkForUpdates.Size = new System.Drawing.Size(160, 17);
			this.checkBox_checkForUpdates.TabIndex = 8;
			this.checkBox_checkForUpdates.Text = "Check for updates at startup";
			this.checkBox_checkForUpdates.UseVisualStyleBackColor = true;
			// 
			// tabPage_scheduler
			// 
			this.tabPage_scheduler.Controls.Add(this.tableLayoutPanel2);
			this.tabPage_scheduler.Location = new System.Drawing.Point(4, 22);
			this.tabPage_scheduler.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage_scheduler.Name = "tabPage_scheduler";
			this.tabPage_scheduler.Size = new System.Drawing.Size(336, 203);
			this.tabPage_scheduler.TabIndex = 1;
			this.tabPage_scheduler.Text = "Scheduler";
			this.tabPage_scheduler.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.panel_settings, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayout_schedulerList, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 203);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// panel_settings
			// 
			this.panel_settings.Controls.Add(this.label_name);
			this.panel_settings.Controls.Add(this.textBox_name);
			this.panel_settings.Controls.Add(this.label_activationTime);
			this.panel_settings.Controls.Add(this.numeric_hours);
			this.panel_settings.Controls.Add(this.label_hours);
			this.panel_settings.Controls.Add(this.numeric_minutes);
			this.panel_settings.Controls.Add(this.label_minutes);
			this.panel_settings.Controls.Add(this.panel_weekDays);
			this.panel_settings.Controls.Add(this.label_action);
			this.panel_settings.Controls.Add(this.panel_action);
			this.panel_settings.Controls.Add(this.checkBox_lockWindows);
			this.panel_settings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_settings.Location = new System.Drawing.Point(0, 0);
			this.panel_settings.Margin = new System.Windows.Forms.Padding(0);
			this.panel_settings.Name = "panel_settings";
			this.panel_settings.Size = new System.Drawing.Size(168, 203);
			this.panel_settings.TabIndex = 1;
			// 
			// label_name
			// 
			this.label_name.AutoSize = true;
			this.label_name.Location = new System.Drawing.Point(12, 7);
			this.label_name.Name = "label_name";
			this.label_name.Size = new System.Drawing.Size(35, 13);
			this.label_name.TabIndex = 1;
			this.label_name.Text = "Name";
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(18, 23);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(129, 20);
			this.textBox_name.TabIndex = 0;
			// 
			// label_activationTime
			// 
			this.label_activationTime.AutoSize = true;
			this.label_activationTime.Location = new System.Drawing.Point(12, 51);
			this.label_activationTime.Name = "label_activationTime";
			this.label_activationTime.Size = new System.Drawing.Size(80, 13);
			this.label_activationTime.TabIndex = 17;
			this.label_activationTime.Text = "Activation Time";
			// 
			// numeric_hours
			// 
			this.numeric_hours.Location = new System.Drawing.Point(15, 67);
			this.numeric_hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.numeric_hours.Name = "numeric_hours";
			this.numeric_hours.Size = new System.Drawing.Size(53, 20);
			this.numeric_hours.TabIndex = 27;
			// 
			// label_hours
			// 
			this.label_hours.AutoSize = true;
			this.label_hours.Location = new System.Drawing.Point(69, 69);
			this.label_hours.Name = "label_hours";
			this.label_hours.Size = new System.Drawing.Size(19, 13);
			this.label_hours.TabIndex = 29;
			this.label_hours.Text = "h :";
			// 
			// numeric_minutes
			// 
			this.numeric_minutes.Location = new System.Drawing.Point(88, 67);
			this.numeric_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numeric_minutes.Name = "numeric_minutes";
			this.numeric_minutes.Size = new System.Drawing.Size(53, 20);
			this.numeric_minutes.TabIndex = 28;
			// 
			// label_minutes
			// 
			this.label_minutes.AutoSize = true;
			this.label_minutes.Location = new System.Drawing.Point(142, 69);
			this.label_minutes.Name = "label_minutes";
			this.label_minutes.Size = new System.Drawing.Size(15, 13);
			this.label_minutes.TabIndex = 30;
			this.label_minutes.Text = "m";
			// 
			// panel_weekDays
			// 
			this.panel_weekDays.Controls.Add(this.label_sunday);
			this.panel_weekDays.Controls.Add(this.checkBox_sunday);
			this.panel_weekDays.Controls.Add(this.label_monday);
			this.panel_weekDays.Controls.Add(this.checkBox_monday);
			this.panel_weekDays.Controls.Add(this.label_tuesday);
			this.panel_weekDays.Controls.Add(this.checkBox_tuesday);
			this.panel_weekDays.Controls.Add(this.label_wednesday);
			this.panel_weekDays.Controls.Add(this.checkBox_wednesday);
			this.panel_weekDays.Controls.Add(this.label_thursday);
			this.panel_weekDays.Controls.Add(this.checkBox_thursday);
			this.panel_weekDays.Controls.Add(this.label_friday);
			this.panel_weekDays.Controls.Add(this.checkBox_friday);
			this.panel_weekDays.Controls.Add(this.label_saturday);
			this.panel_weekDays.Controls.Add(this.checkBox_saturday);
			this.panel_weekDays.Location = new System.Drawing.Point(10, 93);
			this.panel_weekDays.Name = "panel_weekDays";
			this.panel_weekDays.Size = new System.Drawing.Size(148, 35);
			this.panel_weekDays.TabIndex = 26;
			// 
			// label_sunday
			// 
			this.label_sunday.AutoSize = true;
			this.label_sunday.Location = new System.Drawing.Point(4, 2);
			this.label_sunday.Name = "label_sunday";
			this.label_sunday.Size = new System.Drawing.Size(14, 13);
			this.label_sunday.TabIndex = 23;
			this.label_sunday.Text = "S";
			// 
			// checkBox_sunday
			// 
			this.checkBox_sunday.AutoSize = true;
			this.checkBox_sunday.Location = new System.Drawing.Point(4, 18);
			this.checkBox_sunday.Name = "checkBox_sunday";
			this.checkBox_sunday.Size = new System.Drawing.Size(15, 14);
			this.checkBox_sunday.TabIndex = 16;
			this.checkBox_sunday.UseVisualStyleBackColor = true;
			// 
			// label_monday
			// 
			this.label_monday.AutoSize = true;
			this.label_monday.Location = new System.Drawing.Point(24, 2);
			this.label_monday.Name = "label_monday";
			this.label_monday.Size = new System.Drawing.Size(16, 13);
			this.label_monday.TabIndex = 24;
			this.label_monday.Text = "M";
			// 
			// checkBox_monday
			// 
			this.checkBox_monday.AutoSize = true;
			this.checkBox_monday.Location = new System.Drawing.Point(25, 18);
			this.checkBox_monday.Name = "checkBox_monday";
			this.checkBox_monday.Size = new System.Drawing.Size(15, 14);
			this.checkBox_monday.TabIndex = 17;
			this.checkBox_monday.UseVisualStyleBackColor = true;
			// 
			// label_tuesday
			// 
			this.label_tuesday.AutoSize = true;
			this.label_tuesday.Location = new System.Drawing.Point(45, 2);
			this.label_tuesday.Name = "label_tuesday";
			this.label_tuesday.Size = new System.Drawing.Size(14, 13);
			this.label_tuesday.TabIndex = 25;
			this.label_tuesday.Text = "T";
			// 
			// checkBox_tuesday
			// 
			this.checkBox_tuesday.AutoSize = true;
			this.checkBox_tuesday.Location = new System.Drawing.Point(46, 18);
			this.checkBox_tuesday.Name = "checkBox_tuesday";
			this.checkBox_tuesday.Size = new System.Drawing.Size(15, 14);
			this.checkBox_tuesday.TabIndex = 18;
			this.checkBox_tuesday.UseVisualStyleBackColor = true;
			// 
			// label_wednesday
			// 
			this.label_wednesday.AutoSize = true;
			this.label_wednesday.Location = new System.Drawing.Point(65, 2);
			this.label_wednesday.Name = "label_wednesday";
			this.label_wednesday.Size = new System.Drawing.Size(18, 13);
			this.label_wednesday.TabIndex = 26;
			this.label_wednesday.Text = "W";
			// 
			// checkBox_wednesday
			// 
			this.checkBox_wednesday.AutoSize = true;
			this.checkBox_wednesday.Location = new System.Drawing.Point(67, 18);
			this.checkBox_wednesday.Name = "checkBox_wednesday";
			this.checkBox_wednesday.Size = new System.Drawing.Size(15, 14);
			this.checkBox_wednesday.TabIndex = 19;
			this.checkBox_wednesday.UseVisualStyleBackColor = true;
			// 
			// label_thursday
			// 
			this.label_thursday.AutoSize = true;
			this.label_thursday.Location = new System.Drawing.Point(88, 2);
			this.label_thursday.Name = "label_thursday";
			this.label_thursday.Size = new System.Drawing.Size(14, 13);
			this.label_thursday.TabIndex = 27;
			this.label_thursday.Text = "T";
			// 
			// checkBox_thursday
			// 
			this.checkBox_thursday.AutoSize = true;
			this.checkBox_thursday.Location = new System.Drawing.Point(88, 18);
			this.checkBox_thursday.Name = "checkBox_thursday";
			this.checkBox_thursday.Size = new System.Drawing.Size(15, 14);
			this.checkBox_thursday.TabIndex = 20;
			this.checkBox_thursday.UseVisualStyleBackColor = true;
			// 
			// label_friday
			// 
			this.label_friday.AutoSize = true;
			this.label_friday.Location = new System.Drawing.Point(110, 2);
			this.label_friday.Name = "label_friday";
			this.label_friday.Size = new System.Drawing.Size(13, 13);
			this.label_friday.TabIndex = 28;
			this.label_friday.Text = "F";
			// 
			// checkBox_friday
			// 
			this.checkBox_friday.AutoSize = true;
			this.checkBox_friday.Location = new System.Drawing.Point(109, 18);
			this.checkBox_friday.Name = "checkBox_friday";
			this.checkBox_friday.Size = new System.Drawing.Size(15, 14);
			this.checkBox_friday.TabIndex = 21;
			this.checkBox_friday.UseVisualStyleBackColor = true;
			// 
			// label_saturday
			// 
			this.label_saturday.AutoSize = true;
			this.label_saturday.Location = new System.Drawing.Point(130, 2);
			this.label_saturday.Name = "label_saturday";
			this.label_saturday.Size = new System.Drawing.Size(14, 13);
			this.label_saturday.TabIndex = 29;
			this.label_saturday.Text = "S";
			// 
			// checkBox_saturday
			// 
			this.checkBox_saturday.AutoSize = true;
			this.checkBox_saturday.Location = new System.Drawing.Point(130, 18);
			this.checkBox_saturday.Name = "checkBox_saturday";
			this.checkBox_saturday.Size = new System.Drawing.Size(15, 14);
			this.checkBox_saturday.TabIndex = 22;
			this.checkBox_saturday.UseVisualStyleBackColor = true;
			// 
			// label_action
			// 
			this.label_action.AutoSize = true;
			this.label_action.Location = new System.Drawing.Point(13, 131);
			this.label_action.Name = "label_action";
			this.label_action.Size = new System.Drawing.Size(37, 13);
			this.label_action.TabIndex = 23;
			this.label_action.Text = "Action";
			// 
			// panel_action
			// 
			this.panel_action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_action.Controls.Add(this.radio_enable);
			this.panel_action.Controls.Add(this.radio_disable);
			this.panel_action.Location = new System.Drawing.Point(19, 147);
			this.panel_action.Margin = new System.Windows.Forms.Padding(0);
			this.panel_action.Name = "panel_action";
			this.panel_action.Size = new System.Drawing.Size(129, 21);
			this.panel_action.TabIndex = 24;
			// 
			// radio_enable
			// 
			this.radio_enable.AutoSize = true;
			this.radio_enable.Location = new System.Drawing.Point(3, 1);
			this.radio_enable.Name = "radio_enable";
			this.radio_enable.Size = new System.Drawing.Size(58, 17);
			this.radio_enable.TabIndex = 19;
			this.radio_enable.TabStop = true;
			this.radio_enable.Text = "Enable";
			this.radio_enable.UseVisualStyleBackColor = true;
			// 
			// radio_disable
			// 
			this.radio_disable.AutoSize = true;
			this.radio_disable.Location = new System.Drawing.Point(69, 1);
			this.radio_disable.Name = "radio_disable";
			this.radio_disable.Size = new System.Drawing.Size(60, 17);
			this.radio_disable.TabIndex = 20;
			this.radio_disable.TabStop = true;
			this.radio_disable.Text = "Disable";
			this.radio_disable.UseVisualStyleBackColor = true;
			// 
			// checkBox_lockWindows
			// 
			this.checkBox_lockWindows.AutoSize = true;
			this.checkBox_lockWindows.Location = new System.Drawing.Point(19, 178);
			this.checkBox_lockWindows.Name = "checkBox_lockWindows";
			this.checkBox_lockWindows.Size = new System.Drawing.Size(137, 17);
			this.checkBox_lockWindows.TabIndex = 25;
			this.checkBox_lockWindows.Text = "Lock Windows (Win+L)";
			this.checkBox_lockWindows.UseVisualStyleBackColor = true;
			// 
			// tableLayout_schedulerList
			// 
			this.tableLayout_schedulerList.ColumnCount = 1;
			this.tableLayout_schedulerList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayout_schedulerList.Controls.Add(this.listBox_schedulers, 0, 0);
			this.tableLayout_schedulerList.Controls.Add(this.panel_schedulerButtons, 0, 1);
			this.tableLayout_schedulerList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayout_schedulerList.Location = new System.Drawing.Point(168, 0);
			this.tableLayout_schedulerList.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayout_schedulerList.Name = "tableLayout_schedulerList";
			this.tableLayout_schedulerList.RowCount = 2;
			this.tableLayout_schedulerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayout_schedulerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayout_schedulerList.Size = new System.Drawing.Size(168, 203);
			this.tableLayout_schedulerList.TabIndex = 2;
			// 
			// listBox_schedulers
			// 
			this.listBox_schedulers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox_schedulers.FormattingEnabled = true;
			this.listBox_schedulers.Location = new System.Drawing.Point(0, 0);
			this.listBox_schedulers.Margin = new System.Windows.Forms.Padding(0);
			this.listBox_schedulers.Name = "listBox_schedulers";
			this.listBox_schedulers.Size = new System.Drawing.Size(168, 177);
			this.listBox_schedulers.TabIndex = 1;
			// 
			// panel_schedulerButtons
			// 
			this.panel_schedulerButtons.Controls.Add(this.button_add);
			this.panel_schedulerButtons.Controls.Add(this.button_edit);
			this.panel_schedulerButtons.Controls.Add(this.button_remove);
			this.panel_schedulerButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_schedulerButtons.Location = new System.Drawing.Point(0, 177);
			this.panel_schedulerButtons.Margin = new System.Windows.Forms.Padding(0);
			this.panel_schedulerButtons.Name = "panel_schedulerButtons";
			this.panel_schedulerButtons.Size = new System.Drawing.Size(168, 26);
			this.panel_schedulerButtons.TabIndex = 2;
			// 
			// button_add
			// 
			this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_add.Location = new System.Drawing.Point(0, 3);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(38, 20);
			this.button_add.TabIndex = 7;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// button_edit
			// 
			this.button_edit.Location = new System.Drawing.Point(41, 3);
			this.button_edit.Name = "button_edit";
			this.button_edit.Size = new System.Drawing.Size(52, 20);
			this.button_edit.TabIndex = 9;
			this.button_edit.Text = "Edit";
			this.button_edit.UseVisualStyleBackColor = true;
			this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
			// 
			// button_remove
			// 
			this.button_remove.Location = new System.Drawing.Point(106, 3);
			this.button_remove.Name = "button_remove";
			this.button_remove.Size = new System.Drawing.Size(62, 20);
			this.button_remove.TabIndex = 8;
			this.button_remove.Text = "Remove";
			this.button_remove.UseVisualStyleBackColor = true;
			this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
			// 
			// tabPage_about
			// 
			this.tabPage_about.Controls.Add(this.label_by);
			this.tabPage_about.Controls.Add(this.link_milkenm);
			this.tabPage_about.Controls.Add(this.link_github);
			this.tabPage_about.Controls.Add(this.link_issues);
			this.tabPage_about.Controls.Add(this.label_version);
			this.tabPage_about.Controls.Add(this.button_checkUpdate);
			this.tabPage_about.Location = new System.Drawing.Point(4, 22);
			this.tabPage_about.Name = "tabPage_about";
			this.tabPage_about.Size = new System.Drawing.Size(336, 203);
			this.tabPage_about.TabIndex = 2;
			this.tabPage_about.Text = "About";
			this.tabPage_about.UseVisualStyleBackColor = true;
			// 
			// label_by
			// 
			this.label_by.AutoSize = true;
			this.label_by.Location = new System.Drawing.Point(8, 11);
			this.label_by.Name = "label_by";
			this.label_by.Size = new System.Drawing.Size(25, 13);
			this.label_by.TabIndex = 0;
			this.label_by.Text = "By: ";
			// 
			// link_milkenm
			// 
			this.link_milkenm.AutoSize = true;
			this.link_milkenm.Location = new System.Drawing.Point(30, 11);
			this.link_milkenm.Name = "link_milkenm";
			this.link_milkenm.Size = new System.Drawing.Size(46, 13);
			this.link_milkenm.TabIndex = 1;
			this.link_milkenm.TabStop = true;
			this.link_milkenm.Text = "Milkenm";
			this.link_milkenm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_milkenm_LinkClicked);
			// 
			// link_github
			// 
			this.link_github.AutoSize = true;
			this.link_github.Location = new System.Drawing.Point(8, 41);
			this.link_github.Name = "link_github";
			this.link_github.Size = new System.Drawing.Size(111, 13);
			this.link_github.TabIndex = 2;
			this.link_github.TabStop = true;
			this.link_github.Text = "Source Code (GitHub)";
			this.link_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_github_LinkClicked);
			// 
			// link_issues
			// 
			this.link_issues.AutoSize = true;
			this.link_issues.Location = new System.Drawing.Point(8, 71);
			this.link_issues.Name = "link_issues";
			this.link_issues.Size = new System.Drawing.Size(179, 13);
			this.link_issues.TabIndex = 3;
			this.link_issues.TabStop = true;
			this.link_issues.Text = "Report a bug / Request new feature";
			this.link_issues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_issues_LinkClicked);
			// 
			// label_version
			// 
			this.label_version.AutoSize = true;
			this.label_version.Location = new System.Drawing.Point(8, 173);
			this.label_version.Name = "label_version";
			this.label_version.Size = new System.Drawing.Size(28, 13);
			this.label_version.TabIndex = 4;
			this.label_version.Text = "v2.0";
			// 
			// button_checkUpdate
			// 
			this.button_checkUpdate.Location = new System.Drawing.Point(42, 168);
			this.button_checkUpdate.Name = "button_checkUpdate";
			this.button_checkUpdate.Size = new System.Drawing.Size(104, 23);
			this.button_checkUpdate.TabIndex = 5;
			this.button_checkUpdate.Text = "Check for updates";
			this.button_checkUpdate.UseVisualStyleBackColor = true;
			this.button_checkUpdate.Click += new System.EventHandler(this.button_checkUpdate_Click);
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 261);
			this.Controls.Add(this.tableLayout_main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Options";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AntiAFK";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
			this.Load += new System.EventHandler(this.Settings_Load);
			this.tableLayout_main.ResumeLayout(false);
			this.panel_buttons.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabPage_settings.ResumeLayout(false);
			this.tabPage_settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_delay)).EndInit();
			this.tabPage_scheduler.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel_settings.ResumeLayout(false);
			this.panel_settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_hours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_minutes)).EndInit();
			this.panel_weekDays.ResumeLayout(false);
			this.panel_weekDays.PerformLayout();
			this.panel_action.ResumeLayout(false);
			this.panel_action.PerformLayout();
			this.tableLayout_schedulerList.ResumeLayout(false);
			this.panel_schedulerButtons.ResumeLayout(false);
			this.tabPage_about.ResumeLayout(false);
			this.tabPage_about.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button_save;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_default;
		private System.Windows.Forms.TableLayoutPanel tableLayout_main;
		private System.Windows.Forms.Panel panel_buttons;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage_settings;
		private System.Windows.Forms.ComboBox comboBox_timeUnit;
		private System.Windows.Forms.Label label_delay;
		private System.Windows.Forms.TextBox textBox_key;
		private System.Windows.Forms.NumericUpDown numeric_delay;
		private System.Windows.Forms.Label label_key;
		private System.Windows.Forms.TabPage tabPage_scheduler;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel_settings;
		private System.Windows.Forms.Label label_name;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.TableLayoutPanel tableLayout_schedulerList;
		private System.Windows.Forms.ListBox listBox_schedulers;
		private System.Windows.Forms.Panel panel_schedulerButtons;
		private System.Windows.Forms.Button button_edit;
		private System.Windows.Forms.Button button_remove;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Label label_activationTime;
		private System.Windows.Forms.CheckBox checkBox_lockWindows;
		private System.Windows.Forms.Panel panel_action;
		private System.Windows.Forms.RadioButton radio_enable;
		private System.Windows.Forms.RadioButton radio_disable;
		private System.Windows.Forms.Label label_action;
		private System.Windows.Forms.TabPage tabPage_about;
		private System.Windows.Forms.CheckBox checkBox_checkForUpdates;
		private System.Windows.Forms.Panel panel_weekDays;
		private System.Windows.Forms.Label label_sunday;
		private System.Windows.Forms.CheckBox checkBox_sunday;
		private System.Windows.Forms.Label label_monday;
		private System.Windows.Forms.CheckBox checkBox_monday;
		private System.Windows.Forms.Label label_tuesday;
		private System.Windows.Forms.CheckBox checkBox_tuesday;
		private System.Windows.Forms.Label label_wednesday;
		private System.Windows.Forms.CheckBox checkBox_wednesday;
		private System.Windows.Forms.Label label_thursday;
		private System.Windows.Forms.CheckBox checkBox_thursday;
		private System.Windows.Forms.Label label_friday;
		private System.Windows.Forms.CheckBox checkBox_friday;
		private System.Windows.Forms.Label label_saturday;
		private System.Windows.Forms.CheckBox checkBox_saturday;
		private System.Windows.Forms.Label label_minutes;
		private System.Windows.Forms.Label label_hours;
		private System.Windows.Forms.NumericUpDown numeric_minutes;
		private System.Windows.Forms.NumericUpDown numeric_hours;
		private System.Windows.Forms.Button button_checkUpdate;
		private System.Windows.Forms.Label label_version;
		private System.Windows.Forms.LinkLabel link_issues;
		private System.Windows.Forms.LinkLabel link_github;
		private System.Windows.Forms.LinkLabel link_milkenm;
		private System.Windows.Forms.Label label_by;
	}
}