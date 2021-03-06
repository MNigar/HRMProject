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
    public class DismissalTypesService
    {
        private readonly HRContext _context;
        public DismissalTypesService(HRContext context)
        {
            _context = context;
        }

        public DismissalTypeDTO Save(DismissalTypeViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToDismissalTypeDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.DismissalTypes.Add(data);
            }
            else
            {
                var date = _context.DismissalTypes.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.DismissalTypes.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public DismissalTypeViewModel GetById(Guid Id)
        {
            var viewModel = new DismissalTypeViewModel();
            var data = _context.DismissalTypes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToDismissalTypeViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<DismissalTypeDTO> GetAll()
        {

            var data = _context.DismissalTypes.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.DismissalTypes.Find(id);
            if (data != null)
            {
                _context.DismissalTypes.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
