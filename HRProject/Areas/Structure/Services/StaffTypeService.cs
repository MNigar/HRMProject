using HRProject.Areas.Structure.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Services
{
    public class StaffTypeService
    {
        private readonly HRContext _context;
        public StaffTypeService(HRContext context)
        {
            _context = context;
        }

        public StaffTypeDTO Save(StaffTypeViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToStaffTypeDTO(model);

            if (model.IsNew == true)
            {
                _context.StaffTypes.Add(data);
            }
            else
            {
                _context.StaffTypes.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public StaffTypeViewModel GetById(Guid Id)
        {
            var viewModel = new StaffTypeViewModel();
            var data = _context.StaffTypes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToStaffTypeViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<StaffTypeDTO> GetAll()
        {

            var data = _context.StaffTypes.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.StaffTypes.Find(id);
            if (company != null)
            {
                _context.StaffTypes.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}
