﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreApp.Utilities.Dtos;

namespace WebCoreApp.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
