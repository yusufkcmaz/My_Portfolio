﻿using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
