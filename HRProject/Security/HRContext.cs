using HRProject.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Security
{
    public class HRContext: DbContext
    {
        public HRContext(DbContextOptions<HRContext> dbContextOptions) : base(dbContextOptions) { }

        public virtual DbSet<CompanyDto> Companies  { get; set; }
        public virtual DbSet<ContactTypeDTO> ContactTypes { get; set; }
        public virtual DbSet<CountryDTO> Countries { get; set; }


    }
}
