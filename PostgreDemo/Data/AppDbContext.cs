// Data/AppDbContext.cs

using PostgreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace PostgreDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Name = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Description = "A novel about the American Dream during the Roaring Twenties.",
                    Price = 14.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-30)
                },
                new Book
                {
                    Id = 2,
                    Name = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Description = "A classic novel addressing racial injustice in the American South.",
                    Price = 19.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-25)
                },
                new Book
                {
                    Id = 3,
                    Name = "1984",
                    Author = "George Orwell",
                    Description = "A dystopian novel depicting a totalitarian society.",
                    Price = 12.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-20)
                },
                new Book
                {
                    Id = 4,
                    Name = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    Description = "A coming-of-age novel following the experiences of a teenage boy in New York City.",
                    Price = 16.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-18)
                },
                new Book
                {
                    Id = 5,
                    Name = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Description = "A classic novel exploring issues of love, reputation, and class.",
                    Price = 18.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-15)
                },
                new Book
                {
                    Id = 6,
                    Name = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Description = "A fantasy novel that serves as a prelude to The Lord of the Rings trilogy.",
                    Price = 22.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-12)
                },
                new Book
                {
                    Id = 7,
                    Name = "One Hundred Years of Solitude",
                    Author = "Gabriel García Márquez",
                    Description = "A landmark novel in the magical realism genre, exploring the history of the Buendía family.",
                    Price = 20.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-10)
                },
                new Book
                {
                    Id = 8,
                    Name = "The Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    Description = "An epic high fantasy trilogy that follows the journey to destroy the One Ring.",
                    Price = 29.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-8)
                },
                new Book
                {
                    Id = 9,
                    Name = "The Chronicles of Narnia",
                    Author = "C.S. Lewis",
                    Description = "A series of seven high fantasy novels set in the fictional world of Narnia.",
                    Price = 26.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-5)
                },
                new Book
                {
                    Id = 10,
                    Name = "Brave New World",
                    Author = "Aldous Huxley",
                    Description = "A dystopian novel that explores the dangers of a technologically advanced society.",
                    Price = 17.99,
                    CreatedAt = DateTime.UtcNow.AddDays(-3)
                }
                );
        }
    }
}