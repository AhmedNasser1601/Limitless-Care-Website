using Limitless_Care_Website.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.Data
{
    public class ApplicationContext:IdentityDbContext
    { 
    
        public ApplicationContext(DbContextOptions options) : base(options) { }
    
        public DbSet<Carts> carts { get; set; }

        // Data Of The Cart    
        public DbSet<Section1> Section1 { get; set; }
        public DbSet<Section2> Section2 { get; set; }
        public DbSet<Section3> Section3 { get; set; }        
        public DbSet<Section4> Section4 { get; set; }
        public DbSet<Section5> Section5 { get; set; }
        public DbSet<Section5Details> Section5Details { get; set; }

        //Benefits Need To Ask
        public DbSet<InPatient> inPatients { get; set; }
        public DbSet<OutPatient> outPatients { get; set; }
        public DbSet<Others> Others { get; set; }
        public DbSet<SpecialBenefits> SpecialBenefits { get; set; }

        // Request
        public DbSet<Requests> requests { get; set; }
      
        //Latest Updates 
        public DbSet<Updates>  Updates { get; set; }

        //Meet People
        public DbSet<Peoples> Peoples { get; set; }









        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //}
    }
}
