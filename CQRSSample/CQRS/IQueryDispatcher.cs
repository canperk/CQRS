using System.Threading.Tasks;

namespace CQRSSample.CQRS
{
    interface IQueryDispatcher<TIn, TOut> : IQuery where TIn : IRequest 
                                                   where TOut : DtoBase
    {
        Task<TOut> Handle(TIn query);
    }
}
