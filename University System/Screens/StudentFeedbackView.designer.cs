namespace PolyLearn.Screens
{
    partial class StudentFeedbackView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFeedbackView));
            this.EmailBtn = new System.Windows.Forms.Button();
            this.ViewCoursesBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BookingMng_Btn = new System.Windows.Forms.Button();
            this.FeedbackBtn = new System.Windows.Forms.Button();
            this.changePwdBtn = new System.Windows.Forms.Button();
            this.announcmentBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new PolyLearn.Database1DataSet();
            this.courseTableAdapter = new PolyLearn.Database1DataSetTableAdapters.CourseTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.receiverUsersComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.messageRichTxt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailBtn
            // 
            this.EmailBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.EmailBtn.Location = new System.Drawing.Point(3, 287);
            this.EmailBtn.Name = "EmailBtn";
            this.EmailBtn.Size = new System.Drawing.Size(263, 57);
            this.EmailBtn.TabIndex = 4;
            this.EmailBtn.Text = "View Emails";
            this.EmailBtn.UseVisualStyleBackColor = true;
            this.EmailBtn.Click += new System.EventHandler(this.EmailBtn_Click);
            // 
            // ViewCoursesBtn
            // 
            this.ViewCoursesBtn.BackColor = System.Drawing.Color.White;
            this.ViewCoursesBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.ViewCoursesBtn.Location = new System.Drawing.Point(3, 227);
            this.ViewCoursesBtn.Name = "ViewCoursesBtn";
            this.ViewCoursesBtn.Size = new System.Drawing.Size(263, 57);
            this.ViewCoursesBtn.TabIndex = 4;
            this.ViewCoursesBtn.Text = "View courses";
            this.ViewCoursesBtn.UseVisualStyleBackColor = false;
            this.ViewCoursesBtn.Click += new System.EventHandler(this.ViewCoursesBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // BookingMng_Btn
            // 
            this.BookingMng_Btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BookingMng_Btn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.BookingMng_Btn.Location = new System.Drawing.Point(57, 798);
            this.BookingMng_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookingMng_Btn.Name = "BookingMng_Btn";
            this.BookingMng_Btn.Size = new System.Drawing.Size(135, 25);
            this.BookingMng_Btn.TabIndex = 16;
            this.BookingMng_Btn.Text = "Logout";
            this.BookingMng_Btn.UseVisualStyleBackColor = false;
            // 
            // FeedbackBtn
            // 
            this.FeedbackBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.FeedbackBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.FeedbackBtn.Location = new System.Drawing.Point(3, 350);
            this.FeedbackBtn.Name = "FeedbackBtn";
            this.FeedbackBtn.Size = new System.Drawing.Size(263, 57);
            this.FeedbackBtn.TabIndex = 17;
            this.FeedbackBtn.Text = "Send Feedback";
            this.FeedbackBtn.UseVisualStyleBackColor = false;
            // 
            // changePwdBtn
            // 
            this.changePwdBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.changePwdBtn.Location = new System.Drawing.Point(3, 413);
            this.changePwdBtn.Name = "changePwdBtn";
            this.changePwdBtn.Size = new System.Drawing.Size(263, 57);
            this.changePwdBtn.TabIndex = 18;
            this.changePwdBtn.Text = "Change Password";
            this.changePwdBtn.UseVisualStyleBackColor = true;
            this.changePwdBtn.Click += new System.EventHandler(this.changePwdBtn_Click);
            // 
            // announcmentBtn
            // 
            this.announcmentBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.announcmentBtn.Location = new System.Drawing.Point(4, 476);
            this.announcmentBtn.Name = "announcmentBtn";
            this.announcmentBtn.Size = new System.Drawing.Size(263, 57);
            this.announcmentBtn.TabIndex = 19;
            this.announcmentBtn.Text = "Announcments";
            this.announcmentBtn.UseVisualStyleBackColor = true;
            this.announcmentBtn.Click += new System.EventHandler(this.announcmentBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.announcmentBtn);
            this.panel2.Controls.Add(this.changePwdBtn);
            this.panel2.Controls.Add(this.FeedbackBtn);
            this.panel2.Controls.Add(this.BookingMng_Btn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.ViewCoursesBtn);
            this.panel2.Controls.Add(this.EmailBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 676);
            this.panel2.TabIndex = 215;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Brown;
            this.panel4.Location = new System.Drawing.Point(3, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 58);
            this.panel4.TabIndex = 3;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(242, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "FeedBack";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.logoutLbl);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(269, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 125);
            this.panel1.TabIndex = 221;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.Location = new System.Drawing.Point(744, 11);
            this.logoutLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(44, 16);
            this.logoutLbl.TabIndex = 19;
            this.logoutLbl.Text = "Logout";
            this.logoutLbl.Click += new System.EventHandler(this.logoutLbl_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 112);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // receiverUsersComboBox
            // 
            this.receiverUsersComboBox.DisplayMember = "username";
            this.receiverUsersComboBox.FormattingEnabled = true;
            this.receiverUsersComboBox.Location = new System.Drawing.Point(446, 188);
            this.receiverUsersComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receiverUsersComboBox.Name = "receiverUsersComboBox";
            this.receiverUsersComboBox.Size = new System.Drawing.Size(453, 21);
            this.receiverUsersComboBox.TabIndex = 227;
            this.receiverUsersComboBox.ValueMember = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 226;
            this.label3.Text = "Message: ";
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.Maroon;
            this.SendBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendBtn.Location = new System.Drawing.Point(518, 428);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(303, 28);
            this.SendBtn.TabIndex = 225;
            this.SendBtn.Text = "Send feedback";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // messageRichTxt
            // 
            this.messageRichTxt.Location = new System.Drawing.Point(446, 253);
            this.messageRichTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageRichTxt.Name = "messageRichTxt";
            this.messageRichTxt.Size = new System.Drawing.Size(453, 154);
            this.messageRichTxt.TabIndex = 224;
            this.messageRichTxt.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 222;
            this.label4.Text = "Course Code:";
            // 
            // StudentFeedbackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.receiverUsersComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.messageRichTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentFeedbackView";
            this.Text = "StudentFeedbackView";
            this.Load += new System.EventHandler(this.StudentFeedbackView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button EmailBtn;
        private System.Windows.Forms.Button ViewCoursesBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BookingMng_Btn;
        public System.Windows.Forms.Button FeedbackBtn;
        public System.Windows.Forms.Button changePwdBtn;
        public System.Windows.Forms.Button announcmentBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox receiverUsersComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.RichTextBox messageRichTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label logoutLbl;
    }
}