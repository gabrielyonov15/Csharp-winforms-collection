namespace RezarvaciqNaKinoBilet
{
    partial class frmMovieReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovieReservation));
            cmbMovie = new ComboBox();
            lblMovieTitle = new Label();
            rb2D = new RadioButton();
            rb3D = new RadioButton();
            gbProjection = new GroupBox();
            chkPopcorn = new CheckBox();
            lblServices = new Label();
            btnReserve = new Button();
            gbSeatType = new GroupBox();
            rbVIP = new RadioButton();
            rbStandard = new RadioButton();
            chkDrink = new CheckBox();
            gbProjection.SuspendLayout();
            gbSeatType.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Items.AddRange(new object[] { "Екшън – 10.00 лв.", "Комедия – 8.00 лв.", "Анимация – 7.00 лв." });
            cmbMovie.Location = new Point(313, 62);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(151, 28);
            cmbMovie.TabIndex = 0;
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMovieTitle.Location = new Point(303, 19);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(175, 31);
            lblMovieTitle.TabIndex = 1;
            lblMovieTitle.Text = "Избор на филм";
            // 
            // rb2D
            // 
            rb2D.AutoSize = true;
            rb2D.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb2D.Location = new Point(11, 26);
            rb2D.Name = "rb2D";
            rb2D.Size = new Size(195, 27);
            rb2D.TabIndex = 3;
            rb2D.TabStop = true;
            rb2D.Text = "2D – без оскъпяване";
            rb2D.UseVisualStyleBackColor = true;
            // 
            // rb3D
            // 
            rb3D.AutoSize = true;
            rb3D.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb3D.Location = new Point(11, 56);
            rb3D.Name = "rb3D";
            rb3D.Size = new Size(141, 27);
            rb3D.TabIndex = 4;
            rb3D.TabStop = true;
            rb3D.Text = "3D – +3.00 лв.";
            rb3D.UseVisualStyleBackColor = true;
            // 
            // gbProjection
            // 
            gbProjection.Controls.Add(rb2D);
            gbProjection.Controls.Add(rb3D);
            gbProjection.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbProjection.Location = new Point(538, 108);
            gbProjection.Name = "gbProjection";
            gbProjection.Size = new Size(250, 125);
            gbProjection.TabIndex = 5;
            gbProjection.TabStop = false;
            gbProjection.Text = "Прожекция";
            // 
            // chkPopcorn
            // 
            chkPopcorn.AutoSize = true;
            chkPopcorn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPopcorn.Location = new Point(313, 144);
            chkPopcorn.Name = "chkPopcorn";
            chkPopcorn.Size = new Size(186, 27);
            chkPopcorn.TabIndex = 7;
            chkPopcorn.Text = "Пуканки – +4.00 лв.";
            chkPopcorn.UseVisualStyleBackColor = true;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServices.Location = new Point(360, 108);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(83, 31);
            lblServices.TabIndex = 8;
            lblServices.Text = "Услуги";
            // 
            // btnReserve
            // 
            btnReserve.BackColor = Color.IndianRed;
            btnReserve.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReserve.ForeColor = Color.Black;
            btnReserve.Location = new Point(258, 290);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(306, 107);
            btnReserve.TabIndex = 9;
            btnReserve.Text = "Резервирай";
            btnReserve.UseVisualStyleBackColor = false;
            btnReserve.Click += btnReserve_Click;
            // 
            // gbSeatType
            // 
            gbSeatType.BackColor = Color.IndianRed;
            gbSeatType.Controls.Add(rbVIP);
            gbSeatType.Controls.Add(rbStandard);
            gbSeatType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSeatType.Location = new Point(31, 108);
            gbSeatType.Name = "gbSeatType";
            gbSeatType.Size = new Size(250, 125);
            gbSeatType.TabIndex = 10;
            gbSeatType.TabStop = false;
            gbSeatType.Text = "Място";
            // 
            // rbVIP
            // 
            rbVIP.AutoSize = true;
            rbVIP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbVIP.Location = new Point(6, 56);
            rbVIP.Name = "rbVIP";
            rbVIP.Size = new Size(146, 27);
            rbVIP.TabIndex = 1;
            rbVIP.TabStop = true;
            rbVIP.Text = "VIP – +5.00 лв.";
            rbVIP.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            rbStandard.AutoSize = true;
            rbStandard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbStandard.Location = new Point(6, 26);
            rbStandard.Name = "rbStandard";
            rbStandard.Size = new Size(224, 27);
            rbStandard.TabIndex = 0;
            rbStandard.TabStop = true;
            rbStandard.Text = "Стандартно – безплатно";
            rbStandard.UseVisualStyleBackColor = true;
            // 
            // chkDrink
            // 
            chkDrink.AutoSize = true;
            chkDrink.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDrink.Location = new Point(313, 174);
            chkDrink.Name = "chkDrink";
            chkDrink.Size = new Size(186, 27);
            chkDrink.TabIndex = 11;
            chkDrink.Text = "Напитка – +3.00 лв.";
            chkDrink.UseVisualStyleBackColor = true;
            // 
            // frmMovieReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(chkDrink);
            Controls.Add(gbSeatType);
            Controls.Add(btnReserve);
            Controls.Add(lblServices);
            Controls.Add(chkPopcorn);
            Controls.Add(gbProjection);
            Controls.Add(lblMovieTitle);
            Controls.Add(cmbMovie);
            Name = "frmMovieReservation";
            Text = "Резервация за филм";
            gbProjection.ResumeLayout(false);
            gbProjection.PerformLayout();
            gbSeatType.ResumeLayout(false);
            gbSeatType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMovie;
        private Label lblMovieTitle;
        private RadioButton rb2D;
        private RadioButton radioButton1;
        private RadioButton rb3D;
        private GroupBox gbProjection;
        private CheckBox checkBox1;
        private CheckBox chkPopcorn;
        private Label lblServices;
        private Button btnReserve;
        private GroupBox gbSeatType;
        private RadioButton rbVIP;
        private RadioButton rbStandard;
        private CheckBox chkDrink;
    }
}
