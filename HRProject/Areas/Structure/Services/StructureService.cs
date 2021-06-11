using HRProject.Areas.Structure.Models;
using HRProject.Areas.Structure.Models.GridModel;
using HRProject.Models.DTO;
using HRProject.Security;
using Microsoft.EntityFrameworkCore;
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
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.Structures.Add(data);
            }
            else
            {
                var date = _context.Structures.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
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
        public IQueryable<StructureGridModel> GetAll()
        {

            var result = from structure in _context.Structures
                         join type in _context.StructureTypes
                         on structure.StructureTypeId equals type.Id
                         select new StructureGridModel
                         {
                             Id = structure.Id,
                             Name = structure.Name,
                             Description = structure.Description,
                             StructureTypeName = type.Name,
                             StructureTypeId = type.Id
                         };
            return result;

        }

        public void Remove(Guid? id)
        {
            var data = _context.Structures.Find(id);
            if (data != null)
            {
                _context.Structures.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}

