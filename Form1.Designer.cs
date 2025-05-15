namespace Password_Generator_Pro
{
    partial class frmMain
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.trbPasswordLength = new System.Windows.Forms.TrackBar();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.chbUpperCase = new System.Windows.Forms.CheckBox();
            this.chbLowerCase = new System.Windows.Forms.CheckBox();
            this.chbNumbers = new System.Windows.Forms.CheckBox();
            this.chbSpecialChar = new System.Windows.Forms.CheckBox();
            this.chbExtraSpecial = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlExtra = new System.Windows.Forms.Panel();
            this.lblMinimumUpperCase = new System.Windows.Forms.Label();
            this.btnAddMinimumUpperCase = new System.Windows.Forms.Button();
            this.btnAddMinimumLowerCase = new System.Windows.Forms.Button();
            this.btnSubtractMinimumNumbers = new System.Windows.Forms.Button();
            this.btnSubtractMinimumLowerCase = new System.Windows.Forms.Button();
            this.btnSubtractMinimumUpperCase = new System.Windows.Forms.Button();
            this.btnAddMinimumNumbers = new System.Windows.Forms.Button();
            this.lblMinimumLowerCase = new System.Windows.Forms.Label();
            this.lblMinimumNumbers = new System.Windows.Forms.Label();
            this.lblMinimumUpperCaseCount = new System.Windows.Forms.Label();
            this.lblMinimumLowerCaseCount = new System.Windows.Forms.Label();
            this.lblMinimumNumbersCount = new System.Windows.Forms.Label();
            this.lblMinimumSpecialCount = new System.Windows.Forms.Label();
            this.lblMinimumSpecial = new System.Windows.Forms.Label();
            this.btnAddMinimumSpecial = new System.Windows.Forms.Button();
            this.btnSubtractMinimumSpecial = new System.Windows.Forms.Button();
            this.lblMinimumExtraSpecialCount = new System.Windows.Forms.Label();
            this.lblMinimumExtraSpecial = new System.Windows.Forms.Label();
            this.btnAddMinimumExtraSpecial = new System.Windows.Forms.Button();
            this.btnSubtractMinimumExtraSpecial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbPasswordLength)).BeginInit();
            this.pnlExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(12, 115);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(698, 127);
            this.txtPassword.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(185, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 43);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Password Generator";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCopy.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.Purple;
            this.btnCopy.Location = new System.Drawing.Point(579, 248);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(131, 59);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // trbPasswordLength
            // 
            this.trbPasswordLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trbPasswordLength.LargeChange = 32;
            this.trbPasswordLength.Location = new System.Drawing.Point(100, 325);
            this.trbPasswordLength.Maximum = 128;
            this.trbPasswordLength.Minimum = 8;
            this.trbPasswordLength.Name = "trbPasswordLength";
            this.trbPasswordLength.Size = new System.Drawing.Size(479, 45);
            this.trbPasswordLength.TabIndex = 3;
            this.trbPasswordLength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbPasswordLength.Value = 8;
            this.trbPasswordLength.Scroll += new System.EventHandler(this.trbPasswordLength_Scroll);
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLength.Location = new System.Drawing.Point(12, 332);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(82, 26);
            this.lblPasswordLength.TabIndex = 4;
            this.lblPasswordLength.Text = "Length :";
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.BackColor = System.Drawing.Color.White;
            this.txtPasswordLength.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLength.Location = new System.Drawing.Point(595, 329);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.ReadOnly = true;
            this.txtPasswordLength.Size = new System.Drawing.Size(100, 33);
            this.txtPasswordLength.TabIndex = 5;
            this.txtPasswordLength.Text = "8";
            this.txtPasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswordLength.TextChanged += new System.EventHandler(this.txtPasswordLength_TextChanged);
            // 
            // chbUpperCase
            // 
            this.chbUpperCase.AutoSize = true;
            this.chbUpperCase.Checked = true;
            this.chbUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUpperCase.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUpperCase.Location = new System.Drawing.Point(12, 400);
            this.chbUpperCase.Name = "chbUpperCase";
            this.chbUpperCase.Size = new System.Drawing.Size(206, 29);
            this.chbUpperCase.TabIndex = 7;
            this.chbUpperCase.Text = "Upper Case ( A - Z )";
            this.chbUpperCase.UseVisualStyleBackColor = true;
            this.chbUpperCase.CheckedChanged += new System.EventHandler(this.chbUpperCase_CheckedChanged);
            this.chbUpperCase.Click += new System.EventHandler(this.chbUpperCase_Click);
            // 
            // chbLowerCase
            // 
            this.chbLowerCase.AutoSize = true;
            this.chbLowerCase.Checked = true;
            this.chbLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLowerCase.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLowerCase.Location = new System.Drawing.Point(270, 400);
            this.chbLowerCase.Name = "chbLowerCase";
            this.chbLowerCase.Size = new System.Drawing.Size(202, 29);
            this.chbLowerCase.TabIndex = 8;
            this.chbLowerCase.Text = "Lower Case ( a - z )";
            this.chbLowerCase.UseVisualStyleBackColor = true;
            this.chbLowerCase.CheckedChanged += new System.EventHandler(this.chbLowerCase_CheckedChanged);
            this.chbLowerCase.Click += new System.EventHandler(this.chbLowerCase_Click);
            // 
            // chbNumbers
            // 
            this.chbNumbers.AutoSize = true;
            this.chbNumbers.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNumbers.Location = new System.Drawing.Point(524, 400);
            this.chbNumbers.Name = "chbNumbers";
            this.chbNumbers.Size = new System.Drawing.Size(186, 29);
            this.chbNumbers.TabIndex = 9;
            this.chbNumbers.Text = "Numbers ( 0 - 9 )";
            this.chbNumbers.UseVisualStyleBackColor = true;
            this.chbNumbers.CheckedChanged += new System.EventHandler(this.chbNumbers_CheckedChanged);
            // 
            // chbSpecialChar
            // 
            this.chbSpecialChar.AutoSize = true;
            this.chbSpecialChar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSpecialChar.Location = new System.Drawing.Point(79, 475);
            this.chbSpecialChar.Name = "chbSpecialChar";
            this.chbSpecialChar.Size = new System.Drawing.Size(214, 29);
            this.chbSpecialChar.TabIndex = 10;
            this.chbSpecialChar.Text = "Special ( !@#$%^&* )";
            this.chbSpecialChar.UseVisualStyleBackColor = true;
            this.chbSpecialChar.CheckedChanged += new System.EventHandler(this.chbSpecialChar_CheckedChanged);
            // 
            // chbExtraSpecial
            // 
            this.chbExtraSpecial.AutoSize = true;
            this.chbExtraSpecial.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExtraSpecial.Location = new System.Drawing.Point(353, 475);
            this.chbExtraSpecial.Name = "chbExtraSpecial";
            this.chbExtraSpecial.Size = new System.Drawing.Size(268, 29);
            this.chbExtraSpecial.TabIndex = 11;
            this.chbExtraSpecial.Text = "Extra Special ( (){}[]<>,.;: )";
            this.chbExtraSpecial.UseVisualStyleBackColor = true;
            this.chbExtraSpecial.CheckedChanged += new System.EventHandler(this.chbExtraSpecial_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 250);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(147, 51);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlExtra
            // 
            this.pnlExtra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExtra.Controls.Add(this.lblMinimumExtraSpecialCount);
            this.pnlExtra.Controls.Add(this.lblMinimumExtraSpecial);
            this.pnlExtra.Controls.Add(this.btnAddMinimumExtraSpecial);
            this.pnlExtra.Controls.Add(this.btnSubtractMinimumExtraSpecial);
            this.pnlExtra.Controls.Add(this.lblMinimumSpecialCount);
            this.pnlExtra.Controls.Add(this.lblMinimumSpecial);
            this.pnlExtra.Controls.Add(this.btnAddMinimumSpecial);
            this.pnlExtra.Controls.Add(this.btnSubtractMinimumSpecial);
            this.pnlExtra.Controls.Add(this.lblMinimumNumbersCount);
            this.pnlExtra.Controls.Add(this.lblMinimumLowerCaseCount);
            this.pnlExtra.Controls.Add(this.lblMinimumUpperCaseCount);
            this.pnlExtra.Controls.Add(this.lblMinimumNumbers);
            this.pnlExtra.Controls.Add(this.lblMinimumLowerCase);
            this.pnlExtra.Controls.Add(this.btnAddMinimumNumbers);
            this.pnlExtra.Controls.Add(this.btnSubtractMinimumUpperCase);
            this.pnlExtra.Controls.Add(this.btnSubtractMinimumLowerCase);
            this.pnlExtra.Controls.Add(this.btnSubtractMinimumNumbers);
            this.pnlExtra.Controls.Add(this.btnAddMinimumLowerCase);
            this.pnlExtra.Controls.Add(this.btnAddMinimumUpperCase);
            this.pnlExtra.Controls.Add(this.lblMinimumUpperCase);
            this.pnlExtra.Location = new System.Drawing.Point(12, 527);
            this.pnlExtra.Name = "pnlExtra";
            this.pnlExtra.Size = new System.Drawing.Size(698, 256);
            this.pnlExtra.TabIndex = 13;
            // 
            // lblMinimumUpperCase
            // 
            this.lblMinimumUpperCase.AutoSize = true;
            this.lblMinimumUpperCase.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumUpperCase.Location = new System.Drawing.Point(7, 19);
            this.lblMinimumUpperCase.Name = "lblMinimumUpperCase";
            this.lblMinimumUpperCase.Size = new System.Drawing.Size(207, 25);
            this.lblMinimumUpperCase.TabIndex = 0;
            this.lblMinimumUpperCase.Text = "Minimum Upper Case";
            // 
            // btnAddMinimumUpperCase
            // 
            this.btnAddMinimumUpperCase.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMinimumUpperCase.Location = new System.Drawing.Point(339, 14);
            this.btnAddMinimumUpperCase.Name = "btnAddMinimumUpperCase";
            this.btnAddMinimumUpperCase.Size = new System.Drawing.Size(38, 33);
            this.btnAddMinimumUpperCase.TabIndex = 1;
            this.btnAddMinimumUpperCase.Text = "+";
            this.btnAddMinimumUpperCase.UseVisualStyleBackColor = true;
            this.btnAddMinimumUpperCase.Click += new System.EventHandler(this.btnAddMinimumUpperCase_Click);
            // 
            // btnAddMinimumLowerCase
            // 
            this.btnAddMinimumLowerCase.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMinimumLowerCase.Location = new System.Drawing.Point(339, 61);
            this.btnAddMinimumLowerCase.Name = "btnAddMinimumLowerCase";
            this.btnAddMinimumLowerCase.Size = new System.Drawing.Size(38, 33);
            this.btnAddMinimumLowerCase.TabIndex = 2;
            this.btnAddMinimumLowerCase.Text = "+";
            this.btnAddMinimumLowerCase.UseVisualStyleBackColor = true;
            this.btnAddMinimumLowerCase.Click += new System.EventHandler(this.btnAddMinimumLowerCase_Click);
            // 
            // btnSubtractMinimumNumbers
            // 
            this.btnSubtractMinimumNumbers.Enabled = false;
            this.btnSubtractMinimumNumbers.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractMinimumNumbers.Location = new System.Drawing.Point(230, 108);
            this.btnSubtractMinimumNumbers.Name = "btnSubtractMinimumNumbers";
            this.btnSubtractMinimumNumbers.Size = new System.Drawing.Size(38, 33);
            this.btnSubtractMinimumNumbers.TabIndex = 3;
            this.btnSubtractMinimumNumbers.Text = "-";
            this.btnSubtractMinimumNumbers.UseVisualStyleBackColor = true;
            this.btnSubtractMinimumNumbers.Click += new System.EventHandler(this.btnSubtractMinimumNumbers_Click);
            // 
            // btnSubtractMinimumLowerCase
            // 
            this.btnSubtractMinimumLowerCase.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractMinimumLowerCase.Location = new System.Drawing.Point(230, 61);
            this.btnSubtractMinimumLowerCase.Name = "btnSubtractMinimumLowerCase";
            this.btnSubtractMinimumLowerCase.Size = new System.Drawing.Size(38, 33);
            this.btnSubtractMinimumLowerCase.TabIndex = 4;
            this.btnSubtractMinimumLowerCase.Text = "-";
            this.btnSubtractMinimumLowerCase.UseVisualStyleBackColor = true;
            this.btnSubtractMinimumLowerCase.Click += new System.EventHandler(this.btnSubtractMinimumLowerCase_Click);
            // 
            // btnSubtractMinimumUpperCase
            // 
            this.btnSubtractMinimumUpperCase.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractMinimumUpperCase.Location = new System.Drawing.Point(230, 14);
            this.btnSubtractMinimumUpperCase.Name = "btnSubtractMinimumUpperCase";
            this.btnSubtractMinimumUpperCase.Size = new System.Drawing.Size(38, 33);
            this.btnSubtractMinimumUpperCase.TabIndex = 5;
            this.btnSubtractMinimumUpperCase.Text = "-";
            this.btnSubtractMinimumUpperCase.UseVisualStyleBackColor = true;
            this.btnSubtractMinimumUpperCase.Click += new System.EventHandler(this.btnSubtractMinimumUpperCase_Click);
            // 
            // btnAddMinimumNumbers
            // 
            this.btnAddMinimumNumbers.Enabled = false;
            this.btnAddMinimumNumbers.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMinimumNumbers.Location = new System.Drawing.Point(339, 108);
            this.btnAddMinimumNumbers.Name = "btnAddMinimumNumbers";
            this.btnAddMinimumNumbers.Size = new System.Drawing.Size(38, 33);
            this.btnAddMinimumNumbers.TabIndex = 6;
            this.btnAddMinimumNumbers.Text = "+";
            this.btnAddMinimumNumbers.UseVisualStyleBackColor = true;
            this.btnAddMinimumNumbers.Click += new System.EventHandler(this.btnAddMinimumNumbers_Click);
            // 
            // lblMinimumLowerCase
            // 
            this.lblMinimumLowerCase.AutoSize = true;
            this.lblMinimumLowerCase.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumLowerCase.Location = new System.Drawing.Point(7, 66);
            this.lblMinimumLowerCase.Name = "lblMinimumLowerCase";
            this.lblMinimumLowerCase.Size = new System.Drawing.Size(207, 25);
            this.lblMinimumLowerCase.TabIndex = 7;
            this.lblMinimumLowerCase.Text = "Minimum Lower Case";
            // 
            // lblMinimumNumbers
            // 
            this.lblMinimumNumbers.AutoSize = true;
            this.lblMinimumNumbers.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumNumbers.Location = new System.Drawing.Point(7, 113);
            this.lblMinimumNumbers.Name = "lblMinimumNumbers";
            this.lblMinimumNumbers.Size = new System.Drawing.Size(187, 25);
            this.lblMinimumNumbers.TabIndex = 8;
            this.lblMinimumNumbers.Text = "Minimum Numbers";
            // 
            // lblMinimumUpperCaseCount
            // 
            this.lblMinimumUpperCaseCount.AutoSize = true;
            this.lblMinimumUpperCaseCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumUpperCaseCount.Location = new System.Drawing.Point(288, 15);
            this.lblMinimumUpperCaseCount.Name = "lblMinimumUpperCaseCount";
            this.lblMinimumUpperCaseCount.Size = new System.Drawing.Size(29, 32);
            this.lblMinimumUpperCaseCount.TabIndex = 9;
            this.lblMinimumUpperCaseCount.Text = "1";
            // 
            // lblMinimumLowerCaseCount
            // 
            this.lblMinimumLowerCaseCount.AutoSize = true;
            this.lblMinimumLowerCaseCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumLowerCaseCount.Location = new System.Drawing.Point(288, 61);
            this.lblMinimumLowerCaseCount.Name = "lblMinimumLowerCaseCount";
            this.lblMinimumLowerCaseCount.Size = new System.Drawing.Size(29, 32);
            this.lblMinimumLowerCaseCount.TabIndex = 10;
            this.lblMinimumLowerCaseCount.Text = "1";
            // 
            // lblMinimumNumbersCount
            // 
            this.lblMinimumNumbersCount.AutoSize = true;
            this.lblMinimumNumbersCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumNumbersCount.Location = new System.Drawing.Point(288, 108);
            this.lblMinimumNumbersCount.Name = "lblMinimumNumbersCount";
            this.lblMinimumNumbersCount.Size = new System.Drawing.Size(29, 32);
            this.lblMinimumNumbersCount.TabIndex = 11;
            this.lblMinimumNumbersCount.Text = "1";
            // 
            // lblMinimumSpecialCount
            // 
            this.lblMinimumSpecialCount.AutoSize = true;
            this.lblMinimumSpecialCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumSpecialCount.Location = new System.Drawing.Point(288, 155);
            this.lblMinimumSpecialCount.Name = "lblMinimumSpecialCount";
            this.lblMinimumSpecialCount.Size = new System.Drawing.Size(29, 32);
            this.lblMinimumSpecialCount.TabIndex = 15;
            this.lblMinimumSpecialCount.Text = "1";
            // 
            // lblMinimumSpecial
            // 
            this.lblMinimumSpecial.AutoSize = true;
            this.lblMinimumSpecial.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumSpecial.Location = new System.Drawing.Point(7, 160);
            this.lblMinimumSpecial.Name = "lblMinimumSpecial";
            this.lblMinimumSpecial.Size = new System.Drawing.Size(167, 25);
            this.lblMinimumSpecial.TabIndex = 14;
            this.lblMinimumSpecial.Text = "Minimum Special";
            // 
            // btnAddMinimumSpecial
            // 
            this.btnAddMinimumSpecial.Enabled = false;
            this.btnAddMinimumSpecial.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMinimumSpecial.Location = new System.Drawing.Point(339, 155);
            this.btnAddMinimumSpecial.Name = "btnAddMinimumSpecial";
            this.btnAddMinimumSpecial.Size = new System.Drawing.Size(38, 33);
            this.btnAddMinimumSpecial.TabIndex = 13;
            this.btnAddMinimumSpecial.Text = "+";
            this.btnAddMinimumSpecial.UseVisualStyleBackColor = true;
            this.btnAddMinimumSpecial.Click += new System.EventHandler(this.btnAddMinimumSpecial_Click);
            // 
            // btnSubtractMinimumSpecial
            // 
            this.btnSubtractMinimumSpecial.Enabled = false;
            this.btnSubtractMinimumSpecial.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractMinimumSpecial.Location = new System.Drawing.Point(230, 155);
            this.btnSubtractMinimumSpecial.Name = "btnSubtractMinimumSpecial";
            this.btnSubtractMinimumSpecial.Size = new System.Drawing.Size(38, 33);
            this.btnSubtractMinimumSpecial.TabIndex = 12;
            this.btnSubtractMinimumSpecial.Text = "-";
            this.btnSubtractMinimumSpecial.UseVisualStyleBackColor = true;
            this.btnSubtractMinimumSpecial.Click += new System.EventHandler(this.btnSubtractMinimumSpecial_Click);
            // 
            // lblMinimumExtraSpecialCount
            // 
            this.lblMinimumExtraSpecialCount.AutoSize = true;
            this.lblMinimumExtraSpecialCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumExtraSpecialCount.Location = new System.Drawing.Point(288, 199);
            this.lblMinimumExtraSpecialCount.Name = "lblMinimumExtraSpecialCount";
            this.lblMinimumExtraSpecialCount.Size = new System.Drawing.Size(29, 32);
            this.lblMinimumExtraSpecialCount.TabIndex = 19;
            this.lblMinimumExtraSpecialCount.Text = "1";
            // 
            // lblMinimumExtraSpecial
            // 
            this.lblMinimumExtraSpecial.AutoSize = true;
            this.lblMinimumExtraSpecial.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumExtraSpecial.Location = new System.Drawing.Point(7, 204);
            this.lblMinimumExtraSpecial.Name = "lblMinimumExtraSpecial";
            this.lblMinimumExtraSpecial.Size = new System.Drawing.Size(220, 25);
            this.lblMinimumExtraSpecial.TabIndex = 18;
            this.lblMinimumExtraSpecial.Text = "Minimum Extra Special";
            // 
            // btnAddMinimumExtraSpecial
            // 
            this.btnAddMinimumExtraSpecial.Enabled = false;
            this.btnAddMinimumExtraSpecial.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMinimumExtraSpecial.Location = new System.Drawing.Point(339, 199);
            this.btnAddMinimumExtraSpecial.Name = "btnAddMinimumExtraSpecial";
            this.btnAddMinimumExtraSpecial.Size = new System.Drawing.Size(38, 33);
            this.btnAddMinimumExtraSpecial.TabIndex = 17;
            this.btnAddMinimumExtraSpecial.Text = "+";
            this.btnAddMinimumExtraSpecial.UseVisualStyleBackColor = true;
            this.btnAddMinimumExtraSpecial.Click += new System.EventHandler(this.btnAddMinimumExtraSpecial_Click);
            // 
            // btnSubtractMinimumExtraSpecial
            // 
            this.btnSubtractMinimumExtraSpecial.Enabled = false;
            this.btnSubtractMinimumExtraSpecial.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractMinimumExtraSpecial.Location = new System.Drawing.Point(230, 199);
            this.btnSubtractMinimumExtraSpecial.Name = "btnSubtractMinimumExtraSpecial";
            this.btnSubtractMinimumExtraSpecial.Size = new System.Drawing.Size(38, 33);
            this.btnSubtractMinimumExtraSpecial.TabIndex = 16;
            this.btnSubtractMinimumExtraSpecial.Text = "-";
            this.btnSubtractMinimumExtraSpecial.UseVisualStyleBackColor = true;
            this.btnSubtractMinimumExtraSpecial.Click += new System.EventHandler(this.btnSubtractMinimumExtraSpecial_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 817);
            this.Controls.Add(this.pnlExtra);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chbExtraSpecial);
            this.Controls.Add(this.chbSpecialChar);
            this.Controls.Add(this.chbNumbers);
            this.Controls.Add(this.chbLowerCase);
            this.Controls.Add(this.chbUpperCase);
            this.Controls.Add(this.txtPasswordLength);
            this.Controls.Add(this.lblPasswordLength);
            this.Controls.Add(this.trbPasswordLength);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPassword);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbPasswordLength)).EndInit();
            this.pnlExtra.ResumeLayout(false);
            this.pnlExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TrackBar trbPasswordLength;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.CheckBox chbUpperCase;
        private System.Windows.Forms.CheckBox chbLowerCase;
        private System.Windows.Forms.CheckBox chbNumbers;
        private System.Windows.Forms.CheckBox chbSpecialChar;
        private System.Windows.Forms.CheckBox chbExtraSpecial;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlExtra;
        private System.Windows.Forms.Label lblMinimumNumbers;
        private System.Windows.Forms.Label lblMinimumLowerCase;
        private System.Windows.Forms.Button btnAddMinimumNumbers;
        private System.Windows.Forms.Button btnSubtractMinimumUpperCase;
        private System.Windows.Forms.Button btnSubtractMinimumLowerCase;
        private System.Windows.Forms.Button btnSubtractMinimumNumbers;
        private System.Windows.Forms.Button btnAddMinimumLowerCase;
        private System.Windows.Forms.Button btnAddMinimumUpperCase;
        private System.Windows.Forms.Label lblMinimumUpperCase;
        private System.Windows.Forms.Label lblMinimumNumbersCount;
        private System.Windows.Forms.Label lblMinimumLowerCaseCount;
        private System.Windows.Forms.Label lblMinimumUpperCaseCount;
        private System.Windows.Forms.Label lblMinimumExtraSpecialCount;
        private System.Windows.Forms.Label lblMinimumExtraSpecial;
        private System.Windows.Forms.Button btnAddMinimumExtraSpecial;
        private System.Windows.Forms.Button btnSubtractMinimumExtraSpecial;
        private System.Windows.Forms.Label lblMinimumSpecialCount;
        private System.Windows.Forms.Label lblMinimumSpecial;
        private System.Windows.Forms.Button btnAddMinimumSpecial;
        private System.Windows.Forms.Button btnSubtractMinimumSpecial;
    }
}

