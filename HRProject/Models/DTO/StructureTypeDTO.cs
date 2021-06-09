using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Models.DTO
{
    public class StructureTypeDTO:BaseDTO
    {
        public StructureTypeDTO()
        {
            Structures = new HashSet<StructureDTO>();
        }
        public ICollection<StructureDTO> Structures { get; set; }
    }
}
