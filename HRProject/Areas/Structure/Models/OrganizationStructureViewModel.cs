using HRProject.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Models
{
    public class OrganizationStructureViewModel:BaseViewModel
    {
        public Guid? OrganizationStructureId { get; set; }
        public virtual OrganizationStructureViewModel OrganizationStructure { get; set; }
        public Guid StructureId { get; set; }
        public virtual StructureViewModel Structure { get; set; }
        public virtual BranchViewModel Branch { get; set; }
        public Guid BranchId { get; set; }
        public virtual BranchViewModel ParentBranch { get; set; }
        public Guid? ParentBranchId { get; set; }
    }
}
