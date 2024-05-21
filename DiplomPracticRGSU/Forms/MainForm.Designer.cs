namespace DiplomPracticRGSU
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labButton = new System.Windows.Forms.Button();
            this.educationButton = new System.Windows.Forms.Button();
            this.traineeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labButton
            // 
            this.labButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labButton.Location = new System.Drawing.Point(139, 267);
            this.labButton.Name = "labButton";
            this.labButton.Size = new System.Drawing.Size(211, 64);
            this.labButton.TabIndex = 0;
            this.labButton.Text = "Лаборатории";
            this.labButton.UseVisualStyleBackColor = true;
            this.labButton.Click += new System.EventHandler(this.labButton_Click);
            // 
            // educationButton
            // 
            this.educationButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationButton.Location = new System.Drawing.Point(139, 173);
            this.educationButton.Name = "educationButton";
            this.educationButton.Size = new System.Drawing.Size(211, 64);
            this.educationButton.TabIndex = 1;
            this.educationButton.Text = "Учебные заведения";
            this.educationButton.UseVisualStyleBackColor = true;
            this.educationButton.Click += new System.EventHandler(this.educationButton_Click);
            // 
            // traineeButton
            // 
            this.traineeButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.traineeButton.Location = new System.Drawing.Point(139, 66);
            this.traineeButton.Name = "traineeButton";
            this.traineeButton.Size = new System.Drawing.Size(211, 64);
            this.traineeButton.TabIndex = 2;
            this.traineeButton.Text = "Список практикантов";
            this.traineeButton.UseVisualStyleBackColor = true;
            this.traineeButton.Click += new System.EventHandler(this.traineeButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(139, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Календарь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.traineeButton);
            this.Controls.Add(this.educationButton);
            this.Controls.Add(this.labButton);
            this.Name = "MainForm";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button labButton;
        private System.Windows.Forms.Button educationButton;
        private System.Windows.Forms.Button traineeButton;
        private System.Windows.Forms.Button button1;
    }
}

