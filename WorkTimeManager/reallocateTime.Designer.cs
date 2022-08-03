
namespace WorkTimeManager
{
    partial class ReallocateTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReallocateTime));
            this.comboBoxFromProject = new System.Windows.Forms.ComboBox();
            this.comboBoxToProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueHours = new System.Windows.Forms.NumericUpDown();
            this.valueMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonReallocate = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.valueHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFromProject
            // 
            this.comboBoxFromProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFromProject.FormattingEnabled = true;
            this.comboBoxFromProject.Location = new System.Drawing.Point(12, 96);
            this.comboBoxFromProject.Name = "comboBoxFromProject";
            this.comboBoxFromProject.Size = new System.Drawing.Size(268, 33);
            this.comboBoxFromProject.TabIndex = 0;
            this.comboBoxFromProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxFromProject_SelectedIndexChanged);
            this.comboBoxFromProject.TextChanged += new System.EventHandler(this.readOnlyCombobox);
            // 
            // comboBoxToProject
            // 
            this.comboBoxToProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxToProject.FormattingEnabled = true;
            this.comboBoxToProject.Location = new System.Drawing.Point(520, 96);
            this.comboBoxToProject.Name = "comboBoxToProject";
            this.comboBoxToProject.Size = new System.Drawing.Size(268, 33);
            this.comboBoxToProject.TabIndex = 1;
            this.comboBoxToProject.TextChanged += new System.EventHandler(this.readOnlyCombobox);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Project :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Project :";
            // 
            // valueHours
            // 
            this.valueHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueHours.Location = new System.Drawing.Point(320, 73);
            this.valueHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.valueHours.Name = "valueHours";
            this.valueHours.Size = new System.Drawing.Size(76, 31);
            this.valueHours.TabIndex = 4;
            this.valueHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valueMinutes
            // 
            this.valueMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueMinutes.Location = new System.Drawing.Point(402, 73);
            this.valueMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.valueMinutes.Name = "valueMinutes";
            this.valueMinutes.Size = new System.Drawing.Size(76, 31);
            this.valueMinutes.TabIndex = 5;
            this.valueMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "> > > > > > > > > > > > >";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minutes";
            // 
            // buttonReallocate
            // 
            this.buttonReallocate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReallocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReallocate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReallocate.ForeColor = System.Drawing.Color.Green;
            this.buttonReallocate.Location = new System.Drawing.Point(12, 135);
            this.buttonReallocate.Name = "buttonReallocate";
            this.buttonReallocate.Size = new System.Drawing.Size(774, 37);
            this.buttonReallocate.TabIndex = 9;
            this.buttonReallocate.Text = "Reallocate Time";
            this.buttonReallocate.UseVisualStyleBackColor = true;
            this.buttonReallocate.Click += new System.EventHandler(this.buttonReallocate_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(776, 31);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // ReallocateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 178);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonReallocate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueMinutes);
            this.Controls.Add(this.valueHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxToProject);
            this.Controls.Add(this.comboBoxFromProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReallocateTime";
            this.Text = "Reallocate Time";
            this.Load += new System.EventHandler(this.reallocateTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valueHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFromProject;
        private System.Windows.Forms.ComboBox comboBoxToProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown valueHours;
        private System.Windows.Forms.NumericUpDown valueMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonReallocate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}