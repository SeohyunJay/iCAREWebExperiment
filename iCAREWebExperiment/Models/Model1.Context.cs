﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iCAREWebExperiment.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class iCAREDBWebTestEntities : DbContext
    {
        public iCAREDBWebTestEntities()
            : base("name=iCAREDBWebTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DocumentMetadata> DocumentMetadata { get; set; }
        public virtual DbSet<DrugManagementSystem> DrugManagementSystem { get; set; }
        public virtual DbSet<DrugsDictionary> DrugsDictionary { get; set; }
        public virtual DbSet<GeoCodes> GeoCodes { get; set; }
        public virtual DbSet<iCAREAdmin> iCAREAdmin { get; set; }
        public virtual DbSet<iCAREUser> iCAREUser { get; set; }
        public virtual DbSet<iCAREWorker> iCAREWorker { get; set; }
        public virtual DbSet<ModificationHistory> ModificationHistory { get; set; }
        public virtual DbSet<PatientRecord> PatientRecord { get; set; }
        public virtual DbSet<TreatmentRecord> TreatmentRecord { get; set; }
        public virtual DbSet<UserPassword> UserPassword { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
    }
}
