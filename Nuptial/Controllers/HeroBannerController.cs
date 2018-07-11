using Nuptial.Data;
using Nuptial.Models;
using Nuptial.Services;
using System.Web.Mvc;

namespace Nuptial.Controllers
{
    public class HeroBannerController : Controller
    {
        Context context = new Context();
        HeroBannerService service;

        public HeroBannerController()
        {
            service = new HeroBannerService(new Data.Repository.HeroBannerRepository(context));
        }

        // GET: HeroBanner
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Home()
        {
            var model = service.GetHeroBanner(Data.Models.EnumPage.Home);
            return PartialView("_HeroBanner", model);
        }

        public PartialViewResult GroomBride()
        {
            var model = service.GetHeroBanner(Data.Models.EnumPage.GroomBride);
            return PartialView("_HeroBanner", model);
        }
    }
}