using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> Get();

        Todo GetById(int id);
    }
}
