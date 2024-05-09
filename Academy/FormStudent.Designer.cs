namespace Academy
{
	partial class FormStudent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.labelBirthDay = new System.Windows.Forms.Label();
			this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanelStudent = new System.Windows.Forms.TableLayoutPanel();
			this.richTextBoxMiddleName = new System.Windows.Forms.RichTextBox();
			this.richTextBoxLastName = new System.Windows.Forms.RichTextBox();
			this.richTextBoxFirstName = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.comboBoxGroups = new System.Windows.Forms.ComboBox();
			this.comboBoxDirections = new System.Windows.Forms.ComboBox();
			this.labelGroup = new System.Windows.Forms.Label();
			this.labelDirection = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.richTextBoxPhone = new System.Windows.Forms.RichTextBox();
			this.richTextBoxEmail = new System.Windows.Forms.RichTextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonBrouse = new System.Windows.Forms.Button();
			this.labelID = new System.Windows.Forms.Label();
			this.tableLayoutPanelStudent.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// labelLastName
			// 
			this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(100, 7);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(69, 16);
			this.labelLastName.TabIndex = 0;
			this.labelLastName.Text = "Фамилия:";
			// 
			// labelFirstName
			// 
			this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Location = new System.Drawing.Point(133, 38);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(36, 16);
			this.labelFirstName.TabIndex = 1;
			this.labelFirstName.Text = "Имя:";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Location = new System.Drawing.Point(96, 69);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(73, 16);
			this.labelMiddleName.TabIndex = 1;
			this.labelMiddleName.Text = "Отчество:";
			// 
			// labelBirthDay
			// 
			this.labelBirthDay.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelBirthDay.AutoSize = true;
			this.labelBirthDay.Location = new System.Drawing.Point(60, 101);
			this.labelBirthDay.Name = "labelBirthDay";
			this.labelBirthDay.Size = new System.Drawing.Size(109, 16);
			this.labelBirthDay.TabIndex = 1;
			this.labelBirthDay.Text = "Дата рождения:";
			// 
			// dateTimePickerBirthDay
			// 
			this.dateTimePickerBirthDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dateTimePickerBirthDay.Location = new System.Drawing.Point(175, 98);
			this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
			this.dateTimePickerBirthDay.Size = new System.Drawing.Size(246, 22);
			this.dateTimePickerBirthDay.TabIndex = 1;
			// 
			// tableLayoutPanelStudent
			// 
			this.tableLayoutPanelStudent.ColumnCount = 2;
			this.tableLayoutPanelStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanelStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanelStudent.Controls.Add(this.richTextBoxMiddleName, 1, 2);
			this.tableLayoutPanelStudent.Controls.Add(this.dateTimePickerBirthDay, 1, 3);
			this.tableLayoutPanelStudent.Controls.Add(this.labelFirstName, 0, 1);
			this.tableLayoutPanelStudent.Controls.Add(this.labelLastName, 0, 0);
			this.tableLayoutPanelStudent.Controls.Add(this.labelBirthDay, 0, 3);
			this.tableLayoutPanelStudent.Controls.Add(this.labelMiddleName, 0, 2);
			this.tableLayoutPanelStudent.Controls.Add(this.richTextBoxLastName, 1, 0);
			this.tableLayoutPanelStudent.Controls.Add(this.richTextBoxFirstName, 1, 1);
			this.tableLayoutPanelStudent.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanelStudent.Name = "tableLayoutPanelStudent";
			this.tableLayoutPanelStudent.RowCount = 4;
			this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelStudent.Size = new System.Drawing.Size(432, 126);
			this.tableLayoutPanelStudent.TabIndex = 1;
			// 
			// richTextBoxMiddleName
			// 
			this.richTextBoxMiddleName.Location = new System.Drawing.Point(175, 65);
			this.richTextBoxMiddleName.MaxLength = 128;
			this.richTextBoxMiddleName.Name = "richTextBoxMiddleName";
			this.richTextBoxMiddleName.Size = new System.Drawing.Size(246, 25);
			this.richTextBoxMiddleName.TabIndex = 6;
			this.richTextBoxMiddleName.Text = "";
			// 
			// richTextBoxLastName
			// 
			this.richTextBoxLastName.Location = new System.Drawing.Point(175, 3);
			this.richTextBoxLastName.MaxLength = 128;
			this.richTextBoxLastName.Name = "richTextBoxLastName";
			this.richTextBoxLastName.Size = new System.Drawing.Size(246, 25);
			this.richTextBoxLastName.TabIndex = 4;
			this.richTextBoxLastName.Text = "";
			// 
			// richTextBoxFirstName
			// 
			this.richTextBoxFirstName.Location = new System.Drawing.Point(175, 34);
			this.richTextBoxFirstName.MaxLength = 128;
			this.richTextBoxFirstName.Name = "richTextBoxFirstName";
			this.richTextBoxFirstName.Size = new System.Drawing.Size(246, 25);
			this.richTextBoxFirstName.TabIndex = 5;
			this.richTextBoxFirstName.Text = "";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.Controls.Add(this.comboBoxGroups, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxDirections, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelGroup, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelDirection, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 250);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 65);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// comboBoxGroups
			// 
			this.comboBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.comboBoxGroups.FormattingEnabled = true;
			this.comboBoxGroups.Location = new System.Drawing.Point(175, 36);
			this.comboBoxGroups.Name = "comboBoxGroups";
			this.comboBoxGroups.Size = new System.Drawing.Size(246, 24);
			this.comboBoxGroups.TabIndex = 4;
			// 
			// comboBoxDirections
			// 
			this.comboBoxDirections.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.comboBoxDirections.FormattingEnabled = true;
			this.comboBoxDirections.Location = new System.Drawing.Point(175, 4);
			this.comboBoxDirections.Name = "comboBoxDirections";
			this.comboBoxDirections.Size = new System.Drawing.Size(246, 24);
			this.comboBoxDirections.TabIndex = 3;
			this.comboBoxDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirections_SelectedIndexChanged);
			// 
			// labelGroup
			// 
			this.labelGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(112, 40);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(57, 16);
			this.labelGroup.TabIndex = 4;
			this.labelGroup.Text = "Группа:";
			// 
			// labelDirection
			// 
			this.labelDirection.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelDirection.AutoSize = true;
			this.labelDirection.Location = new System.Drawing.Point(3, 8);
			this.labelDirection.Name = "labelDirection";
			this.labelDirection.Size = new System.Drawing.Size(166, 16);
			this.labelDirection.TabIndex = 3;
			this.labelDirection.Text = "Направление обучения:";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel2.Controls.Add(this.richTextBoxPhone, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.richTextBoxEmail, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.labelPhone, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.labelEmail, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 160);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(432, 67);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// richTextBoxPhone
			// 
			this.richTextBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.richTextBoxPhone.Location = new System.Drawing.Point(175, 38);
			this.richTextBoxPhone.MaxLength = 17;
			this.richTextBoxPhone.Multiline = false;
			this.richTextBoxPhone.Name = "richTextBoxPhone";
			this.richTextBoxPhone.Size = new System.Drawing.Size(246, 24);
			this.richTextBoxPhone.TabIndex = 5;
			this.richTextBoxPhone.Text = "";
			this.richTextBoxPhone.WordWrap = false;
			// 
			// richTextBoxEmail
			// 
			this.richTextBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.richTextBoxEmail.Location = new System.Drawing.Point(175, 4);
			this.richTextBoxEmail.MaxLength = 50;
			this.richTextBoxEmail.Multiline = false;
			this.richTextBoxEmail.Name = "richTextBoxEmail";
			this.richTextBoxEmail.Size = new System.Drawing.Size(246, 24);
			this.richTextBoxEmail.TabIndex = 4;
			this.richTextBoxEmail.Text = "";
			this.richTextBoxEmail.WordWrap = false;
			// 
			// labelPhone
			// 
			this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(99, 42);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(70, 16);
			this.labelPhone.TabIndex = 4;
			this.labelPhone.Text = "Телефон:";
			// 
			// labelEmail
			// 
			this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(125, 8);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(44, 16);
			this.labelEmail.TabIndex = 4;
			this.labelEmail.Text = "Email:";
			// 
			// pictureBoxPhoto
			// 
			this.pictureBoxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.BackgroundImage")));
			this.pictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxPhoto.Location = new System.Drawing.Point(450, 13);
			this.pictureBoxPhoto.Name = "pictureBoxPhoto";
			this.pictureBoxPhoto.Size = new System.Drawing.Size(197, 214);
			this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxPhoto.TabIndex = 4;
			this.pictureBoxPhoto.TabStop = false;
			// 
			// buttonSave
			// 
			this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSave.Location = new System.Drawing.Point(450, 286);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(95, 30);
			this.buttonSave.TabIndex = 5;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(552, 286);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(95, 30);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonBrouse
			// 
			this.buttonBrouse.Location = new System.Drawing.Point(552, 251);
			this.buttonBrouse.Name = "buttonBrouse";
			this.buttonBrouse.Size = new System.Drawing.Size(95, 27);
			this.buttonBrouse.TabIndex = 7;
			this.buttonBrouse.Text = "Обзор";
			this.buttonBrouse.UseVisualStyleBackColor = true;
			this.buttonBrouse.Click += new System.EventHandler(this.buttonBrouse_Click);
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(450, 230);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(84, 16);
			this.labelID.TabIndex = 8;
			this.labelID.Text = "ID студента";
			// 
			// FormStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 328);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.buttonBrouse);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.pictureBoxPhoto);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.tableLayoutPanelStudent);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "FormStudent";
			this.Text = "Студент";
			this.tableLayoutPanelStudent.ResumeLayout(false);
			this.tableLayoutPanelStudent.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker dateTimePickerBirthDay;
		private System.Windows.Forms.Label labelBirthDay;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStudent;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox comboBoxGroups;
		private System.Windows.Forms.ComboBox comboBoxDirections;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.Label labelDirection;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.RichTextBox richTextBoxPhone;
		private System.Windows.Forms.RichTextBox richTextBoxEmail;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.PictureBox pictureBoxPhoto;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonBrouse;
		private System.Windows.Forms.RichTextBox richTextBoxMiddleName;
		private System.Windows.Forms.RichTextBox richTextBoxLastName;
		private System.Windows.Forms.RichTextBox richTextBoxFirstName;
		private System.Windows.Forms.Label labelID;
	}
}