/*
* Created by SharpDevelop.
* User: tmontauf040213
* Date: 26/12/2013
* Time: 17:04
*
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;
using System.Windows.Forms;

namespace Explorer
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class RichExplorer : Form
   {
        //private holidayCalculator _hc_full;
        //private holidayCalculator _hc_partial;
        //private OpenDays _od;
        //private string _previewsCountry;

        public RichExplorer()
       {
            PreInit();
            InitializeComponent();
        }

        private void PreInit()
       {
            // Time management
            //PanelMonitor pm = new PanelMonitor();
        }
        private void PostInit()
       {
            //// Monitor
            //int[] valueList = new int[120];
            //Random r = new Random();
            //for (int i = 0; i < valueList.Length; i++)
            //{
            //    valueList[i] = r.Next(20, 40);
            //}
            //panelGraph1.Values = valueList;
        }
        private bool BuildCalendar()
       {
            try
           {
                //_hc_partial = new holidayCalculator(DateTime.Now, @"P:\_DEV\holidays" + comboBoxCountry.Text + ".xml");
                //_hc_full = new holidayCalculator(10, @"P:\_DEV\holidays" + comboBoxCountry.Text + ".xml");
                //_od = new OpenDays(_hc_full);

                //foreach (holiday element in _hc_partial.Orderedholidays)
                //{
                //    textBoxCheck.AppendText(element.Name + " - " + element.Date.ToShortDateString() + " - " + element.LocalName + " - " + element.Region);
                //    textBoxCheck.AppendText("\r\n");
                //}
                return true;
            }
            catch (Exception)
           {
                return false;
            }
        }
        private void RefreshPanel()
       {
            //if (!string.IsNullOrEmpty(textBoxYear.Value.ToString()) && !string.IsNullOrEmpty(comboBoxMonth.Text))
            //{
            //    UpdateDGVMonth();
            //    UpdateOpenDay();
            //    UpdateAllOpenDaysTB();
            //}
        }
        private void UpdateOpenDay()
       {
            //labelOpenDayVal.Text = trackBarOpenDay.Value.ToString();
            //int day = _od.GetDayOfOpenNum(trackBarOpenDay.Value, int.Parse(comboBoxMonth.Text), int.Parse(textBoxYear.Text));
            //if (day == 0)
            //{
            //    textBoxResultOpenDay.Text = "Non possible open day for this month.";
            //}
            //else
            //{
            //    DateTime dt = new DateTime((int)textBoxYear.Value, int.Parse(comboBoxMonth.Text), day);
            //    textBoxResultOpenDay.Text = dt.ToShortDateString();
            //}
        }
        private void UpdateDGVMonth()
       {
            //dataGridViewMonth.Rows.Clear();
            //DateTime dt = new DateTime((int)textBoxYear.Value, int.Parse(comboBoxMonth.Text), 1);

            //for (int i = 0; i < DateTime.DaysInMonth((int)textBoxYear.Value, int.Parse(comboBoxMonth.Text)); i++)
            //{
            //    int rowIndex = this.dataGridViewMonth.Rows.Add();
            //    DataGridViewRow row = this.dataGridViewMonth.Rows[rowIndex];

            //    row.Cells[0].Value = dt.ToShortDateString();
            //    row.Cells[1].Value = _od.IsOpenDay(dt) ? "yes" : "no";
            //    int v = _od.GetNumOfOpenDay(dt);
            //    row.Cells[2].Value = v == 0 ? " " : v.ToString();
            //    row.Cells[3].Value = "";

            //    dt = dt.AddDays(1);
            //}
        }
        private void UpdateAllOpenDaysTB()
       {
            //textBoxDays.Clear();
            //for (int i = 1; i <= 12; i++)
            //{
            //    textBoxDays.AppendText(_od.GetDayOfOpenNum(trackBarOpenDay.Value, i, (int)textBoxYear.Value) + "\t/\t" + i + "\t/\t" + (int)textBoxYear.Value + "\r\n");
            //}
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
       {
            RefreshPanel();
        }
        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
       {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBoxYear_TextChanged(object sender, EventArgs e)
       {
            RefreshPanel();
        }
        private void comboBoxMonth_TextChanged(object sender, EventArgs e)
       {
            RefreshPanel();
        }
        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
       {
            RefreshPanel();
        }
        private void textBoxYear_ValueChanged(object sender, EventArgs e)
       {
            RefreshPanel();
        }
        private void comboBoxCountry_SelectedValueChanged(object sender, EventArgs e)
       {
            //if (!BuildCalendar()) comboBoxCountry.Text = _previewsCountry;
            //else _previewsCountry = comboBoxCountry.Text;
            //RefreshPanel();
        }
        private void buttonCalendar_Click(object sender, EventArgs e)
       {
            //tabControlMon.SelectedTab = tabControlMon.TabPages[tabControlMon.TabPages.IndexOfKey(tabPageCalendar.Name)];
        }
        private void buttonTools_Click(object sender, EventArgs e)
       {
            //tabControlMon.SelectedTab = tabControlMon.TabPages[tabControlMon.TabPages.IndexOfKey(tabPageTools.Name)];
        }
        private void buttonMonitoring_Click(object sender, EventArgs e)
       {
            //tabControlMon.SelectedTab = tabControlMon.TabPages[tabControlMon.TabPages.IndexOfKey(tabPageMonitor.Name)];
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
       {
            this.Close();
        }
        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
       {
            Monitor m = new Monitor();
            m.Show();
        }
        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
       {
            Calendar c = new Calendar();
            c.Show();
        }
        private void renameFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }
        private void schedulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Droid_scheduler.GUI scheduler = new Droid_scheduler.GUI();
                // scheduler.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Aïe aïe aïe, there is again some bugs : \n\n" + exp.Message, "Crash !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tobiToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Assistant_GUI.GUI SuperTobiHelpMe = new Assistant_GUI.GUI();
                //SuperTobiHelpMe.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Aïe aïe aïe, there is again some bugs : \n\n" + exp.Message, "Crash !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
