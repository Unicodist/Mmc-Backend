using Microsoft.ML;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Blog.src.Service.Interface;

namespace Mmc.Blog.src.Service
{
    public class CommentService : ICommentService
    {
        private ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Create(IComment comment)
        {
            var context = new MLContext();
            var data = context.Data.LoadFromEnumerable(await _commentRepository.GetAll());
        }

        public Task Update(IComment comment)
        {
            throw new NotImplementedException();
        }
    }
}
