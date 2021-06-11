using HRProject.Areas.Structure.Services;
using HRProject.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Models
{
    public class ModelConverter
    {
       
        internal static BranchViewModel ConvertToBranchViewModel(BranchDTO dto)
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
        internal static StructureTypeViewModel ConvertToStructureTypeViewModel(StructureTypeDTO dto)
        {
            return new StructureTypeViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }
        internal static StructureTypeDTO ConvertToStructureTypeDTO(StructureTypeViewModel viewModel)
        {
            return new StructureTypeDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
               
                Description = viewModel.Description
            };
        }
        internal static StructureViewModel ConvertToStructureViewModel(StructureDTO dto)
        {
            return new StructureViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                StructureTypeId=dto.StructureTypeId,
            };
        }
        internal static StructureDTO ConvertToStructureDTO(StructureViewModel viewModel)
        {
            return new StructureDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                StructureTypeId = viewModel.StructureTypeId,
                Description = viewModel.Description
            };
        }

        
       internal static StaffTypeViewModel ConvertToStaffTypeViewModel(StaffTypeDTO dto)
        {
            return new StaffTypeViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
               VacationDayLimit=dto.VacationDayLimit
            };
        }
        internal static StaffTypeDTO ConvertToStaffTypeDTO(StaffTypeViewModel viewModel)
        {
            return new StaffTypeDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                VacationDayLimit = viewModel.VacationDayLimit,
                Description = viewModel.Description
            };
        }
        internal static OrganizationStructureViewModel ConvertToOrganizationStructureViewModel(OrganizationStructureDTO dto)
        {
            return new OrganizationStructureViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                BranchId=dto.BranchId,
                ParentBranchId=dto.ParentBranchId,
                OrganizationStructureId=dto.OrganizationStructureId,
                StructureId=dto.StructureId

            };
        }
        internal static OrganizationStructureDTO ConvertToOrganizationStructureDTO(OrganizationStructureViewModel viewModel)
        {
            return new OrganizationStructureDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description,
                BranchId = viewModel.BranchId,
                ParentBranchId = viewModel.ParentBranchId,
                OrganizationStructureId = viewModel.OrganizationStructureId,
                StructureId = viewModel.StructureId

            };
        }
        internal static StaffUnitViewModel ConvertToStaffUnitViewModel(StaffUnitDTO dto)
        {
            return new StaffUnitViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                BranchId=dto.BranchId,
                SalaryMax=dto.SalaryMax,
                SalaryMin=dto.SalaryMin,
                CreatedDate=dto.CreatedDate,
                NeedCount=dto.NeedCount,
                EndDate=dto.EndDate,
                StartDate=dto.StartDate,
                OrderNum=dto.OrderNum,
                OrganizationStructureId = dto.OrganizationStructureId,
                StaffTypeId=dto.StaffTypeId,
                

            };
        }
        internal static StaffUnitDTO ConvertToStaffUnitDTO(StaffUnitViewModel viewModel)
        {
            return new StaffUnitDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description,
                BranchId = viewModel.BranchId,
                SalaryMax = viewModel.SalaryMax,
                SalaryMin = viewModel.SalaryMin,
                CreatedDate = viewModel.CreatedDate,
                NeedCount = viewModel.NeedCount,
                EndDate = viewModel.EndDate,
                StartDate = viewModel.StartDate,
                OrderNum = viewModel.OrderNum,
                OrganizationStructureId = viewModel.OrganizationStructureId,
                StaffTypeId = viewModel.StaffTypeId,
            };
        }
    }
}
