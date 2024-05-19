using DiplomPracticRGSU.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DiplomPracticRGSU
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void labButton_Click(object sender, EventArgs e)
        {
            LabForm labForm = new LabForm();
            labForm.Show();
        }

        private void educationButton_Click(object sender, EventArgs e)
        {
            EducationForm educationForm = new EducationForm();
            educationForm.Show();
        }

        private void traineeButton_Click(object sender, EventArgs e)
        {
            TraineeForm traineeForm = new TraineeForm();
            traineeForm.Show();
        }
    }
}
