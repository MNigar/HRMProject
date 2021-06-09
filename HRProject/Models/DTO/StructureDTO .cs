using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Models.DTO
{
    public class StructureDTO:BaseDTO
    {
        public virtual StructureTypeDTO StructureType { get; set; }
        public Guid? StructureTypeId { get; set; }
    }
}
