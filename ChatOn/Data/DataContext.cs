﻿using ChatOn.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatOn.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; Initial Catalog=DBBiblioteca; Integrated Security=SSPI");
        }

        public DbSet<Usuarios> Usuario { get; set; }
      


    }



}
