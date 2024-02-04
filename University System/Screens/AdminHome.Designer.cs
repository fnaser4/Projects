namespace PolyLearn.Screens
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookingMng_Btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.branchBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.courseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.database1DataSet = new PolyLearn.Database1DataSet();
            this.universityBranchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityBranchTableAdapter = new PolyLearn.Database1DataSetTableAdapters.UniversityBranchTableAdapter();
            this.tableAdapterManager = new PolyLearn.Database1DataSetTableAdapters.TableAdapterManager();
            this.universityBranchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.universityBranchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.universityBranchDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBranchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBranchBindingNavigator)).BeginInit();
            this.universityBranchBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityBranchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1036, -119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 403);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.BookingMng_Btn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.branchBtn);
            this.panel2.Controls.Add(this.staffBtn);
            this.panel2.Controls.Add(this.courseBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 523);
            this.panel2.TabIndex = 127;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(3, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 58);
            this.panel3.TabIndex = 2;
            // 
            // BookingMng_Btn
            // 
            this.BookingMng_Btn.BackColor = System.Drawing.SystemColors.ControlDark;
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button7.Location = new System.Drawing.Point(3, 450);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(263, 57);
            this.button7.TabIndex = 7;
            this.button7.Text = "Messages";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button5.Location = new System.Drawing.Point(3, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "Services";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // branchBtn
            // 
            this.branchBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.branchBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.branchBtn.Location = new System.Drawing.Point(3, 227);
            this.branchBtn.Name = "branchBtn";
            this.branchBtn.Size = new System.Drawing.Size(263, 57);
            this.branchBtn.TabIndex = 4;
            this.branchBtn.Text = "Branches";
            this.branchBtn.UseVisualStyleBackColor = false;
            this.branchBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.staffBtn.Location = new System.Drawing.Point(3, 338);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(263, 57);
            this.staffBtn.TabIndex = 4;
            this.staffBtn.Text = "Staff ";
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // courseBtn
            // 
            this.courseBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.courseBtn.Location = new System.Drawing.Point(3, 283);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Size = new System.Drawing.Size(263, 57);
            this.courseBtn.TabIndex = 4;
            this.courseBtn.Text = "Courses";
            this.courseBtn.UseVisualStyleBackColor = true;
            this.courseBtn.Click += new System.EventHandler(this.courseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(274, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(764, 18);
            this.label2.TabIndex = 128;
            this.label2.Text = "_________________________________________________________________________________" +
    "___";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.Maroon;
            this.mainLabel.Location = new System.Drawing.Point(285, 90);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(159, 38);
            this.mainLabel.TabIndex = 129;
            this.mainLabel.Text = "Branches";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // universityBranchBindingSource
            // 
            this.universityBranchBindingSource.DataMember = "UniversityBranch";
            this.universityBranchBindingSource.DataSource = this.database1DataSet;
            // 
            // universityBranchTableAdapter
            // 
            this.universityBranchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassroomTableAdapter = null;
            this.tableAdapterManager.ContentTableAdapter = null;
            this.tableAdapterManager.CourseMaterialTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.FeedbackTableAdapter = null;
            this.tableAdapterManager.PartTimeStudentTableAdapter = null;
            this.tableAdapterManager.ProgramTableAdapter = null;
            this.tableAdapterManager.RemoteStudentTableAdapter = null;
            this.tableAdapterManager.ReportTableAdapter = null;
            this.tableAdapterManager.UniversityBranchTableAdapter = this.universityBranchTableAdapter;
            this.tableAdapterManager.UpdateOrder = PolyLearn.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.WorkingStudentTableAdapter = null;
            // 
            // universityBranchBindingNavigator
            // 
            this.universityBranchBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.universityBranchBindingNavigator.BindingSource = this.universityBranchBindingSource;
            this.universityBranchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.universityBranchBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.universityBranchBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.universityBranchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.universityBranchBindingNavigatorSaveItem});
            this.universityBranchBindingNavigator.Location = new System.Drawing.Point(269, 0);
            this.universityBranchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.universityBranchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.universityBranchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.universityBranchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.universityBranchBindingNavigator.Name = "universityBranchBindingNavigator";
            this.universityBranchBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.universityBranchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.universityBranchBindingNavigator.Size = new System.Drawing.Size(587, 31);
            this.universityBranchBindingNavigator.TabIndex = 130;
            this.universityBranchBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // universityBranchBindingNavigatorSaveItem
            // 
            this.universityBranchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.universityBranchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("universityBranchBindingNavigatorSaveItem.Image")));
            this.universityBranchBindingNavigatorSaveItem.Name = "universityBranchBindingNavigatorSaveItem";
            this.universityBranchBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.universityBranchBindingNavigatorSaveItem.Text = "Save Data";
            this.universityBranchBindingNavigatorSaveItem.Click += new System.EventHandler(this.universityBranchBindingNavigatorSaveItem_Click);
            // 
            // universityBranchDataGridView
            // 
            this.universityBranchDataGridView.AutoGenerateColumns = false;
            this.universityBranchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universityBranchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.universityBranchDataGridView.DataSource = this.universityBranchBindingSource;
            this.universityBranchDataGridView.Location = new System.Drawing.Point(292, 160);
            this.universityBranchDataGridView.Name = "universityBranchDataGridView";
            this.universityBranchDataGridView.RowHeadersWidth = 62;
            this.universityBranchDataGridView.Size = new System.Drawing.Size(341, 220);
            this.universityBranchDataGridView.TabIndex = 130;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "branchId";
            this.dataGridViewTextBoxColumn1.HeaderText = "branchId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "branchName";
            this.dataGridViewTextBoxColumn2.HeaderText = "branchName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "branchLocation";
            this.dataGridViewTextBoxColumn3.HeaderText = "branchLocation";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button2.Location = new System.Drawing.Point(292, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 49);
            this.button2.TabIndex = 147;
            this.button2.Text = "Add new Branch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button3.Location = new System.Drawing.Point(406, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 49);
            this.button3.TabIndex = 149;
            this.button3.Text = "Save Branch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button4.Location = new System.Drawing.Point(525, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 49);
            this.button4.TabIndex = 150;
            this.button4.Text = "Delete Branch";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(684, 33);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 128);
            this.pictureBox3.TabIndex = 151;
            this.pictureBox3.TabStop = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Maroon;
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutbtn.Location = new System.Drawing.Point(769, 477);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(76, 35);
            this.logoutbtn.TabIndex = 155;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 523);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.universityBranchDataGridView);
            this.Controls.Add(this.universityBranchBindingNavigator);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBranchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBranchBindingNavigator)).EndInit();
            this.universityBranchBindingNavigator.ResumeLayout(false);
            this.universityBranchBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityBranchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BookingMng_Btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button branchBtn;
        private System.Windows.Forms.Button staffBtn;
        public System.Windows.Forms.Button courseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mainLabel;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource universityBranchBindingSource;
        private Database1DataSetTableAdapters.UniversityBranchTableAdapter universityBranchTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator universityBranchBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton universityBranchBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView universityBranchDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button logoutbtn;
    }
}