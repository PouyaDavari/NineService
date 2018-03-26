
using System;
using System.Collections.Generic;
using System.Linq;
using NineService.DtoModels;

namespace NineService.DAL
{
    public class CountryRepository : ICountryRepository
    {
        /// <summary>
        /// returns the list of shows based on countries
        /// </summary>
        public IList<ShowDto> GetShows(IList<CountryDto> countries)
        {
            return countries
                    .Where(c => c.Drm && c.EpisodeCount > 0)
                    .Select(c =>
                        new ShowDto
                        {
                            Image = c.Image.ShowImage,
                            Slug = c.Slug,
                            Title = c.Title
                        }
                    ).ToList();
        }
    }
}
