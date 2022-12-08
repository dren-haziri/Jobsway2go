using System.Diagnostics;

namespace Jobsway2go.Core.Models;

public class Post
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAtUTC { get; set; }
    public string CreatedByUserId { get; set; }
    public PostType Type { get; set; }
}

public enum PostType
{
    Standard, 
    Premium
}