using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace ApiAspNetCore.Model
{
    public class ProduitContext : DbContext
    {
        public ProduitContext(DbContextOptions<ProduitContext> connProduitdb)
            : base(connProduitdb)
        {
        }

        public DbSet<Produit> produits { get; set; }
    }
}