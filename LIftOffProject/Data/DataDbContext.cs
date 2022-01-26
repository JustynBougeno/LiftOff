using System;
using LiftOffProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LiftOffProject.Data
{
    public class DataDbContext : DbContext 
    {
        public DbSet<CustomerClass> Customers { get; set; }
        public DbSet<PaymentClassInfo> PaymentInfo { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<OrderClass> Order { get; set; }
        

        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<OrderClass>()
        //        .HasKey(o => new { o.orderId, o.customerId });
        //}
    }
}


//using TechJobsPersistent.Models;
//using Microsoft.EntityFrameworkCore;

//namespace TechJobsPersistent.Data
//{
//    public class JobDbContext : DbContext
//    {
//        public DbSet<Job> Jobs { get; set; }
//        public DbSet<Employer> Employers { get; set; }
//        public DbSet<Skill> Skills { get; set; }
//        public DbSet<JobSkill> JobSkills { get; set; }
//        // Create Options for the dataset for each of the things that it pulls in.
//        public JobDbContext(DbContextOptions<JobDbContext> options)
//            : base(options)
//        {
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<JobSkill>()
//                .HasKey(j => new { j.JobId, j.SkillId });
//        }
//    }
//}
