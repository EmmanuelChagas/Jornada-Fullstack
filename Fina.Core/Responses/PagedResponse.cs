using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    public class PagedResponse<TData> : Response<TData>
    {
        [JsonConstructor]
        public PagedResponse(
            TData data,
            int totalCount, 
            int currentPage = 1, 
            double pageSize = Configuration.defaultPageSize) 
            : base(data)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public PagedResponse(
            TData data,
            int code = Configuration.defaultStatusCode,
            string? message = null)
            : base(data, code, message)
        {
        }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public double PageSize { get; private set; } = Configuration.defaultPageSize;
        public double TotalCount { get; private set; }
        
    }
}