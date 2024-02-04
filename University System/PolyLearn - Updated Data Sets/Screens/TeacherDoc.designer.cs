namespace PolyLearn.Screens
{
    partial class TeacherDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDoc));
            this.tableAdapterManager = new PolyLearn.Database1DataSetTableAdapters.TableAdapterManager();
            this.courseTableAdapter = new PolyLearn.Database1DataSetTableAdapters.CourseTableAdapter();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedCourseBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.database1DataSet = new PolyLearn.Database1DataSet();
            this.mainLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.branchBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.fileNamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.docPg = new System.Windows.Forms.TabPage();
            this.type = new System.Windows.Forms.GroupBox();
            this.imageBtn = new System.Windows.Forms.RadioButton();
            this.videoBtn = new System.Windows.Forms.RadioButton();
            this.audiobtn = new System.Windows.Forms.RadioButton();
            this.Documentbtn = new System.Windows.Forms.RadioButton();
            this.courseMaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet4 = new PolyLearn.Database1DataSet4();
            this.matBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.courseMaterialTableAdapter = new PolyLearn.Database1DataSet4TableAdapters.CourseMaterialTableAdapter();
            this.tableAdapterManager1 = new PolyLearn.Database1DataSet4TableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.docPg.SuspendLayout();
            this.type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseMaterialDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassroomTableAdapter = null;
            this.tableAdapterManager.ContentTableAdapter = null;
            this.tableAdapterManager.CourseMaterialTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.FeedbackTableAdapter = null;
            this.tableAdapterManager.PartTimeStudentTableAdapter = null;
            this.tableAdapterManager.ProgramTableAdapter = null;
            this.tableAdapterManager.RemoteStudentTableAdapter = null;
            this.tableAdapterManager.ReportTableAdapter = null;
            this.tableAdapterManager.UniversityBranchTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PolyLearn.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.WorkingStudentTableAdapter = null;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // selectedCourseBtn
            // 
            this.selectedCourseBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.selectedCourseBtn.ForeColor = System.Drawing.Color.Maroon;
            this.selectedCourseBtn.Location = new System.Drawing.Point(305, 63);
            this.selectedCourseBtn.Name = "selectedCourseBtn";
            this.selectedCourseBtn.Size = new System.Drawing.Size(64, 26);
            this.selectedCourseBtn.TabIndex = 141;
            this.selectedCourseBtn.Text = "Add ";
            this.selectedCourseBtn.UseVisualStyleBackColor = true;
            this.selectedCourseBtn.Click += new System.EventHandler(this.addDocBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1003, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(65, 676);
            this.menuStrip1.TabIndex = 142;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.Maroon;
            this.mainLabel.Location = new System.Drawing.Point(291, 190);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(139, 38);
            this.mainLabel.TabIndex = 139;
            this.mainLabel.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(277, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(764, 18);
            this.label2.TabIndex = 138;
            this.label2.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(189, -35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 292);
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
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
            this.branchBtn.BackColor = System.Drawing.Color.LightGray;
            this.branchBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.branchBtn.ForeColor = System.Drawing.Color.Maroon;
            this.branchBtn.Location = new System.Drawing.Point(3, 227);
            this.branchBtn.Name = "branchBtn";
            this.branchBtn.Size = new System.Drawing.Size(263, 57);
            this.branchBtn.TabIndex = 4;
            this.branchBtn.Text = "Courses";
            this.branchBtn.UseVisualStyleBackColor = false;
            this.branchBtn.Click += new System.EventHandler(this.branchBtn_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.studentBtn.ForeColor = System.Drawing.Color.Maroon;
            this.studentBtn.Location = new System.Drawing.Point(3, 283);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(263, 57);
            this.studentBtn.TabIndex = 4;
            this.studentBtn.Text = "Students";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.branchBtn);
            this.panel2.Controls.Add(this.studentBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 676);
            this.panel2.TabIndex = 136;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.deleteBtn.ForeColor = System.Drawing.Color.Maroon;
            this.deleteBtn.Location = new System.Drawing.Point(347, 326);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(320, 31);
            this.deleteBtn.TabIndex = 144;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // fileNamebox
            // 
            this.fileNamebox.Location = new System.Drawing.Point(159, 63);
            this.fileNamebox.Name = "fileNamebox";
            this.fileNamebox.Size = new System.Drawing.Size(119, 22);
            this.fileNamebox.TabIndex = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 171;
            this.label1.Text = "File Path:";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.uploadBtn.ForeColor = System.Drawing.Color.Maroon;
            this.uploadBtn.Location = new System.Drawing.Point(19, 326);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(300, 31);
            this.uploadBtn.TabIndex = 172;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.docPg);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(303, 249);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 415);
            this.tabControl1.TabIndex = 173;
            // 
            // docPg
            // 
            this.docPg.AutoScroll = true;
            this.docPg.Controls.Add(this.type);
            this.docPg.Controls.Add(this.courseMaterialDataGridView);
            this.docPg.Controls.Add(this.matBox);
            this.docPg.Controls.Add(this.label6);
            this.docPg.Controls.Add(this.label1);
            this.docPg.Controls.Add(this.deleteBtn);
            this.docPg.Controls.Add(this.uploadBtn);
            this.docPg.Controls.Add(this.fileNamebox);
            this.docPg.Controls.Add(this.selectedCourseBtn);
            this.docPg.ForeColor = System.Drawing.Color.Maroon;
            this.docPg.Location = new System.Drawing.Point(4, 26);
            this.docPg.Name = "docPg";
            this.docPg.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.docPg.Size = new System.Drawing.Size(783, 385);
            this.docPg.TabIndex = 0;
            this.docPg.Text = "Documents";
            this.docPg.UseVisualStyleBackColor = true;
            // 
            // type
            // 
            this.type.Controls.Add(this.imageBtn);
            this.type.Controls.Add(this.videoBtn);
            this.type.Controls.Add(this.audiobtn);
            this.type.Controls.Add(this.Documentbtn);
            this.type.Location = new System.Drawing.Point(19, 109);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(648, 66);
            this.type.TabIndex = 176;
            this.type.TabStop = false;
            this.type.Text = "Select Type";
            this.type.Enter += new System.EventHandler(this.type_Enter);
            // 
            // imageBtn
            // 
            this.imageBtn.AutoSize = true;
            this.imageBtn.Location = new System.Drawing.Point(360, 24);
            this.imageBtn.Name = "imageBtn";
            this.imageBtn.Size = new System.Drawing.Size(64, 21);
            this.imageBtn.TabIndex = 178;
            this.imageBtn.TabStop = true;
            this.imageBtn.Text = "Image";
            this.imageBtn.UseVisualStyleBackColor = true;
            // 
            // videoBtn
            // 
            this.videoBtn.AutoSize = true;
            this.videoBtn.Location = new System.Drawing.Point(254, 24);
            this.videoBtn.Name = "videoBtn";
            this.videoBtn.Size = new System.Drawing.Size(85, 21);
            this.videoBtn.TabIndex = 177;
            this.videoBtn.TabStop = true;
            this.videoBtn.Text = "Video File";
            this.videoBtn.UseVisualStyleBackColor = true;
            // 
            // audiobtn
            // 
            this.audiobtn.AutoSize = true;
            this.audiobtn.Location = new System.Drawing.Point(140, 24);
            this.audiobtn.Name = "audiobtn";
            this.audiobtn.Size = new System.Drawing.Size(84, 21);
            this.audiobtn.TabIndex = 176;
            this.audiobtn.TabStop = true;
            this.audiobtn.Text = "Audio File";
            this.audiobtn.UseVisualStyleBackColor = true;
            // 
            // Documentbtn
            // 
            this.Documentbtn.AutoSize = true;
            this.Documentbtn.Location = new System.Drawing.Point(30, 24);
            this.Documentbtn.Name = "Documentbtn";
            this.Documentbtn.Size = new System.Drawing.Size(89, 21);
            this.Documentbtn.TabIndex = 175;
            this.Documentbtn.TabStop = true;
            this.Documentbtn.Text = "Document";
            this.Documentbtn.UseVisualStyleBackColor = true;
            // 
            // courseMaterialDataGridView
            // 
            this.courseMaterialDataGridView.AutoGenerateColumns = false;
            this.courseMaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseMaterialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.courseMaterialDataGridView.DataSource = this.courseMaterialBindingSource;
            this.courseMaterialDataGridView.Location = new System.Drawing.Point(19, 191);
            this.courseMaterialDataGridView.Name = "courseMaterialDataGridView";
            this.courseMaterialDataGridView.RowHeadersWidth = 62;
            this.courseMaterialDataGridView.Size = new System.Drawing.Size(648, 124);
            this.courseMaterialDataGridView.TabIndex = 174;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "materialId";
            this.dataGridViewTextBoxColumn1.HeaderText = "materialId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "materialTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "materialTitle";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "courseCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "courseCode";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fileType";
            this.dataGridViewTextBoxColumn4.HeaderText = "fileType";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fileName";
            this.dataGridViewTextBoxColumn5.HeaderText = "fileName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // courseMaterialBindingSource
            // 
            this.courseMaterialBindingSource.DataMember = "CourseMaterial";
            this.courseMaterialBindingSource.DataSource = this.database1DataSet4;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matBox
            // 
            this.matBox.Location = new System.Drawing.Point(159, 31);
            this.matBox.Name = "matBox";
            this.matBox.Size = new System.Drawing.Size(119, 22);
            this.matBox.TabIndex = 174;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(15, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 173;
            this.label6.Text = "Material Title:";
            // 
            // courseMaterialTableAdapter
            // 
            this.courseMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CourseMaterialTableAdapter = this.courseMaterialTableAdapter;
            this.tableAdapterManager1.FeedBacksTableAdapter = null;
            this.tableAdapterManager1.ImportantInformationTableAdapter = null;
            this.tableAdapterManager1.MailTableAdapter = null;
            this.tableAdapterManager1.StudentsCoursesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = PolyLearn.Database1DataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TeacherDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "TeacherDoc";
            this.Text = "Course Documents";
            this.Load += new System.EventHandler(this.TeacherDoc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.docPg.ResumeLayout(false);
            this.docPg.PerformLayout();
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseMaterialDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.Button selectedCourseBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button branchBtn;
        public System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox fileNamebox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage docPg;
        private System.Windows.Forms.TextBox matBox;
        private System.Windows.Forms.Label label6;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource courseMaterialBindingSource;
        private Database1DataSet4TableAdapters.CourseMaterialTableAdapter courseMaterialTableAdapter;
        private Database1DataSet4TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView courseMaterialDataGridView;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.RadioButton Documentbtn;
        private System.Windows.Forms.RadioButton audiobtn;
        private System.Windows.Forms.RadioButton imageBtn;
        private System.Windows.Forms.RadioButton videoBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}