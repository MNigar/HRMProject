using HRProject.Areas.Structure.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Services
{
    public class BranchService
    {
        private readonly HRContext _context;
        public BranchService(HRContext context)
        {
            _context = context;
        }

        public BranchDTO Save(BranchViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToBranchDTO(model);

            if (model.IsNew == true)
            {
                _context.Branches.Add(data);
            }
            else
            {
                _context.Branches.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public BranchViewModel GetById(Guid Id)
        {
            var viewModel = new BranchViewModel();
            var data = _context.Branches.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToBranchViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<BranchDTO> GetAll()
        {

            var data = _context.Branches.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.Branches.Find(id);
            if (company != null)
            {
                _context.Branches.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}
