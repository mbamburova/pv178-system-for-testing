using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
