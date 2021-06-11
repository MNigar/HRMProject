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
    public class PrivilegeService
    {
        private readonly HRContext _context;
        public PrivilegeService(HRContext context)
        {
            _context = context;
        }

        public PrivilegeDTO Save(PrivilegeViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToPrivilegeDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.Privileges.Add(data);
            }
            else
            {
                var date = _context.Privileges.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.Privileges.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public PrivilegeViewModel GetById(Guid Id)
        {
            var viewModel = new PrivilegeViewModel();
            var data = _context.Privileges.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToPrivilegeViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<PrivilegeDTO> GetAll()
        {

            var data = _context.Privileges.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.Privileges.Find(id);
            if (data != null)
            {
                _context.Privileges.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
