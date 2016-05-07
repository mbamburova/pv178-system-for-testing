using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL.Repositories {
    public class QuestionRepository : EntityFrameworkRepository<Question, int> {
        public QuestionRepository(IUnitOfWorkProvider provider) : base(provider) {
        }
    }
}
