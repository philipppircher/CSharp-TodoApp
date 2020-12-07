using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Controller
    {
        TodosEntities todosEntities = new TodosEntities();

        public List<todostable> GetTodosNowUntilXHours(double hours)
        {
            var timeNow = DateTime.Now;
            var timeintwohours = DateTime.Now.AddHours(hours);

            List<todostable> todos = todosEntities.todostable.Select(x => x).
              Where(x => x.setDate >= timeNow && x.setDate <= timeintwohours).ToList();
            return todos;
        }

        public List<todostable> GetTodosAll()
        { 
            List<todostable> todos = todosEntities.todostable.ToList();
            return todos;
        }

        public List<todostable> GetTodosDone()
        {
            List<todostable> todos = (List<todostable>)todosEntities.todostable.Where(s => s.isDone.Equals(true));
            return todos;
        }

        public List<todostable> GetTodosNotDone()
        {
            List<todostable> todos = (List<todostable>)todosEntities.todostable.Where(s => s.isDone.Equals(false));
            return todos;
        }

        public void AddTodo(DateTime date, string todoText)
        {
            todostable todo = new todostable() { setDate = date, description = todoText };

            todosEntities.todostable.Add(todo);
            todosEntities.SaveChanges();
        }
    }
}
