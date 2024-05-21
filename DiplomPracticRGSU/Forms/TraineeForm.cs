using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiplomPracticRGSU.ModelEF;
using System.Data.Entity.Migrations;


namespace DiplomPracticRGSU.Forms
{
    public partial class TraineeForm : Form
    {
        Model1 mf = new Model1();

        Trainee trainee;

        public TraineeForm()
        {
            InitializeComponent();
        }

        private void traineeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traineeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.technoparkPracticDataSet1);

        }

        private void TraineeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "technoparkPracticDataSet1.EducationInstitution". При необходимости она может быть перемещена или удалена.
            this.educationInstitutionTableAdapter.Fill(this.technoparkPracticDataSet1.EducationInstitution);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "technoparkPracticDataSet1.Laboratory". При необходимости она может быть перемещена или удалена.
            this.laboratoryTableAdapter.Fill(this.technoparkPracticDataSet1.Laboratory);
            traineeDataGridView.DataSource = mf.Trainee.ToList();
        }

        private void traineeDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idTrainee = (int)traineeDataGridView.CurrentRow.Cells[0].Value;

            trainee = mf.Trainee.Where(x => x.TraineeID == idTrainee).FirstOrDefault();

            traineeDataGridView.DataSource = trainee;
        }

        private void newButtton_Click(object sender, EventArgs e)
        {
            trainee = new Trainee();
            traineeBindingSource.DataSource = trainee;
        }

        private void delitButton_Click(object sender, EventArgs e)
        {
            mf.Trainee.Remove(trainee);
            mf.SaveChanges();
            traineeBindingSource.DataSource = mf.Trainee.ToList();
            MessageBox.Show("Лаборатория удалена");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            mf.Trainee.AddOrUpdate(trainee);
            mf.SaveChanges();
            traineeBindingSource.DataSource = mf.Trainee.ToList();
            MessageBox.Show("Изменения сохранены");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            mf.Trainee.Add(trainee);
            mf.SaveChanges();
            traineeBindingSource.DataSource = mf.Trainee.ToList();
            MessageBox.Show("Данные сохранены");
        }
    }
}
