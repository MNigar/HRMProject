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
    public class MartialStatusService
    {
        private readonly HRContext _context;
        public MartialStatusService(HRContext context)
        {
            _context = context;
        }

        public MartialStatusDTO Save(MartialStatusViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToMartialStatusDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.MartialStatuses.Add(data);
            }
            else
            {
                var date = _context.MartialStatuses.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.MartialStatuses.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public MartialStatusViewModel GetById(Guid Id)
        {
            var viewModel = new MartialStatusViewModel();
            var data = _context.MartialStatuses.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToMartialStatusViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<MartialStatusDTO> GetAll()
        {

            var data = _context.MartialStatuses.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.MartialStatuses.Find(id);
            if (data != null)
            {
                _context.MartialStatuses.Remove(data);
                _context.SaveChanges();
            }
        }

    }
}
