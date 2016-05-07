using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL.Repositories {
    public class StudentRepository : EntityFrameworkRepository<Student, int> {
        public StudentRepository(IUnitOfWorkProvider provider) : base(provider) {
        }
    }
}
