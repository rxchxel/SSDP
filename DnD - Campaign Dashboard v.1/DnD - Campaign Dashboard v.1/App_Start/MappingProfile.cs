﻿using AutoMapper;
using DnD___Campaign_Dashboard_v._1.DTOs;
using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Spell, SpellDTO>();

            CreateMap<SpellDTO, Spell>();
        }
    }
    public class MappingConfig
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
           {
               cfg.AddProfile<MappingProfile>();
           });
            return config;
        }
    }
}