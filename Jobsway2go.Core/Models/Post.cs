using Jobsway2go.Core.Enums;

namespace Jobsway2go.Core.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAtUTC { get; set; }
    public string CreatedByUserId { get; set; }
    public PostType Type { get; set; }

    public List<CollectionPost> CollectionPost { get; set;}
}