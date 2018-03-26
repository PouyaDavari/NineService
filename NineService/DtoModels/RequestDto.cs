
using System.Collections.Generic;

namespace NineService.DtoModels
{
    public class RequestDto
    {
        public IList<CountryDto> Payload { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public int TotalRecords { get; set; }
    }
}