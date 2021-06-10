using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Models.DTO
{
    public class StaffUnitDTO:BaseDTO
    {
        public Guid OrganizationStructureId { get; set; }
        public Guid StaffTypeId { get; set; }
        public virtual StaffTypeDTO StaffType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? NeedCount { get; set; }
        public decimal? SalaryMin { get; set; }
        public decimal? SalaryMax { get; set; }
        public decimal? OrderNum { get; set; }
        public Guid? BranchId { get; set; }
        public virtual BranchDTO Branch { get; set; }
    }
}
