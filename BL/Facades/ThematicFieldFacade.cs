﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BL.DTOs;
using BL.Queries;
using BL.Repositories;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Facades {
    public class ThematicFieldFacade : AppFacadeBase {

        public ThematicFieldRepository Repository { get; set; }
        public ThematicFieldListQuery ThematicFieldListQuery { get; set; }

        protected IQuery<ThematicFieldDTO> CreateQuery(ThematicFieldFilter filter) {
            var query = ThematicFieldListQuery;
            query.Filter = filter;
            return query;
        }

        public List<ThematicFieldDTO> GetAllThematicFields() {
            using (UnitOfWorkProvider.Create()) {
                return CreateQuery(new ThematicFieldFilter() { }).Execute().ToList();
            }
        }

        public ThematicFieldDTO GetThematicFieldById(int tfId) {
            using (UnitOfWorkProvider.Create()) {
                var thematicField = Repository.GetById(tfId);
                return Mapper.Map<ThematicFieldDTO>(thematicField);
            }
        }

        public List<ThematicFieldDTO> GetAllThematicFieldsById() {
            throw new NotImplementedException();
        } 
    }
}
