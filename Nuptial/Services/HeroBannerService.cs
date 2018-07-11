using Nuptial.Data.Models;
using Nuptial.Data.Repository;
using Nuptial.Models;
using Nuptial.Models.Data;

namespace Nuptial.Services
{
    public class HeroBannerService : IService<HeroBannerModel>
    {
        public HeroBannerRepository Repo { get; }

        public HeroBannerService(HeroBannerRepository repo)
        {
            Repo = repo;
        }

        public void Delete(int entity)
        {
            Repo.Delete(entity);
            Repo.Commit();
        }

        
        public HeroBannerModel GetHeroBanner(EnumPage page)
        {
            var result = Repo.GetBanner(page);
            return DataToModel(result);
        }

        public HeroBannerModel GetNew()
        {
            var result = Repo.GetNew();
            var model = DataToModel(result);
            return model;
        }

        public void RollBack(int entity)
        {
            Repo.Rollback(entity);
            Repo.Commit();
        }

        public void Save(HeroBannerModel entity)
        {
            var data = ModelToData(entity);
            Repo.Add(data);
            Repo.Commit();
        }


        public void Update(HeroBannerModel entity)
        {
            var data = ModelToData(entity);
            Repo.Update(data);
            Repo.Commit();
        }

        private HeroBannerModel DataToModel(HeroBanner result)
        {
            return new HeroBannerModel()
            {
                ShowDate = result.ShowDate,
                SubTitle = result.SubTitle,
                Title = result.Title,
                Page = result.Page
            };
        }

        private HeroBanner ModelToData(HeroBannerModel entity)
        {
            return new HeroBanner()
            {
                ShowDate = entity.ShowDate,
                SubTitle = entity.SubTitle,
                Title = entity.Title,
                Page = entity.Page                
            };
        }
    }
}