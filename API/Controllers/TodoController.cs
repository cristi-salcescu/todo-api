using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Dtos;
using DI;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]s")]
    public class TodoController : Controller
    {
        private ITodoService todoService;
        public TodoController()
        {
            this.todoService = Bootstrapper.Resolve<ITodoService>();
        }

        // GET: api/todos
        [HttpGet]
        public IEnumerable<TodoDto> Get()
        {
            return todoService.Get();
        }

        // GET api/todos/5
        [HttpGet("{id}")]
        public TodoDto Get(int id)
        {
            return todoService.GetById(id);
        }
    }
}
