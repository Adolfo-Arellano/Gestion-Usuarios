﻿using Microsoft.EntityFrameworkCore;
using UniversityApiBackEnd.Models.DataModels;

namespace UniversityApiBackEnd.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {

        }

        // TODO: Add DBSets (Tables of our Database)
        public DbSet<User>? Users { get; set; }
    }
}
