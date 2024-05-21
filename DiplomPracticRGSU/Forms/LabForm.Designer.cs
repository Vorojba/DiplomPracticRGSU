namespace DiplomPracticRGSU.Forms
{
    partial class LabForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.laboratoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.technoparkPracticDataSet1 = new DiplomPracticRGSU.TechnoparkPracticDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.labIDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.headOfLabTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passportOfLabTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.delitButton = new System.Windows.Forms.Button();
            this.newButtton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.laboratoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratoryTableAdapter = new DiplomPracticRGSU.TechnoparkPracticDataSet1TableAdapters.LaboratoryTableAdapter();
            this.tableAdapterManager = new DiplomPracticRGSU.TechnoparkPracticDataSet1TableAdapters.TableAdapterManager();
            this.laboratoryDataGridView = new System.Windows.Forms.DataGridView();
            this.labIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headOfLabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportOfLabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technoparkPracticDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technoparkPracticDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technoparkPracticDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technoparkPracticDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technoparkPracticDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labIDTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.headOfLabTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.passportOfLabTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numberOfSeatsTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 225);
            this.panel1.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratoryBindingSource1, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(242, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(186, 20);
            this.nameTextBox.TabIndex = 17;
            // 
            // laboratoryBindingSource1
            // 
            this.laboratoryBindingSource1.DataMember = "Laboratory";
            this.laboratoryBindingSource1.DataSource = this.technoparkPracticDataSet1;
            // 
            // technoparkPracticDataSet1
            // 
            this.technoparkPracticDataSet1.DataSetName = "TechnoparkPracticDataSet1";
            this.technoparkPracticDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(133, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Название:";
            // 
            // labIDTextBox
            // 
            this.labIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratoryBindingSource1, "LabID", true));
            this.labIDTextBox.Location = new System.Drawing.Point(242, 26);
            this.labIDTextBox.Name = "labIDTextBox";
            this.labIDTextBox.Size = new System.Drawing.Size(186, 20);
            this.labIDTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratoryBindingSource1, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(242, 86);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(186, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Паспорт лаборатории:";
            // 
            // headOfLabTextBox
            // 
            this.headOfLabTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratoryBindingSource1, "HeadOfLab", true));
            this.headOfLabTextBox.Location = new System.Drawing.Point(242, 118);
            this.headOfLabTextBox.Name = "headOfLabTextBox";
            this.headOfLabTextBox.Size = new System.Drawing.Size(186, 20);
            this.headOfLabTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(70, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество мест:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО Заведующего:";
            // 
            // passportOfLabTextBox
            // 
            this.passportOfLabTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratoryBindingSource1, "PassportOfLab", true));
            this.passportOfLabTextBox.Location = new System.Drawing.Point(242, 191);
            this.passportOfLabTextBox.Name = "passportOfLabTextBox";
            this.passportOfLabTextBox.Size = new System.Drawing.Size(186, 20);
            this.passportOfLabTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(167, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес:";
            // 
            // numberOfSeatsTextBox
            // 
            this.numberOfSeatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratoryBindingSource1, "NumberOfSeats", true));
            this.numberOfSeatsTextBox.Location = new System.Drawing.Point(242, 157);
            this.numberOfSeatsTextBox.Name = "numberOfSeatsTextBox";
            this.numberOfSeatsTextBox.Size = new System.Drawing.Size(186, 20);
            this.numberOfSeatsTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.changeButton);
            this.panel2.Controls.Add(this.delitButton);
            this.panel2.Controls.Add(this.newButtton);
            this.panel2.Location = new System.Drawing.Point(550, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 199);
            this.panel2.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.saveButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(22, 149);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(162, 41);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.changeButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(22, 102);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(162, 41);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // delitButton
            // 
            this.delitButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.delitButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delitButton.Location = new System.Drawing.Point(22, 55);
            this.delitButton.Name = "delitButton";
            this.delitButton.Size = new System.Drawing.Size(162, 41);
            this.delitButton.TabIndex = 4;
            this.delitButton.Text = "Удалить";
            this.delitButton.UseVisualStyleBackColor = false;
            this.delitButton.Click += new System.EventHandler(this.delitButton_Click);
            // 
            // newButtton
            // 
            this.newButtton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.newButtton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newButtton.Location = new System.Drawing.Point(22, 8);
            this.newButtton.Name = "newButtton";
            this.newButtton.Size = new System.Drawing.Size(162, 41);
            this.newButtton.TabIndex = 3;
            this.newButtton.Text = "Новая запись";
            this.newButtton.UseVisualStyleBackColor = false;
            this.newButtton.Click += new System.EventHandler(this.newButtton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(546, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Управление записями";
            // 
            // laboratoryBindingSource
            // 
            this.laboratoryBindingSource.DataMember = "Laboratory";
            this.laboratoryBindingSource.DataSource = this.technoparkPracticDataSet1;
            // 
            // laboratoryTableAdapter
            // 
            this.laboratoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EducationInstitutionTableAdapter = null;
            this.tableAdapterManager.Lab_MasterClassTableAdapter = null;
            this.tableAdapterManager.LaboratoryTableAdapter = this.laboratoryTableAdapter;
            this.tableAdapterManager.MasterClassTableAdapter = null;
            this.tableAdapterManager.TraineeTableAdapter = null;
            this.tableAdapterManager.TypeOfEducationInstitutionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DiplomPracticRGSU.TechnoparkPracticDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // laboratoryDataGridView
            // 
            this.laboratoryDataGridView.AutoGenerateColumns = false;
            this.laboratoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.laboratoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laboratoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.headOfLabDataGridViewTextBoxColumn,
            this.passportOfLabDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn});
            this.laboratoryDataGridView.DataSource = this.laboratoryBindingSource1;
            this.laboratoryDataGridView.Location = new System.Drawing.Point(34, 12);
            this.laboratoryDataGridView.Name = "laboratoryDataGridView";
            this.laboratoryDataGridView.ReadOnly = true;
            this.laboratoryDataGridView.Size = new System.Drawing.Size(716, 326);
            this.laboratoryDataGridView.TabIndex = 4;
            this.laboratoryDataGridView.DoubleClick += new System.EventHandler(this.laboratoryDataGridView_DoubleClick_1);
            // 
            // labIDDataGridViewTextBoxColumn
            // 
            this.labIDDataGridViewTextBoxColumn.DataPropertyName = "LabID";
            this.labIDDataGridViewTextBoxColumn.HeaderText = "LabID";
            this.labIDDataGridViewTextBoxColumn.Name = "labIDDataGridViewTextBoxColumn";
            this.labIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.labIDDataGridViewTextBoxColumn.Width = 61;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 70;
            // 
            // headOfLabDataGridViewTextBoxColumn
            // 
            this.headOfLabDataGridViewTextBoxColumn.DataPropertyName = "HeadOfLab";
            this.headOfLabDataGridViewTextBoxColumn.HeaderText = "HeadOfLab";
            this.headOfLabDataGridViewTextBoxColumn.Name = "headOfLabDataGridViewTextBoxColumn";
            this.headOfLabDataGridViewTextBoxColumn.ReadOnly = true;
            this.headOfLabDataGridViewTextBoxColumn.Width = 87;
            // 
            // passportOfLabDataGridViewTextBoxColumn
            // 
            this.passportOfLabDataGridViewTextBoxColumn.DataPropertyName = "PassportOfLab";
            this.passportOfLabDataGridViewTextBoxColumn.HeaderText = "PassportOfLab";
            this.passportOfLabDataGridViewTextBoxColumn.Name = "passportOfLabDataGridViewTextBoxColumn";
            this.passportOfLabDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportOfLabDataGridViewTextBoxColumn.Width = 102;
            // 
            // numberOfSeatsDataGridViewTextBoxColumn
            // 
            this.numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
            this.numberOfSeatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfSeatsDataGridViewTextBoxColumn.Width = 107;
            // 
            // technoparkPracticDataSet1BindingSource
            // 
            this.technoparkPracticDataSet1BindingSource.DataSource = this.technoparkPracticDataSet1;
            this.technoparkPracticDataSet1BindingSource.Position = 0;
            // 
            // technoparkPracticDataSet1BindingSource1
            // 
            this.technoparkPracticDataSet1BindingSource1.DataSource = this.technoparkPracticDataSet1;
            this.technoparkPracticDataSet1BindingSource1.Position = 0;
            // 
            // LabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 582);
            this.Controls.Add(this.laboratoryDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LabForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LabForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technoparkPracticDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technoparkPracticDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technoparkPracticDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button delitButton;
        private System.Windows.Forms.Button newButtton;
        private TechnoparkPracticDataSet1 technoparkPracticDataSet1;
        private System.Windows.Forms.BindingSource laboratoryBindingSource;
        private TechnoparkPracticDataSet1TableAdapters.LaboratoryTableAdapter laboratoryTableAdapter;
        private TechnoparkPracticDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView laboratoryDataGridView;
        private System.Windows.Forms.BindingSource technoparkPracticDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource technoparkPracticDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn labIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headOfLabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportOfLabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource laboratoryBindingSource1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox labIDTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox headOfLabTextBox;
        private System.Windows.Forms.TextBox passportOfLabTextBox;
        private System.Windows.Forms.TextBox numberOfSeatsTextBox;
    }
}