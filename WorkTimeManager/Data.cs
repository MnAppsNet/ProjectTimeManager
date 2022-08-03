using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace WorkTimeManager
{
    public class Data
    {
        public const string UNALLOCATED = "Unallocated";
        private Dictionary<string,Project> projects = new Dictionary<string, Project>();
        
        public Data()
        {
            load();
        }
        private void load()
        {
            string projectsJSON = Properties.Settings.Default.ProjectsJSON;
            try
            {
                if (projectsJSON != "")
                    projects = JsonConvert.DeserializeObject<Dictionary<string, Project>>(projectsJSON);
            }
            catch{ }
            if (!projects.ContainsKey(UNALLOCATED))
            {
                projects.Add(UNALLOCATED, new Project(UNALLOCATED,"Unallocated time", null));
            }
        }
        public void Save()
        {
            string projectsJson = JsonConvert.SerializeObject(projects);
            Properties.Settings.Default.ProjectsJSON = projectsJson;
            Properties.Settings.Default.Save();
        }
        public void addProject(string project, string description, Dictionary<int, bool> workingDays)
        {
            if (projectExists(project)) return;
            projects.Add(project, new Project(project, description, workingDays));
            Save();
        }
        public void deleteProject(string name)
        {
            projects.Remove(name);
        }
        public void addProject(Project project)
        {
            projects.Add(project.Name, project);
        }
        public Project getProject(string project)
        {
            return (projects.ContainsKey(project)) ? projects[project] : null;
        }
        public List<Project> getProjects()
        {
            List<Project> projectsList = new List<Project>();
            projectsList.AddRange(projects.Values);
            return projectsList;
        }
        public bool projectExists(string project)
        {
            return projects.ContainsKey(project);
        }
        public DateTime chargePreviousProject(DateTime lastChange, string oldProject)
        {
            DateTime now = DateTime.Now;
            chargeProject(oldProject,lastChange,now);
            return now;
        }
        public void chargeProject(string projectName, DateTime from, DateTime to)
        {
            Project project = getProject(projectName);
            if (project == null) return;
            DateTime startWorkingTime = new DateTime(from.Year, from.Month, from.Day,
                Settings.StartTime.Value.Hour, Settings.StartTime.Value.Minute, Settings.StartTime.Value.Second);
            if (from < startWorkingTime) from = startWorkingTime;

            DateTime endWorkingTime = new DateTime(to.Year, to.Month, to.Day,
                Settings.EndTime.Value.Hour, Settings.EndTime.Value.Minute, Settings.EndTime.Value.Second).
                AddMinutes(-1 * Settings.BreakTime);
            if (to > endWorkingTime) to = endWorkingTime;

            while (from < to)
            {
                if (!project.WorkingDays[(int)from.DayOfWeek])
                {//If not a working day go to the next one
                    from = Tools.nextWorkingDay(from);
                    continue;
                }

                string timeStamp = Tools.convertToTimestamp(from);
                if (!project.ChargedTime.ContainsKey(timeStamp))
                {
                    project.ChargedTime.Add(timeStamp, 0);
                }
                DateTime endOfCurrentDay = new DateTime(from.Year, from.Month, from.Day,
                    Settings.EndTime.Value.Hour, Settings.EndTime.Value.Minute, Settings.EndTime.Value.Second).
                    AddMinutes(-1 * Settings.BreakTime);
                if (to <= endOfCurrentDay)
                {
                    project.ChargedTime[timeStamp] += (to - from).TotalHours;
                }
                else if (from <= endOfCurrentDay)
                {
                    project.ChargedTime[timeStamp] += (endOfCurrentDay - from).TotalHours;
                }
                from = Tools.nextWorkingDay(from);
            }
            Save();
        }

        public class Project
        {
            public Project(string name, string description, Dictionary<int, bool> workingDays)
            {
                Name = name;
                Description = description;
                Started = DateTime.Now;
                if (workingDays == null)
                {//If no working day info is provided, assume all days are working days
                    workingDays = new Dictionary<int, bool>();
                    workingDays.Add((int)DayOfWeek.Monday, true);
                    workingDays.Add((int)DayOfWeek.Tuesday, true);
                    workingDays.Add((int)DayOfWeek.Wednesday, true);
                    workingDays.Add((int)DayOfWeek.Thursday, true);
                    workingDays.Add((int)DayOfWeek.Friday, true);
                    workingDays.Add((int)DayOfWeek.Saturday, true);
                    workingDays.Add((int)DayOfWeek.Sunday, true);
                }
                WorkingDays = workingDays;
                ChargedTime = new Dictionary<string, double>();
            }
            public void CloseProject()
            {
                Ended = DateTime.Now;
            }
            public void OpenProject()
            {
                Ended = null;
            }
            public DateTime Started { get; set; }
            public DateTime? Ended { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Dictionary<int, bool> WorkingDays { get; set; }
            public Dictionary<string, double> ChargedTime { get; set; } //Timestamp:hours
        }
    }
}