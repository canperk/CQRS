using System;
using System.Threading.Tasks;

namespace CQRSSample.CQRS
{
    public class CityQuery : IQueryDispatcher<CityRequest, CityDTO>
    {
        public Task<CityDTO> Handle(CityRequest query)
        {
            throw new NotImplementedException();
        }
    }
}
