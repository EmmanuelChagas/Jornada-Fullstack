using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fina.Core.PagedRequest;

namespace Fina.Core.Requests.Transactions
{
    public class GetTransactionsByPeriodRequest : PagedRequests
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}