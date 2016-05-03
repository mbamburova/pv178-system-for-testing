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
    public class StudentGroupListQuery : AppQuery<StudentGroupDTO> {
        public StudentGroupListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<StudentGroupDTO> GetQueryable() {
            IQueryable<StudentGroup> query = Context.StudentGroups;
            return query.ProjectTo<StudentGroupDTO>();
        }
    }
}
