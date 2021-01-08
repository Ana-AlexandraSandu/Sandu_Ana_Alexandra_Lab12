using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sandu_Ana_Alexandra_Lab12.Models;

namespace Sandu_Ana_Alexandra_Lab12.Data
{
    public class Sandu_Ana_Alexandra_Lab12Context : DbContext
    {
        public Sandu_Ana_Alexandra_Lab12Context (DbContextOptions<Sandu_Ana_Alexandra_Lab12Context> options)
            : base(options)
        {
        }

        public DbSet<Sandu_Ana_Alexandra_Lab12.Models.ShopList> ShopList { get; set; }
    }
}
