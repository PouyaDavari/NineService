using NineService.DtoModels;
using System.Collections.Generic;

namespace NineService.DAL
{
    public interface ICountryRepository
    {
        IList<ShowDto> GetShows(IList<CountryDto> countries);
    }
}
