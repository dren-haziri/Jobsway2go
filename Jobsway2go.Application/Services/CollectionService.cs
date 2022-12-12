using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;

namespace Jobsway2go.Application.Services
{
    public class CollectionService : ICollectionService
    {
        private readonly IApplicationDbContext _context;

        public CollectionService(IApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Collection entity)
        {
            _context.Collections.Add(entity);
            _context.SaveChangesAsync();
        }

        public void AddRange(IEnumerable<Collection> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Collection> Find(Expression<Func<Collection, bool>> predicate, params Expression<Func<Collection, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Collection FindOne(Expression<Func<Collection, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Collection> GetAll()
        {
            throw new NotImplementedException();
        }

        public Collection GetById(int id)
        {
            return _context.Collections.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Collection entity)
        {
            var collection = _context.Collections.FirstOrDefault(g => g.Id == entity.Id);
            if (collection != null)
            {
                _context.Collections.Remove(collection);
                _context.SaveChangesAsync();
            }
        }

        public void RemoveRange(IEnumerable<Collection> entity)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void SaveToCollection()
        {
            throw new NotImplementedException();
        }

        public void Update(Collection entity)
        {
            var collection = _context.Collections.FirstOrDefault(x => x.Id == entity.Id);
            if (collection != null)
            {
                collection.User = entity.User;
                collection.Name = entity.Name;
                collection.Job = entity.Job;
                collection.Post = entity.Post;
                _context.Collections.Update(collection);
                _context.SaveChangesAsync();
            }
        }

        public void UpdateRange(IEnumerable<Collection> entity)
        {
            throw new NotImplementedException();
        }
    }
}
