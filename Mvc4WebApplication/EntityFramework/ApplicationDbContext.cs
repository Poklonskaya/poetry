﻿using Poetry.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc4WebApplication.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Poet> Poets { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}