﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DailyHelpMe
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DailyHelpMeDbContext : DbContext
    {
        public DailyHelpMeDbContext()
            : base("name=DailyHelpMeDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Dates> Dates { get; set; }
        public virtual DbSet<InterestedInRegistered> InterestedInRegistered { get; set; }
        public virtual DbSet<RegisteredTo> RegisteredTo { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<ReportType> ReportType { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskInDates> TaskInDates { get; set; }
        public virtual DbSet<TaskTypes> TaskTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VolTypesPreferences> VolTypesPreferences { get; set; }
        public virtual DbSet<VolunteerType> VolunteerType { get; set; }
    }
}
