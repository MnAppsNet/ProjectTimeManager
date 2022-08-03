
namespace WorkTimeManager
{
    partial class EditProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProject));
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.groupBoxWorkingDays = new System.Windows.Forms.GroupBox();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.buttonReallocate = new System.Windows.Forms.Button();
            this.groupBoxChargedTime = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valueMinutes = new System.Windows.Forms.NumericUpDown();
            this.valueHours = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeProjectStarted = new System.Windows.Forms.DateTimePicker();
            this.dateTimeProjectClosed = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxCloseProject = new System.Windows.Forms.CheckBox();
            this.panelClosedProject = new System.Windows.Forms.Panel();
            this.checkBoxOpenProject = new System.Windows.Forms.CheckBox();
            this.groupBoxWorkingDays.SuspendLayout();
            this.groupBoxChargedTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueHours)).BeginInit();
            this.panelClosedProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxProject
            // 
            this.textBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProject.Location = new System.Drawing.Point(12, 12);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(501, 31);
            this.textBoxProject.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(12, 49);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PlaceholderText = "Description";
            this.textBoxDescription.Size = new System.Drawing.Size(501, 31);
            this.textBoxDescription.TabIndex = 1;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // groupBoxWorkingDays
            // 
            this.groupBoxWorkingDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxSunday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxSaturday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxFriday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxThursday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxWednesday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxTuesday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxMonday);
            this.groupBoxWorkingDays.Location = new System.Drawing.Point(12, 176);
            this.groupBoxWorkingDays.Name = "groupBoxWorkingDays";
            this.groupBoxWorkingDays.Size = new System.Drawing.Size(501, 110);
            this.groupBoxWorkingDays.TabIndex = 17;
            this.groupBoxWorkingDays.TabStop = false;
            this.groupBoxWorkingDays.Text = "Working Days";
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.Location = new System.Drawing.Point(250, 65);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(97, 29);
            this.checkBoxSunday.TabIndex = 6;
            this.checkBoxSunday.Text = "Sunday";
            this.checkBoxSunday.UseVisualStyleBackColor = true;
            this.checkBoxSunday.CheckedChanged += new System.EventHandler(this.workingDaysChange);
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Location = new System.Drawing.Point(127, 65);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(108, 29);
            this.checkBoxSaturday.TabIndex = 5;
            this.checkBoxSaturday.Text = "Saturday";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            this.checkBoxSaturday.CheckedChanged += new System.EventHandler(this.workingDaysChange);
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.Checked = true;
            this.checkBoxFriday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFriday.Location = new System.Drawing.Point(6, 65);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(86, 29);
            this.checkBoxFriday.TabIndex = 4;
            this.checkBoxFriday.Text = "Friday";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            this.checkBoxFriday.CheckedChanged += new System.EventHandler(this.workingDaysChange);
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.Checked = true;
            this.checkBoxThursday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxThursday.Location = new System.Drawing.Point(385, 30);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(110, 29);
            this.checkBoxThursday.TabIndex = 3;
            this.checkBoxThursday.Text = "Thursday";
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            this.checkBoxThursday.CheckedChanged += new System.EventHandler(this.workingDaysChange);
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.Checked = true;
            this.checkBoxWednesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWednesday.Location = new System.Drawing.Point(250, 30);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(130, 29);
            this.checkBoxWednesday.TabIndex = 2;
            this.checkBoxWednesday.Tag = "";
            this.checkBoxWednesday.Text = "Wednesday";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            this.checkBoxWednesday.CheckedChanged += new System.EventHandler(this.workingDaysChange);
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.Checked = true;
            this.checkBoxTuesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTuesday.Location = new System.Drawing.Point(127, 30);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(103, 29);
            this.checkBoxTuesday.TabIndex = 1;
            this.checkBoxTuesday.Tag = "";
            this.checkBoxTuesday.Text = "Tuesday";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            this.checkBoxTuesday.CheckedChanged += new System.EventHandler(this.workingDaysChange);
            // 
            // checkBoxMonday
            // 
            this.checkBoxMonday.AutoSize = true;
            this.checkBoxMonday.Checked = true;
            this.checkBoxMonday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMonday.Location = new System.Drawing.Point(6, 30);
            this.checkBoxMonday.Name = "checkBoxMonday";
            this.checkBoxMonday.Size = new System.Drawing.Size(104, 29);
            this.checkBoxMonday.TabIndex = 0;
            this.checkBoxMonday.Tag = "";
            this.checkBoxMonday.Text = "Monday";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            this.checkBoxMonday.CheckedChanged += new System.EventHandler(this.workingDaysChange);
            // 
            // buttonReallocate
            // 
            this.buttonReallocate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReallocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReallocate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReallocate.ForeColor = System.Drawing.Color.Green;
            this.buttonReallocate.Location = new System.Drawing.Point(12, 417);
            this.buttonReallocate.Name = "buttonReallocate";
            this.buttonReallocate.Size = new System.Drawing.Size(501, 37);
            this.buttonReallocate.TabIndex = 18;
            this.buttonReallocate.Text = "Save";
            this.buttonReallocate.UseVisualStyleBackColor = true;
            this.buttonReallocate.Click += new System.EventHandler(this.buttonReallocate_Click);
            // 
            // groupBoxChargedTime
            // 
            this.groupBoxChargedTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChargedTime.Controls.Add(this.label5);
            this.groupBoxChargedTime.Controls.Add(this.label4);
            this.groupBoxChargedTime.Controls.Add(this.valueMinutes);
            this.groupBoxChargedTime.Controls.Add(this.valueHours);
            this.groupBoxChargedTime.Controls.Add(this.dateTimePicker);
            this.groupBoxChargedTime.Location = new System.Drawing.Point(12, 292);
            this.groupBoxChargedTime.Name = "groupBoxChargedTime";
            this.groupBoxChargedTime.Size = new System.Drawing.Size(501, 117);
            this.groupBoxChargedTime.TabIndex = 20;
            this.groupBoxChargedTime.TabStop = false;
            this.groupBoxChargedTime.Text = "Charged Time";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Minutes :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hours :";
            // 
            // valueMinutes
            // 
            this.valueMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueMinutes.Location = new System.Drawing.Point(336, 73);
            this.valueMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.valueMinutes.Name = "valueMinutes";
            this.valueMinutes.Size = new System.Drawing.Size(76, 31);
            this.valueMinutes.TabIndex = 13;
            this.valueMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueMinutes.ValueChanged += new System.EventHandler(this.valueHours_ValueChanged);
            // 
            // valueHours
            // 
            this.valueHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueHours.Location = new System.Drawing.Point(164, 73);
            this.valueHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.valueHours.Name = "valueHours";
            this.valueHours.Size = new System.Drawing.Size(76, 31);
            this.valueHours.TabIndex = 12;
            this.valueHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueHours.ValueChanged += new System.EventHandler(this.valueHours_ValueChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(6, 30);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(489, 31);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Project Started At:";
            // 
            // dateTimeProjectStarted
            // 
            this.dateTimeProjectStarted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeProjectStarted.Enabled = false;
            this.dateTimeProjectStarted.Location = new System.Drawing.Point(172, 86);
            this.dateTimeProjectStarted.Name = "dateTimeProjectStarted";
            this.dateTimeProjectStarted.Size = new System.Drawing.Size(335, 31);
            this.dateTimeProjectStarted.TabIndex = 16;
            // 
            // dateTimeProjectClosed
            // 
            this.dateTimeProjectClosed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeProjectClosed.Enabled = false;
            this.dateTimeProjectClosed.Location = new System.Drawing.Point(160, 6);
            this.dateTimeProjectClosed.Name = "dateTimeProjectClosed";
            this.dateTimeProjectClosed.Size = new System.Drawing.Size(188, 31);
            this.dateTimeProjectClosed.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Project  Closed  At:";
            // 
            // checkBoxCloseProject
            // 
            this.checkBoxCloseProject.AutoSize = true;
            this.checkBoxCloseProject.Location = new System.Drawing.Point(16, 133);
            this.checkBoxCloseProject.Name = "checkBoxCloseProject";
            this.checkBoxCloseProject.Size = new System.Drawing.Size(127, 29);
            this.checkBoxCloseProject.TabIndex = 24;
            this.checkBoxCloseProject.Text = "End Project";
            this.checkBoxCloseProject.UseVisualStyleBackColor = true;
            this.checkBoxCloseProject.CheckedChanged += new System.EventHandler(this.checkBoxCloseProject_CheckedChanged);
            // 
            // panelClosedProject
            // 
            this.panelClosedProject.Controls.Add(this.checkBoxOpenProject);
            this.panelClosedProject.Controls.Add(this.dateTimeProjectClosed);
            this.panelClosedProject.Controls.Add(this.label2);
            this.panelClosedProject.Location = new System.Drawing.Point(12, 123);
            this.panelClosedProject.Name = "panelClosedProject";
            this.panelClosedProject.Size = new System.Drawing.Size(502, 47);
            this.panelClosedProject.TabIndex = 25;
            this.panelClosedProject.Visible = false;
            // 
            // checkBoxOpenProject
            // 
            this.checkBoxOpenProject.AutoSize = true;
            this.checkBoxOpenProject.Location = new System.Drawing.Point(354, 7);
            this.checkBoxOpenProject.Name = "checkBoxOpenProject";
            this.checkBoxOpenProject.Size = new System.Drawing.Size(141, 29);
            this.checkBoxOpenProject.TabIndex = 26;
            this.checkBoxOpenProject.Text = "Open Project";
            this.checkBoxOpenProject.UseVisualStyleBackColor = true;
            this.checkBoxOpenProject.CheckedChanged += new System.EventHandler(this.checkBoxOpenProject_CheckedChanged);
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 466);
            this.Controls.Add(this.checkBoxCloseProject);
            this.Controls.Add(this.dateTimeProjectStarted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxChargedTime);
            this.Controls.Add(this.buttonReallocate);
            this.Controls.Add(this.groupBoxWorkingDays);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.panelClosedProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProject";
            this.Text = "Edit Project";
            this.Load += new System.EventHandler(this.EditProject_Load);
            this.groupBoxWorkingDays.ResumeLayout(false);
            this.groupBoxWorkingDays.PerformLayout();
            this.groupBoxChargedTime.ResumeLayout(false);
            this.groupBoxChargedTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueHours)).EndInit();
            this.panelClosedProject.ResumeLayout(false);
            this.panelClosedProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxWorkingDays;
        private System.Windows.Forms.CheckBox checkBoxSunday;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxThursday;
        private System.Windows.Forms.CheckBox checkBoxWednesday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
        private System.Windows.Forms.CheckBox checkBoxMonday;
        private System.Windows.Forms.Button buttonReallocate;
        private System.Windows.Forms.GroupBox groupBoxChargedTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown valueMinutes;
        private System.Windows.Forms.NumericUpDown valueHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeProjectStarted;
        private System.Windows.Forms.DateTimePicker dateTimeProjectClosed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCloseProject;
        private System.Windows.Forms.Panel panelClosedProject;
        private System.Windows.Forms.CheckBox checkBoxOpenProject;
    }
}