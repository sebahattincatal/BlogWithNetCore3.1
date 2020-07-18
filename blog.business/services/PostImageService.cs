namespace blog.business.services
{
    using data.models;
    using data.context;
    using repositories;
    using System;

    public class PostImageService : Repository<PostImage>, IPostImageRepository
    {
        public PostImageService(blogcontext context) : base(context)
        {
            
        }

        public void SetFalse(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}