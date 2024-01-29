using Post.Query.Domain.Entities;
using Post.Query.Domain.Repositories;

namespace Post.Query.Api.Queries
{
    public class QueryHandler : IQueryHandler
    {
        private readonly IPostRepository _postRepository;

        public QueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }


        public async Task<List<PostEntity>> handleAsync(FindAllPostsQuery query)
        {
            return await _postRepository.ListAllAsync();
        }

        public async Task<List<PostEntity>> handleAsync(FindByPostIdQuery query)
        {
            var post = await _postRepository.GetByIdAsync(query.id);
            return new List<PostEntity>{ post };
        }

        public async Task<List<PostEntity>> handleAsync(FindPostsByAuthorQuery query)
        {
            return await _postRepository.ListByAuthorAsync(query.Author);
        }

        public async Task<List<PostEntity>> handleAsync(FindPostsWithCommentQuery query)
        {
            return await _postRepository.ListWithCommentAsync();
        }

        public Task<List<PostEntity>> handleAsync(FindPostWithLikesQuery query)
        {
            return _postRepository.ListWithLikesAsync(query.NumberOfLikes);
        }

    }
}