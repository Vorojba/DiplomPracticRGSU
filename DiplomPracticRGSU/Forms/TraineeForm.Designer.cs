﻿namespace DiplomPracticRGSU.Forms
{
    partial class TraineeForm
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
            System.Windows.Forms.Label traineeIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label labIDLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label educationalIDLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraineeForm));
            this.technoparkPracticDataSet1 = new DiplomPracticRGSU.TechnoparkPracticDataSet1();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traineeTableAdapter = new DiplomPracticRGSU.TechnoparkPracticDataSet1TableAdapters.TraineeTableAdapter();
            this.tableAdapterManager = new DiplomPracticRGSU.TechnoparkPracticDataSet1TableAdapters.TableAdapterManager();
            this.traineeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.educationalIDComboBox = new System.Windows.Forms.ComboBox();
            this.educationInstitutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labIDComboBox = new System.Windows.Forms.ComboBox();
            this.laboratoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.traineeIDTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.delitButton = new System.Windows.Forms.Button();
            this.newButtton = new System.Windows.Forms.Button();
            this.laboratoryTableAdapter = new DiplomPracticRGSU.TechnoparkPracticDataSet1TableAdapters.LaboratoryTableAdapter();
            this.educationInstitutionTableAdapter = new DiplomPracticRGSU.TechnoparkPracticDataSet1TableAdapters.EducationInstitutionTableAdapter();
            traineeIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            labIDLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            educationalIDLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technoparkPracticDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educationInstitutionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // traineeIDLabel
            // 
            traineeIDLabel.AutoSize = true;
            traineeIDLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            traineeIDLabel.Location = new System.Drawing.Point(233, 19);
            traineeIDLabel.Name = "traineeIDLabel";
            traineeIDLabel.Size = new System.Drawing.Size(37, 23);
            traineeIDLabel.TabIndex = 0;
            traineeIDLabel.Text = "ID:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(169, 45);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(101, 23);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(214, 73);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(56, 23);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Имя:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            patronymicLabel.Location = new System.Drawing.Point(173, 96);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(97, 23);
            patronymicLabel.TabIndex = 6;
            patronymicLabel.Text = "Отчество:";
            // 
            // labIDLabel
            // 
            labIDLabel.AutoSize = true;
            labIDLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labIDLabel.Location = new System.Drawing.Point(137, 126);
            labIDLabel.Name = "labIDLabel";
            labIDLabel.Size = new System.Drawing.Size(133, 23);
            labIDLabel.TabIndex = 8;
            labIDLabel.Text = "Лаборатория:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startDateLabel.Location = new System.Drawing.Point(97, 151);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(173, 23);
            startDateLabel.TabIndex = 10;
            startDateLabel.Text = "Начало праткики:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endDateLabel.Location = new System.Drawing.Point(64, 175);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(206, 23);
            endDateLabel.TabIndex = 12;
            endDateLabel.Text = "Окончание праткики:";
            // 
            // educationalIDLabel
            // 
            educationalIDLabel.AutoSize = true;
            educationalIDLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            educationalIDLabel.Location = new System.Drawing.Point(141, 203);
            educationalIDLabel.Name = "educationalIDLabel";
            educationalIDLabel.Size = new System.Drawing.Size(129, 23);
            educationalIDLabel.TabIndex = 14;
            educationalIDLabel.Text = "Место учебы:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(177, 227);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(93, 23);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Телефон:";
            // 
            // technoparkPracticDataSet1
            // 
            this.technoparkPracticDataSet1.DataSetName = "TechnoparkPracticDataSet1";
            this.technoparkPracticDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataMember = "Trainee";
            this.traineeBindingSource.DataSource = this.technoparkPracticDataSet1;
            // 
            // traineeTableAdapter
            // 
            this.traineeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EducationInstitutionTableAdapter = null;
            this.tableAdapterManager.Lab_MasterClassTableAdapter = null;
            this.tableAdapterManager.LaboratoryTableAdapter = null;
            this.tableAdapterManager.MasterClassTableAdapter = null;
            this.tableAdapterManager.TraineeTableAdapter = this.traineeTableAdapter;
            this.tableAdapterManager.TypeOfEducationInstitutionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DiplomPracticRGSU.TechnoparkPracticDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // traineeDataGridView
            // 
            this.traineeDataGridView.AutoGenerateColumns = false;
            this.traineeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.traineeDataGridView.DataSource = this.traineeBindingSource;
            this.traineeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.traineeDataGridView.Name = "traineeDataGridView";
            this.traineeDataGridView.Size = new System.Drawing.Size(841, 300);
            this.traineeDataGridView.TabIndex = 1;
            this.traineeDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.traineeDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TraineeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TraineeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Patronymic";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LabID";
            this.dataGridViewTextBoxColumn5.HeaderText = "LabID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EducationalID";
            this.dataGridViewTextBoxColumn8.HeaderText = "EducationalID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn9.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.educationalIDComboBox);
            this.panel1.Controls.Add(this.labIDComboBox);
            this.panel1.Controls.Add(this.phoneMaskedTextBox);
            this.panel1.Controls.Add(traineeIDLabel);
            this.panel1.Controls.Add(this.traineeIDTextBox);
            this.panel1.Controls.Add(lastNameLabel);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(patronymicLabel);
            this.panel1.Controls.Add(this.patronymicTextBox);
            this.panel1.Controls.Add(labIDLabel);
            this.panel1.Controls.Add(startDateLabel);
            this.panel1.Controls.Add(this.startDateDateTimePicker);
            this.panel1.Controls.Add(endDateLabel);
            this.panel1.Controls.Add(this.endDateDateTimePicker);
            this.panel1.Controls.Add(educationalIDLabel);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Location = new System.Drawing.Point(57, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 270);
            this.panel1.TabIndex = 2;
            // 
            // educationalIDComboBox
            // 
            this.educationalIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "EducationalID", true));
            this.educationalIDComboBox.DataSource = this.educationInstitutionBindingSource;
            this.educationalIDComboBox.DisplayMember = "Name";
            this.educationalIDComboBox.FormattingEnabled = true;
            this.educationalIDComboBox.Location = new System.Drawing.Point(276, 205);
            this.educationalIDComboBox.Name = "educationalIDComboBox";
            this.educationalIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.educationalIDComboBox.TabIndex = 21;
            this.educationalIDComboBox.ValueMember = "EducationalID";
            // 
            // educationInstitutionBindingSource
            // 
            this.educationInstitutionBindingSource.DataMember = "EducationInstitution";
            this.educationInstitutionBindingSource.DataSource = this.technoparkPracticDataSet1;
            // 
            // labIDComboBox
            // 
            this.labIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "LabID", true));
            this.labIDComboBox.DataSource = this.laboratoryBindingSource;
            this.labIDComboBox.DisplayMember = "Name";
            this.labIDComboBox.FormattingEnabled = true;
            this.labIDComboBox.Location = new System.Drawing.Point(276, 128);
            this.labIDComboBox.Name = "labIDComboBox";
            this.labIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.labIDComboBox.TabIndex = 20;
            this.labIDComboBox.ValueMember = "LabID";
            // 
            // laboratoryBindingSource
            // 
            this.laboratoryBindingSource.DataMember = "Laboratory";
            this.laboratoryBindingSource.DataSource = this.technoparkPracticDataSet1;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(276, 230);
            this.phoneMaskedTextBox.Mask = "+7(000)000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneMaskedTextBox.TabIndex = 19;
            // 
            // traineeIDTextBox
            // 
            this.traineeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "TraineeID", true));
            this.traineeIDTextBox.Location = new System.Drawing.Point(276, 19);
            this.traineeIDTextBox.Name = "traineeIDTextBox";
            this.traineeIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.traineeIDTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(276, 45);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(276, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(276, 99);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronymicTextBox.TabIndex = 7;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.traineeBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(276, 151);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 11;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.traineeBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(276, 177);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateDateTimePicker.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(602, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Управление записями";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.changeButton);
            this.panel2.Controls.Add(this.delitButton);
            this.panel2.Controls.Add(this.newButtton);
            this.panel2.Location = new System.Drawing.Point(606, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 199);
            this.panel2.TabIndex = 6;
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
            // laboratoryTableAdapter
            // 
            this.laboratoryTableAdapter.ClearBeforeFill = true;
            // 
            // educationInstitutionTableAdapter
            // 
            this.educationInstitutionTableAdapter.ClearBeforeFill = true;
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 605);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.traineeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraineeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TraineeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technoparkPracticDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educationInstitutionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TechnoparkPracticDataSet1 technoparkPracticDataSet1;
        private System.Windows.Forms.BindingSource traineeBindingSource;
        private TechnoparkPracticDataSet1TableAdapters.TraineeTableAdapter traineeTableAdapter;
        private TechnoparkPracticDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView traineeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox traineeIDTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button delitButton;
        private System.Windows.Forms.Button newButtton;
        private System.Windows.Forms.ComboBox educationalIDComboBox;
        private System.Windows.Forms.ComboBox labIDComboBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.BindingSource laboratoryBindingSource;
        private TechnoparkPracticDataSet1TableAdapters.LaboratoryTableAdapter laboratoryTableAdapter;
        private System.Windows.Forms.BindingSource educationInstitutionBindingSource;
        private TechnoparkPracticDataSet1TableAdapters.EducationInstitutionTableAdapter educationInstitutionTableAdapter;
    }
}