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
        public readonly Post _post;

        public PostService(Post post)
        {
            _post = post;
        }

        public void Add(Post entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Post> entity)
        {
            throw new NotImplementedException();
        }

        public void FilterByType(PostType type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> Find(Expression<Func<Post, bool>> predicate, 
                                        params Expression<Func<Post, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Post FindOne(Expression<Func<Post, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Post entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Post> entity)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void SearchPost()
        {
            throw new NotImplementedException();
        }

        public void Update(Post entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Post> entity)
        {
            throw new NotImplementedException();
        }
    }
}
