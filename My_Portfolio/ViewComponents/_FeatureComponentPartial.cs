
using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
    public class _FeatureComponentPartial: ViewComponent

    {

        public IViewComponentResult Invoke()
        {
            return View();  
        }

    }
}
