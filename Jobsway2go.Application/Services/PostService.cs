using Jobsway2go.Core.Enums;
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
    public class PostService : IPostService
    {
        private readonly IApplicationDbContext _context;

        public PostService(IApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Post entity)
        {
            _context.Posts.Add(entity);
            _context.SaveChangesAsync();
        }

        public void AddRange(IEnumerable<Post> entity)
        {
            throw new NotImplementedException();
        }

        public void FilterByType(PostType type)
        {
            var posts = _context.Posts.Where(p => p.Type == type);
        }

        public IEnumerable<Post> Find(Expression<Func<Post, bool>> predicate, params Expression<Func<Post, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Post FindOne(Expression<Func<Post, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return _context.Posts.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Post entity)
        {
            var post = _context.Posts.FirstOrDefault(g => g.Id == entity.Id);
            if (post != null)
            {
                _context.Posts.Remove(post);
                _context.SaveChangesAsync();
            }
        }

        public void RemoveRange(IEnumerable<Post> entity)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void SearchPost(string searchTerm)
        {
            var posts = _context.Posts.Where(p => p.Title.Contains(searchTerm));
        }

        public void Update(Post entity)
        {
            var post = _context.Posts.FirstOrDefault(x => x.Id == entity.Id);
            if (post != null)
            {
                post.Title = entity.Title;
                post.Description = entity.Description;
                post.CreatedAtUTC = entity.CreatedAtUTC;
                post.CreatedByUserId = entity.CreatedByUserId;
                post.Type = entity.Type;
                _context.Posts.Update(post);
                _context.SaveChangesAsync();
            }
        }

        public void UpdateRange(IEnumerable<Post> entity)
        {
            throw new NotImplementedException();
        }
    }
}
