using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvin.IDP.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(maxLength: 200, nullable: false),
                    Username = table.Column<string>(maxLength: 200, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(maxLength: 250, nullable: false),
                    Value = table.Column<string>(maxLength: 250, nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "Username" },
                values: new object[] { new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), true, "af6c9fda-c9a9-4830-bd64-d2f054aa7d4a", "password", "d860efca-22d9-47fd-8249-791ba61b07c7", "Frank" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "Username" },
                values: new object[] { new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), true, "8800ed72-2085-4f66-b96b-5f57b800dc7f", "password", "b7539694-97e7-4dfe-84da-b4256e1ff5c7", "Claire" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("dbc894c7-47fb-4465-b003-32bc34f4cdf5"), "8c5788f6-21b4-4d03-96ea-94ee75d06460", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("7e9fcfa1-f9ca-44a1-84fd-b6b42e1de4ed"), "e0597de7-198f-400b-b59a-92db6f039d72", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("c857a71c-53f0-4698-b389-69f31a20d771"), "1acf3f79-de8a-48db-8f22-8cee5ee454c3", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("e9d591b7-f545-4059-b807-946da1b3cc43"), "8c6800de-639e-45e4-ae72-23bf5b5152c0", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("604f2d1d-b68b-49de-b35e-34ad3421542b"), "9c86af30-0733-4b54-8235-8f7c80e26fd1", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("7899fba4-0b4c-4010-8e89-62d76c2a8db8"), "3c0e7c22-2598-4b2b-8f15-65ac8b773017", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("599a8d26-3a10-4caf-88de-66722d773b6a"), "46f4dde0-c09b-4184-85e5-c9082a4fa1c6", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("401273d5-1ffd-4d94-a19e-ab3a5af15904"), "21ec915f-a188-4d35-b4d5-e43c77f3651a", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" },
                    { new Guid("80510807-19a1-42eb-a009-e5cc8d8a99c5"), "9425b135-d9aa-4f4c-ae20-59d0b59f9cdd", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("d123ecf1-b438-41c0-9cc1-2c2035f2232a"), "e12c9d8b-f62d-429c-9c9d-56f24d8f3070", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Subject",
                table: "Users",
                column: "Subject",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
