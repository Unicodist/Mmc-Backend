using Microsoft.ML;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Exception;
using Mmc.Blog.Helper;
using Mmc.Blog.MLModel.Comment;
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
            var tx = TransactionScopeHelper.GetInstance;
            ValidateComment(comment);
            tx.Complete();
        }

        private void ValidateComment(IComment comment)
        {
            
            var sampleData = new ToxiCommentFilter.ModelInput()
            {
                Comment_text = comment.Body,
            };
            if (sampleData.Target==1)
            {
                comment.FlagAsSuspicious();
                
            }
        }

        public Task Update(IComment comment)
        {
            throw new NotImplementedException();
        }
        
    }
}
