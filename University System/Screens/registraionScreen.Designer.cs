namespace PolyLearn.Screens
{
   public partial class registraionScreen
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
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label optionaltext;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registraionScreen));
            this.register = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.uniIdtxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.GroupBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.userTypecomboBox = new System.Windows.Forms.ComboBox();
            this.optional1 = new System.Windows.Forms.TextBox();
            this.departmentTxt = new System.Windows.Forms.TextBox();
            this.optionalPanel = new System.Windows.Forms.Panel();
            this.departmentCombo = new System.Windows.Forms.ComboBox();
            this.courses = new System.Windows.Forms.ComboBox();
            this.programEnrolled = new System.Windows.Forms.ComboBox();
            this.departmentName = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Label();
            this.reg2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            optionaltext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gender.SuspendLayout();
            this.optionalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.ForeColor = System.Drawing.Color.Maroon;
            phoneLabel.Location = new System.Drawing.Point(327, 341);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(116, 19);
            phoneLabel.TabIndex = 35;
            phoneLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.Maroon;
            emailLabel.Location = new System.Drawing.Point(327, 301);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 19);
            emailLabel.TabIndex = 34;
            emailLabel.Text = "Email:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_nameLabel.ForeColor = System.Drawing.Color.Maroon;
            last_nameLabel.Location = new System.Drawing.Point(327, 255);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(85, 19);
            last_nameLabel.TabIndex = 33;
            last_nameLabel.Text = "Last Name:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_nameLabel.ForeColor = System.Drawing.Color.Maroon;
            first_nameLabel.Location = new System.Drawing.Point(327, 210);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(83, 19);
            first_nameLabel.TabIndex = 31;
            first_nameLabel.Text = "First Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.Color.Maroon;
            passwordLabel.Location = new System.Drawing.Point(327, 433);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(76, 19);
            passwordLabel.TabIndex = 29;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.ForeColor = System.Drawing.Color.Maroon;
            usernameLabel.Location = new System.Drawing.Point(327, 387);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(93, 19);
            usernameLabel.TabIndex = 28;
            usernameLabel.Text = "University ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Maroon;
            label1.Location = new System.Drawing.Point(629, 319);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 19);
            label1.TabIndex = 44;
            label1.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Maroon;
            label2.Location = new System.Drawing.Point(629, 369);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 19);
            label2.TabIndex = 48;
            label2.Text = "Date of Birth:";
            // 
            // optionaltext
            // 
            optionaltext.AutoSize = true;
            optionaltext.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            optionaltext.ForeColor = System.Drawing.Color.Maroon;
            optionaltext.Location = new System.Drawing.Point(634, 259);
            optionaltext.Name = "optionaltext";
            optionaltext.Size = new System.Drawing.Size(76, 19);
            optionaltext.TabIndex = 49;
            optionaltext.Text = "User Type:";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Maroon;
            this.register.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register.Location = new System.Drawing.Point(419, 609);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(135, 36);
            this.register.TabIndex = 38;
            this.register.Text = "Proceed";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(461, 255);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(139, 24);
            this.lastNameTextBox.TabIndex = 37;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(461, 210);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(139, 24);
            this.firstNameTextBox.TabIndex = 36;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(461, 433);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(139, 24);
            this.passwordTextBox.TabIndex = 32;
            // 
            // uniIdtxt
            // 
            this.uniIdtxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniIdtxt.Location = new System.Drawing.Point(461, 387);
            this.uniIdtxt.Name = "uniIdtxt";
            this.uniIdtxt.Size = new System.Drawing.Size(139, 24);
            this.uniIdtxt.TabIndex = 30;
            // 
            // phonetxt
            // 
            this.phonetxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxt.Location = new System.Drawing.Point(461, 341);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(139, 24);
            this.phonetxt.TabIndex = 41;
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(461, 301);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(139, 24);
            this.emailtxt.TabIndex = 40;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(405, -65);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(351, 270);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(481, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 38);
            this.label5.TabIndex = 43;
            this.label5.Text = "Registration";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(19, 19);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 45;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(80, 20);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 46;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.Controls.Add(this.male);
            this.gender.Controls.Add(this.female);
            this.gender.Location = new System.Drawing.Point(763, 301);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(156, 48);
            this.gender.TabIndex = 47;
            this.gender.TabStop = false;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirth.Location = new System.Drawing.Point(763, 365);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(152, 20);
            this.dateOfBirth.TabIndex = 0;
            // 
            // userTypecomboBox
            // 
            this.userTypecomboBox.FormattingEnabled = true;
            this.userTypecomboBox.Location = new System.Drawing.Point(763, 259);
            this.userTypecomboBox.Name = "userTypecomboBox";
            this.userTypecomboBox.Size = new System.Drawing.Size(139, 21);
            this.userTypecomboBox.TabIndex = 50;
            this.userTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.userTypecomboBox_SelectedIndexChanged);
            // 
            // optional1
            // 
            this.optional1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optional1.Location = new System.Drawing.Point(206, 13);
            this.optional1.Name = "optional1";
            this.optional1.Size = new System.Drawing.Size(139, 24);
            this.optional1.TabIndex = 52;
            this.optional1.TextChanged += new System.EventHandler(this.optional1_TextChanged);
            // 
            // departmentTxt
            // 
            this.departmentTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentTxt.Location = new System.Drawing.Point(206, 73);
            this.departmentTxt.Name = "departmentTxt";
            this.departmentTxt.Size = new System.Drawing.Size(139, 24);
            this.departmentTxt.TabIndex = 54;
            // 
            // optionalPanel
            // 
            this.optionalPanel.Controls.Add(this.departmentCombo);
            this.optionalPanel.Controls.Add(this.courses);
            this.optionalPanel.Controls.Add(this.programEnrolled);
            this.optionalPanel.Controls.Add(this.departmentName);
            this.optionalPanel.Controls.Add(this.check);
            this.optionalPanel.Controls.Add(this.departmentTxt);
            this.optionalPanel.Controls.Add(this.optional1);
            this.optionalPanel.Location = new System.Drawing.Point(296, 490);
            this.optionalPanel.Name = "optionalPanel";
            this.optionalPanel.Size = new System.Drawing.Size(553, 113);
            this.optionalPanel.TabIndex = 55;
            // 
            // departmentCombo
            // 
            this.departmentCombo.FormattingEnabled = true;
            this.departmentCombo.Location = new System.Drawing.Point(206, 11);
            this.departmentCombo.Name = "departmentCombo";
            this.departmentCombo.Size = new System.Drawing.Size(302, 21);
            this.departmentCombo.TabIndex = 59;
            // 
            // courses
            // 
            this.courses.FormattingEnabled = true;
            this.courses.Location = new System.Drawing.Point(206, 73);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(302, 21);
            this.courses.TabIndex = 58;
            this.courses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // programEnrolled
            // 
            this.programEnrolled.FormattingEnabled = true;
            this.programEnrolled.Location = new System.Drawing.Point(206, 11);
            this.programEnrolled.Name = "programEnrolled";
            this.programEnrolled.Size = new System.Drawing.Size(302, 21);
            this.programEnrolled.TabIndex = 57;
            // 
            // departmentName
            // 
            this.departmentName.AutoSize = true;
            this.departmentName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.departmentName.ForeColor = System.Drawing.Color.Maroon;
            this.departmentName.Location = new System.Drawing.Point(9, 76);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(143, 19);
            this.departmentName.TabIndex = 56;
            this.departmentName.Text = "Department Name:";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.check.ForeColor = System.Drawing.Color.Maroon;
            this.check.Location = new System.Drawing.Point(11, 13);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(129, 19);
            this.check.TabIndex = 55;
            this.check.Text = "Program Enrolled:";
            // 
            // reg2
            // 
            this.reg2.BackColor = System.Drawing.Color.Maroon;
            this.reg2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg2.Location = new System.Drawing.Point(591, 609);
            this.reg2.Name = "reg2";
            this.reg2.Size = new System.Drawing.Size(135, 36);
            this.reg2.TabIndex = 56;
            this.reg2.Text = "Register";
            this.reg2.UseVisualStyleBackColor = false;
            this.reg2.Click += new System.EventHandler(this.reg2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Already registered? Log in";
            // 
            // registraionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg2);
            this.Controls.Add(this.optionalPanel);
            this.Controls.Add(this.userTypecomboBox);
            this.Controls.Add(optionaltext);
            this.Controls.Add(label2);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.gender);
            this.Controls.Add(label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.register);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.uniIdtxt);
            this.KeyPreview = true;
            this.Name = "registraionScreen";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.registraionScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.optionalPanel.ResumeLayout(false);
            this.optionalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox uniIdtxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.GroupBox gender;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.ComboBox userTypecomboBox;
        private System.Windows.Forms.TextBox optional1;
        private System.Windows.Forms.TextBox departmentTxt;
        private System.Windows.Forms.Panel optionalPanel;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.Label departmentName;
        private System.Windows.Forms.Button reg2;
        private System.Windows.Forms.ComboBox programEnrolled;
        private System.Windows.Forms.ComboBox courses;
        private System.Windows.Forms.ComboBox departmentCombo;
        private System.Windows.Forms.Label label3;
    }
}