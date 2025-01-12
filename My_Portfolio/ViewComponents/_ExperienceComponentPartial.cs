using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
    public class _ExperienceComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
