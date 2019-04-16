using System.Linq;
using System.Threading.Tasks;

namespace CQRSSample.CQRS
{
    interface ICommand
    {
    }

    interface IQuery
    {
    }
    public interface IRequest
    {

    }

    public class EntityBase
    {
        public int Id { get; set; }
    }
    public class DtoBase
    {
        public int Id { get; set; }
    }

    public interface IMediator
    {
        Task<T> Send<T>(IRequest request);
    }
    public class Mediator : IMediator
    {
        public async Task<T> Send<T>(IRequest request)
        {
            var type = typeof(T);
            return await Task.FromResult<T>(default(T));
        }
    }
}
