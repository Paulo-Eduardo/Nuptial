using System;
using System.Web;
using Nuptial.Data.Repository;
using Nuptial.Models;
using Nuptial.Models.Data;

namespace Nuptial.Services
{
    public class FooterService : IService<FooterModel>
    {
        public FooterRepository Repo { get; }

        public FooterService(FooterRepository repo)
        {
            Repo = repo;
        }

        public void Delete(int entity)
        {
            Repo.Delete(entity);
            Repo.Commit();
        }

        public FooterModel GetNew()
        {
            var result = Repo.GetNew() ?? new Footer();
            var model = DataToModel(result);
            return model;
        }

        public void RollBack(int entity)
        {
            Repo.Rollback(entity);
            Repo.Commit();
        }

        public void Save(FooterModel entity)
        {
            var data = ModelToData(entity);
            Repo.Add(data);
            Repo.Commit();
        }

        public void Update(FooterModel entity)
        {
            var data = ModelToData(entity);
            Repo.Update(data);
            Repo.Commit();
        }

        private FooterModel DataToModel(Footer result)
        {
            return new FooterModel()
            {
                CopyrightText = result.CopyrightText,
                Dribbble = result.Dribbble,
                Facebook = result.Facebook,
                Instagram = result.Instagram,
                Title = result.Title,
                Twitter = result.Twitter,
                Youtube = result.Youtube
            };
        }

        private Footer ModelToData(FooterModel entity)
        {
            return new Footer()
            {
                CopyrightText = entity.CopyrightText,
                Dribbble = entity.Dribbble,
                Facebook = entity.Facebook,
                Instagram = entity.Instagram,
                Title = entity.Title,
                Twitter = entity.Twitter,
                Youtube = entity.Youtube
            };
        }
    }
}