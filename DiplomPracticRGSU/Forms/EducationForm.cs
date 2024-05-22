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
            educationInstitutionBindingSource.DataSource = mf.EducationInstitution.ToList();
            typeOfEducationInstitutionBindingSource.DataSource = mf.TypeOfEducationInstitution.ToList();
        //   type
        }

        private void educationInstitutionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.educationInstitutionBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.technoparkPracticDataSet1);

        }


        private void educationInstitutionDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int idEducation = (int)educationInstitutionDataGridView.CurrentRow.Cells[0].Value;

            education = mf.EducationInstitution.Where(x => x.EducationalID == idEducation).FirstOrDefault();

            educationInstitutionBindingSource.DataSource = education;
        }

        private void newButtton_Click_1(object sender, EventArgs e)
        {
            educationInstitutionBindingSource.AddNew();
            ((EducationInstitution)educationInstitutionBindingSource.Current).TypeEducationID = (int)comboBox1.SelectedValue;
        }

        private void delitButton_Click_1(object sender, EventArgs e)
        {
            mf.EducationInstitution.Remove(
                (EducationInstitution)educationInstitutionBindingSource.Current);
            mf.SaveChanges();
            MessageBox.Show("Лаборатория удалена");
        }

        private void changeButton_Click_1(object sender, EventArgs e)
        {
            //if (nameTextBox.Text == "")
            //{
            //    MessageBox.Show("Заполните все поля");
            //    return;
            //}

            MessageBox.Show("Изменения сохранены");
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (educationInstitutionBindingSource.Count > mf.EducationInstitution.Count())
            {
                ((EducationInstitution)educationInstitutionBindingSource.Current).TypeEducationID = (int)comboBox1.SelectedValue;
                mf.EducationInstitution.Add(
                    (EducationInstitution)educationInstitutionBindingSource.Current);
                mf.SaveChanges();
                MessageBox.Show("Данные сохранены");
            }
            else
            {
                mf.SaveChanges();
                MessageBox.Show("Данные сохранены");

            }
        }
        private void educationInstitutionDataGridView_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = ((EducationInstitution)educationInstitutionBindingSource.Current).TypeEducationID;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((EducationInstitution)educationInstitutionBindingSource.Current).TypeEducationID = (int)comboBox1.SelectedValue;
            educationInstitutionBindingSource.ResetBindings(true);
        }
    }
}
