using HRProject.Areas.Structure.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Services
{
    public class StructureService
    {
        private readonly HRContext _context;
        public StructureService(HRContext context)
        {
            _context = context;
        }

        public StructureDTO Save(StructureViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToStructureDTO(model);

            if (model.IsNew == true)
            {
                _context.Structures.Add(data);
            }
            else
            {
                _context.Structures.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public StructureViewModel GetById(Guid Id)
        {
            var viewModel = new StructureViewModel();
            var data = _context.Structures.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToStructureViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<StructureDTO> GetAll()
        {

            var data = _context.Structures.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.Structures.Find(id);
            if (company != null)
            {
                _context.Structures.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}

