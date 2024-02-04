namespace PolyLearn.Screens
{
    partial class TeacherSelectCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherSelectCourse));
            this.panel2 = new System.Windows.Forms.Panel();
            this.branchBtn = new System.Windows.Forms.Button();
            this.stuBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progIdLbl = new System.Windows.Forms.Label();
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.courseIdLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateReportBtn = new System.Windows.Forms.Button();
            this.addDocBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.descLbl = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.branchBtn);
            this.panel2.Controls.Add(this.stuBtn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 676);
            this.panel2.TabIndex = 167;
            // 
            // branchBtn
            // 
            this.branchBtn.BackColor = System.Drawing.Color.LightGray;
            this.branchBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.branchBtn.Location = new System.Drawing.Point(3, 227);
            this.branchBtn.Name = "branchBtn";
            this.branchBtn.Size = new System.Drawing.Size(263, 57);
            this.branchBtn.TabIndex = 10;
            this.branchBtn.Text = "Courses";
            this.branchBtn.UseVisualStyleBackColor = false;
            this.branchBtn.Click += new System.EventHandler(this.branchBtn_Click);
            // 
            // stuBtn
            // 
            this.stuBtn.BackColor = System.Drawing.Color.LightGray;
            this.stuBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.stuBtn.Location = new System.Drawing.Point(3, 283);
            this.stuBtn.Name = "stuBtn";
            this.stuBtn.Size = new System.Drawing.Size(263, 57);
            this.stuBtn.TabIndex = 12;
            this.stuBtn.Text = "Students";
            this.stuBtn.UseVisualStyleBackColor = false;
            this.stuBtn.Click += new System.EventHandler(this.stuBtn_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(189, -70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 292);
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // progIdLbl
            // 
            this.progIdLbl.AutoSize = true;
            this.progIdLbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.progIdLbl.ForeColor = System.Drawing.Color.Maroon;
            this.progIdLbl.Location = new System.Drawing.Point(462, 333);
            this.progIdLbl.Name = "progIdLbl";
            this.progIdLbl.Size = new System.Drawing.Size(28, 23);
            this.progIdLbl.TabIndex = 189;
            this.progIdLbl.Text = "id";
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.courseNameLbl.ForeColor = System.Drawing.Color.Maroon;
            this.courseNameLbl.Location = new System.Drawing.Point(462, 298);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(67, 23);
            this.courseNameLbl.TabIndex = 188;
            this.courseNameLbl.Text = "name";
            // 
            // courseIdLbl
            // 
            this.courseIdLbl.AutoSize = true;
            this.courseIdLbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.courseIdLbl.ForeColor = System.Drawing.Color.Maroon;
            this.courseIdLbl.Location = new System.Drawing.Point(462, 261);
            this.courseIdLbl.Name = "courseIdLbl";
            this.courseIdLbl.Size = new System.Drawing.Size(30, 23);
            this.courseIdLbl.TabIndex = 187;
            this.courseIdLbl.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(287, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 23);
            this.label5.TabIndex = 186;
            this.label5.Text = "Course Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(316, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 185;
            this.label4.Text = "Program ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(288, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 184;
            this.label3.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(328, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 183;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(277, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(764, 18);
            this.label2.TabIndex = 191;
            this.label2.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.BackColor = System.Drawing.Color.LightGray;
            this.generateReportBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.generateReportBtn.ForeColor = System.Drawing.Color.Maroon;
            this.generateReportBtn.Location = new System.Drawing.Point(802, 291);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(163, 57);
            this.generateReportBtn.TabIndex = 196;
            this.generateReportBtn.Text = "Generate Report";
            this.generateReportBtn.UseVisualStyleBackColor = false;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // addDocBtn
            // 
            this.addDocBtn.BackColor = System.Drawing.Color.LightGray;
            this.addDocBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.addDocBtn.ForeColor = System.Drawing.Color.Maroon;
            this.addDocBtn.Location = new System.Drawing.Point(802, 227);
            this.addDocBtn.Name = "addDocBtn";
            this.addDocBtn.Size = new System.Drawing.Size(163, 57);
            this.addDocBtn.TabIndex = 192;
            this.addDocBtn.Text = "Course Material";
            this.addDocBtn.UseVisualStyleBackColor = false;
            this.addDocBtn.Click += new System.EventHandler(this.addDocBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1001, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(67, 676);
            this.menuStrip1.TabIndex = 197;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(802, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 57);
            this.button1.TabIndex = 198;
            this.button1.Text = "Grade Students";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // descLbl
            // 
            this.descLbl.Location = new System.Drawing.Point(487, 392);
            this.descLbl.Multiline = true;
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(252, 144);
            this.descLbl.TabIndex = 199;
            // 
            // TeacherSelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.generateReportBtn);
            this.Controls.Add(this.addDocBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progIdLbl);
            this.Controls.Add(this.courseNameLbl);
            this.Controls.Add(this.courseIdLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeacherSelectCourse";
            this.Text = "TeacherSelectCourse";
            this.Load += new System.EventHandler(this.TeacherSelectCourse_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button branchBtn;
        public System.Windows.Forms.Button stuBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label progIdLbl;
        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.Label courseIdLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateReportBtn;
        private System.Windows.Forms.Button addDocBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox descLbl;
    }
}