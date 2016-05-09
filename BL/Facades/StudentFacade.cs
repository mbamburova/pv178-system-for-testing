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
    public class StudentFacade : AppFacadeBase {
        
        public StudentGroupRepository StudentGroupRepository { get; set; }

        public StudentRepository Repository { get; set; }
        public StudentListQuery StudentListQuery { get; set; }


        protected IQuery<StudentDTO> CreateQuery(StudentFilter filter) {
            var query = StudentListQuery;
            query.Filter = filter;
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
                return CreateQuery(new StudentFilter()).Execute().ToList();
            }
        }
        
        public void CreateStudent(StudentDTO student, int studentGroupId) {

            using (var uow = UnitOfWorkProvider.Create()) {
                var dalStudent = Mapper.Map<Student>(student);

                if (studentGroupId > 0) {
                    dalStudent.StudentGroup = StudentGroupRepository.GetById(studentGroupId);
                }   
                Repository.Insert(dalStudent);
                uow.Commit();
            }
        }

        public void UpdateStudent(StudentDTO student, int studentGroupId) {

            using (var uow = UnitOfWorkProvider.Create()) {

                var appStudent = Mapper.Map<Student>(student);
                if (studentGroupId > 0) {
                    appStudent.StudentGroup = StudentGroupRepository.GetById(studentGroupId);
                }
                Repository.Update(appStudent);
                uow.Commit();
            }
        }

    
        public List<StudentDTO> GetStudentsByStudentGroup(int studentGroupId) {
            using (var uow = UnitOfWorkProvider.Create()) {
                return CreateQuery(new StudentFilter() {StudentGroupId = studentGroupId}).Execute().ToList();
            }
        } 
    } 
}
