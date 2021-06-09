﻿using HRProject.Models.DTO;
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
        public virtual DbSet<DismissalTypeDTO>  DismissalTypes { get; set; }
        public virtual DbSet<DocumentTypeDTO> DocumentTypes { get; set; }
        public virtual DbSet<EducationInstituteDTO> EducationInstitutes { get; set; }
        public virtual DbSet<EducationLevelDTO> EducationLevels { get; set; }
        public virtual DbSet<LocalitiesDTO> Localities { get; set; }
        public virtual DbSet<BranchDTO> Branches { get; set; }
        public virtual DbSet<StructureTypeDTO> StructureTypes { get; set; }
        public virtual DbSet<StructureDTO> Structures { get; set; }

    }
}
