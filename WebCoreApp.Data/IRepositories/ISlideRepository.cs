﻿using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApp.Data.Entities;
using WebCoreApp.Infrastructure.Interfaces;

namespace WebCoreApp.Data.IRepositories
{
    public interface ISlideRepository : IRepository<Slide, int>
    {
    }
}