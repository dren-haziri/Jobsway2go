using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Jobsway2go.Infrastructure.Common;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;

namespace Jobsway2go.Application.Services
{
    public class CollectionService : ICollectionService
    {
        public void Add(Collection entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Remove(Collection entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Collection> entity)
        {
            throw new NotImplementedException();
        }
    }
}
