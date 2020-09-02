
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication16.Models;


namespace WebApplication16
{
    public class ApplicationDbContex: DbContext
    {
        public DbSet<Users> Users { get; set; }


        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options)
            : base(options)
        {
        }

    }
}
