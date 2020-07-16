namespace blog.data.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Post : CoreEntity
    {
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FullName { get; set; }

        // navigation property
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; } // bir post bir kategoriye ait olabilir

        public virtual ICollection<PostImage> PostImage { get; set; }
    }
}