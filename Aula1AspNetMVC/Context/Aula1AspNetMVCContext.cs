using Aula1AspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula1AspNetMVC.Context
{
    public class Aula1AspNetMVCContext : DbContext
    {
        public Aula1AspNetMVCContext() : base("Aula1AspNetMVCContext")
        {

        }

        // Lista de classes/tabelas para gerenciamento do Entity Framework
        public DbSet<Cliente> Cliente { get; set; }
    }
}