using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Queries {
    class StudentListQuery : AppQuery<StudentDTO> {
        public StudentListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<StudentDTO> GetQueryable() {
            IQueryable<Student> query = Context.Students;
            return query.ProjectTo<StudentDTO>();
        }
    }
}
