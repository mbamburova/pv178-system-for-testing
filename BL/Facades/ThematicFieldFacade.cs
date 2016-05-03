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
    class ThematicFieldFacade : AppFacadeBase {

        public ThematicFieldRepository Repository { get; set; }
        public ThematicFieldListQuery ThematicFieldListQuery { get; set; }

        protected IQuery<ThematicFieldDTO> CreateQuery() {
            var query = ThematicFieldListQuery;
            return query;
        }

        public List<ThematicFieldDTO> GetAllThematicFields() {
            using (UnitOfWorkProvider.Create()) {
                return CreateQuery().Execute().ToList();
            }
        }

        public ThematicFieldDTO GetThematicFieldById(int tfId) {
            using (UnitOfWorkProvider.Create()) {
                var thematicField = Repository.GetById(tfId);
                return Mapper.Map<ThematicFieldDTO>(thematicField);
            }
        }
    }
}
