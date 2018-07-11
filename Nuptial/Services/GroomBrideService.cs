using System;
using Nuptial.Data.Repository;
using Nuptial.Models;
using Nuptial.Models.Data;

namespace Nuptial.Services
{
    public class GroomBrideService : IService<GroomBrideModel>
    {
        public GroomBrideRepository Repo { get; }

        public GroomBrideService(GroomBrideRepository repo)
        {
            Repo = repo;
        }

        public void Delete(int entity)
        {
            Repo.Delete(entity);
            Repo.Commit();
        }

        public GroomBrideModel GetNew()
        {
            var result = Repo.GetNew() ?? new GroomBride();
            var model = DataToModel(result);
            return model;
        }

        public void RollBack(int entity)
        {
            Repo.Rollback(entity);
            Repo.Commit();
        }

        public void Save(GroomBrideModel entity)
        {
            var data = ModelToData(entity);
            Repo.Add(data);
            Repo.Commit();
        }

        public void Update(GroomBrideModel entity)
        {
            var data = ModelToData(entity);
            Repo.Update(data);
            Repo.Commit();
        }

        private GroomBride ModelToData(GroomBrideModel entity)
        {
            return new GroomBride()
            {
                Title = entity.Title,
            };
        }

        private GroomBrideModel DataToModel(GroomBride result)
        {
            return new GroomBrideModel()
            {
                Title = result.Title
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
    }
}