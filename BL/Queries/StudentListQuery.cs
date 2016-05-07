using Riganti.Utils.Infrastructure.Core;
using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;

namespace BL.Queries {
    public class StudentListQuery : AppQuery<StudentDTO> {
        public StudentListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<StudentDTO> GetQueryable() {
            IQueryable<Student> query = Context.Students;
            return query.ProjectTo<StudentDTO>().AsQueryable();
        }
    }
}
