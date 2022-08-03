using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public partial class EditProject : Form
    {
        Data.Project editedProject;
        Data.Project project;
        Data data;
        string timeStamp;
        public EditProject(Data.Project projectToEdit, Data dataToEdit, DateTime date)
        {
            data = dataToEdit;
            project = projectToEdit;
            //Make a copy of the actual project intance to edit temporarily before saving
            editedProject = new Data.Project(project.Name, project.Description, project.WorkingDays);
            editedProject.ChargedTime = new Dictionary<string, double>(project.ChargedTime);
            InitializeComponent();
            dateTimePicker.Value = date;
            //timeStamp = Tools.convertToTimestamp(date);
            //setHoursOfSelectedDate();
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
            checkBoxMonday.Checked = project.WorkingDays[(int)DayOfWeek.Monday];
            checkBoxTuesday.Checked = project.WorkingDays[(int)DayOfWeek.Tuesday];
            checkBoxWednesday.Checked = project.WorkingDays[(int)DayOfWeek.Wednesday];
            checkBoxThursday.Checked = project.WorkingDays[(int)DayOfWeek.Thursday];
            checkBoxFriday.Checked = project.WorkingDays[(int)DayOfWeek.Friday];
            checkBoxSaturday.Checked = project.WorkingDays[(int)DayOfWeek.Saturday];
            checkBoxSunday.Checked = project.WorkingDays[(int)DayOfWeek.Sunday];

            textBoxProject.Text = project.Name;
            textBoxDescription.Text = project.Description;

            dateTimeProjectStarted.Value = project.Started;
            if (project.Ended != null)
            {
                panelClosedProject.Show();
                checkBoxCloseProject.Hide();
                dateTimeProjectClosed.Value = project.Ended.Value;
            }

            int workingHours = (int)Settings.WorkingHours;
        }

        private void workingDaysChange(object sender, EventArgs e)
        {
            CheckBox workingDay = (CheckBox)sender;
            int day = -1;
            switch (workingDay.Name)
            {
                case "checkBoxMonday":
                    day = (int)DayOfWeek.Monday;
                    break;
                case "checkBoxTuesday":
                    day = (int)DayOfWeek.Tuesday;
                    break;
                case "checkBoxWednesday":
                    day = (int)DayOfWeek.Wednesday;
                    break;
                case "checkBoxThursday":
                    day = (int)DayOfWeek.Thursday;
                    break;
                case "checkBoxFriday":
                    day = (int)DayOfWeek.Friday;
                    break;
                case "checkBoxSaturday":
                    day = (int)DayOfWeek.Saturday;
                    break;
                case "checkBoxSunday":
                    day = (int)DayOfWeek.Sunday;
                    break;
            }
            if (day == -1) return;
            editedProject.WorkingDays[day] = workingDay.Checked;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            try
            {
                editedProject.Description = textBoxDescription.Text;
            }
            catch { }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            timeStamp = Tools.convertToTimestamp(dateTimePicker.Value);
            setHoursOfSelectedDate();
        }
        private void setHoursOfSelectedDate()
        {
            if (timeStamp == null) return;
            double hours = 0;
            if (editedProject.ChargedTime.ContainsKey(timeStamp))
                hours = editedProject.ChargedTime[timeStamp];
            if (hours < 0) hours = 0;
            valueHours.Value = (int)hours;
            valueMinutes.Value = (int)((hours * 60) % 60);
        }

        private void valueHours_ValueChanged(object sender, EventArgs e)
        {
            if (timeStamp == null) return;
            if (!editedProject.ChargedTime.ContainsKey(timeStamp)) editedProject.ChargedTime.Add(timeStamp, 0);
            editedProject.ChargedTime[timeStamp] = (double)valueHours.Value + (double)valueMinutes.Value / 60;
        }

        private void buttonReallocate_Click(object sender, EventArgs e)
        {
            if (project.Name != textBoxProject.Text)
            {
                if (data.projectExists(textBoxProject.Text))
                {
                    MessageBox.Show("The new project name you provided already exists. No changes will be made on the name...","Project name exists",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    data.deleteProject(project.Name);
                    project.Name = textBoxProject.Text;
                    data.addProject(project);
                }
            }
            project.ChargedTime = new Dictionary<string, double>(editedProject.ChargedTime);
            project.Description = editedProject.Description;
            project.WorkingDays = new Dictionary<int, bool>(editedProject.WorkingDays);
            project.Ended = editedProject.Ended;
            Close();
        }

        private void checkBoxCloseProject_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCloseProject.Checked)
            {
                checkBoxCloseProject.Checked = false;
                editedProject.CloseProject();
                dateTimeProjectClosed.Value = editedProject.Ended.Value;
                panelClosedProject.Show();
                checkBoxCloseProject.Hide();
            }
        }

        private void checkBoxOpenProject_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOpenProject.Checked)
            {
                checkBoxOpenProject.Checked = false;
                editedProject.OpenProject();
                panelClosedProject.Hide();
                checkBoxCloseProject.Show();
            }
        }
    }
}
