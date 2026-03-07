namespace FitnessZoneRegistration
{
    partial class frmFitnessRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFitnessRegister));
            lblName = new Label();
            txtName = new TextBox();
            cmbInterests = new ComboBox();
            lblInterests = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblAge = new Label();
            cmbAge = new ComboBox();
            btnRegistration = new Button();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            lblGender = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Honeydew;
            lblName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(75, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(79, 38);
            lblName.TabIndex = 2;
            lblName.Text = "Име:";
            // 
            // txtName
            // 
            txtName.Location = new Point(40, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 27);
            txtName.TabIndex = 0;
            // 
            // cmbInterests
            // 
            cmbInterests.FormattingEnabled = true;
            cmbInterests.Location = new Point(43, 218);
            cmbInterests.Name = "cmbInterests";
            cmbInterests.Size = new Size(151, 28);
            cmbInterests.TabIndex = 6;
            // 
            // lblInterests
            // 
            lblInterests.AutoSize = true;
            lblInterests.BackColor = Color.Honeydew;
            lblInterests.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInterests.Location = new Point(48, 164);
            lblInterests.Name = "lblInterests";
            lblInterests.Size = new Size(146, 38);
            lblInterests.TabIndex = 4;
            lblInterests.Text = "Интереси:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Honeydew;
            lblLastName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(314, 41);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(138, 38);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Фамилия:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(314, 93);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(146, 27);
            txtLastName.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Honeydew;
            lblAge.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(322, 164);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(122, 38);
            lblAge.TabIndex = 5;
            lblAge.Text = "Възраст:";
            // 
            // cmbAge
            // 
            cmbAge.FormattingEnabled = true;
            cmbAge.Location = new Point(309, 218);
            cmbAge.Name = "cmbAge";
            cmbAge.Size = new Size(151, 28);
            cmbAge.TabIndex = 7;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.Honeydew;
            btnRegistration.Location = new Point(283, 339);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(241, 70);
            btnRegistration.TabIndex = 11;
            btnRegistration.Text = "Регистрирай ме";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += buttonRegistration_Click;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.BackColor = Color.Honeydew;
            rbFemale.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(608, 141);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(95, 42);
            rbFemale.TabIndex = 9;
            rbFemale.TabStop = true;
            rbFemale.Text = "г-жа";
            rbFemale.UseVisualStyleBackColor = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.BackColor = Color.Honeydew;
            rbMale.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(608, 93);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(76, 42);
            rbMale.TabIndex = 8;
            rbMale.TabStop = true;
            rbMale.Text = "г-н";
            rbMale.UseVisualStyleBackColor = false;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Honeydew;
            lblGender.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(620, 41);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 38);
            lblGender.TabIndex = 10;
            lblGender.Text = "Пол:";
            // 
            // frmFitnessRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistration);
            Controls.Add(lblGender);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(cmbAge);
            Controls.Add(cmbInterests);
            Controls.Add(lblAge);
            Controls.Add(lblInterests);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Name = "frmFitnessRegister";
            Text = "Регистрация фитнес зона ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private ComboBox cmbInterests;
        private Label lblInterests;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblAge;
        private ComboBox cmbAge;
        private Button btnRegistration;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lblGender;
    }
}
