using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Academy
{
	public partial class MainForm : Form
	{
		string connectionString;
		//SqlConnection connection;
		//SqlDataReader reader;
		//DataTable table;
		public MainForm()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			if(AllocConsole())
			{
				Console.WriteLine(connectionString);
			}
			//connection= new SqlConnection(connectionString);
			LoadStudents();
			LoadDataToComboBox("Groups","group_name", comboBoxStudentsGroup);
			LoadDataToComboBox("Directions","direction_name", comboBoxStudentsDirection);
			UpdateToolStripStatusLabel();
		}
		void LoadStudents(string condition=null)
		{
			//connection.Open();
			//string cmd = $@"
			//SELECT 
			//		[Ф.И.О.]				=FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name),
			//		[Дата рождения]			=birth_date,
			//		[Группа]				=group_name,
			//		[Направление обучения]	=direction_name
			//FROM Students
			//JOIN Groups		ON ([group] = group_id)
			//JOIN Directions	ON (direction=direction_id)
			//";
			//if(condition != null)
			//{
			//	if (condition.Contains("--")) condition = null;
			//	else cmd += $"WHERE {condition}";
			//}
			//SqlCommand command = new SqlCommand(cmd, connection);
			//reader = command.ExecuteReader();
			//table = new DataTable();
			//for(int i=0;i<reader.FieldCount;i++) table.Columns.Add(reader.GetName(i));
			//while (reader.Read())
			//{
			//	DataRow row = table.NewRow();
			//	for(int i =0;i<reader.FieldCount;i++) row[i] = reader[i];
			//	table.Rows.Add(row);
			//}
			//dataGridViewStudents.DataSource = table;
			//connection.Close();

			string columns = $@"
			[Ф.И.О.]				=FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name),
			[Дата рождения]			=birth_date,
			[Группа]				=group_name,
			[Направление обучения]	=direction_name
";
			string tables = "Students, Groups, Directions";
			string relations = "Students.[group] = group_id AND Groups.direction=direction_id";
			if (condition != null && !condition.Contains("--")) condition = $"{relations} AND {condition}";
			else condition = relations;
			Connector connector = new Connector();
			dataGridViewStudents.DataSource = connector.LoadColumnFromTable(columns, tables, condition);
		}
		void LoadDataToComboBox(string tables, string column, ComboBox list, string condition=null)
		{
			list.Items.Clear();
			list.Items.Add("--");
			list.SelectedIndex = 0;
			//string cmd = $@"SELECT {column} FROM {tables}";
			//if(condition != null)
			//{
			//	cmd += $" WHERE {condition}";
			//}
			//connection.Open();
			//SqlCommand command = new SqlCommand(cmd, connection);
			//reader = command.ExecuteReader();			
			//while (reader.Read()) 
			//{
			//	list.Items.Add(reader[0]);
			//}
			//connection.Close() ;
			Connector connector = new Connector();
			connector.LoadColumnFromTable(column, tables, condition);
			string[] items = new string[connector.DataTable.Rows.Count];
			for(int i=0;i<items.Length; i++)
				items[i] = connector.DataTable.Rows[i][0].ToString();
			list.Items.AddRange(items);
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool FreeConsole();

		private void comboBoxStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
		{

			LoadStudents($"group_name = '{comboBoxStudentsGroup.SelectedItem.ToString()}'");
			UpdateToolStripStatusLabel();
		}

		private void comboBoxStudentDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			//comboBoxStudentsGroup.Items.Clear();
			if (comboBoxStudentsDirection.SelectedIndex > 0)
			{
				string condition = $"direction=direction_id AND direction_name='{comboBoxStudentsDirection.SelectedItem.ToString()}'";
				LoadDataToComboBox("Groups, Directions", "group_name", comboBoxStudentsGroup, condition);
			}
			else if (comboBoxStudentsDirection.SelectedIndex == 0) LoadDataToComboBox("Groups", "group_name", comboBoxStudentsGroup);
			LoadStudents($"direction_name = '{comboBoxStudentsDirection.SelectedItem.ToString()}'");
			UpdateToolStripStatusLabel();
		}
		void UpdateToolStripStatusLabel()
		{
			toolStripStatusLabelStudentsCount.Text = $"Кол-во студентов: {(dataGridViewStudents.RowCount-1).ToString()}";
			if(comboBoxStudentsDirection.SelectedIndex==0)
			{
				toolStripStatusLabelGroupsCount.Text = $"Всего групп: {comboBoxStudentsGroup.Items.Count-1}";
			}
			else
			{
				toolStripStatusLabelGroupsCount.Text = $"Групп по выбранному направлению: {comboBoxStudentsGroup.Items.Count-1}";
			}
		}

		private void buttonAddStudent_Click(object sender, EventArgs e)
		{
			FormStudent formStudent = new FormStudent();
			formStudent.ShowDialog();
		}
	}
}

