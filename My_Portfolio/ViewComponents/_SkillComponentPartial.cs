using Microsoft.AspNetCore.Mvc;
using My_Portfolio.DAL.Context;

namespace My_Portfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        My_PortfolioContex contex = new My_PortfolioContex();
        public IViewComponentResult Invoke()
        {
            var value = contex.Skills.ToList();
            return View (value);
        }
    }
}
