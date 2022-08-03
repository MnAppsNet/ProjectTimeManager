using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public partial class Form1 : Form
    {
        const string TITLE = "WorkTimeManager";

        public Form1()
        {
            InitializeComponent();
            Text = TITLE;
        }
        Data data;
        bool workEnded = false;
        
        string selectedProject
        {
            get
            {
                if (Properties.Settings.Default.SelectedProject == "")
                    Properties.Settings.Default.SelectedProject = Data.UNALLOCATED;
                return Properties.Settings.Default.SelectedProject;
            }
            set
            {
                Properties.Settings.Default.SelectedProject = value;
                Properties.Settings.Default.Save();
            }
        }
        DateTime lastDateTime {
            get {
                if (Properties.Settings.Default.LastDateTime.Year == 1900)
                {
                    Properties.Settings.Default.LastDateTime = new DateTime(
                        DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                        Settings.StartTime.Value.Hour, Settings.StartTime.Value.Minute, 0);
                    Properties.Settings.Default.Save();
                }
                return Properties.Settings.Default.LastDateTime;
            }
            set {
                Properties.Settings.Default.LastDateTime = value;
                Properties.Settings.Default.Save();
            }
        }
        List<string> selectedTimestamps = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            data = new Data();
            updateProjectView();
            timerRefresh.Start();
        }
        private bool projectExistsInSelectedDates(DateTime? projectStarted, DateTime? projectEnded)
        {
            if (calendar.SelectionStart < projectStarted &&
                calendar.SelectionEnd < projectStarted &&
                Tools.convertToTimestamp(calendar.SelectionStart) != Tools.convertToTimestamp(projectStarted.Value))
                return false;
            if (projectEnded != null)
                if (calendar.SelectionStart > projectEnded &&
                Tools.convertToTimestamp(calendar.SelectionStart) != Tools.convertToTimestamp(projectEnded.Value))
                    return false;
            return true;
        }
        private void updateProjectView()
        {
            listProjects.Items.Clear();
            if (selectedTimestamps == null)
            {
                selectedTimestamps = new List<string>();
                selectedTimestamps.Add(Tools.convertToTimestamp(DateTime.Now));
            }

            //Charge currently active project from last change until now:
            DateTime now = DateTime.Now;
            data.chargeProject(selectedProject, lastDateTime, now);
            lastDateTime = now;

            //Gather charged time of projects :
            foreach(Data.Project project in data.getProjects())
            {
                if (!projectExistsInSelectedDates(project.Started,project.Ended))
                {
                    continue;
                }
                
                double totalHours = 0;
                foreach(string ts in selectedTimestamps)
                {
                    if (project.ChargedTime.ContainsKey(ts))
                        totalHours += project.ChargedTime[ts];
                }
                int hours = (int)totalHours;
                int minutes = (int)((totalHours * 60) % 60);
                ListViewItem line = new ListViewItem(new string[] {
                project.Name, hours.ToString("D2") + ":" +
                minutes.ToString("D2"),
                project.Description});
                if (project.Name == selectedProject) line.Checked = true;
                line.Name = project.Name;

                listProjects.Items.Add(line);
            }
            updateProgress();
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            updateProjectView();
        }

        private void updateProgress()
        {
            DateTime endTime = new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day,
                    Settings.EndTime.Value.Hour,
                    Settings.EndTime.Value.Minute,
                    Settings.EndTime.Value.Second
            );
            DateTime startTime = new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day,
                    Settings.StartTime.Value.Hour,
                    Settings.StartTime.Value.Minute,
                    Settings.StartTime.Value.Second
            );
            double totalTimeAtWork = (endTime - startTime).TotalHours;
            double progress = 0;
            double hourDifference = (endTime - DateTime.Now).TotalHours;
            if (DateTime.Now > endTime)
            {
                hourDifference = 0;
            }
            else if (DateTime.Now < startTime)
            {
                hourDifference = totalTimeAtWork;
                workEnded = false;
            }

            progress = (totalTimeAtWork - hourDifference) / totalTimeAtWork * 100;
            if (progress < 0 || progress > 100 ) progress = 100;
            if (progress == 100 && workEnded == false)
            {
                SoundPlayer endOfWorkSound = new SoundPlayer(Properties.Resources.end_of_work);
                endOfWorkSound.Play();
                notifyIcon.ShowBalloonTip(5000,"End Of Work","Another working day has come to an end! That's it for today, it's time to relax and have some time for yourself!",ToolTipIcon.Info);
                workEnded = true;
            }
            progressBar.Value = (int)progress;
            if (hourDifference != 0)
                Text = $"{TITLE} - {((int)hourDifference).ToString("D2")}h : {((int)((hourDifference * 60) % 60)).ToString("D2")}m";
            else
                Text = TITLE;
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = new DateTime(e.Start.Year, e.Start.Month, e.Start.Day,0,0,0);
            DateTime endDate = new DateTime(e.End.Year, e.End.Month, e.End.Day, 0, 0, 0);
            selectedTimestamps = new List<string>();
            while (startDate <= endDate)
            {
                selectedTimestamps.Add(Tools.convertToTimestamp(startDate));
                startDate = startDate.AddDays(1);
            }
            updateProjectView();
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            AddProject newProject = new AddProject();
            if (newProject.ShowDialog() != DialogResult.OK) return;
            if (newProject.Name == "") return;
            if (data.projectExists(newProject.Name))
            {
                MessageBox.Show("This project name already exists","Project exists",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            data.addProject(newProject.Name, newProject.Description, newProject.WorkingDays);
            updateProjectView();
        }

        private void listProjects_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                foreach (ListViewItem item in listProjects.Items)
                {
                    if (item == e.Item) continue;
                    item.Checked = false;
                }
                if (selectedProject != e.Item.Name)
                {//Charge previous project only if the project actually changed
                    lastDateTime = data.chargePreviousProject(lastDateTime, selectedProject);
                    selectedProject = e.Item.Name;
                }
            }
            if(listProjects.CheckedItems.Count == 0)
            {
                try
                {
                    listProjects.Items.Find(selectedProject, true)[0].Checked = true;
                }
                catch { }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            updateProjectView();
        }

        private void buttonReallocate_Click(object sender, EventArgs e)
        {
            updateProjectView();
            ReallocateTime reallocate = new ReallocateTime(data,calendar.SelectionStart);
            reallocate.ShowDialog();
            updateProjectView();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string selectedProjectInList;
            if (listProjects.SelectedItems.Count != 0)
                selectedProjectInList = listProjects.SelectedItems[0].Name;
            else selectedProjectInList = selectedProject;
            Data.Project projectToEdit = data.getProject(selectedProjectInList);
            if (projectToEdit != null)
            {
                EditProject editProject = new EditProject(projectToEdit, data, calendar.SelectionStart);
                editProject.Show();
                updateProjectView();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (data != null)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void contextMenuForIcon_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToLower().Contains("exit"))
            {
                timerRefresh.Stop();
                data = null;
                Application.Exit();
            }
            else if (e.ClickedItem.Name.ToLower().Contains("open"))
            {
                Show();
            }
        }
    }
}
