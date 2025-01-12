using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
    public class _StatsComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }

    }
}
