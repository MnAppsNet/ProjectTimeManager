using System;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public partial class Settings : Form
    {
        private static DateTime? _StartTime;
        private static DateTime? _EndTime;
        private static int _BreakTime;
        public static DateTime? StartTime 
        { 
            get { 
                if (_StartTime == null) _StartTime = Properties.Settings.Default.StartTime; 
                return _StartTime; } 
            set { _StartTime = value; } }
        public static DateTime? EndTime
        {
            get
            {
                if (_EndTime == null) _EndTime = Properties.Settings.Default.EndTime;
                return _EndTime.Value;
            }
            set { _EndTime = value; }
        }
        public static int BreakTime
        {
            get
            {
                if (_BreakTime == 0) _BreakTime = Properties.Settings.Default.BreakTime;
                return _BreakTime;
            }
            set { _BreakTime = value; }
        }
        public static double WorkingHours { get { return Math.Abs((EndTime - StartTime).Value.TotalHours); } }
        public Settings()
        {
            InitializeComponent();
        }

        private void timeChanged(object sender, EventArgs e)
        {
            TimeSpan workingHours = 
                (startTime.Value.TimeOfDay < endTime.Value.TimeOfDay)?
                    endTime.Value.TimeOfDay - startTime.Value.TimeOfDay:
                    startTime.Value.TimeOfDay - endTime.Value.TimeOfDay;
            workingHours = workingHours.Add(new TimeSpan(0, 0, -1 * (int)breakTime.Value, 0, 0));
            workTime.Text = workingHours.Hours.ToString("D2") + ':' + workingHours.Minutes.ToString("D2");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StartTime = startTime.Value;
            EndTime = endTime.Value;
            BreakTime = (int)breakTime.Value;

            Properties.Settings.Default.StartTime = startTime.Value;
            Properties.Settings.Default.EndTime = endTime.Value;
            Properties.Settings.Default.BreakTime = (int)breakTime.Value;
            Properties.Settings.Default.Save();

            Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            startTime.Value = Properties.Settings.Default.StartTime;
            endTime.Value = Properties.Settings.Default.EndTime;
            breakTime.Value = Properties.Settings.Default.BreakTime;
        }
    }
}