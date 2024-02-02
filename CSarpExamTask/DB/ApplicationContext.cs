﻿using CSarpExamTask.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarpExamTask.DB;

public class ApplicationContext : DbContext
{
    public DbSet<Human> Humans { get; set; } = null!;
    public DbSet<Car> Cars { get; set; } = null!;
    public DbSet<House> Houses { get; set; } = null!;

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Human>().HasKey(c => c.Id);
        modelBuilder.Entity<Car>().HasKey(c => c.Id);
        modelBuilder.Entity<House>().HasKey(c => c.Id);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
}
