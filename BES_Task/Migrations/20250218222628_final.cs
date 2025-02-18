using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BES_Task.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$NljoZb81GHCKXognR8mM9OlJmr7qCMCVEdjadCwp0KF0oyigGeFUO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$ckPnNw6SC1A4ap3QYwksUuW4pl6ItQs6INTXqC7gBZNGtxlo8A5YO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$yJZE8rYW.4G00T7YMduZKOVL0Dd.beyeilAuKVgfhVptNqMBryemu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$o9HeWoxUak0g1x/NDf8CQO.9SgxE5.qNp9K/yrO9mMnFiSYbzgBZC");
        }
    }
}
