namespace IceCreamOrderingSystem
{
    partial class frmIceCreamOrder
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
            lblName = new Label();
            txtName = new TextBox();
            rbLarge = new RadioButton();
            rbMedium = new RadioButton();
            rbSmall = new RadioButton();
            lblSizeTitle = new Label();
            grpSize = new GroupBox();
            cmbFlavor = new ComboBox();
            lblFlavorTitle = new Label();
            chkVanilla = new CheckBox();
            chkCaramel = new CheckBox();
            chkSprinkles = new CheckBox();
            chkCookies = new CheckBox();
            chkWaferSticks = new CheckBox();
            lblToppingsTitle = new Label();
            grpToppings = new GroupBox();
            lstOrder = new ListBox();
            btnOrder = new Button();
            grpSize.SuspendLayout();
            grpToppings.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(34, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(138, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Въведи име";
            // 
            // txtName
            // 
            txtName.Location = new Point(228, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 27);
            txtName.TabIndex = 1;
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(6, 26);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(73, 24);
            rbLarge.TabIndex = 2;
            rbLarge.TabStop = true;
            rbLarge.Text = "Голям";
            rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(6, 53);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(81, 24);
            rbMedium.TabIndex = 3;
            rbMedium.TabStop = true;
            rbMedium.Text = "Среден";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(6, 83);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(75, 24);
            rbSmall.TabIndex = 4;
            rbSmall.TabStop = true;
            rbSmall.Text = "Малък";
            rbSmall.UseVisualStyleBackColor = true;
            // 
            // lblSizeTitle
            // 
            lblSizeTitle.AutoSize = true;
            lblSizeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSizeTitle.Location = new Point(34, 132);
            lblSizeTitle.Name = "lblSizeTitle";
            lblSizeTitle.Size = new Size(154, 28);
            lblSizeTitle.TabIndex = 5;
            lblSizeTitle.Text = "Избери размер";
            // 
            // grpSize
            // 
            grpSize.Controls.Add(rbLarge);
            grpSize.Controls.Add(rbMedium);
            grpSize.Controls.Add(rbSmall);
            grpSize.Location = new Point(34, 187);
            grpSize.Name = "grpSize";
            grpSize.Size = new Size(177, 129);
            grpSize.TabIndex = 6;
            grpSize.TabStop = false;
            grpSize.Text = "Размер";
            // 
            // cmbFlavor
            // 
            cmbFlavor.FormattingEnabled = true;
            cmbFlavor.Items.AddRange(new object[] { "Черен шоколад", "Бял шоколад", "Млечен шоколад", "Ягодов", "Троен шоколад" });
            cmbFlavor.Location = new Point(278, 187);
            cmbFlavor.Name = "cmbFlavor";
            cmbFlavor.Size = new Size(151, 28);
            cmbFlavor.TabIndex = 7;
            // 
            // lblFlavorTitle
            // 
            lblFlavorTitle.AutoSize = true;
            lblFlavorTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlavorTitle.Location = new Point(290, 132);
            lblFlavorTitle.Name = "lblFlavorTitle";
            lblFlavorTitle.Size = new Size(127, 28);
            lblFlavorTitle.TabIndex = 8;
            lblFlavorTitle.Text = "Избери вкус";
            // 
            // chkVanilla
            // 
            chkVanilla.AutoSize = true;
            chkVanilla.Location = new Point(6, 27);
            chkVanilla.Name = "chkVanilla";
            chkVanilla.Size = new Size(91, 24);
            chkVanilla.TabIndex = 9;
            chkVanilla.Text = "Ванилия";
            chkVanilla.UseVisualStyleBackColor = true;
            // 
            // chkCaramel
            // 
            chkCaramel.AutoSize = true;
            chkCaramel.Location = new Point(143, 57);
            chkCaramel.Name = "chkCaramel";
            chkCaramel.Size = new Size(92, 24);
            chkCaramel.TabIndex = 11;
            chkCaramel.Text = "Карамел";
            chkCaramel.UseVisualStyleBackColor = true;
            // 
            // chkSprinkles
            // 
            chkSprinkles.AutoSize = true;
            chkSprinkles.Location = new Point(143, 27);
            chkSprinkles.Name = "chkSprinkles";
            chkSprinkles.Size = new Size(95, 24);
            chkSprinkles.TabIndex = 12;
            chkSprinkles.Text = "Пръчици";
            chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // chkCookies
            // 
            chkCookies.AutoSize = true;
            chkCookies.Location = new Point(6, 57);
            chkCookies.Name = "chkCookies";
            chkCookies.Size = new Size(95, 24);
            chkCookies.TabIndex = 13;
            chkCookies.Text = "Бисквити";
            chkCookies.UseVisualStyleBackColor = true;
            // 
            // chkWaferSticks
            // 
            chkWaferSticks.AutoSize = true;
            chkWaferSticks.Location = new Point(6, 83);
            chkWaferSticks.Name = "chkWaferSticks";
            chkWaferSticks.Size = new Size(91, 24);
            chkWaferSticks.TabIndex = 14;
            chkWaferSticks.Text = "Пурички";
            chkWaferSticks.UseVisualStyleBackColor = true;
            // 
            // lblToppingsTitle
            // 
            lblToppingsTitle.AutoSize = true;
            lblToppingsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToppingsTitle.Location = new Point(564, 132);
            lblToppingsTitle.Name = "lblToppingsTitle";
            lblToppingsTitle.Size = new Size(165, 28);
            lblToppingsTitle.TabIndex = 15;
            lblToppingsTitle.Text = "Избери добавки";
            // 
            // grpToppings
            // 
            grpToppings.Controls.Add(chkVanilla);
            grpToppings.Controls.Add(chkCaramel);
            grpToppings.Controls.Add(chkWaferSticks);
            grpToppings.Controls.Add(chkSprinkles);
            grpToppings.Controls.Add(chkCookies);
            grpToppings.Location = new Point(494, 187);
            grpToppings.Name = "grpToppings";
            grpToppings.Size = new Size(294, 125);
            grpToppings.TabIndex = 16;
            grpToppings.TabStop = false;
            grpToppings.Text = "Добавки";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.HorizontalScrollbar = true;
            lstOrder.Location = new Point(64, 334);
            lstOrder.Name = "lstOrder";
            lstOrder.ScrollAlwaysVisible = true;
            lstOrder.Size = new Size(495, 104);
            lstOrder.TabIndex = 17;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(595, 359);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(180, 79);
            btnOrder.TabIndex = 18;
            btnOrder.Text = "Поръчай";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // frmIceCreamOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrder);
            Controls.Add(lstOrder);
            Controls.Add(grpToppings);
            Controls.Add(lblToppingsTitle);
            Controls.Add(lblFlavorTitle);
            Controls.Add(cmbFlavor);
            Controls.Add(grpSize);
            Controls.Add(lblSizeTitle);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "frmIceCreamOrder";
            Text = "Поръчка за сладолед";
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            grpToppings.ResumeLayout(false);
            grpToppings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private RadioButton rbLarge;
        private RadioButton rbMedium;
        private RadioButton rbSmall;
        private Label lblSizeTitle;
        private GroupBox grpSize;
        private ComboBox cmbFlavor;
        private Label lblFlavorTitle;
        private CheckBox chkVanilla;
        private CheckBox chkCaramel;
        private CheckBox chkSprinkles;
        private CheckBox chkCookies;
        private CheckBox chkWaferSticks;
        private Label lblToppingsTitle;
        private GroupBox grpToppings;
        private ListBox lstOrder;
        private Button btnOrder;
    }
}
