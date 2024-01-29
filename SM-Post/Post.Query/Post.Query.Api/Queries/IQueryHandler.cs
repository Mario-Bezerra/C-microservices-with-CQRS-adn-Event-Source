using Post.Query.Domain.Entities;

namespace Post.Query.Api.Queries
{
    public interface IQueryHandler
    {
         Task<List<PostEntity>> handleAsync(FindAllPostsQuery query);
         Task<List<PostEntity>> handleAsync(FindByPostIdQuery query);
         Task<List<PostEntity>> handleAsync(FindPostsByAuthorQuery query);
         Task<List<PostEntity>> handleAsync(FindPostsWithCommentQuery query);
         Task<List<PostEntity>> handleAsync(FindPostWithLikesQuery query);
    }
}