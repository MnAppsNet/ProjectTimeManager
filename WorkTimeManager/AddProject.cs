using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WorkTimeManager
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }
        public new string Name;
        public string Description;
        public Dictionary<int,bool> WorkingDays;
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textName.Text.Trim() == "")
            {
                MessageBox.Show("Provide a project name","Missing value",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (!checkBoxMonday.Checked && !checkBoxTuesday.Checked && !checkBoxWednesday.Checked &&
                !checkBoxThursday.Checked && !checkBoxFriday.Checked && !checkBoxSaturday.Checked &&
                !checkBoxSunday.Checked)
            {
                MessageBox.Show("Select at least one working day", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Name = textName.Text;
            Description = textDescription.Text;
            WorkingDays = new Dictionary<int, bool>();
            WorkingDays.Add((int)DayOfWeek.Monday,checkBoxMonday.Checked);
            WorkingDays.Add((int)DayOfWeek.Tuesday, checkBoxTuesday.Checked);
            WorkingDays.Add((int)DayOfWeek.Wednesday, checkBoxWednesday.Checked);
            WorkingDays.Add((int)DayOfWeek.Thursday, checkBoxThursday.Checked);
            WorkingDays.Add((int)DayOfWeek.Friday, checkBoxFriday.Checked);
            WorkingDays.Add((int)DayOfWeek.Saturday, checkBoxSaturday.Checked);
            WorkingDays.Add((int)DayOfWeek.Sunday, checkBoxSunday.Checked);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}