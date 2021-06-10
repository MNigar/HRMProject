using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Models.DTO
{
    public class OrganizationStructureDTO:BaseDTO
    {
        public Guid? OrganizationStructureId { get; set; }
        public virtual OrganizationStructureDTO OrganizationStructure { get; set; }
        public Guid StructureId { get; set; }
        public virtual StructureDTO Structure { get; set; }
        public virtual BranchDTO Branch { get; set; }
        public Guid BranchId { get; set; }
        public virtual BranchDTO ParentBranch { get; set; }
        public Guid? ParentBranchId { get; set; }
    }
}
