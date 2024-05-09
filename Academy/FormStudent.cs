using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academy
{
	public partial class FormStudent : Form
	{
		int id;
		public FormStudent()
		{
			InitializeComponent();
			FormDataLoader.LoadDataToComboBox("Directions","direction_name",comboBoxDirections, null,"--");
			FormDataLoader.LoadDataToComboBox("Groups","group_name",comboBoxGroups);
			//comboBoxGroups.Items.Remove("--");
			//comboBoxGroups.SelectedIndex = -1;
			//InitForm();
			id = -1;
			labelID.Visible= false;
		}
		void InitForm()
		{
			richTextBoxLastName.Text = "Тупенко";
			richTextBoxFirstName.Text = "Мурзик";
			richTextBoxMiddleName.Text = "Тимофеевич";
			dateTimePickerBirthDay.Value = new DateTime(2005, 04, 01);
		}
		/*
		public void InitForm
			(string last_name,string first_name,string middle_name, 
			DateTime birth_date, string email, string phone, 
			string group, string direction, Image photo)
		{
			richTextBoxLastName.Text = last_name;
			richTextBoxFirstName.Text = first_name;
			richTextBoxMiddleName.Text = middle_name;
			dateTimePickerBirthDay.Value = birth_date;
			richTextBoxEmail.Text = email;
			richTextBoxPhone.Text = phone;
			comboBoxGroups.SelectedValue = group;
			comboBoxDirections.SelectedValue = direction;
			pictureBoxPhoto.Image = photo;
			comboBoxGroups.Enabled = false;
			comboBoxDirections.Enabled = false;
		}*/
		public void InitForm(DataTable table)
		{
			DataRow row = table.Rows[0];
			id = Convert.ToInt32(row["stud_id"].ToString());
			richTextBoxLastName.Text = row["last_name"].ToString();
			richTextBoxFirstName.Text = row["first_name"].ToString();
			richTextBoxMiddleName.Text = row["middle_name"].ToString();
			dateTimePickerBirthDay.Value = DateTime.Parse(row["birth_date"].ToString());
			richTextBoxEmail.Text = row["email"].ToString();
			richTextBoxPhone.Text = row["phone"].ToString();
			Connector connector = new Connector();
			connector.LoadColumnFromTable("group_name, direction", "Groups", $"group_id={row["group"]}");
			comboBoxGroups.SelectedIndex = comboBoxGroups.FindStringExact(connector.DataTable.Rows[0]["group_name"].ToString());
			connector.LoadColumnFromTable("direction_name", "Directions", $"direction_id={connector.DataTable.Rows[0]["direction"]}");
			comboBoxDirections.SelectedIndex = comboBoxDirections.FindStringExact(connector.DataTable.Rows[0]["direction_name"].ToString());
			byte[] imageData = Encoding.Unicode.GetBytes(row["photo"].ToString());
			MemoryStream ms=new MemoryStream(imageData);
			pictureBoxPhoto.Image = Image.FromStream(ms);
			labelID.Text = $"ID студента: {id}";
			labelID.Visible = true;
			//LockFields();
		}
		void LockFields()
		{
			richTextBoxLastName.Enabled = false;
			richTextBoxFirstName.Enabled = false;
			richTextBoxMiddleName.Enabled = false;
			dateTimePickerBirthDay.Enabled = false;
			richTextBoxEmail.Enabled = false;
			richTextBoxPhone.Enabled = false;
			comboBoxGroups.Enabled = false;
			comboBoxDirections.Enabled = false;
		}
		private void buttonSave_Click(object sender, EventArgs e)
		{
			Connector connector = new Connector();
			if (id < 0) 
			{ 
				//Single responsibility principle
				connector.InsertDataToBase("Students",
										"last_name, first_name, middle_name, birth_date, email, phone, photo, [group]",
										$"'{richTextBoxLastName.Text}',"+
										$"'{richTextBoxFirstName.Text}',"+
										$"'{richTextBoxMiddleName.Text}',"+
										$"'{dateTimePickerBirthDay.Value}',"+
										$"'{richTextBoxEmail.Text}',"+
										$"'{richTextBoxPhone.Text}',"+
										$"'{pictureBoxPhoto.Image}',"+
										$"{connector.GetIDbyValue("Groups","group_id,group_name",comboBoxGroups.SelectedItem.ToString())}");
			}
			else
			{
				connector.UpdateDataInBase
					(
					"Students",
					"last_name,first_name,middle_name,birth_date,email,phone,photo,[group]",
										$"'{richTextBoxLastName.Text}'," +
										$"'{richTextBoxFirstName.Text}'," +
										$"'{richTextBoxMiddleName.Text}'," +
										$"'{dateTimePickerBirthDay.Value}'," +
										$"'{richTextBoxEmail.Text}'," +
										$"'{richTextBoxPhone.Text}'," +
										$"'{pictureBoxPhoto.Image}'," +
										$"{connector.GetIDbyValue("Groups", "group_id,group_name", comboBoxGroups.SelectedItem.ToString())}",
										$"stud_id={id}"
										);
			}
		}

		private void buttonBrouse_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.ShowDialog();
			string filename = open.FileName;
			pictureBoxPhoto.Image = Image.FromFile(filename);
		}

		private void comboBoxDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			FormDataLoader.GroupFilter(comboBoxDirections, comboBoxGroups);
		}
	}
}
