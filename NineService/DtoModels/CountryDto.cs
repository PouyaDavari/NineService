
using System.Collections.Generic;
using System.ComponentModel;

namespace NineService.DtoModels
{        
    public class CountryDto
    {
        public string Country { get; set; }
        public string Description { get; set; }

        [DefaultValue(false)]
        public bool Drm { get; set; }
        public int? EpisodeCount { get; set; }
        public string Genre { get; set; }
        public ImageDto Image { get; set; }
        public string Language { get; set; }
        public EpisodDto NextEpisode { get; set; }
        public string PrimaryColour { get; set; }
        public IList<SeasonDto> Seasons { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string TvChannel { get; set; }
    }
}