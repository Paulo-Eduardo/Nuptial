using System;
using Nuptial.Data.Repository;
using Nuptial.Models;
using Nuptial.Models.Data;

namespace Nuptial.Services
{
    public class PersonService : IService<PersonModel>
    {
        public PersonRepository Repo { get; }

        public PersonService(PersonRepository repo)
        {
            Repo = repo;
        }

        public PersonModel GetNew()
        {
            var result = Repo.GetNew();
            var model = DataToModel(result);
            return model;
        }

        internal PersonModel GetPerson(EnumGroomBride groomBride)
        {
            var result = Repo.GetPerson(groomBride);
            return DataToModel(result);
        }

        public void Save(PersonModel entity)
        {
            var data = ModelToData(entity);
            Repo.Add(data);
            Repo.Commit();
        }

        public void Update(PersonModel entity)
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

        private PersonModel DataToModel(Person result)
        {
            return new PersonModel()
            {
                Biography = result.Biography,
                Dribbble = result.Dribbble,
                Facebook = result.Facebook,
                FirstName = result.FirstName,
                Instagram = result.Instagram,
                LastName = result.LastName,
                Picture = result.Picture,
                Twitter = result.Twitter,
                Youtube = result.Youtube,
                GoomBride = result.GroomBride
            };
        }

        private Person ModelToData(PersonModel entity)
        {
            return new Person()
            {
                Biography = entity.Biography,
                Dribbble = entity.Dribbble,
                Facebook = entity.Facebook,
                FirstName = entity.FirstName,
                Instagram = entity.Instagram,
                LastName = entity.LastName,
                Picture = entity.Picture,
                Twitter = entity.Twitter,
                Youtube = entity.Youtube,
                GroomBride = entity.GoomBride
            };
        }
    }
}