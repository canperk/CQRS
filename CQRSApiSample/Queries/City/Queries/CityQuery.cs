using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSApiSample.Queries
{
    public class CityQuery : IRequestHandler<CityRequest, CityDTO>
    {
        public async Task<CityDTO> Handle(CityRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult<CityDTO>(new CityDTO());
        }
    }
}