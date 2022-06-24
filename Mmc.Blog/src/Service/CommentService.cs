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
        private readonly IInteractionLogService _interactionLogService;

        public CommentService(ICommentRepository commentRepository, IBlogUserRepository userRepository, IArticleRepository articleRepository, IInteractionLogService interactionLogService)
        {
            _commentRepository = commentRepository;
            _userRepository = userRepository;
            _articleRepository = articleRepository;
            _interactionLogService = interactionLogService;
        }

        public async Task<long> Create(CommentCreateDto c)
        {
            var tx = TransactionScopeHelper.GetInstance;
            var user = await _userRepository.GetByIdAsync(c.UserId) ?? throw new UserNotFoundException();
            var article = await _articleRepository.GetByGuidAsync(c.ArticleGuid)??throw new ArticleNotFoundException();
            var comment = new Comment(c.Body,user,article) {ArticleId = article.Id, UserId = user.Id};
            ValidateComment(comment);
            await _commentRepository.InsertAsync(comment);
            await _interactionLogService.Create(comment);
            tx.Complete();
            return comment.Id;
        }

        private void ValidateComment(Comment comment)
        {
            
            var sampleData = new ToxiCommentFilter.ModelInput
            {
                Comment_text = comment.Body,
            };
            var predicted = ToxiCommentFilter.Predict(sampleData);
            if (predicted.Prediction  > 0)
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
