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

    }
}
