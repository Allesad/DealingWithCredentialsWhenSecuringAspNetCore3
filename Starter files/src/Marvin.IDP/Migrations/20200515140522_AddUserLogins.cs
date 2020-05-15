using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvin.IDP.Migrations
{
    public partial class AddUserLogins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0a74f90c-0630-4035-b542-37d2f262fd8c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0c626567-df4a-4884-8126-ccfc4017c46b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("10f9fa07-4565-46f7-a9b8-b3086dc61162"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("18bd0261-54a4-4e7d-8afd-083672825cd3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3009ab25-7710-404b-82b8-4ba78c715fc4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4b41d953-56f7-4e8a-b597-7e07668204c8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a19eee0d-4e7d-42af-8644-63efab0dec1d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c9847835-583e-4eee-b8e7-1b88016ab5dc"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f4e4630d-5912-4a51-98b2-95e71d897f1d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("fbbef130-af70-466b-a9da-3c6d967c90f8"));

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Provider = table.Column<string>(maxLength: 200, nullable: false),
                    ProviderIdentityKey = table.Column<string>(maxLength: 200, nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("b36f5045-0707-44cf-ae38-584a393070d9"), "ddbf4b8a-77f5-4b30-94c0-20f71e56806d", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("fee91565-706d-4bb4-abb9-9639f9ead35d"), "2febb274-746f-4b4d-adbb-07abeb449da2", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("4cfdc5a0-fac5-4bc3-979b-67224216cee1"), "822e483f-591e-4e9a-be4e-8de73969be88", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("29827587-1d6d-43d7-9ac6-8f6c2f373475"), "58b4a745-3abf-4bd5-8536-a1b81d48e17e", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("d5986e0d-ea65-4767-b4f3-68134f056598"), "28c2d02f-7903-4efc-a9a7-8782947ba999", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("05614e12-7d52-4800-9dc5-68b0c032ceda"), "11a554ce-0f83-4c9c-ab1f-022c0e140eea", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("d448968d-e370-45d3-b88a-5877d8dd0f82"), "b281b4ac-c06a-42d1-b40a-f74c482d42fb", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("0c8cfa28-0c4f-4a7a-a513-20d42166d855"), "ca6080dc-a057-497c-bd53-c7f11d48454c", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" },
                    { new Guid("c15680c4-099f-4a03-a936-9b0571fc646b"), "f7a83cec-9cd1-4c74-a370-745ef7310848", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("dc502737-d779-40af-b25d-375042a1defd"), "8ccddc01-8aa2-4d46-9f21-61b30626f633", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "51043e79-2bfb-4c71-be1d-d081c0c1f354");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "76f2d875-d7a1-44c1-9657-9dcb1373a05f");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("05614e12-7d52-4800-9dc5-68b0c032ceda"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0c8cfa28-0c4f-4a7a-a513-20d42166d855"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("29827587-1d6d-43d7-9ac6-8f6c2f373475"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4cfdc5a0-fac5-4bc3-979b-67224216cee1"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b36f5045-0707-44cf-ae38-584a393070d9"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c15680c4-099f-4a03-a936-9b0571fc646b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d448968d-e370-45d3-b88a-5877d8dd0f82"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d5986e0d-ea65-4767-b4f3-68134f056598"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("dc502737-d779-40af-b25d-375042a1defd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("fee91565-706d-4bb4-abb9-9639f9ead35d"));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("4b41d953-56f7-4e8a-b597-7e07668204c8"), "30bf7565-b633-478e-931c-42f1ccdfadf7", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("f4e4630d-5912-4a51-98b2-95e71d897f1d"), "34fc5346-10cb-41cd-be41-a6dc1b632531", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("0c626567-df4a-4884-8126-ccfc4017c46b"), "8648df49-8eb8-4e5f-b965-8108d871c289", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("10f9fa07-4565-46f7-a9b8-b3086dc61162"), "0ebe485c-633d-4d1e-b71c-7be44c99a6d6", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("fbbef130-af70-466b-a9da-3c6d967c90f8"), "bda84c06-f1bd-41ef-bda5-823f66a234e1", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("c9847835-583e-4eee-b8e7-1b88016ab5dc"), "c090c516-ed43-4ff0-b1d9-ca3e921f2c8c", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("18bd0261-54a4-4e7d-8afd-083672825cd3"), "2eef76ae-e490-4b5e-8749-3171574ced5a", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("3009ab25-7710-404b-82b8-4ba78c715fc4"), "46d2996c-9980-4da3-b58f-b8779abad3a2", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" },
                    { new Guid("a19eee0d-4e7d-42af-8644-63efab0dec1d"), "7d40f5c1-969c-4e5f-98df-6000964a9643", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("0a74f90c-0630-4035-b542-37d2f262fd8c"), "cdafc903-6c73-4ba8-af11-666440957ba5", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "8b4358fb-9269-44c5-905f-6fffbb790a40");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "5e6521ab-a178-4434-9106-b7335b332758");
        }
    }
}
