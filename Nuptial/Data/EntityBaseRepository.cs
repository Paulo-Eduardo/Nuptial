using Nuptial.Data.Models;
using Nuptial.Models.Data;
using System;
using System.Data.Entity;
using System.Linq;

namespace Nuptial.Data
{
    public class EntityBaseRepository<T> where T : class, IEntityBase
    {
        private readonly Context context;

        public EntityBaseRepository(Context context)
        {
            this.context = context;
        }

        public T GetSingle(int id)
        {
            return context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public HeroBanner GetBanner(EnumPage page)
        {
            var result = context.Set<HeroBanner>().OrderByDescending(x => x.Updated).FirstOrDefault(x => x.Page == page);
            return result ?? new HeroBanner();
        }

        internal Person GetPerson(EnumGroomBride groomBride)
        {
            var result = context.Set<Person>().OrderByDescending(x => x.Updated).FirstOrDefault(x => x.GroomBride == groomBride);
            return result ?? new Person();
        }

        public T GetNew()
        {
            return context.Set<T>().OrderByDescending(x => x.Updated).FirstOrDefault();
        }

        public virtual void Add(T entity)
        {
            entity.Updated = DateTime.Now;
            var dbEntityEntry = context.Entry<T>(entity);
            context.Set<T>().Add(entity);
        }

        public virtual void Update(T entity)
        {
            var item = GetSingle(entity.Id);
            context.Entry(item).CurrentValues.SetValues(entity);
        }

        public virtual void Delete(int entity)
        {
            var item = GetSingle(entity);
            context.Entry(item).State = EntityState.Deleted;
        }

        public virtual void Delete(int[] entityIds)
        {
            foreach (var id in entityIds)
            {
                var item = GetSingle(id);
                context.Entry(item).State = EntityState.Deleted;

            }
        }

        public virtual void Commit()
        {
            context.SaveChanges();
        }

        public void Rollback(int entity)
        {
            var item = GetSingle(entity);
            context.Entry(item).State = EntityState.Unchanged;
        }

    }
}