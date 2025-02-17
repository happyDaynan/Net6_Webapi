﻿using Microsoft.EntityFrameworkCore;

namespace Net6_Webapi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }   
    }
}
