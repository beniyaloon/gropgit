using gropgit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Net.WebRequestMethods;

namespace gropgit.DAL
{
    public class DataLayer : DbContext
    {
        public DataLayer(string ConnectionString) : base(GetOptions(ConnectionString))
        {
            Database.EnsureCreated();
            Seed();
        }
        private void Seed()
        {
            if (Shoes.Any()) return;
            Shoe shoe =new Shoe { measure= 54, Color= "שחור", brand= "נייק", Image= "https://www.jdsports.co.il/cdn/shop/products/jd_FV5951-001_a_1000x.jpg?v=1710057777" };
            Shoes.Add(shoe);
            SaveChanges();
        }
        private static DbContextOptions GetOptions(string ConnectionString)
        {
            return new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
        }
        public DbSet<Shoe> Shoes { get; set; }
        //public DbSet<Shelf> shelfs { get; set; }
        //public DbSet<Book> Books { get; set; }
    }
}
