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
    class TestPrefaceFacade : AppFacadeBase  {

        public TestPrefaceRepository Repository { get; set; }
        public TestPrefaceListQuery TestPrefaceListQuery { get; set; }

        protected IQuery<TestPrefaceDTO> CreateQuery() {
            var query = TestPrefaceListQuery;
            return query;
        }
    }
}
