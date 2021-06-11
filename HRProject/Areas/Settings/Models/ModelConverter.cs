using HRProject.Areas.Structure.Models;
using HRProject.Models;
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
        

        internal static KnowledgeLevelViewModel ConvertToKnowledgeLevelViewModel(KnowledgeLevelDTO dto)
        {
            return new KnowledgeLevelViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static KnowledgeLevelDTO ConvertToKnowledgeLevelDTO(KnowledgeLevelViewModel viewModel)
        {
            return new KnowledgeLevelDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        

        internal static LanguageViewModel ConvertToLanguageViewModel(LanguageDTO dto)
        {
            return new LanguageViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static LanguageDTO ConvertToLanguageDTO(LanguageViewModel viewModel)
        {
            return new LanguageDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            }; 
        }
        internal static PrivilegeViewModel ConvertToPrivilegeViewModel(PrivilegeDTO dto)
        {
            return new PrivilegeViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static PrivilegeDTO ConvertToPrivilegeDTO(PrivilegeViewModel viewModel)
        {
            return new PrivilegeDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            }; 
        }
        
       internal static RelationshipTypeViewModel ConvertToRelationshipTypeViewModel(RelationshipTypeDTO dto)
        {
            return new RelationshipTypeViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static RelationshipTypeDTO ConvertToRelationshipTypeDTO(RelationshipTypeViewModel viewModel)
        {
            return new RelationshipTypeDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static SkillViewModel ConvertToSkillViewModel(SkillDTO dto)
        {
            return new SkillViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static SkillDTO ConvertToSkillDTO(SkillViewModel viewModel)
        {
            return new SkillDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static SpecialitieViewModel ConvertToSpecialitieViewModel(SpecialitieDTO dto)
        {
            return new SpecialitieViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static SpecialitieDTO ConvertToSpecialitieDTO(SpecialitieViewModel viewModel)
        {
            return new SpecialitieDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static WorkTypeViewModel ConvertToWorkTypeViewModel(WorkTypeDTO dto)
        {
            return new WorkTypeViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description

            };
        }
        internal static WorkTypeDTO ConvertToWorkTypeDTO(WorkTypeViewModel viewModel)
        {
            return new WorkTypeDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
        internal static ExcludedDayViewModel ConvertToExcludedDayViewModel(ExcludedDayDTO dto)
        {
            return new ExcludedDayViewModel
            {
                Id = dto.Id,
                HolidayDate=dto.HolidayDate,
                IsHoliday=dto.IsHoliday,                
                Description = dto.Description

            };
        }
        internal static ExcludedDayDTO ConvertToExcludedDayDTO(ExcludedDayViewModel viewModel)
        {
            return new ExcludedDayDTO
            {
                Id = viewModel.Id,
                HolidayDate = viewModel.HolidayDate,
                IsHoliday = viewModel.IsHoliday,
                Description = viewModel.Description
            };
        }
        internal static TransportViewModel ConvertToTransportViewModel(TransportDTO dto)
        {
            return new TransportViewModel
            {
                Id = dto.Id,
                Name=dto.Name,
                Description = dto.Description

            };
        }
        internal static TransportDTO ConvertToTransportDTO(TransportViewModel viewModel)
        {
            return new TransportDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
    }
}
