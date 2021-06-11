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
    public class RelationshipTypeService
    {
        private readonly HRContext _context;
        public RelationshipTypeService(HRContext context)
        {
            _context = context;
        }

        public RelationshipTypeDTO Save(RelationshipTypeViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToRelationshipTypeDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.RelationshipTypes.Add(data);
            }
            else
            {
                var date = _context.RelationshipTypes.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.RelationshipTypes.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public RelationshipTypeViewModel GetById(Guid Id)
        {
            var viewModel = new RelationshipTypeViewModel();
            var data = _context.RelationshipTypes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToRelationshipTypeViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<RelationshipTypeDTO> GetAll()
        {

            var data = _context.RelationshipTypes.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.RelationshipTypes.Find(id);
            if (data != null)
            {
                _context.RelationshipTypes.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
