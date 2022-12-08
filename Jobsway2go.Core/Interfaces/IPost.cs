using Jobsway2go.Core.Models;

namespace Jobsway2go.Core.Interfaces;

public interface IPost : IRepository<Post>
{
    public void SearchPost();
    public void FilterByType(PostType type);
}