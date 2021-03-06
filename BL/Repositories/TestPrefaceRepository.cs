﻿using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL.Repositories {
    public class TestPrefaceRepository : EntityFrameworkRepository<TestPreface, int> {
        public TestPrefaceRepository(IUnitOfWorkProvider provider) : base(provider) {
        }
    }
}
