
using Microsoft.AspNetCore.Mvc;
using My_Portfolio.DAL.Context;

namespace My_Portfolio.ViewComponents
{
    public class _FeatureComponentPartial: ViewComponent

    {
        My_PortfolioContex portfolioContex = new My_PortfolioContex();
        public IViewComponentResult Invoke()
        {
            var value = portfolioContex.Features.ToList ();
            return View(value);  
        }

    }
}
