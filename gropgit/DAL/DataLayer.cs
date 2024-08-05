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
            //Seed("גמרא");
        }
        //private void Seed(string Genre)
        //{
        //    if (librariess.Any()) return;
        //    Library library = new Library { Genre = Genre };
        //    librariess.Add(library);
        //    SaveChanges();
        //}
        private static DbContextOptions GetOptions(string ConnectionString)
        {
            return new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
        }
        public DbSet<Shoe> Shoes { get; set; }
        //public DbSet<Shelf> shelfs { get; set; }
        //public DbSet<Book> Books { get; set; }
    }
}
