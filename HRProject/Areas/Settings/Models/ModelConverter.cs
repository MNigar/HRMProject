﻿using HRProject.Areas.Structure.Models;
using HRProject.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Models
{
    public class ModelConverter
    {
        internal static CompanyViewModel ConvertToCompanyViewModel(CompanyDto dto)
        {
            return new CompanyViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }
        internal static CompanyDto ConvertToCompanyDto(CompanyViewModel viewModel)
        {
            return new CompanyDto
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static ContactTypeViewModel ConvertToContactTypeViewModel(ContactTypeDTO dto)
        {
            return new ContactTypeViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }
        internal static ContactTypeDTO ConvertToContactTypeDTO(ContactTypeViewModel viewModel)
        {
            return new ContactTypeDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static CountryViewModel ConvertToCountryViewModel(CountryDTO dto)
        {
            return new CountryViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }
        internal static CountryDTO ConvertToCountryDTO(CountryViewModel viewModel)
        {
            return new CountryDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static DismissalTypeViewModel ConvertToDismissalTypeViewModel(DismissalTypeDTO dto)
        {
            return new DismissalTypeViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }
        internal static DismissalTypeDTO ConvertToDismissalTypeDTO(DismissalTypeViewModel viewModel)
        {
            return new DismissalTypeDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }

        internal static DocumentTypeViewModel ConvertToDocumentTypeViewModel(DocumentTypeDTO dto)
        {
            return new DocumentTypeViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }
        internal static DocumentTypeDTO ConvertToDocumentTypeDTO(DocumentTypeViewModel viewModel)
        {
            return new DocumentTypeDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static EducationInstituteViewModel ConvertToEducationInstituteViewModel(EducationInstituteDTO dto)
        {
            return new EducationInstituteViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }
        internal static EducationInstituteDTO ConvertToEducationInstituteDTO(EducationInstituteViewModel viewModel)
        {
            return new EducationInstituteDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static EducationLevelViewModel ConvertToEducationLevelViewModel(EducationLevelDTO dto)
        {
            return new EducationLevelViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }
        internal static EducationLevelDTO ConvertToEducationLevelDTO(EducationLevelViewModel viewModel)
        {
            return new EducationLevelDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static LocalitiesViewModel ConvertToLocalitiesViewModel(LocalitiesDTO dto)
        {
            return new LocalitiesViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                CountryId=dto.CountryId,
                Description = dto.Description
            };
        }
        internal static LocalitiesDTO ConvertToLocalitiesDTO(LocalitiesViewModel viewModel)
        {
            return new LocalitiesDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                CountryId = viewModel.CountryId,

                Description = viewModel.Description
            };
        }
        internal static BranchViewModel ConvertToBrachViewModel(BranchDTO dto)
        {
            return new BranchViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }
        internal static BranchDTO ConvertToBranchDTO(BranchViewModel viewModel)
        {
            return new BranchDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,

                Description = viewModel.Description
            };
        }
        internal static IssuedOrganizationViewModel ConvertToIssuedOrganizationViewModel(IssuedOrganizationDTO dto)
        {
            return new IssuedOrganizationViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static IssuedOrganizationDTO ConvertToIssuedOrganizationDTO(IssuedOrganizationViewModel viewModel)
        {
            return new IssuedOrganizationDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static MartialStatusViewModel ConvertToMartialStatusViewModel(MartialStatusDTO dto)
        {
            return new MartialStatusViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static MartialStatusDTO ConvertToMartialStatusDTO(MartialStatusViewModel viewModel)
        {
            return new MartialStatusDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        
        internal static PositionViewModel ConvertToPositionViewModel(PositionDTO dto)
        {
            return new PositionViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static PositionDTO ConvertToPositionDTO(PositionViewModel viewModel)
        {
            return new PositionDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
    }
}
