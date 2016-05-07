using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL.Repositories {
    public class StudentGroupRepository : EntityFrameworkRepository<StudentGroup, int> {
        public StudentGroupRepository(IUnitOfWorkProvider provider) : base(provider) {
        }
    }
}
