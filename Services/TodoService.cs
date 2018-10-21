﻿using AutoMapper;
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
        public TodoService()
        {
            var config = AutoMapperConfig.CreateConfiguration();
            mapper = config.CreateMapper();
            repository = new TodoRepository();
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
