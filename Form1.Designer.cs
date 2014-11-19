namespace binary_clock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.time = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_time_dec = new System.Windows.Forms.Label();
            this.lbl_time_bin_min = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_time_bin_sec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Img_clock = new System.Windows.Forms.PictureBox();
            this.chk_sec_mil = new System.Windows.Forms.CheckBox();
            this.chk_mil_min = new System.Windows.Forms.CheckBox();
            this.chk_mil_hour = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmd_about = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_ticks = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_day_year = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nfi_tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.right_click = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.click_time = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_hide = new System.Windows.Forms.Timer(this.components);
            this.tim_show = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Img_clock)).BeginInit();
            this.right_click.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.Lime;
            this.lbl_time.Location = new System.Drawing.Point(-15, 57);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(188, 25);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "0000000000000000";
            // 
            // lbl_time_dec
            // 
            this.lbl_time_dec.AutoSize = true;
            this.lbl_time_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_dec.Location = new System.Drawing.Point(4, 7);
            this.lbl_time_dec.Name = "lbl_time_dec";
            this.lbl_time_dec.Size = new System.Drawing.Size(90, 25);
            this.lbl_time_dec.TabIndex = 1;
            this.lbl_time_dec.Text = "00:00:00";
            // 
            // lbl_time_bin_min
            // 
            this.lbl_time_bin_min.AutoSize = true;
            this.lbl_time_bin_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_bin_min.ForeColor = System.Drawing.Color.Red;
            this.lbl_time_bin_min.Location = new System.Drawing.Point(-15, 82);
            this.lbl_time_bin_min.Name = "lbl_time_bin_min";
            this.lbl_time_bin_min.Size = new System.Drawing.Size(188, 25);
            this.lbl_time_bin_min.TabIndex = 2;
            this.lbl_time_bin_min.Text = "0000000000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "8421";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "8421";
            // 
            // lbl_time_bin_sec
            // 
            this.lbl_time_bin_sec.AutoSize = true;
            this.lbl_time_bin_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_bin_sec.ForeColor = System.Drawing.Color.Blue;
            this.lbl_time_bin_sec.Location = new System.Drawing.Point(-15, 107);
            this.lbl_time_bin_sec.Name = "lbl_time_bin_sec";
            this.lbl_time_bin_sec.Size = new System.Drawing.Size(188, 25);
            this.lbl_time_bin_sec.TabIndex = 5;
            this.lbl_time_bin_sec.Text = "0000000000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(-39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-39, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(-39, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "H";
            // 
            // Img_clock
            // 
            this.Img_clock.BackColor = System.Drawing.Color.White;
            this.Img_clock.Location = new System.Drawing.Point(222, -43);
            this.Img_clock.Name = "Img_clock";
            this.Img_clock.Size = new System.Drawing.Size(320, 320);
            this.Img_clock.TabIndex = 9;
            this.Img_clock.TabStop = false;
            // 
            // chk_sec_mil
            // 
            this.chk_sec_mil.AutoSize = true;
            this.chk_sec_mil.Checked = true;
            this.chk_sec_mil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_sec_mil.Location = new System.Drawing.Point(93, 166);
            this.chk_sec_mil.Name = "chk_sec_mil";
            this.chk_sec_mil.Size = new System.Drawing.Size(107, 17);
            this.chk_sec_mil.TabIndex = 10;
            this.chk_sec_mil.Text = "Seconds windmill";
            this.chk_sec_mil.UseVisualStyleBackColor = true;
            this.chk_sec_mil.Visible = false;
            // 
            // chk_mil_min
            // 
            this.chk_mil_min.AutoSize = true;
            this.chk_mil_min.Checked = true;
            this.chk_mil_min.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_mil_min.Location = new System.Drawing.Point(93, 189);
            this.chk_mil_min.Name = "chk_mil_min";
            this.chk_mil_min.Size = new System.Drawing.Size(97, 17);
            this.chk_mil_min.TabIndex = 11;
            this.chk_mil_min.Text = "minuits windmill";
            this.chk_mil_min.UseVisualStyleBackColor = true;
            this.chk_mil_min.Visible = false;
            // 
            // chk_mil_hour
            // 
            this.chk_mil_hour.AutoSize = true;
            this.chk_mil_hour.Checked = true;
            this.chk_mil_hour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_mil_hour.Location = new System.Drawing.Point(93, 212);
            this.chk_mil_hour.Name = "chk_mil_hour";
            this.chk_mil_hour.Size = new System.Drawing.Size(91, 17);
            this.chk_mil_hour.TabIndex = 12;
            this.chk_mil_hour.Text = "hours windmill";
            this.chk_mil_hour.UseVisualStyleBackColor = true;
            this.chk_mil_hour.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // cmd_about
            // 
            this.cmd_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_about.Location = new System.Drawing.Point(5, 223);
            this.cmd_about.Name = "cmd_about";
            this.cmd_about.Size = new System.Drawing.Size(45, 23);
            this.cmd_about.TabIndex = 14;
            this.cmd_about.Text = "about";
            this.cmd_about.UseVisualStyleBackColor = true;
            this.cmd_about.Click += new System.EventHandler(this.cmd_about_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(378, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "6";
            // 
            // lbl_ticks
            // 
            this.lbl_ticks.AutoSize = true;
            this.lbl_ticks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticks.Location = new System.Drawing.Point(2, 132);
            this.lbl_ticks.Name = "lbl_ticks";
            this.lbl_ticks.Size = new System.Drawing.Size(54, 17);
            this.lbl_ticks.TabIndex = 19;
            this.lbl_ticks.Text = "label10";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_month.Location = new System.Drawing.Point(2, 176);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(54, 17);
            this.lbl_month.TabIndex = 20;
            this.lbl_month.Text = "label10";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day.Location = new System.Drawing.Point(2, 154);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(54, 17);
            this.lbl_day.TabIndex = 21;
            this.lbl_day.Text = "label10";
            // 
            // lbl_day_year
            // 
            this.lbl_day_year.AutoSize = true;
            this.lbl_day_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day_year.Location = new System.Drawing.Point(2, 199);
            this.lbl_day_year.Name = "lbl_day_year";
            this.lbl_day_year.Size = new System.Drawing.Size(54, 17);
            this.lbl_day_year.TabIndex = 22;
            this.lbl_day_year.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(483, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(480, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(439, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(318, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "7";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(278, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "8";
            //  
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(271, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(316, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "11";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(521, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 22);
            this.button1.TabIndex = 31;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nfi_tray
            // 
            this.nfi_tray.ContextMenuStrip = this.right_click;
            this.nfi_tray.Icon = ((System.Drawing.Icon)(resources.GetObject("nfi_tray.Icon")));
            this.nfi_tray.Text = "Pie clock";
            this.nfi_tray.Visible = true;
            this.nfi_tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfi_tray_MouseDoubleClick);
            // 
            // right_click
            // 
            this.right_click.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_time,
            this.exitToolStripMenuItem});
            this.right_click.Name = "right_click";
            this.right_click.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.right_click.ShowImageMargin = false;
            this.right_click.Size = new System.Drawing.Size(94, 48);
            this.right_click.Opening += new System.ComponentModel.CancelEventHandler(this.right_click_Opening);
            // 
            // click_time
            // 
            this.click_time.Name = "click_time";
            this.click_time.Size = new System.Drawing.Size(127, 22);
            this.click_time.Text = "00:00:00";
            this.click_time.Visible = false;
            this.click_time.Click += new System.EventHandler(this.click_time_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tim_hide
            // 
            this.tim_hide.Interval = 10;
            this.tim_hide.Tick += new System.EventHandler(this.tim_hide_Tick);
            // 
            // tim_show
            // 
            this.tim_show.Interval = 10;
            this.tim_show.Tick += new System.EventHandler(this.tim_show_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(-34, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 66);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Location = new System.Drawing.Point(79, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 66);
            this.panel2.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(38, -4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 25);
            this.label18.TabIndex = 34;
            this.label18.Text = "H";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(15, -4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 25);
            this.label19.TabIndex = 35;
            this.label19.Text = "H";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(38, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 25);
            this.label20.TabIndex = 34;
            this.label20.Text = "M";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(15, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 25);
            this.label21.TabIndex = 35;
            this.label21.Text = "M";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(38, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 25);
            this.label22.TabIndex = 34;
            this.label22.Text = "S";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(15, 44);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 25);
            this.label23.TabIndex = 35;
            this.label23.Text = "S";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(542, 252);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_day_year);
            this.Controls.Add(this.lbl_day);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.lbl_ticks);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmd_about);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Img_clock);
            this.Controls.Add(this.chk_mil_hour);
            this.Controls.Add(this.chk_mil_min);
            this.Controls.Add(this.chk_sec_mil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_time_bin_sec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_time_bin_min);
            this.Controls.Add(this.lbl_time_dec);
            this.Controls.Add(this.lbl_time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_clock)).EndInit();
            this.right_click.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_time_dec;
        private System.Windows.Forms.Label lbl_time_bin_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_time_bin_sec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Img_clock;
        private System.Windows.Forms.CheckBox chk_sec_mil;
        private System.Windows.Forms.CheckBox chk_mil_min;
        private System.Windows.Forms.CheckBox chk_mil_hour;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmd_about;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_ticks;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Label lbl_day_year;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon nfi_tray;
        private System.Windows.Forms.ContextMenuStrip right_click;
        private System.Windows.Forms.ToolStripMenuItem click_time;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer tim_hide;
        private System.Windows.Forms.Timer tim_show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

