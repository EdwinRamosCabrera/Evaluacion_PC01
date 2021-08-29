using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace demomvc.Data
{
    public class ApplicationDbContext: IdentityDbContext

    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
        {
           
        }
         public DbSet<demomvc.Models.Registro>DataProductos{get; set;}        
    }
}