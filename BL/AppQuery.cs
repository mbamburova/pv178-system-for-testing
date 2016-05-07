﻿using DAL;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL {
    public abstract class AppQuery<T> : EntityFrameworkQuery<T> {
        public new StudentsContext Context => (StudentsContext)base.Context;

        public AppQuery(IUnitOfWorkProvider provider) : base(provider) {

        }
    }
}
