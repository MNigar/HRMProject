using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Models.DTO
{
    public class ExcludedDayDTO
    {
        public Guid Id { get; set; }
        public DateTime HolidayDate { get; set; }
        public bool IsHoliday { get; set; }
        public string Description { get; set; }
        public bool IsNew { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
