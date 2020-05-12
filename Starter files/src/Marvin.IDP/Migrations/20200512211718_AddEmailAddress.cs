using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvin.IDP.Migrations
{
    public partial class AddEmailAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("401273d5-1ffd-4d94-a19e-ab3a5af15904"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("599a8d26-3a10-4caf-88de-66722d773b6a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("604f2d1d-b68b-49de-b35e-34ad3421542b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7899fba4-0b4c-4010-8e89-62d76c2a8db8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7e9fcfa1-f9ca-44a1-84fd-b6b42e1de4ed"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("80510807-19a1-42eb-a009-e5cc8d8a99c5"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c857a71c-53f0-4698-b389-69f31a20d771"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d123ecf1-b438-41c0-9cc1-2c2035f2232a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("dbc894c7-47fb-4465-b003-32bc34f4cdf5"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e9d591b7-f545-4059-b807-946da1b3cc43"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "af6c9fda-c9a9-4830-bd64-d2f054aa7d4a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "8800ed72-2085-4f66-b96b-5f57b800dc7f");
        }
    }
}
