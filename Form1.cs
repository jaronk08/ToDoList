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

namespace ToDoList
{
    public partial class ToDoListForm : Form
    {
        public ToDoListForm()
        {
            InitializeComponent();
        }

        //table to hold data of tasks
        DataTable todoList = new DataTable();

        //variable to determine is data is being edited
        bool editing = false;
        

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            //create columns of DataTable
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            //set datagridview to todoList
            todolistView.DataSource = todoList;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editing = true;
            //load text from selected cell and index, display it back into textboxes
            titleTextBox.Text = todoList.Rows[todolistView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[todolistView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                todoList.Rows[todolistView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[todolistView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;
            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text,descriptionTextBox.Text);
            }
            //clear fields
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            editing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //delete selected row
            try
            {
                todoList.Rows[todolistView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }

}
