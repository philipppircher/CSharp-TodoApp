using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Logic;

namespace TodosApp
{
    public partial class TodosAddForm : Form
    {
        public TodosAddForm()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DateTime _date = dtpDateTime.Value;
            string _todoText = rtbTodos.Text;
            Controller controller = new Controller();

            controller.AddTodo(_date, _todoText);

            rtbTodos.Text = null;
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            TodosShowForm todosSelectWindow = new TodosShowForm();
            todosSelectWindow.Show();
        }
    }
}
