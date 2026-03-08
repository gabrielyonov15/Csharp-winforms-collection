namespace WinFormsApp2
{
    partial class frmEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblIDNumber = new Label();
            txtIDNumber = new TextBox();
            rbMale = new RadioButton();
            grpGender = new GroupBox();
            rbFemale = new RadioButton();
            cmbOccupation = new ComboBox();
            lblOccupation = new Label();
            btnSubmit = new Button();
            btnPrint = new Button();
            grpGender.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(40, 17);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(51, 28);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Име";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 53);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMiddleName.Location = new Point(229, 13);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(93, 28);
            lblMiddleName.TabIndex = 2;
            lblMiddleName.Text = "Презиме";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(217, 53);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(125, 27);
            txtMiddleName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(461, 17);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(96, 28);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(452, 53);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 5;
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDNumber.Location = new Point(665, 20);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(45, 28);
            lblIDNumber.TabIndex = 6;
            lblIDNumber.Text = "ЕГН";
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(626, 53);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(125, 27);
            txtIDNumber.TabIndex = 7;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(13, 26);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 8;
            rbMale.TabStop = true;
            rbMale.Text = "Мъж";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbFemale);
            grpGender.Controls.Add(rbMale);
            grpGender.Location = new Point(27, 142);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(250, 125);
            grpGender.TabIndex = 9;
            grpGender.TabStop = false;
            grpGender.Text = "Пол";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(13, 66);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(68, 24);
            rbFemale.TabIndex = 9;
            rbFemale.TabStop = true;
            rbFemale.Text = "Жена";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // cmbOccupation
            // 
            cmbOccupation.FormattingEnabled = true;
            cmbOccupation.Items.AddRange(new object[] { "Учащ", "Държавен служител", "Работник в частна фирма", "Безработен" });
            cmbOccupation.Location = new Point(550, 194);
            cmbOccupation.Name = "cmbOccupation";
            cmbOccupation.Size = new Size(151, 28);
            cmbOccupation.TabIndex = 10;
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOccupation.Location = new Point(544, 142);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(166, 28);
            lblOccupation.TabIndex = 11;
            lblOccupation.Text = "Сфера на работа";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(27, 324);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(203, 76);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Запиши";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(550, 324);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(201, 76);
            btnPrint.TabIndex = 13;
            btnPrint.Text = "Потвърди";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(btnSubmit);
            Controls.Add(lblOccupation);
            Controls.Add(cmbOccupation);
            Controls.Add(grpGender);
            Controls.Add(txtIDNumber);
            Controls.Add(lblIDNumber);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация на служител";
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblIDNumber;
        private TextBox txtIDNumber;
        private RadioButton rbMale;
        private GroupBox grpGender;
        private RadioButton rbFemale;
        private ComboBox cmbOccupation;
        private Label lblOccupation;
        private Button btnSubmit;
        private Button btnPrint;
    }
}
