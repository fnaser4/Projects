namespace PolyLearn.Screens
{
    partial class TeacherHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherHome));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.branchBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectedCourseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.database1DataSet1 = new PolyLearn.Database1DataSet1();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new PolyLearn.Database1DataSet1TableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new PolyLearn.Database1DataSet1TableAdapters.TableAdapterManager();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.courseIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.branchBtn);
            this.panel2.Controls.Add(this.studentBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 676);
            this.panel2.TabIndex = 129;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(3, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 58);
            this.panel3.TabIndex = 2;
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
            // branchBtn
            // 
            this.branchBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.branchBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.branchBtn.Location = new System.Drawing.Point(3, 227);
            this.branchBtn.Name = "branchBtn";
            this.branchBtn.Size = new System.Drawing.Size(263, 57);
            this.branchBtn.TabIndex = 4;
            this.branchBtn.Text = "Courses";
            this.branchBtn.UseVisualStyleBackColor = false;
            // 
            // studentBtn
            // 
            this.studentBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.studentBtn.Location = new System.Drawing.Point(3, 283);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(263, 57);
            this.studentBtn.TabIndex = 4;
            this.studentBtn.Text = "Students";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
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
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // selectedCourseBtn
            // 
            this.selectedCourseBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.selectedCourseBtn.ForeColor = System.Drawing.Color.Maroon;
            this.selectedCourseBtn.Location = new System.Drawing.Point(737, 240);
            this.selectedCourseBtn.Name = "selectedCourseBtn";
            this.selectedCourseBtn.Size = new System.Drawing.Size(280, 57);
            this.selectedCourseBtn.TabIndex = 135;
            this.selectedCourseBtn.Text = "View Selected Course Details";
            this.selectedCourseBtn.UseVisualStyleBackColor = true;
            this.selectedCourseBtn.Click += new System.EventHandler(this.selectedCourseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(277, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(764, 18);
            this.label2.TabIndex = 136;
            this.label2.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.Maroon;
            this.mainLabel.Location = new System.Drawing.Point(291, 155);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(139, 38);
            this.mainLabel.TabIndex = 137;
            this.mainLabel.Text = "Courses";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.database1DataSet1;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.Feedback2TableAdapter = null;
            this.tableAdapterManager.ProgramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PolyLearn.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.AutoGenerateColumns = false;
            this.coursesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdColumn,
            this.dataGridViewTextBoxColumn2,
            this.courseDescription,
            this.programId});
            this.coursesDataGridView.DataSource = this.coursesBindingSource;
            this.coursesDataGridView.Location = new System.Drawing.Point(280, 240);
            this.coursesDataGridView.MultiSelect = false;
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.RowHeadersWidth = 62;
            this.coursesDataGridView.Size = new System.Drawing.Size(451, 305);
            this.coursesDataGridView.TabIndex = 138;
            this.coursesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesDataGridView_CellContentClick);
            // 
            // courseIdColumn
            // 
            this.courseIdColumn.DataPropertyName = "courseId";
            this.courseIdColumn.HeaderText = "courseId";
            this.courseIdColumn.MinimumWidth = 8;
            this.courseIdColumn.Name = "courseIdColumn";
            this.courseIdColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "courseName";
            this.dataGridViewTextBoxColumn2.HeaderText = "courseName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // courseDescription
            // 
            this.courseDescription.DataPropertyName = "courseDescription";
            this.courseDescription.HeaderText = "courseDescription";
            this.courseDescription.MinimumWidth = 8;
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Visible = false;
            this.courseDescription.Width = 150;
            // 
            // programId
            // 
            this.programId.DataPropertyName = "programId";
            this.programId.HeaderText = "programId";
            this.programId.MinimumWidth = 8;
            this.programId.Name = "programId";
            this.programId.Visible = false;
            this.programId.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(942, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 676);
            this.menuStrip1.TabIndex = 198;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // TeacherHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.coursesDataGridView);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedCourseBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeacherHome";
            this.Text = "TeacherHome";
            this.Load += new System.EventHandler(this.TeacherHome_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button branchBtn;
        public System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button selectedCourseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mainLabel;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private Database1DataSet1TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn programId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}