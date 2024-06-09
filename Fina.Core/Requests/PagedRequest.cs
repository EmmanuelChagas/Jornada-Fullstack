using Fina.Core.Requests;

namespace Fina.Core.PagedRequest
{
    public abstract class PagedRequests : Request
    {
        public int PageNumber { get; set; } = Configuration.defaultPageNumber;
        public int PageSize { get; set; } = Configuration.defaultPageSize;
    }
}