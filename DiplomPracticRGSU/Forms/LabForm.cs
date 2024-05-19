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
using System.Data.Entity;
using DiplomPracticRGSU.ModelEF;
using System.Data.Entity.Migrations;

namespace DiplomPracticRGSU.Forms
{
    public partial class LabForm : Form
    {
       
        Model1 mf = new Model1();

        Laboratory laboratory;

        public LabForm()
        {
            InitializeComponent();
        }

        private void LabForm_Load(object sender, EventArgs e)
        {
            laboratoryDataGridView.DataSource = mf.Laboratory.ToList();
        }


        private void laboratoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.laboratoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.technoparkPracticDataSet1);

        }

        private void laboratoryDataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            int idLab = (int)laboratoryDataGridView.CurrentRow.Cells[0].Value;

            laboratory = mf.Laboratory.Where(x => x.LabID == idLab).FirstOrDefault();

            laboratoryBindingSource1.DataSource = laboratory;
        }

        private void newButtton_Click(object sender, EventArgs e)
        {
            laboratory = new Laboratory();
            laboratoryBindingSource1.DataSource = laboratory;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || addressTextBox.Text == "" || headOfLabTextBox.Text  == "" || numberOfSeatsTextBox.Text =="")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            mf.Laboratory.Add(laboratory);
            mf.SaveChanges();
            laboratoryDataGridView.DataSource = mf.Laboratory.ToList();
            MessageBox.Show("Данные сохранены");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || addressTextBox.Text == "" || headOfLabTextBox.Text == "" || numberOfSeatsTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            mf.Laboratory.AddOrUpdate(laboratory);
            mf.SaveChanges();
            laboratoryDataGridView.DataSource = mf.Laboratory.ToList();
            MessageBox.Show("Изменения сохранены");
        }

        private void delitButton_Click(object sender, EventArgs e)
        {
            mf.Laboratory.Remove(laboratory);
            mf.SaveChanges();
            laboratoryDataGridView.DataSource = mf.Laboratory.ToList();
            MessageBox.Show("Лаборатория удалена");
        }
    }
}
