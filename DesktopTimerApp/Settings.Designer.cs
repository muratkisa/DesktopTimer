
namespace DesktopTimerApp
{
    partial class Settings
    {
        

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BackGroundImagesCombo = new System.Windows.Forms.ComboBox();
            this.StartControl = new System.Windows.Forms.CheckBox();
            this.timeORcounter = new System.Windows.Forms.CheckBox();
            this.AlarmTime = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.AlarmVolume = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.HourUpDown = new System.Windows.Forms.NumericUpDown();
            this.MilliSecondCombo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MilliSecondCombo);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BackGroundImagesCombo);
            this.groupBox1.Controls.Add(this.StartControl);
            this.groupBox1.Controls.Add(this.timeORcounter);
            this.groupBox1.Controls.Add(this.AlarmTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AlarmVolume);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SecondUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MinuteUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HourUpDown);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(11, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 101);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(44, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "15:09:28";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save BG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BackGroundImagesCombo
            // 
            this.BackGroundImagesCombo.FormattingEnabled = true;
            this.BackGroundImagesCombo.Location = new System.Drawing.Point(11, 195);
            this.BackGroundImagesCombo.Name = "BackGroundImagesCombo";
            this.BackGroundImagesCombo.Size = new System.Drawing.Size(159, 23);
            this.BackGroundImagesCombo.TabIndex = 12;
            this.BackGroundImagesCombo.SelectedIndexChanged += new System.EventHandler(this.BackGroundImagesCombo_SelectedIndexChanged);
            // 
            // StartControl
            // 
            this.StartControl.AutoSize = true;
            this.StartControl.Location = new System.Drawing.Point(11, 170);
            this.StartControl.Name = "StartControl";
            this.StartControl.Size = new System.Drawing.Size(225, 19);
            this.StartControl.TabIndex = 11;
            this.StartControl.Text = "Start immediately when screen closed";
            this.StartControl.UseVisualStyleBackColor = true;
            // 
            // timeORcounter
            // 
            this.timeORcounter.AutoSize = true;
            this.timeORcounter.Location = new System.Drawing.Point(11, 145);
            this.timeORcounter.Name = "timeORcounter";
            this.timeORcounter.Size = new System.Drawing.Size(120, 19);
            this.timeORcounter.TabIndex = 2;
            this.timeORcounter.Text = "Start with counter";
            this.timeORcounter.UseVisualStyleBackColor = true;
            // 
            // AlarmTime
            // 
            this.AlarmTime.Location = new System.Drawing.Point(102, 105);
            this.AlarmTime.Name = "AlarmTime";
            this.AlarmTime.Size = new System.Drawing.Size(170, 45);
            this.AlarmTime.TabIndex = 10;
            this.AlarmTime.Value = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alarm Time:";
            // 
            // AlarmVolume
            // 
            this.AlarmVolume.Location = new System.Drawing.Point(102, 67);
            this.AlarmVolume.Name = "AlarmVolume";
            this.AlarmVolume.Size = new System.Drawing.Size(170, 45);
            this.AlarmVolume.TabIndex = 8;
            this.AlarmVolume.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alarm Volume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "S:";
            // 
            // SecondUpDown
            // 
            this.SecondUpDown.Location = new System.Drawing.Point(166, 27);
            this.SecondUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SecondUpDown.Name = "SecondUpDown";
            this.SecondUpDown.ReadOnly = true;
            this.SecondUpDown.Size = new System.Drawing.Size(36, 23);
            this.SecondUpDown.TabIndex = 5;
            this.SecondUpDown.ValueChanged += new System.EventHandler(this.SecondUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "M:";
            // 
            // MinuteUpDown
            // 
            this.MinuteUpDown.Location = new System.Drawing.Point(102, 27);
            this.MinuteUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinuteUpDown.Name = "MinuteUpDown";
            this.MinuteUpDown.ReadOnly = true;
            this.MinuteUpDown.Size = new System.Drawing.Size(36, 23);
            this.MinuteUpDown.TabIndex = 3;
            this.MinuteUpDown.ValueChanged += new System.EventHandler(this.MinuteUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "H:";
            // 
            // HourUpDown
            // 
            this.HourUpDown.Location = new System.Drawing.Point(33, 27);
            this.HourUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HourUpDown.Name = "HourUpDown";
            this.HourUpDown.ReadOnly = true;
            this.HourUpDown.Size = new System.Drawing.Size(36, 23);
            this.HourUpDown.TabIndex = 1;
            this.HourUpDown.ValueChanged += new System.EventHandler(this.HourUpDown_ValueChanged);
            // 
            // MilliSecondCombo
            // 
            this.MilliSecondCombo.AutoSize = true;
            this.MilliSecondCombo.Location = new System.Drawing.Point(208, 29);
            this.MilliSecondCombo.Name = "MilliSecondCombo";
            this.MilliSecondCombo.Size = new System.Drawing.Size(87, 19);
            this.MilliSecondCombo.TabIndex = 15;
            this.MilliSecondCombo.Text = "Millisecond";
            this.MilliSecondCombo.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.ClientSize = new System.Drawing.Size(382, 356);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).EndInit();
            this.ResumeLayout(false);

        }
                
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SecondUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MinuteUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HourUpDown;
        private System.Windows.Forms.TrackBar AlarmVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar AlarmTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox timeORcounter;
        private System.Windows.Forms.CheckBox StartControl;
        private System.Windows.Forms.ComboBox BackGroundImagesCombo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox MilliSecondCombo;
    }
}

