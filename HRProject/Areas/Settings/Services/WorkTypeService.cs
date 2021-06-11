using HRProject.Areas.Settings.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Services
{
    public class WorkTypeService
    {
        private readonly HRContext _context;
        public WorkTypeService(HRContext context)
        {
            _context = context;
        }

        public WorkTypeDTO Save(WorkTypeViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToWorkTypeDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.WorkTypes.Add(data);
            }
            else
            {
                var date = _context.WorkTypes.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.WorkTypes.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public WorkTypeViewModel GetById(Guid Id)
        {
            var viewModel = new WorkTypeViewModel();
            var data = _context.WorkTypes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToWorkTypeViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<WorkTypeDTO> GetAll()
        {

            var data = _context.WorkTypes.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.WorkTypes.Find(id);
            if (data != null)
            {
                _context.WorkTypes.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
