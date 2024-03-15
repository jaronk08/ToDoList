using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

using System.Data.SqlClient; //SQL Server local db

namespace ToDoList
{
    public partial class ToDoListForm : Form
    {
        //table to hold data of tasks
        DataTable todoList = new DataTable();

        #region Form
        public ToDoListForm()
        {
            InitializeComponent();
        }

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            load_Tasks();
        }
        #endregion /Form

        #region Buttons
        private void editButton_Click(object sender, EventArgs e)
        {
            edit_Task();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            add_Task();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete_Task();
        }
        #endregion /Buttons

        #region Methods
        private void load_Tasks()
        {
            //connection string
            string cn_string = Properties.Settings.Default.dbTasksConnectionString;

            //connection
            SqlConnection cn_connection = new SqlConnection(cn_string);

            if (cn_connection.State != ConnectionState.Open)
                cn_connection.Open();

            string sql_Text = "SELECT * FROM tbl_Tasks";

            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);
            adapter.Fill(todoList);

            //set datagridview to todoList
            todolistView.DataSource = todoList;

            cn_connection.Close();

        }

        private void add_Task()
        {
            //connection string
            string cn_string = Properties.Settings.Default.dbTasksConnectionString;

            //connection
            SqlConnection cn_connection = new SqlConnection(cn_string);

            if (cn_connection.State != ConnectionState.Open)
                cn_connection.Open();

            //input from form
            string taskTitle = titleTextBox.Text;
            string taskDescription = descriptionTextBox.Text;

            string sql_Text = "INSERT INTO tbl_Tasks (Title, Description) VALUES('" + taskTitle + "','" + taskDescription + "')";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();

            cn_connection.Close();

            //reload
            todoList.Clear();
            load_Tasks();

        }

        private void delete_Task()
        {
            //connection string
            string cn_string = Properties.Settings.Default.dbTasksConnectionString;

            //connection
            SqlConnection cn_connection = new SqlConnection(cn_string);

            if (cn_connection.State != ConnectionState.Open)
                cn_connection.Open();

            //selected row
            DataRowView row = todolistView.CurrentRow.DataBoundItem as DataRowView;
            string IDTask = row["ID"].ToString();

            string sql_Text = "DELETE FROM tbl_Tasks WHERE (ID = " + IDTask + ")";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();

            cn_connection.Close();

            //reload
            todoList.Clear();
            load_Tasks();
        }

        private void edit_Task()
        {
            //connection string
            string cn_string = Properties.Settings.Default.dbTasksConnectionString;

            //connection
            SqlConnection cn_connection = new SqlConnection(cn_string);

            if (cn_connection.State != ConnectionState.Open)
                cn_connection.Open();

            //input data
            string taskTitle = titleTextBox.Text;
            string taskDescription = descriptionTextBox.Text;

            //selected row
            DataRowView row = todolistView.CurrentRow.DataBoundItem as DataRowView;
            string IDTask = row["ID"].ToString();

            string sql_Text = "UPDATE tbl_Tasks SET Title = '" + taskTitle + "', Description = '" + taskDescription + "' WHERE Id = " + IDTask;

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();

            cn_connection.Close();

            //reload
            todoList.Clear();
            load_Tasks();
        }

        #endregion /Methods

    }

}
