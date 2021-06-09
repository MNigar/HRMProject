using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Models.DTO
{
    public class LocalitiesDTO:BaseDTO
    {
        public Guid CountryId { get; set; }
        public virtual CountryDTO Country { get; set; }
    }
}
