using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public partial class SelectTIme : Form
    {
        public SelectTIme()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (dateTo.Value < dateFrom.Value) dateTo = dateFrom;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SelectTIme_Load(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            dateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01, 0, 0, 0);
            dateTo.Value = DateTime.Now;
        }
    }
}
