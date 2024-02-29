using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostgreDemo.Migrations
{
    /// <inheritdoc />
    public partial class SeedBooksToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", new DateTime(2024, 1, 30, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2025), "A novel about the American Dream during the Roaring Twenties.", "The Great Gatsby", 14.99 },
                    { 2, "Harper Lee", new DateTime(2024, 2, 4, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2034), "A classic novel addressing racial injustice in the American South.", "To Kill a Mockingbird", 19.989999999999998 },
                    { 3, "George Orwell", new DateTime(2024, 2, 9, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2035), "A dystopian novel depicting a totalitarian society.", "1984", 12.99 },
                    { 4, "J.D. Salinger", new DateTime(2024, 2, 11, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2037), "A coming-of-age novel following the experiences of a teenage boy in New York City.", "The Catcher in the Rye", 16.989999999999998 },
                    { 5, "Jane Austen", new DateTime(2024, 2, 14, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2038), "A classic novel exploring issues of love, reputation, and class.", "Pride and Prejudice", 18.989999999999998 },
                    { 6, "J.R.R. Tolkien", new DateTime(2024, 2, 17, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2039), "A fantasy novel that serves as a prelude to The Lord of the Rings trilogy.", "The Hobbit", 22.989999999999998 },
                    { 7, "Gabriel García Márquez", new DateTime(2024, 2, 19, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2042), "A landmark novel in the magical realism genre, exploring the history of the Buendía family.", "One Hundred Years of Solitude", 20.989999999999998 },
                    { 8, "J.R.R. Tolkien", new DateTime(2024, 2, 21, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2043), "An epic high fantasy trilogy that follows the journey to destroy the One Ring.", "The Lord of the Rings", 29.989999999999998 },
                    { 9, "C.S. Lewis", new DateTime(2024, 2, 24, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2044), "A series of seven high fantasy novels set in the fictional world of Narnia.", "The Chronicles of Narnia", 26.989999999999998 },
                    { 10, "Aldous Huxley", new DateTime(2024, 2, 26, 15, 3, 43, 629, DateTimeKind.Utc).AddTicks(2046), "A dystopian novel that explores the dangers of a technologically advanced society.", "Brave New World", 17.989999999999998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
