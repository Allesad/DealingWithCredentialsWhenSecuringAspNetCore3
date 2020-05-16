using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvin.IDP.Migrations
{
    public partial class AddUserSecret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "UserSecrets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Secret = table.Column<string>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecrets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSecrets_Users_UserId",
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
                    { new Guid("b0cc9f68-4190-4521-b499-7464fa844a04"), "429d24a4-f754-4dd5-b4a7-2a19daffe1f2", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("d2f43ea6-2b36-4acd-a25a-2155ed1e5837"), "ed82156c-b49d-4cd1-a125-109a93681875", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("c4de1435-5f09-47c6-ad68-e71a1a3ec874"), "3d607dab-0fbe-478d-9302-5b9f7c6ce3e7", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("323e59f5-f59b-4e7e-89e5-1c9e650eb0f7"), "a10574eb-1c37-4038-9f76-8fca30858442", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("34baadf8-793d-47e5-9252-ccafabc546a8"), "7112c773-9a6b-42a8-9de3-4c9e91d1c269", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("38d436e6-1d74-4e10-93d3-820de003043d"), "b8214efe-421d-4eaa-ae05-1aa2d76b02c8", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("34c9ca93-31bd-484e-a12b-c455830f9998"), "af65affa-4c3f-49f0-b7cf-86288cbd90db", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("857854c2-6246-44be-8823-4c687305808b"), "411b7761-02e2-4f92-9e4d-a841e66e25c3", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" },
                    { new Guid("53630f1f-4dcb-4748-92df-6730fc63638a"), "ffce2281-4e1d-4d38-af91-1076da673770", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("457eff5f-ad52-4530-8db9-e4bd2a042876"), "0a2e21d9-ca99-4bcf-a754-2414802ae6b2", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "e25262b9-da97-4759-9c44-83aaaf9c3a61");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "168fc741-f507-46a8-a318-b45863fe4fdc");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecrets_UserId",
                table: "UserSecrets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSecrets");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("323e59f5-f59b-4e7e-89e5-1c9e650eb0f7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("34baadf8-793d-47e5-9252-ccafabc546a8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("34c9ca93-31bd-484e-a12b-c455830f9998"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("38d436e6-1d74-4e10-93d3-820de003043d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("457eff5f-ad52-4530-8db9-e4bd2a042876"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("53630f1f-4dcb-4748-92df-6730fc63638a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("857854c2-6246-44be-8823-4c687305808b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b0cc9f68-4190-4521-b499-7464fa844a04"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c4de1435-5f09-47c6-ad68-e71a1a3ec874"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d2f43ea6-2b36-4acd-a25a-2155ed1e5837"));

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
        }
    }
}
