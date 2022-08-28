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





        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //}
    }
}
