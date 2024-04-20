namespace PoliceDB_321
{
	partial class MainForm
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageViolations = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridViewViolations = new System.Windows.Forms.DataGridView();
			this.labelViolationType = new System.Windows.Forms.Label();
			this.comboBoxViolationType = new System.Windows.Forms.ComboBox();
			this.buttonAddViolation = new System.Windows.Forms.Button();
			this.buttonAlterViolation = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPageViolations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewViolations)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageViolations);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 450);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageViolations
			// 
			this.tabPageViolations.Controls.Add(this.buttonAlterViolation);
			this.tabPageViolations.Controls.Add(this.buttonAddViolation);
			this.tabPageViolations.Controls.Add(this.comboBoxViolationType);
			this.tabPageViolations.Controls.Add(this.labelViolationType);
			this.tabPageViolations.Controls.Add(this.dataGridViewViolations);
			this.tabPageViolations.Location = new System.Drawing.Point(4, 25);
			this.tabPageViolations.Name = "tabPageViolations";
			this.tabPageViolations.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageViolations.Size = new System.Drawing.Size(792, 421);
			this.tabPageViolations.TabIndex = 0;
			this.tabPageViolations.Text = "Violations";
			this.tabPageViolations.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 421);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridViewViolations
			// 
			this.dataGridViewViolations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewViolations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewViolations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewViolations.Location = new System.Drawing.Point(6, 35);
			this.dataGridViewViolations.Name = "dataGridViewViolations";
			this.dataGridViewViolations.RowHeadersWidth = 51;
			this.dataGridViewViolations.RowTemplate.Height = 24;
			this.dataGridViewViolations.Size = new System.Drawing.Size(780, 380);
			this.dataGridViewViolations.TabIndex = 0;
			// 
			// labelViolationType
			// 
			this.labelViolationType.AutoSize = true;
			this.labelViolationType.Location = new System.Drawing.Point(6, 7);
			this.labelViolationType.Name = "labelViolationType";
			this.labelViolationType.Size = new System.Drawing.Size(107, 16);
			this.labelViolationType.TabIndex = 1;
			this.labelViolationType.Text = "Тип нарушения";
			// 
			// comboBoxViolationType
			// 
			this.comboBoxViolationType.FormattingEnabled = true;
			this.comboBoxViolationType.Location = new System.Drawing.Point(119, 3);
			this.comboBoxViolationType.Name = "comboBoxViolationType";
			this.comboBoxViolationType.Size = new System.Drawing.Size(459, 24);
			this.comboBoxViolationType.TabIndex = 2;
			this.comboBoxViolationType.SelectedIndexChanged += new System.EventHandler(this.comboBoxViolationType_SelectedIndexChanged);
			// 
			// buttonAddViolation
			// 
			this.buttonAddViolation.Location = new System.Drawing.Point(687, 4);
			this.buttonAddViolation.Name = "buttonAddViolation";
			this.buttonAddViolation.Size = new System.Drawing.Size(97, 23);
			this.buttonAddViolation.TabIndex = 3;
			this.buttonAddViolation.Text = "Добавить";
			this.buttonAddViolation.UseVisualStyleBackColor = true;
			this.buttonAddViolation.Click += new System.EventHandler(this.buttonAddViolation_Click);
			// 
			// buttonAlterViolation
			// 
			this.buttonAlterViolation.Location = new System.Drawing.Point(584, 4);
			this.buttonAlterViolation.Name = "buttonAlterViolation";
			this.buttonAlterViolation.Size = new System.Drawing.Size(97, 23);
			this.buttonAlterViolation.TabIndex = 4;
			this.buttonAlterViolation.Text = "Изменить";
			this.buttonAlterViolation.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.Text = "PoliceDB_321";
			this.tabControl.ResumeLayout(false);
			this.tabPageViolations.ResumeLayout(false);
			this.tabPageViolations.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewViolations)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageViolations;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button buttonAlterViolation;
		private System.Windows.Forms.Button buttonAddViolation;
		private System.Windows.Forms.ComboBox comboBoxViolationType;
		private System.Windows.Forms.Label labelViolationType;
		private System.Windows.Forms.DataGridView dataGridViewViolations;
	}
}

