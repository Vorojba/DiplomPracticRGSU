using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DiplomPracticRGSU.ModelEF;
using System.Data.Entity.Migrations;


namespace DiplomPracticRGSU.Forms
{
    public partial class EducationForm : Form
    {
        Model1 mf = new Model1();

        EducationInstitution education; 
        public EducationForm()
        {
            InitializeComponent();
        }
        private void EducationForm_Load(object sender, EventArgs e)
        {
            this.typeOfEducationInstitutionTableAdapter.Fill(this.technoparkPracticDataSet1.TypeOfEducationInstitution);
            educationInstitutionDataGridView.DataSource = mf.EducationInstitution.ToList();
            //typeEducationIDComboBox.DataSource = mf.TypeOfEducationInstitution.ToList();
        }

        private void educationInstitutionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.educationInstitutionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.technoparkPracticDataSet1);

        }


        private void educationInstitutionDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int idEducation = (int)educationInstitutionDataGridView.CurrentRow.Cells[0].Value;

            education = mf.EducationInstitution.Where(x => x.EducationalID == idEducation).FirstOrDefault();

            educationInstitutionBindingSource.DataSource = education;
        }

        private void newButtton_Click_1(object sender, EventArgs e)
        {
            education = new EducationInstitution();
            educationInstitutionBindingSource.DataSource = education;
        }

        private void delitButton_Click_1(object sender, EventArgs e)
        {
            mf.EducationInstitution.Remove(education);
            mf.SaveChanges();
            educationInstitutionDataGridView.DataSource = mf.EducationInstitution.ToList();
            MessageBox.Show("Лаборатория удалена");
        }

        private void changeButton_Click_1(object sender, EventArgs e)
        {
            //if (nameTextBox.Text == "")
            //{
            //    MessageBox.Show("Заполните все поля");
            //    return;
            //}
            mf.EducationInstitution.AddOrUpdate(education);
            mf.SaveChanges();
            educationInstitutionDataGridView.DataSource = mf.EducationInstitution.ToList();
            MessageBox.Show("Изменения сохранены");
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            //if (nameTextBox.Text == "")
            //{
            //    MessageBox.Show("Заполните все поля");
            //    return;
            //}
            mf.EducationInstitution.Add(education);
            mf.SaveChanges();
            educationInstitutionDataGridView.DataSource = mf.EducationInstitution.ToList();
            MessageBox.Show("Данные сохранены");
        }

        
    }
}
