namespace PolyLearn.Screens
{
    partial class studentCourseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentCourseDetails));
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new PolyLearn.Database1DataSet();
            this.courseTableAdapter = new PolyLearn.Database1DataSetTableAdapters.CourseTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.announcmentBtn = new System.Windows.Forms.Button();
            this.changePwdBtn = new System.Windows.Forms.Button();
            this.FeedbackBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookingMng_Btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ViewCoursesBtn = new System.Windows.Forms.Button();
            this.EmailBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.courseIdLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.database1DataSet4 = new PolyLearn.Database1DataSet4();
            this.importantInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importantInformationTableAdapter = new PolyLearn.Database1DataSet4TableAdapters.ImportantInformationTableAdapter();
            this.tableAdapterManager = new PolyLearn.Database1DataSet4TableAdapters.TableAdapterManager();
            this.viewGradesBtn = new System.Windows.Forms.Button();
            this.database1DataSet3 = new PolyLearn.Database1DataSet3();
            this.course_GradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_GradesTableAdapter = new PolyLearn.Database1DataSet3TableAdapters.Course_GradesTableAdapter();
            this.tableAdapterManager1 = new PolyLearn.Database1DataSet3TableAdapters.TableAdapterManager();
            this.course_GradesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.published = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseMaterialTableAdapter = new PolyLearn.Database1DataSet4TableAdapters.CourseMaterialTableAdapter();
            this.courseMaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GradesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMaterialDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.announcmentBtn);
            this.panel2.Controls.Add(this.changePwdBtn);
            this.panel2.Controls.Add(this.FeedbackBtn);
            this.panel2.Controls.Add(this.panel3);
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
            // FeedbackBtn
            // 
            this.FeedbackBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.FeedbackBtn.Location = new System.Drawing.Point(3, 350);
            this.FeedbackBtn.Name = "FeedbackBtn";
            this.FeedbackBtn.Size = new System.Drawing.Size(263, 57);
            this.FeedbackBtn.TabIndex = 17;
            this.FeedbackBtn.Text = "Send Feedback";
            this.FeedbackBtn.UseVisualStyleBackColor = true;
            this.FeedbackBtn.Click += new System.EventHandler(this.FeedbackBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(3, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 58);
            this.panel3.TabIndex = 2;
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
            // ViewCoursesBtn
            // 
            this.ViewCoursesBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.ViewCoursesBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.ViewCoursesBtn.Location = new System.Drawing.Point(3, 227);
            this.ViewCoursesBtn.Name = "ViewCoursesBtn";
            this.ViewCoursesBtn.Size = new System.Drawing.Size(263, 57);
            this.ViewCoursesBtn.TabIndex = 4;
            this.ViewCoursesBtn.Text = "View courses";
            this.ViewCoursesBtn.UseVisualStyleBackColor = false;
            this.ViewCoursesBtn.Click += new System.EventHandler(this.ViewCoursesBtn_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(269, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 125);
            this.panel1.TabIndex = 219;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 112);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(183, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Registered Courses";
            // 
            // downloadBtn
            // 
            this.downloadBtn.BackColor = System.Drawing.Color.Maroon;
            this.downloadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.downloadBtn.Location = new System.Drawing.Point(328, 427);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(268, 26);
            this.downloadBtn.TabIndex = 225;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLbl.ForeColor = System.Drawing.Color.Maroon;
            this.courseNameLbl.Location = new System.Drawing.Point(583, 187);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(68, 23);
            this.courseNameLbl.TabIndex = 223;
            this.courseNameLbl.Text = "name";
            // 
            // courseIdLbl
            // 
            this.courseIdLbl.AutoSize = true;
            this.courseIdLbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdLbl.ForeColor = System.Drawing.Color.Maroon;
            this.courseIdLbl.Location = new System.Drawing.Point(539, 147);
            this.courseIdLbl.Name = "courseIdLbl";
            this.courseIdLbl.Size = new System.Drawing.Size(30, 23);
            this.courseIdLbl.TabIndex = 222;
            this.courseIdLbl.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(417, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 221;
            this.label3.Text = "Course Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(417, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 220;
            this.label6.Text = "Course ID:";
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importantInformationBindingSource
            // 
            this.importantInformationBindingSource.DataMember = "ImportantInformation";
            this.importantInformationBindingSource.DataSource = this.database1DataSet4;
            // 
            // importantInformationTableAdapter
            // 
            this.importantInformationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseMaterialTableAdapter = null;
            this.tableAdapterManager.FeedBacksTableAdapter = null;
            this.tableAdapterManager.ImportantInformationTableAdapter = this.importantInformationTableAdapter;
            this.tableAdapterManager.MailTableAdapter = null;
            this.tableAdapterManager.StudentsCoursesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PolyLearn.Database1DataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viewGradesBtn
            // 
            this.viewGradesBtn.BackColor = System.Drawing.Color.Maroon;
            this.viewGradesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewGradesBtn.Location = new System.Drawing.Point(702, 428);
            this.viewGradesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewGradesBtn.Name = "viewGradesBtn";
            this.viewGradesBtn.Size = new System.Drawing.Size(259, 26);
            this.viewGradesBtn.TabIndex = 228;
            this.viewGradesBtn.Text = "View Grades";
            this.viewGradesBtn.UseVisualStyleBackColor = false;
            this.viewGradesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // course_GradesBindingSource
            // 
            this.course_GradesBindingSource.DataMember = "Course_Grades";
            this.course_GradesBindingSource.DataSource = this.database1DataSet3;
            // 
            // course_GradesTableAdapter
            // 
            this.course_GradesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AnnouncementTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Course_GradesTableAdapter = this.course_GradesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = PolyLearn.Database1DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // course_GradesDataGridView
            // 
            this.course_GradesDataGridView.AutoGenerateColumns = false;
            this.course_GradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.course_GradesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.published});
            this.course_GradesDataGridView.DataSource = this.course_GradesBindingSource;
            this.course_GradesDataGridView.Location = new System.Drawing.Point(318, 476);
            this.course_GradesDataGridView.Name = "course_GradesDataGridView";
            this.course_GradesDataGridView.RowHeadersWidth = 62;
            this.course_GradesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.course_GradesDataGridView.Size = new System.Drawing.Size(643, 148);
            this.course_GradesDataGridView.TabIndex = 228;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "courseid";
            this.dataGridViewTextBoxColumn1.HeaderText = "courseid";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studentId";
            this.dataGridViewTextBoxColumn2.HeaderText = "studentId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "assessment1";
            this.dataGridViewTextBoxColumn3.HeaderText = "assessment1";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "assessment2";
            this.dataGridViewTextBoxColumn4.HeaderText = "assessment2";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "assessment3";
            this.dataGridViewTextBoxColumn5.HeaderText = "assessment3";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // published
            // 
            this.published.DataPropertyName = "published";
            this.published.HeaderText = "published";
            this.published.MinimumWidth = 8;
            this.published.Name = "published";
            this.published.Width = 150;
            // 
            // courseMaterialBindingSource
            // 
            this.courseMaterialBindingSource.DataMember = "CourseMaterial";
            this.courseMaterialBindingSource.DataSource = this.database1DataSet4;
            // 
            // courseMaterialTableAdapter
            // 
            this.courseMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // courseMaterialDataGridView
            // 
            this.courseMaterialDataGridView.AutoGenerateColumns = false;
            this.courseMaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseMaterialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.courseMaterialDataGridView.DataSource = this.courseMaterialBindingSource;
            this.courseMaterialDataGridView.Location = new System.Drawing.Point(318, 229);
            this.courseMaterialDataGridView.Name = "courseMaterialDataGridView";
            this.courseMaterialDataGridView.Size = new System.Drawing.Size(643, 178);
            this.courseMaterialDataGridView.TabIndex = 228;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "materialId";
            this.dataGridViewTextBoxColumn6.HeaderText = "materialId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "materialTitle";
            this.dataGridViewTextBoxColumn7.HeaderText = "materialTitle";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "courseCode";
            this.dataGridViewTextBoxColumn8.HeaderText = "courseCode";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fileType";
            this.dataGridViewTextBoxColumn9.HeaderText = "fileType";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fileName";
            this.dataGridViewTextBoxColumn10.HeaderText = "fileName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // studentCourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.courseMaterialDataGridView);
            this.Controls.Add(this.course_GradesDataGridView);
            this.Controls.Add(this.viewGradesBtn);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.courseNameLbl);
            this.Controls.Add(this.courseIdLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "studentCourseDetails";
            this.Text = "studentCourseDetails";
            this.Load += new System.EventHandler(this.studentCourseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GradesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMaterialDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource courseBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button announcmentBtn;
        public System.Windows.Forms.Button changePwdBtn;
        public System.Windows.Forms.Button FeedbackBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BookingMng_Btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ViewCoursesBtn;
        public System.Windows.Forms.Button EmailBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.Label courseIdLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource importantInformationBindingSource;
        private Database1DataSet4TableAdapters.ImportantInformationTableAdapter importantInformationTableAdapter;
        private Database1DataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewGradesBtn;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource course_GradesBindingSource;
        private Database1DataSet3TableAdapters.Course_GradesTableAdapter course_GradesTableAdapter;
        private Database1DataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView course_GradesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn published;
        private System.Windows.Forms.BindingSource courseMaterialBindingSource;
        private Database1DataSet4TableAdapters.CourseMaterialTableAdapter courseMaterialTableAdapter;
        private System.Windows.Forms.DataGridView courseMaterialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}