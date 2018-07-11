using Nuptial.Data;
using Nuptial.Models;
using Nuptial.Services;
using System.Web.Mvc;

namespace Nuptial.Controllers
{
    public class GroomBrideController : Controller
    {
        Context context = new Context();
        GroomBrideService service;

        public GroomBrideController()
        {
            service = new GroomBrideService(new Data.Repository.GroomBrideRepository(context));
        }

        // GET: GroomBride
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GroomBride()
        {
            var groomBrideModel = service.GetNew();
            groomBrideModel.Groom = GroomModel.Instance.groom;
            groomBrideModel.Bride = BrideModel.Instance.bride;

            return PartialView("_GroomBride", groomBrideModel);
        }
    }
}