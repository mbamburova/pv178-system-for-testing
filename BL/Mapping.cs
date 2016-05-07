using AutoMapper;
using BL.DTOs;
using DAL.Entities;

namespace BL {
    public class Mapping {
        public static void Create() {

            Mapper.CreateMap<Answer, AnswerDTO>();
            Mapper.CreateMap<AnswerDTO, Answer>();

            Mapper.CreateMap<Question, QuestionDTO>();
            Mapper.CreateMap<QuestionDTO, Question>();

            Mapper.CreateMap<Student, StudentDTO>();
            Mapper.CreateMap<StudentDTO, Student>();

            Mapper.CreateMap<StudentGroup, StudentGroupDTO>();
            Mapper.CreateMap<StudentGroupDTO, StudentGroup>();

            Mapper.CreateMap<Teacher, TeacherDTO>();
            Mapper.CreateMap<TeacherDTO, Teacher>();

            Mapper.CreateMap<TestPreface, TestPrefaceDTO>();
            Mapper.CreateMap<TestPrefaceDTO, TestPreface>();

            Mapper.CreateMap<ThematicField, ThematicFieldDTO>();
            Mapper.CreateMap<ThematicFieldDTO, ThematicField>();
        }
    }
}
