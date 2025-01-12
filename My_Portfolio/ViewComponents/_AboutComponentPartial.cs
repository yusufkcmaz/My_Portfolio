using Microsoft.AspNetCore.Mvc;
using My_Portfolio.DAL.Context;

namespace My_Portfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        My_PortfolioContex portfolioContex = new My_PortfolioContex();
        public IViewComponentResult Invoke()
        {
           //Birden fazla değer çekmek.
           ViewBag.aboutTitle = portfolioContex.Abouts.Select(x => x.Title).FirstOrDefault();
           ViewBag.aboutSubDescription = portfolioContex.Abouts.Select(x => x.SubDescription).FirstOrDefault();
           ViewBag.aboutDetail= portfolioContex.Abouts.Select(x => x.Detail).FirstOrDefault();
            return View();
        }
    }
}
