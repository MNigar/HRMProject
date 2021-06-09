using HRProject.Areas.Structure.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Services
{
    public class StructureTypeService
    {
        private readonly HRContext _context;
        public StructureTypeService(HRContext context)
        {
            _context = context;
        }

        public StructureTypeDTO Save(StructureTypeViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToStructureTypeDTO(model);

            if (model.IsNew == true)
            {
                _context.StructureTypes.Add(data);
            }
            else
            {
                _context.StructureTypes.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public StructureTypeViewModel GetById(Guid Id)
        {
            var viewModel = new StructureTypeViewModel();
            var data = _context.StructureTypes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToStructureTypeViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<StructureTypeDTO> GetAll()
        {

            var data = _context.StructureTypes.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.StructureTypes.Find(id);
            if (company != null)
            {
                _context.StructureTypes.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}
