using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSSample.CQRS
{
    interface IQueryAsEnumerableDispatcher<TIn, TOut> : IQuery where TIn : IRequest
                                                               where TOut : IEnumerable<DtoBase>
    {
        Task<TOut> Handle(TIn query);
    }
}
