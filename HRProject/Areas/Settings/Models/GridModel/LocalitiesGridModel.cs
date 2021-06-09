using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Models.GridModel
{
    public class LocalitiesGridModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CountryId { get; set; }

        public string CountryName { get; set; }
       }
}
