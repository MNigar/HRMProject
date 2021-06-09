using HRProject.Areas.Structure.Models;
using HRProject.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Models
{
    public class StructureViewModel:BaseViewModel
    {
        public Guid? StructureTypeId { get; set; }
        public StructureTypeViewModel StructureType { get; set; }
    }
}
