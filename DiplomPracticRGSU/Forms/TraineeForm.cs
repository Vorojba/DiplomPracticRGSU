using System;
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
    public partial class TraineeForm : Form
    {
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "technoparkPracticDataSet1.Trainee". При необходимости она может быть перемещена или удалена.
            this.traineeTableAdapter.Fill(this.technoparkPracticDataSet1.Trainee);

        }
    }
}
