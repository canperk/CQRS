using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSSample.CQRS
{
    public class CityListQuery : IQueryAsEnumerableDispatcher<CityListRequest, IEnumerable<CityDTO>>
    {
        public Task<IEnumerable<CityDTO>> Handle(CityListRequest query)
        {
            throw new NotImplementedException();
        }
    }
}
