using System.Collections.Generic;
using System;

namespace WebApplication1.Models
{
public class Feed
{
    public int FeedId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public DateTime LastUpdated { get; set; }

    public virtual ICollection<Article> Articles { get; set; }
} }

