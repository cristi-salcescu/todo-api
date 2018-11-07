﻿using AutoMapper;
using Core;
using Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class AutoMapperConfig
    {
        public MapperConfiguration CreateConfiguration()
        {
            return new MapperConfiguration(cfg => {
                cfg.CreateMap<Todo, TodoDto>();
            });
        }
    }
}
