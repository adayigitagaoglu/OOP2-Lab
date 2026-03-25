using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prelab_03_152120231167_152120241075_Group5
{
   
    public partial class Form1 : Form
    {
        private DateTime baseTime;
        private Color dayColor = Color.Black;
        public Form1()
        {
            InitializeComponent();
            baseTime = DateTime.UtcNow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtZoneName_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            baseTime = baseTime.AddSeconds(1);
            DateTime displayTime = baseTime;

            if (cBoxTimeZone.SelectedItem is TimeZoneItem selectedZone)
            {
                displayTime = baseTime.AddHours(selectedZone.OffsetHours);
                ZoneLabel.Text = $" {selectedZone.Name}";
            }
            else
            {
                ZoneLabel.Text = " Default"; 
            }

            clockLabel.Text = displayTime.ToString("HH:mm:ss");

            if (displayTime.Hour >= 10 && displayTime.Hour < 23)
            {
                clockLabel.ForeColor = dayColor;
            }
            else
            {
                clockLabel.ForeColor = Color.Green;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            baseTime = new DateTime(baseTime.Year, baseTime.Month, baseTime.Day,
                  dateTimePicker.Value.Hour, dateTimePicker.Value.Minute, dateTimePicker.Value.Second);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtZoneoffset.Text, out double offset))
            {
                var newZone = new TimeZoneItem { Name = txtZoneName.Text, OffsetHours = offset };
                cBoxTimeZone.Items.Add(newZone);
                clbTimeZones.Items.Add(newZone);
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the offset.");
            }
        }

        private void clockLabel_Click(object sender, EventArgs e)
        {

        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dayColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clbTimeZones.CheckedIndices.Count == 1)
            {
                int index = clbTimeZones.CheckedIndices[0];
                if (double.TryParse(txtZoneoffset.Text, out double offset))
                {
                    var updatedZone = new TimeZoneItem { Name = txtZoneName.Text, OffsetHours = offset };

                    clbTimeZones.Items[index] = updatedZone;
                    cBoxTimeZone.Items[index] = updatedZone;

                    clbTimeZones.SetItemChecked(index, false);
                }
            }
            else
            {
                MessageBox.Show("Please check one time zone in the list to update.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = clbTimeZones.CheckedIndices.Count - 1; i >= 0; i--)
            {
                int indexToDelete = clbTimeZones.CheckedIndices[i];
                cBoxTimeZone.Items.RemoveAt(indexToDelete);
                clbTimeZones.Items.RemoveAt(indexToDelete);
            }
        }

        public class TimeZoneItem
        {
            public string Name { get; set; }
            public double OffsetHours { get; set; }

            public override string ToString()
            {
                return $"{Name} (UTC {OffsetHours:+0.##;-0.##;0})";
            }
        }

        private void clbTimeZones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelZoneName_Click(object sender, EventArgs e)
        {

        }

        private void labelZoneOffset_Click(object sender, EventArgs e)
        {

        }
    }
}
