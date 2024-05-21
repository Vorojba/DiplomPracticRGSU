﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomPracticRGSU.Forms
{
    public partial class UkDay : UserControl
    {
        string _day, date, weekday;

        private void panel1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
            {
                checkBox1 .Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 70);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        public UkDay(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            checkBox1.Hide();
            date = Calendar._month + "/" + _day + "/" + Calendar._year;
        }

        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekday = day.ToString("ddd");
                if(weekday == "Sun")
                {
                    label1.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }catch(Exception ex) { }
        }
        private void UkDay_Load(object sender, EventArgs e)
        {
            sundays();
        }
    }
}
