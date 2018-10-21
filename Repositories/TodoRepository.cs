using Core;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public class TodoRepository: ITodoRepository
    {
        public IEnumerable<Todo> Get()
        {
            var todos = new List<Todo>()
            {
                new Todo() { Id=1, Title="task1", Completed=false },
                new Todo() { Id=2, Title="task2", Completed=false }
            };

            return todos;
        }

        public Todo GetById(int id)
        {
            Todo todo = new Todo();
            return todo;
        }
    }
}
