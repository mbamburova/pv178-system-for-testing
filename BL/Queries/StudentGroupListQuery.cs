using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Queries {
    public class StudentGroupListQuery : AppQuery<StudentGroupDTO> {
        public StudentGroupFilter Filter { get; set; }

        public StudentGroupListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<StudentGroupDTO> GetQueryable() {
            IQueryable<StudentGroup> query = Context.StudentGroups;

            if (Filter.StudentId > 0) {
                query = Context.StudentGroups.Where(s => s.Students.Any(c => c.Id == Filter.StudentId));
            }
           
            return query.ProjectTo<StudentGroupDTO>();
        }
    }
}
