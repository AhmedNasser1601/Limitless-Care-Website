using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.Data
{
    public class ApplicationContext : IdentityDbContext
    {
       public ApplicationContext(DbContextOptions options) : base(options)    { }

   

        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //}
    }
}
