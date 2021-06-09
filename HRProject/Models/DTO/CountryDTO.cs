using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Models.DTO
{
    public class CountryDTO : BaseDTO
    {
        public CountryDTO()
        {
            Localities = new HashSet<LocalitiesDTO>();
        }
        public ICollection<LocalitiesDTO> Localities { get; set; }
    }
}
