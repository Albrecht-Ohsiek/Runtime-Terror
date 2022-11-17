namespace Runtime_Terror
{
    partial class FormDataCapture
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
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.buttonStudentStoreInfo = new System.Windows.Forms.Button();
            this.comboBoxStudentGender = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxStudentLastName = new System.Windows.Forms.TextBox();
            this.textBoxStudentEmail = new System.Windows.Forms.TextBox();
            this.textBoxStudentModule = new System.Windows.Forms.TextBox();
            this.buttonStudentSearch = new System.Windows.Forms.Button();
            this.buttonStudentUpdate = new System.Windows.Forms.Button();
            this.buttonStudentDelete = new System.Windows.Forms.Button();
            this.buttonStudentsViewAll = new System.Windows.Forms.Button();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelStudentLastName = new System.Windows.Forms.Label();
            this.labelStudentDOB = new System.Windows.Forms.Label();
            this.labelStudentPhoneNum = new System.Windows.Forms.Label();
            this.labelStudentEmail = new System.Windows.Forms.Label();
            this.labelStudentModule = new System.Windows.Forms.Label();
            this.textBoxStudentPhoneNum = new System.Windows.Forms.TextBox();
            this.labelStudentGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonModuleDelete = new System.Windows.Forms.Button();
            this.buttonModuleUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxModuleSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonModuleSearch = new System.Windows.Forms.Button();
            this.buttonModuleStoreInfo = new System.Windows.Forms.Button();
            this.labelModuleID = new System.Windows.Forms.Label();
            this.textBoxModuleId = new System.Windows.Forms.TextBox();
            this.textBoxModuleName = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelModuleLink = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelModuleName = new System.Windows.Forms.Label();
            this.labelModuleDiscription = new System.Windows.Forms.Label();
            this.buttonMuduleViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(14, 26);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "Student ID";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(127, 23);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(215, 20);
            this.textBoxStudentID.TabIndex = 1;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(20, 344);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(750, 103);
            this.dgvDisplay.TabIndex = 2;
            // 
            // buttonStudentStoreInfo
            // 
            this.buttonStudentStoreInfo.Location = new System.Drawing.Point(9, 237);
            this.buttonStudentStoreInfo.Name = "buttonStudentStoreInfo";
            this.buttonStudentStoreInfo.Size = new System.Drawing.Size(109, 29);
            this.buttonStudentStoreInfo.TabIndex = 3;
            this.buttonStudentStoreInfo.Text = "Create";
            this.buttonStudentStoreInfo.UseVisualStyleBackColor = true;
            this.buttonStudentStoreInfo.Click += new System.EventHandler(this.buttonStoreInfo_Click);
            // 
            // comboBoxStudentGender
            // 
            this.comboBoxStudentGender.FormattingEnabled = true;
            this.comboBoxStudentGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not-Specific"});
            this.comboBoxStudentGender.Location = new System.Drawing.Point(127, 155);
            this.comboBoxStudentGender.Name = "comboBoxStudentGender";
            this.comboBoxStudentGender.Size = new System.Drawing.Size(181, 21);
            this.comboBoxStudentGender.TabIndex = 4;
            // 
            // dateTimePickerStudentDOB
            // 
            this.dateTimePickerStudentDOB.Location = new System.Drawing.Point(127, 103);
            this.dateTimePickerStudentDOB.Name = "dateTimePickerStudentDOB";
            this.dateTimePickerStudentDOB.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerStudentDOB.TabIndex = 5;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(127, 51);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(215, 20);
            this.textBoxStudentName.TabIndex = 6;
            // 
            // textBoxStudentLastName
            // 
            this.textBoxStudentLastName.Location = new System.Drawing.Point(127, 77);
            this.textBoxStudentLastName.Name = "textBoxStudentLastName";
            this.textBoxStudentLastName.Size = new System.Drawing.Size(215, 20);
            this.textBoxStudentLastName.TabIndex = 7;
            // 
            // textBoxStudentEmail
            // 
            this.textBoxStudentEmail.Location = new System.Drawing.Point(127, 182);
            this.textBoxStudentEmail.Name = "textBoxStudentEmail";
            this.textBoxStudentEmail.Size = new System.Drawing.Size(215, 20);
            this.textBoxStudentEmail.TabIndex = 8;
            // 
            // textBoxStudentModule
            // 
            this.textBoxStudentModule.Location = new System.Drawing.Point(127, 208);
            this.textBoxStudentModule.Name = "textBoxStudentModule";
            this.textBoxStudentModule.Size = new System.Drawing.Size(215, 20);
            this.textBoxStudentModule.TabIndex = 9;
            // 
            // buttonStudentSearch
            // 
            this.buttonStudentSearch.Location = new System.Drawing.Point(267, 13);
            this.buttonStudentSearch.Name = "buttonStudentSearch";
            this.buttonStudentSearch.Size = new System.Drawing.Size(77, 29);
            this.buttonStudentSearch.TabIndex = 10;
            this.buttonStudentSearch.Text = "Search";
            this.buttonStudentSearch.UseVisualStyleBackColor = true;
            this.buttonStudentSearch.Click += new System.EventHandler(this.buttonStudentSearch_Click);
            // 
            // buttonStudentUpdate
            // 
            this.buttonStudentUpdate.Location = new System.Drawing.Point(127, 237);
            this.buttonStudentUpdate.Name = "buttonStudentUpdate";
            this.buttonStudentUpdate.Size = new System.Drawing.Size(109, 29);
            this.buttonStudentUpdate.TabIndex = 11;
            this.buttonStudentUpdate.Text = "Update";
            this.buttonStudentUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonStudentDelete
            // 
            this.buttonStudentDelete.Location = new System.Drawing.Point(244, 237);
            this.buttonStudentDelete.Name = "buttonStudentDelete";
            this.buttonStudentDelete.Size = new System.Drawing.Size(109, 29);
            this.buttonStudentDelete.TabIndex = 12;
            this.buttonStudentDelete.Text = "Delete";
            this.buttonStudentDelete.UseVisualStyleBackColor = true;
            // 
            // buttonStudentsViewAll
            // 
            this.buttonStudentsViewAll.Location = new System.Drawing.Point(490, 453);
            this.buttonStudentsViewAll.Name = "buttonStudentsViewAll";
            this.buttonStudentsViewAll.Size = new System.Drawing.Size(137, 29);
            this.buttonStudentsViewAll.TabIndex = 13;
            this.buttonStudentsViewAll.Text = "Display Students";
            this.buttonStudentsViewAll.UseVisualStyleBackColor = true;
            this.buttonStudentsViewAll.Click += new System.EventHandler(this.buttonStudentsViewAll_Click);
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(14, 54);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(75, 13);
            this.labelStudentName.TabIndex = 14;
            this.labelStudentName.Text = "Student Name";
            // 
            // labelStudentLastName
            // 
            this.labelStudentLastName.AutoSize = true;
            this.labelStudentLastName.Location = new System.Drawing.Point(14, 80);
            this.labelStudentLastName.Name = "labelStudentLastName";
            this.labelStudentLastName.Size = new System.Drawing.Size(89, 13);
            this.labelStudentLastName.TabIndex = 15;
            this.labelStudentLastName.Text = "Student Surname";
            // 
            // labelStudentDOB
            // 
            this.labelStudentDOB.AutoSize = true;
            this.labelStudentDOB.Location = new System.Drawing.Point(14, 107);
            this.labelStudentDOB.Name = "labelStudentDOB";
            this.labelStudentDOB.Size = new System.Drawing.Size(66, 13);
            this.labelStudentDOB.TabIndex = 16;
            this.labelStudentDOB.Text = "Date of Birth";
            // 
            // labelStudentPhoneNum
            // 
            this.labelStudentPhoneNum.AutoSize = true;
            this.labelStudentPhoneNum.Location = new System.Drawing.Point(14, 132);
            this.labelStudentPhoneNum.Name = "labelStudentPhoneNum";
            this.labelStudentPhoneNum.Size = new System.Drawing.Size(78, 13);
            this.labelStudentPhoneNum.TabIndex = 17;
            this.labelStudentPhoneNum.Text = "Phone Number";
            // 
            // labelStudentEmail
            // 
            this.labelStudentEmail.AutoSize = true;
            this.labelStudentEmail.Location = new System.Drawing.Point(14, 185);
            this.labelStudentEmail.Name = "labelStudentEmail";
            this.labelStudentEmail.Size = new System.Drawing.Size(73, 13);
            this.labelStudentEmail.TabIndex = 18;
            this.labelStudentEmail.Text = "Email Address";
            // 
            // labelStudentModule
            // 
            this.labelStudentModule.AutoSize = true;
            this.labelStudentModule.Location = new System.Drawing.Point(14, 211);
            this.labelStudentModule.Name = "labelStudentModule";
            this.labelStudentModule.Size = new System.Drawing.Size(47, 13);
            this.labelStudentModule.TabIndex = 19;
            this.labelStudentModule.Text = "Modules";
            // 
            // textBoxStudentPhoneNum
            // 
            this.textBoxStudentPhoneNum.Location = new System.Drawing.Point(127, 129);
            this.textBoxStudentPhoneNum.Name = "textBoxStudentPhoneNum";
            this.textBoxStudentPhoneNum.Size = new System.Drawing.Size(215, 20);
            this.textBoxStudentPhoneNum.TabIndex = 20;
            // 
            // labelStudentGender
            // 
            this.labelStudentGender.AutoSize = true;
            this.labelStudentGender.Location = new System.Drawing.Point(14, 158);
            this.labelStudentGender.Name = "labelStudentGender";
            this.labelStudentGender.Size = new System.Drawing.Size(42, 13);
            this.labelStudentGender.TabIndex = 21;
            this.labelStudentGender.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.labelStudentID);
            this.groupBox1.Controls.Add(this.textBoxStudentID);
            this.groupBox1.Controls.Add(this.comboBoxStudentGender);
            this.groupBox1.Controls.Add(this.buttonStudentDelete);
            this.groupBox1.Controls.Add(this.labelStudentGender);
            this.groupBox1.Controls.Add(this.buttonStudentUpdate);
            this.groupBox1.Controls.Add(this.dateTimePickerStudentDOB);
            this.groupBox1.Controls.Add(this.textBoxStudentPhoneNum);
            this.groupBox1.Controls.Add(this.buttonStudentStoreInfo);
            this.groupBox1.Controls.Add(this.textBoxStudentName);
            this.groupBox1.Controls.Add(this.labelStudentModule);
            this.groupBox1.Controls.Add(this.textBoxStudentLastName);
            this.groupBox1.Controls.Add(this.labelStudentEmail);
            this.groupBox1.Controls.Add(this.textBoxStudentEmail);
            this.groupBox1.Controls.Add(this.labelStudentPhoneNum);
            this.groupBox1.Controls.Add(this.textBoxStudentModule);
            this.groupBox1.Controls.Add(this.labelStudentDOB);
            this.groupBox1.Controls.Add(this.labelStudentName);
            this.groupBox1.Controls.Add(this.labelStudentLastName);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 320);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxSearchStudent);
            this.groupBox4.Controls.Add(this.buttonStudentSearch);
            this.groupBox4.Location = new System.Drawing.Point(6, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 48);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Student ID";
            // 
            // textBoxSearchStudent
            // 
            this.textBoxSearchStudent.Location = new System.Drawing.Point(72, 18);
            this.textBoxSearchStudent.Name = "textBoxSearchStudent";
            this.textBoxSearchStudent.Size = new System.Drawing.Size(189, 20);
            this.textBoxSearchStudent.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonModuleDelete);
            this.groupBox3.Controls.Add(this.buttonModuleUpdate);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.buttonModuleStoreInfo);
            this.groupBox3.Controls.Add(this.labelModuleID);
            this.groupBox3.Controls.Add(this.textBoxModuleId);
            this.groupBox3.Controls.Add(this.textBoxModuleName);
            this.groupBox3.Controls.Add(this.textBoxDesc);
            this.groupBox3.Controls.Add(this.labelModuleLink);
            this.groupBox3.Controls.Add(this.textBoxLink);
            this.groupBox3.Controls.Add(this.labelModuleName);
            this.groupBox3.Controls.Add(this.labelModuleDiscription);
            this.groupBox3.Location = new System.Drawing.Point(408, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 320);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modules";
            // 
            // buttonModuleDelete
            // 
            this.buttonModuleDelete.Location = new System.Drawing.Point(244, 237);
            this.buttonModuleDelete.Name = "buttonModuleDelete";
            this.buttonModuleDelete.Size = new System.Drawing.Size(109, 29);
            this.buttonModuleDelete.TabIndex = 24;
            this.buttonModuleDelete.Text = "Delete";
            this.buttonModuleDelete.UseVisualStyleBackColor = true;
            this.buttonModuleDelete.Click += new System.EventHandler(this.buttonModuleDelete_Click);
            // 
            // buttonModuleUpdate
            // 
            this.buttonModuleUpdate.Location = new System.Drawing.Point(127, 237);
            this.buttonModuleUpdate.Name = "buttonModuleUpdate";
            this.buttonModuleUpdate.Size = new System.Drawing.Size(109, 29);
            this.buttonModuleUpdate.TabIndex = 23;
            this.buttonModuleUpdate.Text = "Update";
            this.buttonModuleUpdate.UseVisualStyleBackColor = true;
            this.buttonModuleUpdate.Click += new System.EventHandler(this.buttonModuleUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxModuleSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonModuleSearch);
            this.groupBox2.Location = new System.Drawing.Point(6, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 48);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // textBoxModuleSearch
            // 
            this.textBoxModuleSearch.Location = new System.Drawing.Point(70, 18);
            this.textBoxModuleSearch.Name = "textBoxModuleSearch";
            this.textBoxModuleSearch.Size = new System.Drawing.Size(191, 20);
            this.textBoxModuleSearch.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Module ID";
            // 
            // buttonModuleSearch
            // 
            this.buttonModuleSearch.Location = new System.Drawing.Point(267, 13);
            this.buttonModuleSearch.Name = "buttonModuleSearch";
            this.buttonModuleSearch.Size = new System.Drawing.Size(77, 29);
            this.buttonModuleSearch.TabIndex = 11;
            this.buttonModuleSearch.Text = "Search";
            this.buttonModuleSearch.UseVisualStyleBackColor = true;
            this.buttonModuleSearch.Click += new System.EventHandler(this.buttonModuleSearch_Click);
            // 
            // buttonModuleStoreInfo
            // 
            this.buttonModuleStoreInfo.Location = new System.Drawing.Point(9, 237);
            this.buttonModuleStoreInfo.Name = "buttonModuleStoreInfo";
            this.buttonModuleStoreInfo.Size = new System.Drawing.Size(109, 29);
            this.buttonModuleStoreInfo.TabIndex = 22;
            this.buttonModuleStoreInfo.Text = "Create";
            this.buttonModuleStoreInfo.UseVisualStyleBackColor = true;
            this.buttonModuleStoreInfo.Click += new System.EventHandler(this.buttonModuleStoreInfo_Click);
            // 
            // labelModuleID
            // 
            this.labelModuleID.AutoSize = true;
            this.labelModuleID.Location = new System.Drawing.Point(14, 26);
            this.labelModuleID.Name = "labelModuleID";
            this.labelModuleID.Size = new System.Drawing.Size(70, 13);
            this.labelModuleID.TabIndex = 0;
            this.labelModuleID.Text = "Module Code";
            // 
            // textBoxModuleId
            // 
            this.textBoxModuleId.Location = new System.Drawing.Point(127, 23);
            this.textBoxModuleId.Name = "textBoxModuleId";
            this.textBoxModuleId.Size = new System.Drawing.Size(215, 20);
            this.textBoxModuleId.TabIndex = 1;
            // 
            // textBoxModuleName
            // 
            this.textBoxModuleName.Location = new System.Drawing.Point(127, 51);
            this.textBoxModuleName.Name = "textBoxModuleName";
            this.textBoxModuleName.Size = new System.Drawing.Size(215, 20);
            this.textBoxModuleName.TabIndex = 6;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(127, 77);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(215, 20);
            this.textBoxDesc.TabIndex = 7;
            // 
            // labelModuleLink
            // 
            this.labelModuleLink.AutoSize = true;
            this.labelModuleLink.Location = new System.Drawing.Point(14, 106);
            this.labelModuleLink.Name = "labelModuleLink";
            this.labelModuleLink.Size = new System.Drawing.Size(76, 13);
            this.labelModuleLink.TabIndex = 18;
            this.labelModuleLink.Text = "Resource Link";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(127, 103);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(215, 20);
            this.textBoxLink.TabIndex = 8;
            // 
            // labelModuleName
            // 
            this.labelModuleName.AutoSize = true;
            this.labelModuleName.Location = new System.Drawing.Point(14, 54);
            this.labelModuleName.Name = "labelModuleName";
            this.labelModuleName.Size = new System.Drawing.Size(73, 13);
            this.labelModuleName.TabIndex = 14;
            this.labelModuleName.Text = "Module Name";
            // 
            // labelModuleDiscription
            // 
            this.labelModuleDiscription.AutoSize = true;
            this.labelModuleDiscription.Location = new System.Drawing.Point(14, 80);
            this.labelModuleDiscription.Name = "labelModuleDiscription";
            this.labelModuleDiscription.Size = new System.Drawing.Size(60, 13);
            this.labelModuleDiscription.TabIndex = 15;
            this.labelModuleDiscription.Text = "Description";
            // 
            // buttonMuduleViewAll
            // 
            this.buttonMuduleViewAll.Location = new System.Drawing.Point(634, 453);
            this.buttonMuduleViewAll.Name = "buttonMuduleViewAll";
            this.buttonMuduleViewAll.Size = new System.Drawing.Size(137, 29);
            this.buttonMuduleViewAll.TabIndex = 25;
            this.buttonMuduleViewAll.Text = "Display Modules";
            this.buttonMuduleViewAll.UseVisualStyleBackColor = true;
            this.buttonMuduleViewAll.Click += new System.EventHandler(this.buttonMuduleViewAll_Click);
            // 
            // FormDataCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 495);
            this.Controls.Add(this.buttonMuduleViewAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStudentsViewAll);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "FormDataCapture";
            this.Text = "Form2DataCapture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDataCapture_FormClosed);
            this.Load += new System.EventHandler(this.FormDataCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button buttonStudentStoreInfo;
        private System.Windows.Forms.ComboBox comboBoxStudentGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerStudentDOB;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxStudentLastName;
        private System.Windows.Forms.TextBox textBoxStudentEmail;
        private System.Windows.Forms.TextBox textBoxStudentModule;
        private System.Windows.Forms.Button buttonStudentSearch;
        private System.Windows.Forms.Button buttonStudentUpdate;
        private System.Windows.Forms.Button buttonStudentDelete;
        private System.Windows.Forms.Button buttonStudentsViewAll;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelStudentLastName;
        private System.Windows.Forms.Label labelStudentDOB;
        private System.Windows.Forms.Label labelStudentPhoneNum;
        private System.Windows.Forms.Label labelStudentEmail;
        private System.Windows.Forms.Label labelStudentModule;
        private System.Windows.Forms.TextBox textBoxStudentPhoneNum;
        private System.Windows.Forms.Label labelStudentGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelModuleID;
        private System.Windows.Forms.TextBox textBoxModuleId;
        private System.Windows.Forms.TextBox textBoxModuleName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelModuleLink;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label labelModuleName;
        private System.Windows.Forms.Label labelModuleDiscription;
        private System.Windows.Forms.Button buttonMuduleViewAll;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxModuleSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonModuleSearch;
        private System.Windows.Forms.Button buttonModuleDelete;
        private System.Windows.Forms.Button buttonModuleUpdate;
        private System.Windows.Forms.Button buttonModuleStoreInfo;
    }
}