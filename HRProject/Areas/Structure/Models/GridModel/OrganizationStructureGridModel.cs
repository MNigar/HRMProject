using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Models.GridModel
{
    public class OrganizationStructureGridModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? OrganizationStructureId { get; set; }
        public string  OrganizationStructureName { get; set; }
        public Guid StructureId { get; set; }
        public string StructureName { get; set; }
        public string BranchName { get; set; }
        public Guid BranchId { get; set; }
        public string ParentBranchName { get; set; }
        public Guid? ParentBranchId { get; set; }
    }
}
