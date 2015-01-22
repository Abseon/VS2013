namespace SampleApp
{
    partial class MyForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.DataEntry = new System.Windows.Forms.TabPage();
            this.addEntry = new System.Windows.Forms.Button();
            this.leaveEnd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.leaveStart = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.homeNumberBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reports = new System.Windows.Forms.TabPage();
            this.viewTable = new System.Windows.Forms.TableLayoutPanel();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.scheduleTable = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleTimer = new System.Windows.Forms.Timer(this.components);
            this.scheduleNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.pendingDocuments = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.DataEntry.SuspendLayout();
            this.Reports.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.DataEntry);
            this.Tabs.Controls.Add(this.Reports);
            this.Tabs.Controls.Add(this.Schedule);
            this.Tabs.Location = new System.Drawing.Point(12, 27);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1160, 522);
            this.Tabs.TabIndex = 0;
            // 
            // DataEntry
            // 
            this.DataEntry.Controls.Add(this.addEntry);
            this.DataEntry.Controls.Add(this.leaveEnd);
            this.DataEntry.Controls.Add(this.label17);
            this.DataEntry.Controls.Add(this.leaveStart);
            this.DataEntry.Controls.Add(this.label16);
            this.DataEntry.Controls.Add(this.dateTimePicker1);
            this.DataEntry.Controls.Add(this.label15);
            this.DataEntry.Controls.Add(this.checkBox1);
            this.DataEntry.Controls.Add(this.label14);
            this.DataEntry.Controls.Add(this.comboBox2);
            this.DataEntry.Controls.Add(this.label13);
            this.DataEntry.Controls.Add(this.textBox11);
            this.DataEntry.Controls.Add(this.label12);
            this.DataEntry.Controls.Add(this.label11);
            this.DataEntry.Controls.Add(this.label10);
            this.DataEntry.Controls.Add(this.textBox8);
            this.DataEntry.Controls.Add(this.textBox9);
            this.DataEntry.Controls.Add(this.textBox10);
            this.DataEntry.Controls.Add(this.label9);
            this.DataEntry.Controls.Add(this.textBox7);
            this.DataEntry.Controls.Add(this.textBox6);
            this.DataEntry.Controls.Add(this.homeNumberBox);
            this.DataEntry.Controls.Add(this.label8);
            this.DataEntry.Controls.Add(this.label7);
            this.DataEntry.Controls.Add(this.comboBox1);
            this.DataEntry.Controls.Add(this.label6);
            this.DataEntry.Controls.Add(this.textBox4);
            this.DataEntry.Controls.Add(this.label5);
            this.DataEntry.Controls.Add(this.addressBox);
            this.DataEntry.Controls.Add(this.label4);
            this.DataEntry.Controls.Add(this.label3);
            this.DataEntry.Controls.Add(this.textBox2);
            this.DataEntry.Controls.Add(this.label2);
            this.DataEntry.Controls.Add(this.firstNameBox);
            this.DataEntry.Controls.Add(this.label1);
            this.DataEntry.Location = new System.Drawing.Point(4, 22);
            this.DataEntry.Name = "DataEntry";
            this.DataEntry.Padding = new System.Windows.Forms.Padding(3);
            this.DataEntry.Size = new System.Drawing.Size(1152, 496);
            this.DataEntry.TabIndex = 0;
            this.DataEntry.Text = "Data Entry";
            this.DataEntry.UseVisualStyleBackColor = true;
            // 
            // addEntry
            // 
            this.addEntry.Location = new System.Drawing.Point(456, 258);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(170, 23);
            this.addEntry.TabIndex = 34;
            this.addEntry.Text = "Enter";
            this.addEntry.UseVisualStyleBackColor = true;
            this.addEntry.Click += new System.EventHandler(this.onEntered);
            // 
            // leaveEnd
            // 
            this.leaveEnd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.leaveEnd.Enabled = false;
            this.leaveEnd.Location = new System.Drawing.Point(790, 215);
            this.leaveEnd.Name = "leaveEnd";
            this.leaveEnd.Size = new System.Drawing.Size(151, 20);
            this.leaveEnd.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(692, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Sick Leave Expiry";
            // 
            // leaveStart
            // 
            this.leaveStart.Location = new System.Drawing.Point(516, 215);
            this.leaveStart.Name = "leaveStart";
            this.leaveStart.Size = new System.Drawing.Size(152, 20);
            this.leaveStart.TabIndex = 31;
            this.leaveStart.ValueChanged += new System.EventHandler(this.leaveChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(402, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Sick Leave Start";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(517, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(402, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Referral Recieved";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(516, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(402, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "LTD Eligible";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Status 1",
            "Status 2",
            "Status 3",
            "Status 4",
            "Status 5"});
            this.comboBox2.Location = new System.Drawing.Point(516, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Status";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(517, 61);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(151, 20);
            this.textBox11.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(402, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Employee Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(529, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Employee Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label10.Location = new System.Drawing.Point(248, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ext";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(242, 303);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(29, 20);
            this.textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(163, 303);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(73, 20);
            this.textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(118, 303);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(39, 20);
            this.textBox10.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label9.Location = new System.Drawing.Point(248, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ext";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(242, 261);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(29, 20);
            this.textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(163, 261);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(73, 20);
            this.textBox6.TabIndex = 14;
            // 
            // homeNumberBox
            // 
            this.homeNumberBox.Location = new System.Drawing.Point(118, 261);
            this.homeNumberBox.Name = "homeNumberBox";
            this.homeNumberBox.Size = new System.Drawing.Size(39, 20);
            this.homeNumberBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Work Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Home Number";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alberta",
            "Manitoba",
            "New Brunswick",
            "Newfoundland",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan"});
            this.comboBox1.Location = new System.Drawing.Point(118, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Province";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "City";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(118, 137);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(152, 20);
            this.addressBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(115, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personal Info";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(119, 64);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(151, 20);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.viewTable);
            this.Reports.Location = new System.Drawing.Point(4, 22);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(1152, 496);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // viewTable
            // 
            this.viewTable.AutoScroll = true;
            this.viewTable.ColumnCount = 3;
            this.viewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.viewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.viewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.viewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.Location = new System.Drawing.Point(6, 6);
            this.viewTable.Name = "viewTable";
            this.viewTable.RowCount = 16;
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTable.Size = new System.Drawing.Size(1128, 484);
            this.viewTable.TabIndex = 0;
            // 
            // Schedule
            // 
            this.Schedule.Controls.Add(this.label20);
            this.Schedule.Controls.Add(this.label19);
            this.Schedule.Controls.Add(this.label18);
            this.Schedule.Controls.Add(this.scheduleTable);
            this.Schedule.Location = new System.Drawing.Point(4, 22);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(1152, 496);
            this.Schedule.TabIndex = 2;
            this.Schedule.Text = "Scheduling";
            this.Schedule.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(250, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Date (+7 days)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(204, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Pending Documents";
            // 
            // scheduleTable
            // 
            this.scheduleTable.ColumnCount = 2;
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scheduleTable.Location = new System.Drawing.Point(30, 78);
            this.scheduleTable.Name = "scheduleTable";
            this.scheduleTable.RowCount = 2;
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scheduleTable.Size = new System.Drawing.Size(439, 100);
            this.scheduleTable.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // scheduleTimer
            // 
            this.scheduleTimer.Tick += new System.EventHandler(this.scheduleCheck);
            // 
            // scheduleNotify
            // 
            this.scheduleNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.scheduleNotify.BalloonTipText = "Documents Pending";
            this.scheduleNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("scheduleNotify.Icon")));
            this.scheduleNotify.Text = "notifySchedule";
            this.scheduleNotify.Visible = true;
            // 
            // pendingDocuments
            // 
            this.pendingDocuments.AutoSize = true;
            this.pendingDocuments.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pendingDocuments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pendingDocuments.Location = new System.Drawing.Point(204, 24);
            this.pendingDocuments.Name = "pendingDocuments";
            this.pendingDocuments.Size = new System.Drawing.Size(103, 13);
            this.pendingDocuments.TabIndex = 2;
            this.pendingDocuments.Text = "Documents Pending";
            this.pendingDocuments.Visible = false;
            this.pendingDocuments.Click += new System.EventHandler(this.alertSilence);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pendingDocuments);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyForm";
            this.Text = "Disability Services Database Sample";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.Tabs.ResumeLayout(false);
            this.DataEntry.ResumeLayout(false);
            this.DataEntry.PerformLayout();
            this.Reports.ResumeLayout(false);
            this.Schedule.ResumeLayout(false);
            this.Schedule.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage DataEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox homeNumberBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker leaveStart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox leaveEnd;
        private System.Windows.Forms.Button addEntry;
        private System.Windows.Forms.TableLayoutPanel viewTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel scheduleTable;
        private System.Windows.Forms.Timer scheduleTimer;
        private System.Windows.Forms.NotifyIcon scheduleNotify;
        private System.Windows.Forms.Label pendingDocuments;

    }
}

