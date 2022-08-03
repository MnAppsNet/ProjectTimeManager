using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public partial class ReallocateTime : Form
    {
        Data data;
        string timeStamp;
        public ReallocateTime(Data dataInstance, DateTime dateTime)
        {
            timeStamp = Tools.convertToTimestamp(dateTime);
            data = dataInstance;
            InitializeComponent();
            dateTimePicker.Value = dateTime;
        }
        private void reallocateTime_Load(object sender, EventArgs e)
        {
            foreach(Data.Project project in data.getProjects())
            {
                comboBoxFromProject.Items.Add(project.Name);
                comboBoxToProject.Items.Add(project.Name);
            }
            comboBoxFromProject.SelectedIndex = 0;
            comboBoxToProject.SelectedIndex = 0;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            timeStamp = Tools.convertToTimestamp(dateTimePicker.Value);
            updateMaxValues();
        }

        private void readOnlyCombobox(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (!box.Items.Contains(box.Text))
            {
                box.SelectedIndex = 0;
            }
        }

        private void comboBoxFromProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMaxValues();
        }
        private void updateMaxValues()
        {
            double totalHours = 0;
            Data.Project selectedProject = data.getProject(comboBoxFromProject.Text);
            if (selectedProject == null) return;
            try
            {
                totalHours = selectedProject.ChargedTime[timeStamp];
            }
            catch { }
            if (totalHours < 0) totalHours = 0;
            valueHours.Maximum = (int)totalHours;
            valueMinutes.Maximum = (int)((totalHours * 60) % 60);
        }
        private void buttonReallocate_Click(object sender, EventArgs e)
        {
            double totalHours = (double)valueHours.Value + (double)valueMinutes.Value / 60;
            if (totalHours <= 0)
            {
                MessageBox.Show("No time selected for reallocation","No time selected",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Data.Project projectFrom = data.getProject(comboBoxFromProject.Text);
                Data.Project projectTo = data.getProject(comboBoxToProject.Text);
                if (!projectTo.ChargedTime.ContainsKey(timeStamp))
                    projectTo.ChargedTime.Add(timeStamp, 0);
                if (!projectFrom.ChargedTime.ContainsKey(timeStamp))
                    projectFrom.ChargedTime.Add(timeStamp, 0);

                if (projectFrom.ChargedTime[timeStamp] < totalHours)
                {
                    MessageBox.Show("The time selected is more than the available charged time on the selected project", "Not available time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                projectFrom.ChargedTime[timeStamp] -= totalHours;
                projectTo.ChargedTime[timeStamp] += totalHours;
            }
            catch { }
            Close();
        }
    }
}
