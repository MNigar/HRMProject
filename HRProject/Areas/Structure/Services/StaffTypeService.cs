using HRProject.Areas.Structure.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using Microsoft.EntityFrameworkCore;
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
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.StaffTypes.Add(data);
            }
            else
            {
                var date = _context.StaffTypes.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
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
            var data = _context.StaffTypes.Find(id);
            if (data != null)
            {
                _context.StaffTypes.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
