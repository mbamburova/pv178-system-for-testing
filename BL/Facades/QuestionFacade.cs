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
    class QuestionFacade : AppFacadeBase {

        public QuestionRepository Repository { get; set; }
        public QuestionListQuery QuestionListQuery { get; set; }

        protected IQuery<QuestionDTO> CreateQuery() {
            var query = QuestionListQuery;
            return query;
        }
    }
}
