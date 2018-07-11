using Nuptial.Data;
using Nuptial.Models;
using Nuptial.Services;
using System.Web.Mvc;

namespace Nuptial.Controllers
{
    public class CoupleController : Controller
    {
        Context context = new Context();
        CoupleService service;

        public CoupleController()
        {
            service = new CoupleService(new Data.Repository.CoupleRepository(context));
        }
        // GET: Couple
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult CoupleHome()
        {
            BrideModel bride = BrideModel.Instance;
            GroomModel groom = GroomModel.Instance;

            var couple = service.GetNew();
            couple.Groom = groom.groom;
            couple.Bride = bride.bride;

            return PartialView("_Couple", couple);
        }
    }
}