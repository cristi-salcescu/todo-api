using Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface ITodoService
    {
        IEnumerable<TodoDto> Get();

        TodoDto GetById(int id);
    }
}
