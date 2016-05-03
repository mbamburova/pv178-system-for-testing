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
    class StudentGroupFacade : AppFacadeBase {

        public StudentGroupRepository Repository { get; set; }
        public StudentGroupListQuery StudentGroupListQuery { get; set; }

        protected IQuery<StudentGroupDTO> CreateQuery() {
            var query = StudentGroupListQuery;
            return query;
        }
    }
}
