using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BL.DTOs;
using BL.Queries;
using BL.Repositories;
using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Facades {
    public class StudentGroupFacade : AppFacadeBase {

       // public StudentRepository StudentRepository { get; set; }

        public StudentGroupRepository Repository { get; set; }
        public StudentGroupListQuery StudentGroupListQuery { get; set; }

        protected IQuery<StudentGroupDTO> CreateQuery(StudentGroupFilter filter) {
            var query = StudentGroupListQuery;
            query.Filter = filter;
            return query;
        }

        public List<StudentGroupDTO> GetAllStudentGroups() {
            using (var uow = UnitOfWorkProvider.Create()) {
                return CreateQuery(new StudentGroupFilter() { }).Execute().ToList();
            }
        }
        
        public void UpdateStudentGroup(StudentGroupDTO studentGroup, int[] selectedStudents) {
            throw new NotImplementedException();
        }

        public StudentGroupDTO GetStudentGroupById(int sgId) {
            using (UnitOfWorkProvider.Create()) {
                var studentGroup = Repository.GetById(sgId);
                return Mapper.Map<StudentGroupDTO>(studentGroup);
            }
        }
    }
}
