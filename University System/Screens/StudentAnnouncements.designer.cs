namespace PolyLearn.Screens
{
    partial class StudentAnnouncements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAnnouncements));
            this.database1DataSet3 = new PolyLearn.Database1DataSet3();
            this.announcementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.announcementTableAdapter = new PolyLearn.Database1DataSet3TableAdapters.AnnouncementTableAdapter();
            this.tableAdapterManager = new PolyLearn.Database1DataSet3TableAdapters.TableAdapterManager();
            this.announcementBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.announcementBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.announcementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new PolyLearn.Database1DataSet();
            this.courseTableAdapter = new PolyLearn.Database1DataSetTableAdapters.CourseTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.announcmentBtn = new System.Windows.Forms.Button();
            this.changePwdBtn = new System.Windows.Forms.Button();
            this.FeedbackBtn = new System.Windows.Forms.Button();
            this.BookingMng_Btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ViewCoursesBtn = new System.Windows.Forms.Button();
            this.EmailBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementBindingNavigator)).BeginInit();
            this.announcementBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.announcementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // announcementBindingSource
            // 
            this.announcementBindingSource.DataMember = "Announcement";
            this.announcementBindingSource.DataSource = this.database1DataSet3;
            // 
            // announcementTableAdapter
            // 
            this.announcementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnnouncementTableAdapter = this.announcementTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Course_GradesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PolyLearn.Database1DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // announcementBindingNavigator
            // 
            this.announcementBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.announcementBindingNavigator.BindingSource = this.announcementBindingSource;
            this.announcementBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.announcementBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.announcementBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.announcementBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.announcementBindingNavigatorSaveItem});
            this.announcementBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.announcementBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.announcementBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.announcementBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.announcementBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.announcementBindingNavigator.Name = "announcementBindingNavigator";
            this.announcementBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.announcementBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.announcementBindingNavigator.Size = new System.Drawing.Size(1068, 31);
            this.announcementBindingNavigator.TabIndex = 135;
            this.announcementBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // announcementBindingNavigatorSaveItem
            // 
            this.announcementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.announcementBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("announcementBindingNavigatorSaveItem.Image")));
            this.announcementBindingNavigatorSaveItem.Name = "announcementBindingNavigatorSaveItem";
            this.announcementBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.announcementBindingNavigatorSaveItem.Text = "Save Data";
            this.announcementBindingNavigatorSaveItem.Click += new System.EventHandler(this.announcementBindingNavigatorSaveItem_Click);
            // 
            // announcementDataGridView
            // 
            this.announcementDataGridView.AutoGenerateColumns = false;
            this.announcementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.announcementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.announcementDataGridView.DataSource = this.announcementBindingSource;
            this.announcementDataGridView.Location = new System.Drawing.Point(317, 183);
            this.announcementDataGridView.Name = "announcementDataGridView";
            this.announcementDataGridView.RowHeadersWidth = 62;
            this.announcementDataGridView.Size = new System.Drawing.Size(455, 349);
            this.announcementDataGridView.TabIndex = 135;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "announcementid";
            this.dataGridViewTextBoxColumn1.HeaderText = "announcementid";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "informationTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "informationTitle";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "informationMessage";
            this.dataGridViewTextBoxColumn3.HeaderText = "informationMessage";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
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
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.announcmentBtn);
            this.panel2.Controls.Add(this.changePwdBtn);
            this.panel2.Controls.Add(this.FeedbackBtn);
            this.panel2.Controls.Add(this.BookingMng_Btn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.ViewCoursesBtn);
            this.panel2.Controls.Add(this.EmailBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 645);
            this.panel2.TabIndex = 211;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Brown;
            this.panel4.Location = new System.Drawing.Point(4, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 58);
            this.panel4.TabIndex = 20;
            // 
            // announcmentBtn
            // 
            this.announcmentBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.announcmentBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.announcmentBtn.Location = new System.Drawing.Point(4, 476);
            this.announcmentBtn.Name = "announcmentBtn";
            this.announcmentBtn.Size = new System.Drawing.Size(263, 57);
            this.announcmentBtn.TabIndex = 19;
            this.announcmentBtn.Text = "Announcments";
            this.announcmentBtn.UseVisualStyleBackColor = false;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(208, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Announcments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.logoutLbl);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(269, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 125);
            this.panel1.TabIndex = 220;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.Location = new System.Drawing.Point(744, 0);
            this.logoutLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(44, 16);
            this.logoutLbl.TabIndex = 17;
            this.logoutLbl.Text = "Logout";
            this.logoutLbl.Click += new System.EventHandler(this.label1_Click);
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
            // StudentAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.announcementDataGridView);
            this.Controls.Add(this.announcementBindingNavigator);
            this.Name = "StudentAnnouncements";
            this.Text = "StudentAnnouncements";
            this.Load += new System.EventHandler(this.StudentAnnouncements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementBindingNavigator)).EndInit();
            this.announcementBindingNavigator.ResumeLayout(false);
            this.announcementBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.announcementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource announcementBindingSource;
        private Database1DataSet3TableAdapters.AnnouncementTableAdapter announcementTableAdapter;
        private Database1DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator announcementBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton announcementBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView announcementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button announcmentBtn;
        public System.Windows.Forms.Button changePwdBtn;
        public System.Windows.Forms.Button FeedbackBtn;
        private System.Windows.Forms.Button BookingMng_Btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ViewCoursesBtn;
        public System.Windows.Forms.Button EmailBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label logoutLbl;
    }
}