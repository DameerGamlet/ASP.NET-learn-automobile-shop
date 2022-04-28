using Microsoft.EntityFrameworkCore;
using ACP_learn.Interfaces;
using ACP_learn.Models;

namespace ACP_learn
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options){

        }

        public DbSet<Car>? Car {get;set;}
        public DbSet<Category>? Categories {get; set;}
    }
}