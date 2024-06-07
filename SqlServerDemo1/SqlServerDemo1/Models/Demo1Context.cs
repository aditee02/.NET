using System;
using System.Collections.Generic;
using EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace SqlServerDemo1.Models;

public partial class Demo1Context : DbContext
{
    public Demo1Context()
    {
    }

    public Demo1Context(DbContextOptions<Demo1Context> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Demo1;Trusted_Connection=True;TrustServerCertificate=True");
    public DbSet<Student_Info1> StudentInfos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
        modelBuilder.Entity<Student_Info1>()
            .HasNoKey();



    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
