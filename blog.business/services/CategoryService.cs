namespace blog.business.services
{
    using data.models;
    using data.context;
    using repositories;
    public class CategoryService : Repository<Category>, ICategoryRepository
    {
        public CategoryService(blogcontext context) : base(context)
        {
            
        }
    }
}