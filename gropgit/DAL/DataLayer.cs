using gropgit.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace gropgit.DAL
{
    public class DataLayer : DbContext
    {
        public DataLayer(string ConnectionString) : base(GetOptions(ConnectionString))
        {
            Database.EnsureCreated();
            Seed(54,"שחור","נייק","https://www.jdsports.co.il/cdn/shop/products/jd_FV5951-001_a_1000x.jpg?v=1710057777");
        }
        private void Seed(int measure,string Color,string brand ,string Image)
        {
            if (Shoes.Any()) return;
            Shoe library = new Shoe { measure = measure , Color = Color , brand = brand , Image = Image };
            Shoes.Add(library);
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
