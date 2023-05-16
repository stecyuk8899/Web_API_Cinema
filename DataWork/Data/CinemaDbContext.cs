using DataWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataWork.Data
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Session>().HasData(new[]
            {
                new Session(){Id = 1, NameFilm = "Schedryck", Price = 100, Hall = "Alpha", Start = new DateTime(2023, 06, 01, 15, 0, 0), End = new DateTime(2023, 06, 01, 17, 40, 0)},
                new Session(){Id = 2, NameFilm = "Sky wars", Price = 50, Hall = "Beta", Start = new DateTime(2023, 06, 01, 15, 0, 0), End = new DateTime(2023, 06, 01, 18, 25, 0)},
                new Session(){Id = 3, NameFilm = "Skazhene vesillya", Price = 80, Hall = "Alpha", Start = new DateTime(2023, 06, 04, 15, 0, 0), End = new DateTime(2023, 06, 01, 18, 0, 0)},
                new Session(){Id = 4, NameFilm = "Titanic", Price = 100, Hall = "Beta", Start = new DateTime(2023, 06, 09, 9, 0, 0), End = new DateTime(2023, 06, 01, 12, 40, 0)}
            });
            modelBuilder.Entity<Actor>().HasData(new[]
            {
                new Actor(){Id = 1, Country = "Canada", DateBirth = new DateTime(1980, 11, 12), Name = "Rayan Gosling", Raiting = 10},
                new Actor(){Id = 2, Country = "UK", DateBirth = new DateTime(1955, 11, 6), Name = "Rowan Atkinson", Raiting = 10},
                new Actor(){Id = 3, Country = "UK", DateBirth = new DateTime(1967, 07, 26), Name = "Jason Statham", Raiting = 9},
            });
        }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}
