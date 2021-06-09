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
                Description = dto.Description
            };
        }
        internal static StructureDTO ConvertToStructureDTO(StructureViewModel viewModel)
        {
            return new StructureDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,

                Description = viewModel.Description
            };
        }
    }
}
