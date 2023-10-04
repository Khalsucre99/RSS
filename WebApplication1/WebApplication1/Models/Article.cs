using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WebApplication1.Models
{ 
    public class Article
    {
        public int Id { get; set; }  // Primary Key

        public string Title { get; set; }

        public string Link { get; set; }

        public string Guid { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Description { get; set; }

        public string CategoriesString { get; set; }

        [NotMapped]
        public ICollection<string> Categories
        {
            get { return CategoriesString.Split(',').ToList(); }
            set { CategoriesString = string.Join(',', value); }
        }
        // Multiple categories

        public string MediaContent { get; set; }  // Assuming this will hold some content later

        public string Keywords { get; set; }  // Could also be ICollection<string> if you want to split them

        public string Creator { get; set; }

        public string Publisher { get; set; }

        public string Subject { get; set; }

        public string ThumbnailUrl { get; set; }

        public int ThumbnailWidth { get; set; }

        public int ThumbnailHeight { get; set; }

            // Constructor to initialize the Categories collection
            public virtual Feed Feed { get; set; }
        }
}
