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
            var timeNow = DateTime.Now.AddHours(-1);
            var hoursDelay = DateTime.Now.AddHours(hours);

            List<todostable> todos = todosEntities.todostable.Select(x => x).
              Where(x => x.setDate >= timeNow && x.setDate <= hoursDelay).ToList();
            return todos;
        }

        public List<todostable> GetTodosAll()
        {
            List<todostable> todos = todosEntities.todostable.ToList();
            return todos;
        }

        public List<todostable> GetTodosDone()
        {
            //return _toDoEntities.todo.Select(x => x).Where(x => x.isdone == isDone).ToList();
            List<todostable> todos = (List<todostable>)todosEntities.todostable.Select(s => s).Where(s => s.isDone == true).ToList();
            return todos;
        }

        public List<todostable> GetTodosNotDone()
        {
            List<todostable> todos = (List<todostable>)todosEntities.todostable.Select(s => s).Where(s => s.isDone == false || s.isDone == null).ToList();
            return todos;
        }

        public void AddTodo(DateTime date, string todoText)
        {
            todostable todo = new todostable() { setDate = date, description = todoText };

            todosEntities.todostable.Add(todo);
            todosEntities.SaveChanges();
        }

        public void DeleteTodo(int id)
        {
            var todo = todosEntities.todostable.Where(x => x.id == id).FirstOrDefault();

            if (todo != null)
            {
                todosEntities.todostable.Remove(todo);
                todosEntities.SaveChanges();
            }
        }
    }
}
