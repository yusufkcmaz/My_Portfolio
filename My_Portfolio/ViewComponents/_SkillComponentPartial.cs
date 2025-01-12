using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View ();
        }
    }
}
