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
    class StudentFacade : AppFacadeBase {

        public StudentRepository Repository { get; set; }
        public StudentListQuery StudentListQuery { get; set; }

        protected IQuery<StudentDTO> CreateQuery() {
            var query = StudentListQuery;
            return query;
        }

        public StudentDTO GetStudentById(int studentId) {
            using (UnitOfWorkProvider.Create()) {
                var student = Repository.GetById(studentId);
                return Mapper.Map<StudentDTO>(student);
            }
        }

        public List<StudentDTO> GetAllStudents() {
            using (var uow = UnitOfWorkProvider.Create()) {
                return CreateQuery().Execute().ToList();
            }
        }

        public List<StudentDTO> GetStudentsByStudentsGroups() {
            throw new NotImplementedException();
        } 

    }
}
