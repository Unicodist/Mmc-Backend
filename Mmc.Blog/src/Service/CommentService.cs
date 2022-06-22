using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Exception;
using Mmc.Blog.Helper;
using Mmc.Blog.MLModel.Comment;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Blog.src.Service
{
    public class CommentService : ICommentService
    {
        private ICommentRepository _commentRepository;
        private readonly IBlogUserRepository _userRepository;
        private readonly IArticleRepository _articleRepository;

        public CommentService(ICommentRepository commentRepository, IBlogUserRepository userRepository, IArticleRepository articleRepository)
        {
            _commentRepository = commentRepository;
            _userRepository = userRepository;
            _articleRepository = articleRepository;
        }

        public async Task<IComment> Create(CommentCreateDto c)
        {
            var tx = TransactionScopeHelper.GetInstance;
            var user = await _userRepository.GetBlogUserById(c.UserId) ?? throw new UserNotFoundException();
            var article = await _articleRepository.GetByGuidAsync(c.ArticleGuid)??throw new ArticleNotFoundException();
            var comment = new Comment(c.Body,user,article);
            ValidateComment(comment);
            tx.Complete();
            return comment;
        }

        private void ValidateComment(Comment comment)
        {
            
            var sampleData = new ToxiCommentFilter.ModelInput()
            {
                Comment_text = comment.Body,
            };
            var predicted = ToxiCommentFilter.Predict(sampleData);
            if (Math.Abs(predicted.Prediction - 1) < 1)
            {
                comment.FlagAsSuspicious();
            }
        }

        public async Task Update(CommentUpdateDto c)
        {
            var tx = TransactionScopeHelper.GetInstance;

            var comment = await _commentRepository.GetByIdAsync(c.Id)??throw new CommentNotFoundException();
            comment.Update(c.Body);
            
            tx.Complete();
        }
        
    }
}
