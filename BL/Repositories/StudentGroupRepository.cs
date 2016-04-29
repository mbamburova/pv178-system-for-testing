using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL.Repositories {
    public class StudentGroupRepository : EntityFrameworkRepository<Category, int> {
        public StudentGroupRepository(IUnitOfWorkProvider provider) : base(provider) {
        }
    }
}
