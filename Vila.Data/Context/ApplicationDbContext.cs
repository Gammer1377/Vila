﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vila.Data.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UserFluentConfigs());
            //modelBuilder.ApplyConfiguration(new RoleFluentConfigs());
            //modelBuilder.ApplyConfiguration(new UserRoleFluentConfigs());
        }

        #region DbSets



        #endregion
    }
}
