using CQRS.Core.Queries;

namespace Post.Query.Api.Queries
{
    public class FindByPostIdQuery : BaseQuery
    {
        public Guid id { get; set; }
    }
}