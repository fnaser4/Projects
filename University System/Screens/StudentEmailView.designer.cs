namespace PolyLearn.Screens
{
    partial class StudentEmailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEmailView));
            this.panel2 = new System.Windows.Forms.Panel();
            this.announcmentBtn = new System.Windows.Forms.Button();
            this.changePwdBtn = new System.Windows.Forms.Button();
            this.FeedbackBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookingMng_Btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ViewCoursesBtn = new System.Windows.Forms.Button();
            this.EmailBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sendMailBtn = new System.Windows.Forms.Button();
            this.database1DataSet4 = new PolyLearn.Database1DataSet4();
            this.mailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailTableAdapter = new PolyLearn.Database1DataSet4TableAdapters.MailTableAdapter();
            this.tableAdapterManager = new PolyLearn.Database1DataSet4TableAdapters.TableAdapterManager();
            this.mailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBindingNavigator)).BeginInit();
            this.mailBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 1040);
            this.panel2.TabIndex = 215;
            // 
            // announcmentBtn
            // 
            this.announcmentBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.announcmentBtn.Location = new System.Drawing.Point(6, 732);
            this.announcmentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.announcmentBtn.Name = "announcmentBtn";
            this.announcmentBtn.Size = new System.Drawing.Size(394, 88);
            this.announcmentBtn.TabIndex = 19;
            this.announcmentBtn.Text = "Announcments";
            this.announcmentBtn.UseVisualStyleBackColor = true;
            this.announcmentBtn.Click += new System.EventHandler(this.announcmentBtn_Click_1);
            // 
            // changePwdBtn
            // 
            this.changePwdBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.changePwdBtn.Location = new System.Drawing.Point(4, 635);
            this.changePwdBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changePwdBtn.Name = "changePwdBtn";
            this.changePwdBtn.Size = new System.Drawing.Size(394, 88);
            this.changePwdBtn.TabIndex = 18;
            this.changePwdBtn.Text = "Change Password";
            this.changePwdBtn.UseVisualStyleBackColor = true;
            this.changePwdBtn.Click += new System.EventHandler(this.changePwdBtn_Click);
            // 
            // FeedbackBtn
            // 
            this.FeedbackBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.FeedbackBtn.Location = new System.Drawing.Point(4, 538);
            this.FeedbackBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FeedbackBtn.Name = "FeedbackBtn";
            this.FeedbackBtn.Size = new System.Drawing.Size(394, 88);
            this.FeedbackBtn.TabIndex = 17;
            this.FeedbackBtn.Text = "Send Feedback";
            this.FeedbackBtn.UseVisualStyleBackColor = true;
            this.FeedbackBtn.Click += new System.EventHandler(this.FeedbackBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(4, 442);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 89);
            this.panel3.TabIndex = 2;
            // 
            // BookingMng_Btn
            // 
            this.BookingMng_Btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BookingMng_Btn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.BookingMng_Btn.Location = new System.Drawing.Point(86, 1228);
            this.BookingMng_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BookingMng_Btn.Name = "BookingMng_Btn";
            this.BookingMng_Btn.Size = new System.Drawing.Size(202, 38);
            this.BookingMng_Btn.TabIndex = 16;
            this.BookingMng_Btn.Text = "Logout";
            this.BookingMng_Btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 248);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // ViewCoursesBtn
            // 
            this.ViewCoursesBtn.BackColor = System.Drawing.Color.White;
            this.ViewCoursesBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.ViewCoursesBtn.Location = new System.Drawing.Point(4, 349);
            this.ViewCoursesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewCoursesBtn.Name = "ViewCoursesBtn";
            this.ViewCoursesBtn.Size = new System.Drawing.Size(394, 88);
            this.ViewCoursesBtn.TabIndex = 4;
            this.ViewCoursesBtn.Text = "View courses";
            this.ViewCoursesBtn.UseVisualStyleBackColor = false;
            this.ViewCoursesBtn.Click += new System.EventHandler(this.ViewCoursesBtn_Click);
            // 
            // EmailBtn
            // 
            this.EmailBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.EmailBtn.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.EmailBtn.Location = new System.Drawing.Point(4, 442);
            this.EmailBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailBtn.Name = "EmailBtn";
            this.EmailBtn.Size = new System.Drawing.Size(394, 88);
            this.EmailBtn.TabIndex = 4;
            this.EmailBtn.Text = "View Emails";
            this.EmailBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(356, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 56);
            this.label5.TabIndex = 0;
            this.label5.Text = "View Emails";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.logoutLbl);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(404, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 192);
            this.panel1.TabIndex = 220;
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.Location = new System.Drawing.Point(1116, 17);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(65, 21);
            this.logoutLbl.TabIndex = 18;
            this.logoutLbl.Text = "Logout";
            this.logoutLbl.Click += new System.EventHandler(this.logoutLbl_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 172);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.BackColor = System.Drawing.Color.Maroon;
            this.sendMailBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendMailBtn.Location = new System.Drawing.Point(448, 289);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(183, 46);
            this.sendMailBtn.TabIndex = 221;
            this.sendMailBtn.Text = "Send new email";
            this.sendMailBtn.UseVisualStyleBackColor = false;
            this.sendMailBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mailBindingSource
            // 
            this.mailBindingSource.DataMember = "Mail";
            this.mailBindingSource.DataSource = this.database1DataSet4;
            // 
            // mailTableAdapter
            // 
            this.mailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseMaterialTableAdapter = null;
            this.tableAdapterManager.FeedBacksTableAdapter = null;
            this.tableAdapterManager.ImportantInformationTableAdapter = null;
            this.tableAdapterManager.MailTableAdapter = this.mailTableAdapter;
            this.tableAdapterManager.StudentsCoursesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PolyLearn.Database1DataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mailBindingNavigator
            // 
            this.mailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mailBindingNavigator.BindingSource = this.mailBindingSource;
            this.mailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mailBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mailBindingNavigatorSaveItem});
            this.mailBindingNavigator.Location = new System.Drawing.Point(404, 192);
            this.mailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mailBindingNavigator.Name = "mailBindingNavigator";
            this.mailBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.mailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mailBindingNavigator.Size = new System.Drawing.Size(1198, 33);
            this.mailBindingNavigator.TabIndex = 222;
            this.mailBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // mailBindingNavigatorSaveItem
            // 
            this.mailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mailBindingNavigatorSaveItem.Image")));
            this.mailBindingNavigatorSaveItem.Name = "mailBindingNavigatorSaveItem";
            this.mailBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.mailBindingNavigatorSaveItem.Text = "Save Data";
            this.mailBindingNavigatorSaveItem.Click += new System.EventHandler(this.mailBindingNavigatorSaveItem_Click);
            // 
            // mailDataGridView
            // 
            this.mailDataGridView.AutoGenerateColumns = false;
            this.mailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.mailDataGridView.DataSource = this.mailBindingSource;
            this.mailDataGridView.Location = new System.Drawing.Point(448, 362);
            this.mailDataGridView.Name = "mailDataGridView";
            this.mailDataGridView.RowHeadersWidth = 62;
            this.mailDataGridView.RowTemplate.Height = 28;
            this.mailDataGridView.Size = new System.Drawing.Size(1112, 352);
            this.mailDataGridView.TabIndex = 222;
            this.mailDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mailDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mailId";
            this.dataGridViewTextBoxColumn1.HeaderText = "mailId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "senderUsername";
            this.dataGridViewTextBoxColumn2.HeaderText = "senderUsername";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "recieverUsername";
            this.dataGridViewTextBoxColumn3.HeaderText = "recieverUsername";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "message";
            this.dataGridViewTextBoxColumn4.HeaderText = "message";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "subject";
            this.dataGridViewTextBoxColumn5.HeaderText = "subject";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // StudentEmailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 1040);
            this.Controls.Add(this.mailDataGridView);
            this.Controls.Add(this.mailBindingNavigator);
            this.Controls.Add(this.sendMailBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentEmailView";
            this.Text = "sendEmail";
            this.Load += new System.EventHandler(this.StudentEmailView_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBindingNavigator)).EndInit();
            this.mailBindingNavigator.ResumeLayout(false);
            this.mailBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button announcmentBtn;
        public System.Windows.Forms.Button changePwdBtn;
        public System.Windows.Forms.Button FeedbackBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BookingMng_Btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ViewCoursesBtn;
        public System.Windows.Forms.Button EmailBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button sendMailBtn;
        private System.Windows.Forms.Label logoutLbl;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource mailBindingSource;
        private Database1DataSet4TableAdapters.MailTableAdapter mailTableAdapter;
        private Database1DataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mailBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mailBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}