using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL.Repositories {
    public class TeacherRepository : EntityFrameworkRepository<Teacher, int> {
        public TeacherRepository(IUnitOfWorkProvider provider) : base(provider) {
        }
    }
}
