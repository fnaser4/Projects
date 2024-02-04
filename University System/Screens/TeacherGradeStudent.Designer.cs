namespace PolyLearn.Screens
{
    partial class TeacherGradeStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherGradeStudent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.branchBtn = new System.Windows.Forms.Button();
            this.stuBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.database1DataSet3 = new PolyLearn.Database1DataSet3();
            this.course_GradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_GradesTableAdapter = new PolyLearn.Database1DataSet3TableAdapters.Course_GradesTableAdapter();
            this.tableAdapterManager = new PolyLearn.Database1DataSet3TableAdapters.TableAdapterManager();
            this.course_GradesDataGridView = new System.Windows.Forms.DataGridView();
            this.studentCombo = new System.Windows.Forms.ComboBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.assessmentCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GradesDataGridView)).BeginInit();
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
            this.panel2.TabIndex = 189;
            // 
            // branchBtn
            // 
            this.branchBtn.BackColor = System.Drawing.Color.LightGray;
            this.branchBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.branchBtn.ForeColor = System.Drawing.Color.Maroon;
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
            this.stuBtn.ForeColor = System.Drawing.Color.Maroon;
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 292);
            this.pictureBox1.TabIndex = 190;
            this.pictureBox1.TabStop = false;
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
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.Maroon;
            this.mainLabel.Location = new System.Drawing.Point(291, 155);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(255, 38);
            this.mainLabel.TabIndex = 192;
            this.mainLabel.Text = "Grade Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(311, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 194;
            this.label3.Text = "Select Student:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(324, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 195;
            this.label1.Text = "Add Grade:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnnouncementTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Course_GradesTableAdapter = this.course_GradesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PolyLearn.Database1DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // course_GradesDataGridView
            // 
            this.course_GradesDataGridView.AutoGenerateColumns = false;
            this.course_GradesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.course_GradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.course_GradesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.course_GradesDataGridView.DataSource = this.course_GradesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.course_GradesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.course_GradesDataGridView.Location = new System.Drawing.Point(298, 456);
            this.course_GradesDataGridView.Name = "course_GradesDataGridView";
            this.course_GradesDataGridView.RowHeadersWidth = 62;
            this.course_GradesDataGridView.Size = new System.Drawing.Size(653, 220);
            this.course_GradesDataGridView.TabIndex = 196;
            // 
            // studentCombo
            // 
            this.studentCombo.FormattingEnabled = true;
            this.studentCombo.Location = new System.Drawing.Point(478, 259);
            this.studentCombo.Name = "studentCombo";
            this.studentCombo.Size = new System.Drawing.Size(458, 21);
            this.studentCombo.TabIndex = 197;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(464, 353);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(335, 20);
            this.grade.TabIndex = 198;
            // 
            // changePassBtn
            // 
            this.changePassBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.changePassBtn.ForeColor = System.Drawing.Color.Maroon;
            this.changePassBtn.Location = new System.Drawing.Point(344, 391);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(592, 34);
            this.changePassBtn.TabIndex = 199;
            this.changePassBtn.Text = "Send Grade";
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // assessmentCombo
            // 
            this.assessmentCombo.FormattingEnabled = true;
            this.assessmentCombo.Location = new System.Drawing.Point(510, 306);
            this.assessmentCombo.Name = "assessmentCombo";
            this.assessmentCombo.Size = new System.Drawing.Size(458, 21);
            this.assessmentCombo.TabIndex = 201;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(311, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 200;
            this.label4.Text = "Select Assessment:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "courseid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Course Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studentId";
            this.dataGridViewTextBoxColumn2.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "assessment1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Assessment 1";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "assessment2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Assessment 2";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "assessment3";
            this.dataGridViewTextBoxColumn5.HeaderText = "Assessment 3";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "published";
            this.dataGridViewTextBoxColumn6.HeaderText = "Published";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // TeacherGradeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.assessmentCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.studentCombo);
            this.Controls.Add(this.course_GradesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeacherGradeStudent";
            this.Text = "TeacherGradeStudent";
            this.Load += new System.EventHandler(this.TeacherGradeStudent_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GradesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button branchBtn;
        public System.Windows.Forms.Button stuBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource course_GradesBindingSource;
        private Database1DataSet3TableAdapters.Course_GradesTableAdapter course_GradesTableAdapter;
        private Database1DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView course_GradesDataGridView;
        private System.Windows.Forms.ComboBox studentCombo;
        private System.Windows.Forms.TextBox grade;
        public System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.ComboBox assessmentCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}