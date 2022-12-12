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
    public class GroupService : IGroupService
    {
        private readonly IApplicationDbContext _context;

        public GroupService (IApplicationDbContext ctx)
        {
            _context = ctx;
        }
        public void Add(Group entity)
        {
           _context.Groups.Add(entity);
            _context.SaveChangesAsync();
        }

        public void AddRange(IEnumerable<Group> entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Group> Find(Expression<Func<Group, bool>> predicate, params Expression<Func<Group, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Group FindOne(Expression<Func<Group, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Group> GetAll()
        {
            return _context.Groups.ToList();
        }

        public Group GetById(int id)
        {
           return  _context.Groups.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Group entity)
        {
            var group = _context.Groups.FirstOrDefault(g=> g.Id == entity.Id);
            if(group != null)
            {
                _context.Groups.Remove(group);
                _context.SaveChangesAsync();
            }
        }

        public void Delete(int Id)
        {
            var group = _context.Groups.FirstOrDefault(g => g.Id == Id);
            if (group != null)
            {
                _context.Groups.Remove(group);
                _context.SaveChangesAsync();
            }
        }

        public void RemoveRange(IEnumerable<Group> entity)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Group entity)
        {
            var group = _context.Groups.FirstOrDefault(x => x.Id == entity.Id);
            if(group != null)
            {
                group.Name = entity.Name;
                _context.Groups.Update(group);
            }
        }

        public void UpdateRange(IEnumerable<Group> entity)
        {
            throw new NotImplementedException();
        }
    }
}
