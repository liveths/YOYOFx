﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOYO.AspNetCore.Owin;

namespace YOYO.AspNetCore.Mvc
{
    public interface IActionResult
    {

        Task ProcessAsync(IOwinContext context);

    }
}
