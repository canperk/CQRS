using MediatR;
using System.Collections.Generic;

namespace CQRSApiSample.Queries
{
    public class CityRequest : IRequest<CityDTO>
    {
        public CityRequest(int id)
        {
            CityId = id;
        }
        public int CityId { get; }
    }

    public class CityListRequest : IRequest<IEnumerable<CityDTO>>
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}