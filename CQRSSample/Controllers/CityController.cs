using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSSample.CQRS;
using Microsoft.AspNetCore.Mvc;

namespace CQRSSample.Controllers
{
    public class CityController : Controller
    {
        private readonly IMediator mediator;

        public CityController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetCities([FromBody]CityListRequest request)
        {
            var result = await mediator.Send<IEnumerable<CityDTO>>(request);
            return Json(result);
        }

        public async Task<IActionResult> GetCity(int id)
        {
            var result = await mediator.Send<CityDTO>(new CityRequest(id));   
            return Json(result);
        }
    }
}