namespace DiplomPracticRGSU.Forms
{
    partial class EducationForm
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactPersonLabel;
            System.Windows.Forms.Label contractLabel;
            System.Windows.Forms.Label contractTimeLabel;
            System.Windows.Forms.Label costOfTraineesLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label typeEducationIDLabel;
            System.Windows.Forms.Label phoneContactLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.typeOfEducationInstitutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneContactMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.educationInstitutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.contractTextBox = new System.Windows.Forms.TextBox();
            this.contractTimeTextBox = new System.Windows.Forms.TextBox();
            this.costOfTraineesTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.delitButton = new System.Windows.Forms.Button();
            this.newButtton = new System.Windows.Forms.Button();
            this.educationInstitutionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addressLabel = new System.Windows.Forms.Label();
            contactPersonLabel = new System.Windows.Forms.Label();
            contractLabel = new System.Windows.Forms.Label();
            contractTimeLabel = new System.Windows.Forms.Label();
            costOfTraineesLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            typeEducationIDLabel = new System.Windows.Forms.Label();
            phoneContactLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfEducationInstitutionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationInstitutionBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educationInstitutionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(276, 22);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // contactPersonLabel
            // 
            contactPersonLabel.AutoSize = true;
            contactPersonLabel.Location = new System.Drawing.Point(276, 48);
            contactPersonLabel.Name = "contactPersonLabel";
            contactPersonLabel.Size = new System.Drawing.Size(83, 13);
            contactPersonLabel.TabIndex = 2;
            contactPersonLabel.Text = "Contact Person:";
            // 
            // contractLabel
            // 
            contractLabel.AutoSize = true;
            contractLabel.Location = new System.Drawing.Point(276, 74);
            contractLabel.Name = "contractLabel";
            contractLabel.Size = new System.Drawing.Size(50, 13);
            contractLabel.TabIndex = 4;
            contractLabel.Text = "Contract:";
            // 
            // contractTimeLabel
            // 
            contractTimeLabel.AutoSize = true;
            contractTimeLabel.Location = new System.Drawing.Point(276, 100);
            contractTimeLabel.Name = "contractTimeLabel";
            contractTimeLabel.Size = new System.Drawing.Size(76, 13);
            contractTimeLabel.TabIndex = 6;
            contractTimeLabel.Text = "Contract Time:";
            // 
            // costOfTraineesLabel
            // 
            costOfTraineesLabel.AutoSize = true;
            costOfTraineesLabel.Location = new System.Drawing.Point(276, 126);
            costOfTraineesLabel.Name = "costOfTraineesLabel";
            costOfTraineesLabel.Size = new System.Drawing.Size(89, 13);
            costOfTraineesLabel.TabIndex = 8;
            costOfTraineesLabel.Text = "Cost Of Trainees:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(276, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(276, 187);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // typeEducationIDLabel
            // 
            typeEducationIDLabel.AutoSize = true;
            typeEducationIDLabel.Location = new System.Drawing.Point(276, 239);
            typeEducationIDLabel.Name = "typeEducationIDLabel";
            typeEducationIDLabel.Size = new System.Drawing.Size(99, 13);
            typeEducationIDLabel.TabIndex = 18;
            typeEducationIDLabel.Text = "Type Education ID:";
            // 
            // phoneContactLabel
            // 
            phoneContactLabel.AutoSize = true;
            phoneContactLabel.Location = new System.Drawing.Point(276, 214);
            phoneContactLabel.Name = "phoneContactLabel";
            phoneContactLabel.Size = new System.Drawing.Size(81, 13);
            phoneContactLabel.TabIndex = 19;
            phoneContactLabel.Text = "Phone Contact:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(phoneContactLabel);
            this.panel1.Controls.Add(this.phoneContactMaskedTextBox);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(contactPersonLabel);
            this.panel1.Controls.Add(this.contactPersonTextBox);
            this.panel1.Controls.Add(contractLabel);
            this.panel1.Controls.Add(this.contractTextBox);
            this.panel1.Controls.Add(contractTimeLabel);
            this.panel1.Controls.Add(this.contractTimeTextBox);
            this.panel1.Controls.Add(costOfTraineesLabel);
            this.panel1.Controls.Add(this.costOfTraineesTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(typeEducationIDLabel);
            this.panel1.Location = new System.Drawing.Point(26, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 294);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.typeOfEducationInstitutionBindingSource;
            this.comboBox1.DisplayMember = "NameOfType";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(382, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "TypeEducationID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // typeOfEducationInstitutionBindingSource
            // 
            this.typeOfEducationInstitutionBindingSource.DataSource = typeof(DiplomPracticRGSU.ModelEF.TypeOfEducationInstitution);
            // 
            // phoneContactMaskedTextBox
            // 
            this.phoneContactMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationInstitutionBindingSource, "PhoneContact", true));
            this.phoneContactMaskedTextBox.Location = new System.Drawing.Point(381, 210);
            this.phoneContactMaskedTextBox.Mask = "8(000) 000-00-00";
            this.phoneContactMaskedTextBox.Name = "phoneContactMaskedTextBox";
            this.phoneContactMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.phoneContactMaskedTextBox.TabIndex = 20;
            // 
            // educationInstitutionBindingSource
            // 
            this.educationInstitutionBindingSource.DataSource = typeof(DiplomPracticRGSU.ModelEF.EducationInstitution);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationInstitutionBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(381, 19);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationInstitutionBindingSource, "ContactPerson", true));
            this.contactPersonTextBox.Location = new System.Drawing.Point(381, 45);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactPersonTextBox.TabIndex = 3;
            // 
            // contractTextBox
            // 
            this.contractTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationInstitutionBindingSource, "Contract", true));
            this.contractTextBox.Location = new System.Drawing.Point(381, 71);
            this.contractTextBox.Name = "contractTextBox";
            this.contractTextBox.Size = new System.Drawing.Size(121, 20);
            this.contractTextBox.TabIndex = 5;
            // 
            // contractTimeTextBox
            // 
            this.contractTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationInstitutionBindingSource, "ContractTime", true));
            this.contractTimeTextBox.Location = new System.Drawing.Point(381, 97);
            this.contractTimeTextBox.Name = "contractTimeTextBox";
            this.contractTimeTextBox.Size = new System.Drawing.Size(121, 20);
            this.contractTimeTextBox.TabIndex = 7;
            // 
            // costOfTraineesTextBox
            // 
            this.costOfTraineesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationInstitutionBindingSource, "CostOfTrainees", true));
            this.costOfTraineesTextBox.Location = new System.Drawing.Point(381, 123);
            this.costOfTraineesTextBox.Name = "costOfTraineesTextBox";
            this.costOfTraineesTextBox.Size = new System.Drawing.Size(121, 20);
            this.costOfTraineesTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationInstitutionBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(381, 158);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationInstitutionBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(381, 184);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(657, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Управление записями";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.delitButton);
            this.panel2.Controls.Add(this.newButtton);
            this.panel2.Location = new System.Drawing.Point(661, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 155);
            this.panel2.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.saveButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(22, 102);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(162, 41);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
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
            this.delitButton.Click += new System.EventHandler(this.delitButton_Click_1);
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
            this.newButtton.Click += new System.EventHandler(this.newButtton_Click_1);
            // 
            // educationInstitutionDataGridView
            // 
            this.educationInstitutionDataGridView.AutoGenerateColumns = false;
            this.educationInstitutionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.educationInstitutionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.educationInstitutionDataGridView.DataSource = this.educationInstitutionBindingSource;
            this.educationInstitutionDataGridView.Location = new System.Drawing.Point(12, 12);
            this.educationInstitutionDataGridView.Name = "educationInstitutionDataGridView";
            this.educationInstitutionDataGridView.Size = new System.Drawing.Size(878, 291);
            this.educationInstitutionDataGridView.TabIndex = 6;
            this.educationInstitutionDataGridView.Click += new System.EventHandler(this.educationInstitutionDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EducationalID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EducationalID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeEducationID";
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeEducationID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ContactPerson";
            this.dataGridViewTextBoxColumn6.HeaderText = "ContactPerson";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PhoneContact";
            this.dataGridViewTextBoxColumn7.HeaderText = "PhoneContact";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Contract";
            this.dataGridViewTextBoxColumn8.HeaderText = "Contract";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CostOfTrainees";
            this.dataGridViewTextBoxColumn9.HeaderText = "CostOfTrainees";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ContractTime";
            this.dataGridViewTextBoxColumn10.HeaderText = "ContractTime";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TypeOfEducationInstitution";
            this.dataGridViewTextBoxColumn11.HeaderText = "TypeOfEducationInstitution";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Trainee";
            this.dataGridViewTextBoxColumn12.HeaderText = "Trainee";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 616);
            this.Controls.Add(this.educationInstitutionDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EducationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EducationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfEducationInstitutionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationInstitutionBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.educationInstitutionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button delitButton;
        private System.Windows.Forms.Button newButtton;
        private System.Windows.Forms.MaskedTextBox phoneContactMaskedTextBox;
        private System.Windows.Forms.BindingSource educationInstitutionBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.TextBox contractTextBox;
        private System.Windows.Forms.TextBox contractTimeTextBox;
        private System.Windows.Forms.TextBox costOfTraineesTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource typeOfEducationInstitutionBindingSource;
        private System.Windows.Forms.DataGridView educationInstitutionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}