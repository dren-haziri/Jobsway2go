using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Application.Services
{
    public class JobService : IJobService
    {
        private readonly IApplicationDbContext _context;

        public JobService(IApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Job> ListJobs()
        {
            return _context.Jobs.ToList();

        }

        public Job SearchJob(int jobToSearchId)
        {
            return _context.Jobs.SingleOrDefault(x => x.Id == jobToSearchId);
        }
        public Job FilterByLocation(string jobToSearchLocation)
        {
            return _context.Jobs.SingleOrDefault(x => x.Location == jobToSearchLocation);
        }
        public List<Job> FindAll()
        {
            return _context.Jobs.ToList();
        }

        public void Add(Job entity)
        {
           _context.Jobs.Add(entity);
            _context.SaveChangesAsync();
        }

        public void AddRange(IEnumerable<Job> entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Job entity)
        {
            _context.Jobs.Remove(entity);
            _context.SaveChangesAsync();
        }

        public void RemoveRange(IEnumerable<Job> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Job entity)
        {
            _context.Jobs.Update(entity);
            _context.SaveChangesAsync();
        }

        public void UpdateRange(IEnumerable<Job> entity)
        {
            throw new NotImplementedException();
        }

        public Job GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Job> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Job> Find(Expression<Func<Job, bool>> predicate, params Expression<Func<Job, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Job FindOne(Expression<Func<Job, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }   
}


