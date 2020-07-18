namespace blog.business.services
{
    using data.models;
    using data.context;
    using repositories;
    public class PostService : Repository<Post>, IPostRepository
    {
        public PostService(blogcontext context) : base(context)
        {
            
        }
    }
}