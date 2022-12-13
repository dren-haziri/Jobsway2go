using Jobsway2go.Core.Enums;
using Jobsway2go.Core.Models;

namespace Jobsway2go.Core.Interfaces;

public interface IPostService : IRepository<Post>
{
    void SearchPost(string searchTerm); 
    void FilterByType(PostType type);
}