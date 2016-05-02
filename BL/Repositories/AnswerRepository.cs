using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL.Repositories {
    class AnswerRepository : EntityFrameworkRepository<Category, int> {
        public AnswerRepository(IUnitOfWorkProvider provider) : base(provider) {
        }
    }
}
