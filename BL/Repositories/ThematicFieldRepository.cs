using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL.Repositories {
    public class ThematicFieldRepository : EntityFrameworkRepository<ThematicField, int> {
        public ThematicFieldRepository(IUnitOfWorkProvider provider) : base(provider) {
        }
    }
}
