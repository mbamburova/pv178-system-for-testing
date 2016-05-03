﻿using System;
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
    class AnswerFacade : AppFacadeBase {

        public AnswerRepository Repository { get; set; }
        public AnswerListQuery AnswerListQuery { get; set; }

        protected IQuery<AnswerDTO> CreateQuery() {
            var query = AnswerListQuery;
            return query;
        }

        public List<AnswerDTO> GetAllAnswers() {
            using (var uow = UnitOfWorkProvider.Create()) {
                return CreateQuery().Execute().ToList();
            }
        }

        public AnswerDTO GetProductById(int productId) {
            using (var uow = UnitOfWorkProvider.Create()) {
                var appProduct = Repository.GetById(productId);
                return Mapper.Map<AnswerDTO>(appProduct);
            }
        }


    }
}
