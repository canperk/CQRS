using Microsoft.AspNetCore.Mvc;

namespace CQRSApiSample.Queries
{
    public class CityDTO
    {
        public ActionResult<string> Name { get; internal set; }
    }
}