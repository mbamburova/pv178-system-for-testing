using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.DTOs;
using BL.Queries;
using BL.Repositories;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Facades {
    public class StudentGroupFacade : AppFacadeBase {

        public StudentGroupRepository Repository { get; set; }
        public StudentGroupListQuery StudentGroupListQuery { get; set; }

        protected IQuery<StudentGroupDTO> CreateQuery() {
            var query = StudentGroupListQuery;
            return query;
        }

        public List<StudentGroupDTO> GetAllStudentGroups() {
            using (var uow = UnitOfWorkProvider.Create()) {
                return CreateQuery().Execute().ToList();
            }
        }

        public void UpdateStudentGroup() {
            throw new NotImplementedException();
        }

        public StudentGroupDTO GetStudentGroupById(int sgId) {
            var sGroup = Repository.GetById(sgId);
            return Mapper.Map<StudentGroupDTO>(sGroup);
        }
    

    }
}
