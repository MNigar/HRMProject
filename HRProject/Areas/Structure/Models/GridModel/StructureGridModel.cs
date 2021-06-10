using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Models.GridModel
{
    public class StructureGridModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid StructureTypeId { get; set; }

        public string StructureTypeName { get; set; }
    }
}
