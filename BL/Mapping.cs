using System;
using AutoMapper.Mappers;
using BL.DTOs;
using DAL.Entities;
using static AutoMapper.Mapper;

namespace BL {
    class Mapping {
        public static void Create() {

            CreateMap<Answer, AnswerDTO>();
            CreateMap<AnswerDTO, Answer>();

            CreateMap<Question, QuestionDTO>();
            CreateMap<QuestionDTO, Question>();

            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO, Student>();

            CreateMap<StudentGroup, StudentGroupDTO>();
            CreateMap<StudentGroupDTO, StudentGroup>();

            CreateMap<Teacher, TeacherDTO>();
            CreateMap<TeacherDTO, Teacher>();

            CreateMap<TestPreface, TestPrefaceDTO>();
            CreateMap<TestPrefaceDTO, TestPreface>();

            CreateMap<ThematicField, ThematicFieldDTO>();
            CreateMap<ThematicFieldDTO, ThematicField>();
        }
    }
}
