using HRProject.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Models
{
    public class StaffUnitViewModel:BaseViewModel
    {
        public Guid OrganizationStructureId { get; set; }
        public string OrganizationStructureName { get; set; }
        public Guid StaffTypeId { get; set; }
        public string StaffTypeName { get; set; }
        public virtual StaffTypeViewModel StaffType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? NeedCount { get; set; }
        public decimal? SalaryMin { get; set; }
        public decimal? SalaryMax { get; set; }
        public decimal? OrderNum { get; set; }
        public Guid? BranchId { get; set; }
        public string BranchName { get; set; }
        public virtual BranchViewModel Branch { get; set; }
    }
}
