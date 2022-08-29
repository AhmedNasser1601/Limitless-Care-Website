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
        public DbSet<Digitalization> digitalizations { get; set; }
        public DbSet<DigitalizationDetails> DigitalizationDetails { get; set; }
        public DbSet<Flexibility> flexibility { get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<Benefits> Benefits { get; set; }
        public DbSet<InPatient> inPatients { get; set; }

        public DbSet<OutPatient> outPatients { get; set; }

        public DbSet<Others> Others { get; set; }
        public DbSet<Requests> requests { get; set; }
        public DbSet<SpecialBenefits> SpecialBenefits { get; set; }







        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //}
    }
}
