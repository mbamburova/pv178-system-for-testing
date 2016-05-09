using Riganti.Utils.Infrastructure.Core;
using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;

namespace BL.Queries {
    public class StudentListQuery : AppQuery<StudentDTO> {

        public StudentFilter Filter { get; set; }
        public StudentListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<StudentDTO> GetQueryable() {
            IQueryable<Student> query = Context.Students;

            if (!string.IsNullOrEmpty(Filter.StudentName)) {
                query = Context.Students.Where(s => s.Name == Filter.StudentName);
            }

            if (Filter.StudentGroupId > 0) {
                query = Context.Students.Where(s => s.StudentGroup.Id == Filter.StudentGroupId);
            }

            return query.ProjectTo<StudentDTO>();
        }
    }
}
