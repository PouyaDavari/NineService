
using NineService.DAL;
using NineService.DtoModels;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NineService.Controllers
{
    [RoutePrefix("api/v1/country")]
    public class CountryController : ApiController
    {
        ICountryRepository _CountryRepository;

        // Dependency injection
        public CountryController(ICountryRepository countryRepository)
        {
            this._CountryRepository = countryRepository;
        }

        //Post api/v1/country
        [HttpPost]
        [Route("")]
        public HttpResponseMessage PostCountry([FromBody]RequestDto request)
        {
            if (!ModelState.IsValid || request == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Error = "Could not decode request: JSON parsing failed" });

            var shows = _CountryRepository
                            .GetShows(request.Payload)
                            .Skip(request.Skip)
                            .Take(request.Take)
                            .ToList();

            return Request.CreateResponse(HttpStatusCode.OK, new ResponseDto { Response = shows });
        }
    }
}
