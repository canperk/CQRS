using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSApiSample.Queries.City.Queries
{
    public class CityListQuery : IRequestHandler<CityListRequest, IEnumerable<CityDTO>>
    {
        public async Task<IEnumerable<CityDTO>> Handle(CityListRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult<IEnumerable<CityDTO>>(new List<CityDTO>());
        }
    }
}
