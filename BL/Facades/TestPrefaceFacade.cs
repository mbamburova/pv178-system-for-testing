using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BL.DTOs;
using BL.Queries;
using BL.Repositories;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Facades {
    public class TestPrefaceFacade : AppFacadeBase  {

        public TestPrefaceRepository Repository { get; set; }
        public TestPrefaceListQuery TestPrefaceListQuery { get; set; }

        protected IQuery<TestPrefaceDTO> CreateQuery() {
            var query = TestPrefaceListQuery;
            return query;
        }

        public List<TestPrefaceDTO> GetAllTestPrefaces() {
            using (UnitOfWorkProvider.Create()) {
                return CreateQuery().Execute().ToList();
            }
        }

        public TestPrefaceDTO GetTestPrefaceById(int tpId) {
            using (UnitOfWorkProvider.Create()) {
                var testPreface = Repository.GetById(tpId);
                return Mapper.Map<TestPrefaceDTO>(testPreface);
            }
        }


    }
}
