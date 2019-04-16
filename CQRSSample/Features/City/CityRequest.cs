namespace CQRSSample.CQRS
{
    public class CityRequest : IRequest
    {
        public CityRequest(int id)
        {
            CityId = id;
        }
        public int CityId { get; }
    }
    public class CityListRequest : IRequest
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
