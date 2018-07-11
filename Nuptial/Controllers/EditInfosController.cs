using Nuptial.Data;
using Nuptial.Models;
using Nuptial.Services;
using System;
using System.Drawing;
using System.IO;
using System.Web.Mvc;

namespace Nuptial.Controllers
{
    public class EditInfosController : Controller
    {
        Context context = new Context();
        public IService<PersonModel> PersonService { get; }
        public IService<HeroBannerModel> HeroBannerService { get; }
        public IService<GroomBrideModel> GroomBrideService { get; }
        public IService<FooterModel> FooterService { get; }
        public IService<CoupleModel> CoupleService { get; }

        public EditInfosController()
        {
            context.Database.CreateIfNotExists();
            PersonService = new PersonService(new Data.Repository.PersonRepository(context));
            HeroBannerService = new HeroBannerService(new Data.Repository.HeroBannerRepository(context));
            GroomBrideService = new GroomBrideService(new Data.Repository.GroomBrideRepository(context));
            FooterService = new FooterService(new Data.Repository.FooterRepository(context));
            CoupleService = new CoupleService(new Data.Repository.CoupleRepository(context));
        }

        public void Groom(PersonModel model)
        {
            model.GoomBride = Models.Data.EnumGroomBride.Groom;
            PersonService.Save(model);
        }

        public void Bride(PersonModel model)
        {
            model.GoomBride = Models.Data.EnumGroomBride.Bride;
            PersonService.Save(model);
        }

        public void HeroBannerHome(HeroBannerModel model)
        {
            model.Page = Data.Models.EnumPage.Home;
            HeroBannerService.Save(model);
        }

        public void HeroBannerGroomBride(HeroBannerModel model)
        {
            model.Page = Data.Models.EnumPage.GroomBride;
            HeroBannerService.Save(model);
        }

        public void GroomBride(GroomBrideModel model)
        {
            GroomBrideService.Save(model);
        }

        public void Footer(FooterModel model)
        {
            FooterService.Save(model);
        }

        public void Couple(CoupleModel model)
        {
            CoupleService.Save(model);
        }

        public void ImageGroom()
        {
            var file = Request.Files["Image"];
            GroomModel gb = GroomModel.Instance;
            string path = Server.MapPath("~\\images\\");
            file.SaveAs(path + gb.groom.Picture);
        }

        public void ImageBride()
        {
            var file = Request.Files["Image"];
            BrideModel gb = BrideModel.Instance;
            string path = Server.MapPath("~\\images\\");
            file.SaveAs(path + gb.bride.Picture);
        }
    }
}