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
    class TeacherFacade : AppFacadeBase {
        public TeacherRepository Repository { get; set; }
        public TeacherListQuery TeacherListQuery { get; set; }

        protected IQuery<TeacherDTO> CreateQuery() {
            var query = TeacherListQuery;
            return query;
        }

    }
}
