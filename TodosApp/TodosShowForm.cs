using Data;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodosApp
{
    public partial class TodosShowForm : Form
    {
        List<todostable> selectedTodos;
        Controller controller;
        bool isLoadedTodos;

        public TodosShowForm()
        {
            InitializeComponent();

            controller = new Controller();

            isLoadedTodos = false;

            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isLoadedTodos)
            {
                foreach (todostable todo in selectedTodos)
                {
                    rtbTodos.Text += String.Format("{0} - {1} - {2} - {3}\n", todo.id, todo.setDate, todo.description, todo.isDone);
                }
            }
        }

        private void rbShowAllTodos_CheckedChanged(object sender, EventArgs e)
        {
            isLoadedTodos = false;
            selectedTodos = controller.GetTodosAll();
            isLoadedTodos = true;
        }
    }
}
