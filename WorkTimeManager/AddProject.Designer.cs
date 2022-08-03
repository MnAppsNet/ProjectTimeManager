
namespace WorkTimeManager
{
    partial class AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            this.textName = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBoxWorkingDays = new System.Windows.Forms.GroupBox();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.groupBoxWorkingDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Location = new System.Drawing.Point(12, 12);
            this.textName.Name = "textName";
            this.textName.PlaceholderText = "Project Name...";
            this.textName.Size = new System.Drawing.Size(501, 31);
            this.textName.TabIndex = 0;
            // 
            // textDescription
            // 
            this.textDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescription.Location = new System.Drawing.Point(12, 49);
            this.textDescription.Name = "textDescription";
            this.textDescription.PlaceholderText = "Description...";
            this.textDescription.Size = new System.Drawing.Size(501, 31);
            this.textDescription.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreate.ForeColor = System.Drawing.Color.Green;
            this.buttonCreate.Location = new System.Drawing.Point(12, 202);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(501, 34);
            this.buttonCreate.TabIndex = 13;
            this.buttonCreate.Text = "Create Project";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBoxWorkingDays
            // 
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxSunday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxSaturday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxFriday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxThursday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxWednesday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxTuesday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxMonday);
            this.groupBoxWorkingDays.Location = new System.Drawing.Point(12, 86);
            this.groupBoxWorkingDays.Name = "groupBoxWorkingDays";
            this.groupBoxWorkingDays.Size = new System.Drawing.Size(501, 110);
            this.groupBoxWorkingDays.TabIndex = 16;
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
            this.checkBoxWednesday.Text = "Wednesday";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
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
            this.checkBoxTuesday.Text = "Tuesday";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
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
            this.checkBoxMonday.Text = "Monday";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 250);
            this.Controls.Add(this.groupBoxWorkingDays);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProject";
            this.Text = "Add New Project";
            this.groupBoxWorkingDays.ResumeLayout(false);
            this.groupBoxWorkingDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBoxWorkingDays;
        private System.Windows.Forms.CheckBox checkBoxSunday;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxThursday;
        private System.Windows.Forms.CheckBox checkBoxWednesday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
        private System.Windows.Forms.CheckBox checkBoxMonday;
    }
}