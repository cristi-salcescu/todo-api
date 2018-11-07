using AutoMapper;
using Core;
using Core.Dtos;
using Repositories;
using System;
using System.Collections.Generic;

namespace Services
{
    public class TodoService : ITodoService
    {
        IMapper mapper;
        ITodoRepository repository;

        public TodoService(): this(new AutoMapperConfig(), new TodoRepository())
        {
        }

        public TodoService(AutoMapperConfig mapperConfig, TodoRepository repository)
        {
            var config = mapperConfig.CreateConfiguration();
            this.mapper = config.CreateMapper();
            this.repository = repository;
        }

        public IEnumerable<TodoDto> Get()
        {
            var todos = repository.Get();
            return mapper.Map<List<TodoDto>>(todos);
        }

        public TodoDto GetById(int id)
        {
            Todo todo = repository.GetById(id);
            return mapper.Map<TodoDto>(todo);
        }
    }
}
