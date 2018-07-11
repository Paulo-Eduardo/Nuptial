using System;
using System.Collections.Generic;
using Nuptial.Data.Repository;
using Nuptial.Models;
using Nuptial.Models.Data;

namespace Nuptial.Services
{
    public class CoupleService : IService<CoupleModel>
    {
        public CoupleRepository Repo { get; }

        public CoupleService(CoupleRepository repo)
        {
            Repo = repo;
        }

        public CoupleModel GetNew()
        {
            var result = Repo.GetNew() ?? new Couple();
            var model = DataToModel(result);
            return model;
        }

        public void Save(CoupleModel entity)
        {
            var data = ModelToData(entity);
            Repo.Add(data);
            Repo.Commit();
        }

        public void Update(CoupleModel entity)
        {
            var data = ModelToData(entity);
            Repo.Update(data);
            Repo.Commit();
        }

        public void Delete(int entity)
        {
            Repo.Delete(entity);
            Repo.Commit();
        }

        public void RollBack(int entity)
        {
            Repo.Rollback(entity);
            Repo.Commit();
        }

        private Couple ModelToData(CoupleModel entity)
        {
            return new Couple()
            {
                City = entity.City,
                Country = entity.Country,
                Date = entity.Date,
                Title = entity.Title
            };
        }

        private CoupleModel DataToModel(Couple result)
        {
            return new CoupleModel()
            {
                City = result.City,
                Country = result.Country,
                Date = result.Date,
                Title = result.Title
            };
        }

        private Person getPersonData(PersonModel person)
        {
            return new Person()
            {
                Biography = person.Biography,
                Dribbble = person.Dribbble,
                Facebook = person.Facebook,
                FirstName = person.FirstName,
                Instagram = person.Instagram,
                LastName = person.LastName,
                Picture = person.Picture,
                Twitter = person.Twitter,
                Youtube = person.Youtube
            };
        }

        private PersonModel getPersonModel(Person person)
        {
            return new PersonModel()
            {
                Biography = person.Biography,
                Dribbble = person.Dribbble,
                Facebook = person.Facebook,
                FirstName = person.FirstName,
                Instagram = person.Instagram,
                LastName = person.LastName,
                Picture = person.Picture,
                Twitter = person.Twitter,
                Youtube = person.Youtube
            };
        }
    }
}