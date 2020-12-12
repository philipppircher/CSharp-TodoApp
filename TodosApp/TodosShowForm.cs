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
        List<todostable> _todos;

        private enum ListModeTodos { All, Done, NotDone, TimeLimit };

        private ListModeTodos _listModeTodos;

        public TodosShowForm()
        {
            InitializeComponent();

            controller = new Controller();

            _todos = new List<todostable>();

            var timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            //if (_todos.Count != selectedTodos.Count)
            {
                //_todos = selectedTodos;
                lbTodos.Items.Clear();

                // Here must be the correct methode called (selectedTodos = controller.GetTodosAll())
                // This Works :) => selectedTodos = controller.GetTodosAll();
                ExecuteCurrentMode();

                foreach (todostable todo in selectedTodos)
                {
                    lbTodos.Items.Add(String.Format("{0} - {1} - {2} - {3}\n", todo.id, todo.setDate, todo.description, todo.isDone));
                }
            }
        }

        private void ExecuteCurrentMode()
        {
            switch(_listModeTodos)
            {
                case ListModeTodos.All:
                    selectedTodos = controller.GetTodosAll();
                    break;
                case ListModeTodos.Done:
                    selectedTodos = controller.GetTodosDone();
                    break;
                case ListModeTodos.NotDone:
                    selectedTodos = controller.GetTodosNotDone();
                    break;
                case ListModeTodos.TimeLimit:
                    int hours = Convert.ToInt32(nudHours.Value);
                    selectedTodos = controller.GetTodosNowUntilXHours(hours);
                    break;
            }
        }

        private void rbShowAllTodos_CheckedChanged(object sender, EventArgs e)
        {
            //selectedTodos = controller.GetTodosAll();
            _listModeTodos = ListModeTodos.All;
        }

        private void lbTodos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rbTodosDone_CheckedChanged(object sender, EventArgs e)
        {
            _listModeTodos = ListModeTodos.Done;
        }

        private void rbTodosNotDone_CheckedChanged(object sender, EventArgs e)
        {
            _listModeTodos = ListModeTodos.NotDone;
        }

        private void rbTodoNextToHours_CheckedChanged(object sender, EventArgs e)
        {
            _listModeTodos = ListModeTodos.TimeLimit;
        }

        private void nudHours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbIsDone_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private string GetIndexAsString()
        {
            string currentSelectedIndexAsString = "";
            try
            {
                currentSelectedIndexAsString = lbTodos.SelectedItem.ToString();
                int index = currentSelectedIndexAsString.IndexOf(" ");
                currentSelectedIndexAsString = currentSelectedIndexAsString.Remove(index, currentSelectedIndexAsString.Length - 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler");
            }
            return currentSelectedIndexAsString;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (cbIsDone.Checked && lbTodos.SelectedIndex != -1)
            {
                string indexString = GetIndexAsString();
                controller.DeleteTodo(Convert.ToInt32(indexString));
                string output = String.Format("Todo mit Index: {0} wurde entfernt", indexString);
                MessageBox.Show(output);
            }
        }
    }
}
