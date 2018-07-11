using Nuptial.Data;
using Nuptial.Models;
using Nuptial.Services;
using System.Web.Mvc;

namespace Nuptial.Controllers
{
    public class FooterController : Controller
    {
        Context context = new Context();
        FooterService service;

        public FooterController()
        {
            service = new FooterService(new Data.Repository.FooterRepository(context));
        }

        public PartialViewResult Footer()
        {
            var footerModel = service.GetNew();
            return PartialView("_Footer", footerModel);
        }
    }
}