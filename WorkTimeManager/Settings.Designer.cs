
namespace WorkTimeManager
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.breakTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.workTime = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.breakTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work starts at:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Work end at:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minutes of break:";
            // 
            // breakTime
            // 
            this.breakTime.Location = new System.Drawing.Point(182, 115);
            this.breakTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.breakTime.Name = "breakTime";
            this.breakTime.Size = new System.Drawing.Size(56, 31);
            this.breakTime.TabIndex = 9;
            this.breakTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.breakTime.ValueChanged += new System.EventHandler(this.timeChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total work time:";
            // 
            // workTime
            // 
            this.workTime.AutoSize = true;
            this.workTime.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workTime.Location = new System.Drawing.Point(182, 162);
            this.workTime.Name = "workTime";
            this.workTime.Size = new System.Drawing.Size(62, 25);
            this.workTime.TabIndex = 11;
            this.workTime.Text = "08:00";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.Green;
            this.buttonSave.Location = new System.Drawing.Point(10, 204);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(321, 34);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "HH:mm";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(182, 23);
            this.startTime.MaxDate = new System.DateTime(9998, 12, 30, 0, 0, 0, 0);
            this.startTime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(140, 31);
            this.startTime.TabIndex = 13;
            this.startTime.Value = new System.DateTime(2022, 7, 27, 0, 0, 0, 0);
            this.startTime.ValueChanged += new System.EventHandler(this.timeChanged);
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "HH:mm";
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.Location = new System.Drawing.Point(182, 68);
            this.endTime.MaxDate = new System.DateTime(9998, 12, 30, 0, 0, 0, 0);
            this.endTime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(140, 31);
            this.endTime.TabIndex = 14;
            this.endTime.Value = new System.DateTime(2022, 7, 27, 0, 0, 0, 0);
            this.endTime.ValueChanged += new System.EventHandler(this.timeChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 250);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.workTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.breakTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Opacity = 0.99D;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown breakTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label workTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endTime;
    }
}