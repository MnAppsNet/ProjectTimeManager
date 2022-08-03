
namespace WorkTimeManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.listProjects = new System.Windows.Forms.ListView();
            this.columnProject = new System.Windows.Forms.ColumnHeader();
            this.columnTime = new System.Windows.Forms.ColumnHeader();
            this.columnDescription = new System.Windows.Forms.ColumnHeader();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReallocate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuForIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuForIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 487);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(615, 14);
            this.progressBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project to charge :";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.BackColor = System.Drawing.Color.White;
            this.buttonSettings.BackgroundImage = global::WorkTimeManager.Properties.Resources.gears;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.Location = new System.Drawing.Point(571, 255);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(43, 35);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProject.BackColor = System.Drawing.Color.White;
            this.buttonAddProject.BackgroundImage = global::WorkTimeManager.Properties.Resources.plus;
            this.buttonAddProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddProject.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddProject.ForeColor = System.Drawing.Color.Green;
            this.buttonAddProject.Location = new System.Drawing.Point(522, 255);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(43, 35);
            this.buttonAddProject.TabIndex = 7;
            this.buttonAddProject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddProject.UseVisualStyleBackColor = false;
            this.buttonAddProject.Click += new System.EventHandler(this.buttonAddProject_Click);
            // 
            // listProjects
            // 
            this.listProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProjects.CheckBoxes = true;
            this.listProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProject,
            this.columnTime,
            this.columnDescription});
            this.listProjects.FullRowSelect = true;
            this.listProjects.HideSelection = false;
            this.listProjects.LabelEdit = true;
            this.listProjects.Location = new System.Drawing.Point(0, 293);
            this.listProjects.MultiSelect = false;
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(614, 188);
            this.listProjects.TabIndex = 9;
            this.listProjects.UseCompatibleStateImageBehavior = false;
            this.listProjects.View = System.Windows.Forms.View.Details;
            this.listProjects.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listProjects_ItemChecked);
            // 
            // columnProject
            // 
            this.columnProject.Text = "Project";
            this.columnProject.Width = 200;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.Width = 80;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 320;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 10000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // calendar
            // 
            this.calendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.calendar.Location = new System.Drawing.Point(8, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 8;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackColor = System.Drawing.Color.White;
            this.buttonRefresh.BackgroundImage = global::WorkTimeManager.Properties.Resources.refresh;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Green;
            this.buttonRefresh.Location = new System.Drawing.Point(375, 255);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(43, 35);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReallocate
            // 
            this.buttonReallocate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReallocate.BackColor = System.Drawing.Color.White;
            this.buttonReallocate.BackgroundImage = global::WorkTimeManager.Properties.Resources.move;
            this.buttonReallocate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReallocate.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReallocate.ForeColor = System.Drawing.Color.Green;
            this.buttonReallocate.Location = new System.Drawing.Point(473, 255);
            this.buttonReallocate.Name = "buttonReallocate";
            this.buttonReallocate.Size = new System.Drawing.Size(43, 35);
            this.buttonReallocate.TabIndex = 11;
            this.buttonReallocate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonReallocate.UseVisualStyleBackColor = false;
            this.buttonReallocate.Click += new System.EventHandler(this.buttonReallocate_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.BackgroundImage = global::WorkTimeManager.Properties.Resources.editing;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.Color.Green;
            this.buttonEdit.Location = new System.Drawing.Point(424, 255);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(43, 35);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.contextMenuForIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WorkTimeManager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuForIcon
            // 
            this.contextMenuForIcon.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuForIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemExit});
            this.contextMenuForIcon.Name = "contextMenuForIcon";
            this.contextMenuForIcon.Size = new System.Drawing.Size(135, 72);
            this.contextMenuForIcon.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuForIcon_ItemClicked);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItemOpen.ForeColor = System.Drawing.Color.Green;
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItemOpen.Text = "Open";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItemExit.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 501);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonReallocate);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.listProjects);
            this.Controls.Add(this.buttonAddProject);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.calendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.Text = "WorkTimeManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuForIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.ListView listProjects;
        private System.Windows.Forms.ColumnHeader Project;
        private System.Windows.Forms.ColumnHeader column;
        private System.Windows.Forms.ColumnHeader columnProject;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonReallocate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuForIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
    }
}

