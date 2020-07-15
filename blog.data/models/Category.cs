namespace blog.data.models {

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Category : CoreEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; } // bir kategorinin birden fazla postu olabilir
    }
}