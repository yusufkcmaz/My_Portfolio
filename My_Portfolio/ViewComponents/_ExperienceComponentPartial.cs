using Microsoft.AspNetCore.Mvc;
using My_Portfolio.DAL.Context;

namespace My_Portfolio.ViewComponents
{
    public class _ExperienceComponentPartial: ViewComponent
    {
        My_PortfolioContex contex = new My_PortfolioContex();
        public IViewComponentResult Invoke()
        {
            var value = contex.Experiences.ToList();
            return View(value);
        }

    }
}
