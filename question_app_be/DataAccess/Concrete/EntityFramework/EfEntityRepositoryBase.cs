using Core.Utilities.ExceptionHandler;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete.Dto.Response;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                try
                {
                    var ent = context.Entry(entity);
                    ent.State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new GenericException(ErrorResponse.NOT_FOUND);
                }
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                try
                {
                    var ent = context.Entry(entity);
                    ent.State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new GenericException(ErrorResponse.DELETE_FAILED);
                }
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                TEntity entity = context.Set<TEntity>().SingleOrDefault(filter);

                if (entity == null)
                {
                    throw new GenericException(ErrorResponse.NOT_FOUND);
                }

                return entity;
            }
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                    var ent = context.Entry(entity);
                    ent.State = EntityState.Modified;
                    context.SaveChanges();
            }
        }
    }
}
