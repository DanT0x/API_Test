﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestDbContext : DbContext
    {
        protected TestDbContext() : base("DBConnectionString")
        {
        }
    }
}
