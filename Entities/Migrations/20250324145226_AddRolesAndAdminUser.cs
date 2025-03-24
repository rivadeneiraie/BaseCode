using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesAndAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp", "Description" },
                values: new object[] { "f65fed09-726b-45cf-a7af-a86c83b40124", "Admin", "ADMIN", Guid.NewGuid().ToString(), "Admin role" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp", "Description" },
                values: new object[] { "b564d04a-da87-4649-ac91-a3f08adfa7d1", "User", "USER", Guid.NewGuid().ToString(), "User role" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { 
                    "Id", 
                    "UserName", 
                    "NormalizedUserName", 
                    "Email", 
                    "NormalizedEmail", 
                    "PasswordHash", 
                    "SecurityStamp", 
                    "EmailConfirmed", 
                    "PhoneNumberConfirmed",
                    "TwoFactorEnabled",
                    "LockoutEnabled",
                    "AccessFailedCount"
                },
                values: new object[]
                {
                    "c19f43c4-79b5-4d67-8966-c70882cd7be9",
                    "admin@example.com",
                    "ADMIN@EXAMPLE.COM",
                    "admin@example.com",
                    "ADMIN@EXAMPLE.COM",
                    "AQAAAAIAAYagAAAAEHWKzD2jaUtPAGkOENPO7EbZPBVbzEGcdevQxY9QPCbmf57Jjcb5u1Lr5bD1V8II1A==", //qweQWE123!#
                    Guid.NewGuid().ToString(),
                    false,
                    false,
                    false,
                    true,
                    0
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "c19f43c4-79b5-4d67-8966-c70882cd7be9", "f65fed09-726b-45cf-a7af-a86c83b40124" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {            
            
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumn: "UserId",
                keyValue: "c19f43c4-79b5-4d67-8966-c70882cd7be9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Email",
                keyValue: "admin@example.com");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Name",
                keyValue: "Admin");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Name",
                keyValue: "User");
        }
    }
}
