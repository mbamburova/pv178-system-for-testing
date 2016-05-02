using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL.Repositories {
    public class AnswerRepository : EntityFrameworkRepository<Answer, int> {
        public AnswerRepository(IUnitOfWorkProvider provider) : base(provider) {
        }
    }
}
