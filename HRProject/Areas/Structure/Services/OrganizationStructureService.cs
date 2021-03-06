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
    public class OrganizationStructureService
    {
        private readonly HRContext _context;
        public OrganizationStructureService(HRContext context)
        {
            _context = context;
        }

        public OrganizationStructureDTO Save(OrganizationStructureViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToOrganizationStructureDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.OrganizationStructures.Add(data);
            }
            else
            {
                var date = _context.OrganizationStructures.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.OrganizationStructures.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public OrganizationStructureViewModel GetById(Guid Id)
        {
            var viewModel = new OrganizationStructureViewModel();
            var data = _context.OrganizationStructures.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToOrganizationStructureViewModel(data);
            }
            return viewModel;

        }
       
            public IQueryable<OrganizationStructureGridModel> GetAll()
            {
            var result = from org in _context.OrganizationStructures
                         join strc in _context.Structures
                         on org.StructureId equals strc.Id
                         join branch in _context.Branches
                         on org.BranchId equals branch.Id                          
                         join parentBranch in _context.Branches
                         on org.ParentBranchId equals parentBranch.Id into parentBranchS
                         from parentBranch in parentBranchS.DefaultIfEmpty()
                         join self in _context.OrganizationStructures
                         on org.OrganizationStructureId equals self.Id into selfs
                         from self in selfs.DefaultIfEmpty()
                         select new OrganizationStructureGridModel
                         {
                             Id = org.Id,
                             Name = org.Name,
                             Description = org.Description,
                             BranchName = branch.Name,
                             StructureName = strc.Name,
                             OrganizationStructureName = self.Name,
                             ParentBranchName = parentBranch.Name

                         };
            return result;

            
        }

        public void Remove(Guid? id)
        {
            var data = _context.OrganizationStructures.Find(id);
            if (data != null)
            {
                _context.OrganizationStructures.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
