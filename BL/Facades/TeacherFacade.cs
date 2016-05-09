using BL.DTOs;
using BL.Queries;
using BL.Repositories;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Facades {

    public class TeacherFacade : AppFacadeBase {

        public TeacherRepository Repository { get; set; }
        public TeacherListQuery TeacherListQuery { get; set; }

        protected IQuery<TeacherDTO> CreateQuery() {
            var query = TeacherListQuery;
            return query;
        }
    }
}
