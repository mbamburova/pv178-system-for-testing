﻿using System;
using System.Data.Entity;
using DAL;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace BL {
    public class AppUnitOfWork : EntityFrameworkUnitOfWork{
        public new StudentsContext Context => (StudentsContext)base.Context;

        public AppUnitOfWork(IUnitOfWorkProvider provider, Func<DbContext> dbContextFactory, DbContextOptions options) : base(provider, dbContextFactory, options) {
        }
    }
}
