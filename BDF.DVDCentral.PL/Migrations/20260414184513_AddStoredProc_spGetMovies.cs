using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BDF.DVDCentral.PL.Migrations
{
    /// <inheritdoc />
    public partial class AddStoredProc_spGetMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("6bcb26ca-55ec-4a8d-b3f8-53bd27df8cda"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("b315c88b-ed2e-4d59-8f54-0943b057643c"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("26590f9d-72bf-4db4-91fb-3a527c8b4921"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("f05b1751-05ce-4aa7-8e33-e886bac5d159"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("a6ba33d4-fabe-4194-abef-c90cee75d291"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("93563451-319d-422d-bcdd-1225c5103020"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("d1d5ba7c-5674-4f18-9543-0dc03c6dec04"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("e9e2991e-b7d8-4b46-9c33-483bb0fc41c8"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("f5f4d76c-62f7-42bf-9f4d-625a8075cb54"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("0af105dd-484a-4207-b8c2-9d348370c2cc"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("131407b6-09a1-4711-9f46-897bfb789d71"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("204e3dd1-74d7-4dfa-9781-e4547d7012b4"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("4642452c-b6aa-4674-a2cd-20baeba00dd9"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("5d75b195-e85c-4ffb-b6e8-f88bb9df18c7"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("686f5e97-cdcf-44f0-b250-22c1b1dfec38"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("7de13edf-36ad-4a81-aabf-63506e189632"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("87757825-3e9a-46c6-8ce6-0029cbe1b5dd"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("aabbf2a5-817d-4f84-8c45-34a1df8d1261"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("c7043aa7-c33d-4209-945e-5c0ad50f5b18"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("d151fb6c-7051-4bfe-9a64-5ccbcef9294d"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("ec479098-1d5e-4be7-aca6-9c5c36ee5e65"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("fe51f0af-00c9-4663-8ec4-711805bcf971"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("229b05ca-bfa1-48e4-b6ad-25ad9f106c2e"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("101d324d-1091-4088-b338-042c6ae25a33"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("2214297a-2f6d-44d6-a3e3-c725114ed47b"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("47c6e7aa-4704-4f9e-90e9-44c40d0d856b"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("6e78fdd2-795b-4439-9bf2-411bd03d39a9"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("b6e68cf7-8fd5-43ee-bcff-0afa2bb8a88b"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("4a9719a8-49da-4109-80bc-e3cdfaf4a586"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("2554f62b-2153-468a-ba84-83df15147f5f"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("328b62c0-2d4b-4fce-927a-b4d19689b927"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("6715bdaf-f5fa-41fc-bf2f-20f1440a001a"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("672a0c47-d498-46a5-aa77-7fa892b2d7c4"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("8118fca5-2e87-4bb6-9dfc-773a85a24247"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("a9b3539a-eafa-4434-9331-978951ce2e2f"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("cf794402-c743-494b-bfc0-58b8b3d32e85"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("3d0add41-5007-43d1-9b00-6b864c1a0281"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("5d38bc3e-ccd1-4768-aa52-4cb7eec8b987"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("732d945e-1482-46cb-9abf-f097e0957d85"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("bae7740e-96ce-482e-9db4-ed3ec8a0abd1"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("c49b331b-34b9-4142-a198-2eb207e6a4fa"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("fc624838-23b0-43a9-a7b7-3c7aba189f4a"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("19f2228e-eafd-4b6e-bb67-b4742ed630d7"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("3eaab255-b26f-486b-8ab1-48bb1231520d"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("259a2a2a-1006-42f9-80eb-a15a55eb1af8"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("8ac084ec-0d24-443a-9d7d-d80716e38eaa"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("44151a9e-a522-41ea-b50c-6c45dc39190b"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("72f2ae73-5ffd-40ca-8d7a-219b89597bed"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("a5847793-5163-4a28-89ca-10c315662eca"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("ec8d62eb-1c27-447f-85e9-4cebe6ff158e"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("929622cc-6be9-45fa-a758-47d809fc5683"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("d1c3a568-977b-4ad8-88fd-975c29d54965"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("fa7bf046-3d42-4b05-aa11-c3853ce3b1be"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("064f5963-e477-4b75-b707-10f78e5fb71e"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("70f4de95-db5a-4748-a3c6-88d255dddec6"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("c5d825f6-d2ae-464e-b753-c0d90df33d35"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("f864adf7-48fd-4a67-954c-e7dbe5016b54"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("5e489d79-76f4-4f5d-b4ea-e39aa37fdf86"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("5c19b233-711f-467b-b932-62aca6e7e99d"));

            migrationBuilder.CreateTable(
                name: "spGetMoviesResult",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    InStkQty = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.InsertData(
                table: "tblDirector",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("07b131b9-1add-4473-9528-2941f5655992"), "Rob", "Reiner" },
                    { new Guid("09afb148-1700-4a2a-b229-2e3b2ccf153b"), "Other", "Other" },
                    { new Guid("2c43d0de-2305-42e9-a24b-7741d2b13cf5"), "George", "Lucas" },
                    { new Guid("36473983-e830-4e69-95db-c6830df7d541"), "Clint", "Eastwood" },
                    { new Guid("82c72373-7dd2-4c75-95f1-a98feed67835"), "John", "Avildsen" },
                    { new Guid("a882e5ae-aecc-433f-a4e1-706f4acdf76b"), "Steven", "Spielberg" }
                });

            migrationBuilder.InsertData(
                table: "tblFormat",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("60827f42-c368-4fef-ba34-610b68626694"), "Blu-Ray" },
                    { new Guid("74503613-bded-4a75-8edc-29246e0597fe"), "VHS" },
                    { new Guid("a2f2856a-efd1-4a87-a6c3-c4e293d10071"), "Other" },
                    { new Guid("c547a498-d8a7-4a04-a3b8-235fdb0c8fa2"), "DVD" }
                });

            migrationBuilder.InsertData(
                table: "tblGenre",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("24575a54-34c9-46f6-ba14-2d74c04aa7c1"), "Musical" },
                    { new Guid("3b7f0077-9754-42d5-a440-eb3d7f9d05a7"), "Horror" },
                    { new Guid("3e87b47b-657b-4e0b-8a55-59241604752a"), "Sci-Fi" },
                    { new Guid("6419e69d-043f-466e-b320-dd4586cf00fa"), "Action" },
                    { new Guid("74ad856b-3978-46b4-9c99-5ac11281d12d"), "Comedy" },
                    { new Guid("8a411452-6eb3-46a1-b49f-9a84535d1130"), "Western" },
                    { new Guid("8a4a0eb1-03d0-4bcc-a085-24e95ce00575"), "Documentary" },
                    { new Guid("acc98b10-28f1-427b-b466-0977d7ee09e1"), "Mystery" },
                    { new Guid("b7f9b549-e525-4545-baad-aa0d4692e1a5"), "Romance" },
                    { new Guid("d1d7c595-8870-48c9-860b-176d5c4d597b"), "Other" }
                });

            migrationBuilder.InsertData(
                table: "tblRating",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("27589f2c-4b75-4cd0-96ad-947261996250"), "PG" },
                    { new Guid("2c425159-927f-450f-bcc2-5f133be6b888"), "G" },
                    { new Guid("68b55e4b-f31a-4ace-8a93-744f648e7ef6"), "PG-13" },
                    { new Guid("842f3c81-b51c-4b0b-ac6a-c9b15ed0f4c2"), "R" },
                    { new Guid("ec573346-db6b-4cd1-a070-169aee2d6669"), "Other" }
                });

            migrationBuilder.InsertData(
                table: "tblUser",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserId" },
                values: new object[,]
                {
                    { new Guid("01ec4844-5259-453b-8784-f9bfe718fcf3"), "Brian", "Foote", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "bfoote" },
                    { new Guid("4aaad1ee-15fa-4d81-8717-6b9317059137"), "Steve", "Marin", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "smarin" },
                    { new Guid("573f46c8-10f5-4a50-af6b-412c3c50ba8c"), "Other", "Other", "X1BEO/529yeajg8vCpiXXNv/OOk=", "sophie" },
                    { new Guid("6bf60220-ad00-45f0-921d-5e3d14b4d4e4"), "John", "Doro", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "jdoro" }
                });

            migrationBuilder.InsertData(
                table: "tblCustomer",
                columns: new[] { "Id", "Address", "City", "FirstName", "LastName", "Phone", "State", "UserId", "Zip" },
                values: new object[,]
                {
                    { new Guid("07dc5e16-ce6e-42f9-be3b-fd5f699c2da6"), "159 Johnson Avenue", "Allenton", "Brian", "Foote", "9202623415", "WI", new Guid("01ec4844-5259-453b-8784-f9bfe718fcf3"), "53142" },
                    { new Guid("85750aea-fda2-4221-941e-de46f36afef5"), "453 Oak Street", "Fond du Lac", "Steve", "Marin", "9205879797", "WI", new Guid("4aaad1ee-15fa-4d81-8717-6b9317059137"), "54935" },
                    { new Guid("c3ed8bc1-4b1a-4620-ac03-faf55c1dc6ac"), "159 Johnson Avenue", "Allenton", "Other", "Other", "9202623415", "WI", new Guid("01ec4844-5259-453b-8784-f9bfe718fcf3"), "53142" },
                    { new Guid("f38ad6db-d2c7-43a4-8151-01dc654b27da"), "987 Willow Road", "Slinger", "John", "Doro", "9202623345", "WI", new Guid("6bf60220-ad00-45f0-921d-5e3d14b4d4e4"), "56495" }
                });

            migrationBuilder.InsertData(
                table: "tblMovie",
                columns: new[] { "Id", "Cost", "Description", "DirectorId", "FormatId", "ImagePath", "InStkQty", "RatingId", "Title" },
                values: new object[,]
                {
                    { new Guid("3b0cf02d-727d-4826-8b1b-c1da1bf1f0ec"), 6.9900000000000002, "Other", new Guid("82c72373-7dd2-4c75-95f1-a98feed67835"), new Guid("74503613-bded-4a75-8edc-29246e0597fe"), "Rocky.jpg", 2, new Guid("2c425159-927f-450f-bcc2-5f133be6b888"), "Other" },
                    { new Guid("5da8c185-1073-45f2-972e-edbb59af9091"), 12.5, "The Princess Bride is a 1987 American fantasy adventure comedy film directed and co-produced by Rob Reiner, starring Cary Elwes, Robin Wright, Mandy Patinkin, Chris Sarandon, Wallace Shawn, André the Giant, and Christopher Guest.", new Guid("07b131b9-1add-4473-9528-2941f5655992"), new Guid("60827f42-c368-4fef-ba34-610b68626694"), "PrincessBride.jpg", 4, new Guid("27589f2c-4b75-4cd0-96ad-947261996250"), "The Princess Bride" },
                    { new Guid("69a9e53a-88d0-4432-abc9-a36c4e9bfb82"), 6.9900000000000002, "Rocky is a 1976 American sports drama film directed by John G. Avildsen, written by and starring Sylvester Stallone.", new Guid("82c72373-7dd2-4c75-95f1-a98feed67835"), new Guid("74503613-bded-4a75-8edc-29246e0597fe"), "Rocky.jpg", 2, new Guid("2c425159-927f-450f-bcc2-5f133be6b888"), "Rocky" },
                    { new Guid("9926feee-0d0f-4948-8bd2-9bc3b485b356"), 10.5, "Indiana Jones and the Last Crusade is a 1989 American action-adventure film directed by Steven Spielberg, from a story co-written by executive producer George Lucas.", new Guid("2c43d0de-2305-42e9-a24b-7741d2b13cf5"), new Guid("60827f42-c368-4fef-ba34-610b68626694"), "IndianaJonesLastCrusade.jpg", 2, new Guid("842f3c81-b51c-4b0b-ac6a-c9b15ed0f4c2"), "Indiana Jones and the Last Crusade" },
                    { new Guid("c90e9084-21c3-46b0-82f6-43fca5421cb2"), 8.9900000000000002, "Jaws is a 1975 American thriller film directed by Steven Spielberg and based on the Peter Benchley 1974 novel of the same name.", new Guid("a882e5ae-aecc-433f-a4e1-706f4acdf76b"), new Guid("c547a498-d8a7-4a04-a3b8-235fdb0c8fa2"), "Jaws1.jpg", 1, new Guid("68b55e4b-f31a-4ace-8a93-744f648e7ef6"), "Jaws" },
                    { new Guid("f3f856bd-bbe6-4842-96b5-40ac2c5b6c38"), 7.5, "Star Wars: Episode IV – A New Hope is a 1977 American epic space-opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", new Guid("a882e5ae-aecc-433f-a4e1-706f4acdf76b"), new Guid("c547a498-d8a7-4a04-a3b8-235fdb0c8fa2"), "StarWarsNewHope.jpg", 1, new Guid("68b55e4b-f31a-4ace-8a93-744f648e7ef6"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("f67938d9-6a42-4f87-8d31-f94c146a0b0a"), 9.9900000000000002, "Pale Rider is a 1985 American Western film produced and directed by Clint Eastwood, who also stars in the lead role.", new Guid("a882e5ae-aecc-433f-a4e1-706f4acdf76b"), new Guid("c547a498-d8a7-4a04-a3b8-235fdb0c8fa2"), "PaleRider.jpg", 1, new Guid("68b55e4b-f31a-4ace-8a93-744f648e7ef6"), "Pale Rider" }
                });

            migrationBuilder.InsertData(
                table: "tblMovieGenre",
                columns: new[] { "Id", "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("038aeee0-e143-4c6b-8700-3764579fdfc2"), new Guid("3e87b47b-657b-4e0b-8a55-59241604752a"), new Guid("69a9e53a-88d0-4432-abc9-a36c4e9bfb82") },
                    { new Guid("0ba3a226-38f6-484b-97e1-dc3e6a2e8228"), new Guid("3b7f0077-9754-42d5-a440-eb3d7f9d05a7"), new Guid("69a9e53a-88d0-4432-abc9-a36c4e9bfb82") },
                    { new Guid("1dc99cbd-3194-44b5-8115-e0ff9b23517e"), new Guid("6419e69d-043f-466e-b320-dd4586cf00fa"), new Guid("5da8c185-1073-45f2-972e-edbb59af9091") },
                    { new Guid("38e226da-8963-4e81-bfa9-cc62a761d8cd"), new Guid("3b7f0077-9754-42d5-a440-eb3d7f9d05a7"), new Guid("9926feee-0d0f-4948-8bd2-9bc3b485b356") },
                    { new Guid("664504ad-ffde-413c-98d7-8519fe4ee00f"), new Guid("8a4a0eb1-03d0-4bcc-a085-24e95ce00575"), new Guid("69a9e53a-88d0-4432-abc9-a36c4e9bfb82") },
                    { new Guid("6a5f8d1d-777a-4cbf-a1ab-4dfbf7ff2aa4"), new Guid("acc98b10-28f1-427b-b466-0977d7ee09e1"), new Guid("f67938d9-6a42-4f87-8d31-f94c146a0b0a") },
                    { new Guid("73a0b13c-f006-4784-9ef8-3810a4cea109"), new Guid("3b7f0077-9754-42d5-a440-eb3d7f9d05a7"), new Guid("f3f856bd-bbe6-4842-96b5-40ac2c5b6c38") },
                    { new Guid("827cca84-97ba-439a-868f-b1915304673d"), new Guid("8a4a0eb1-03d0-4bcc-a085-24e95ce00575"), new Guid("9926feee-0d0f-4948-8bd2-9bc3b485b356") },
                    { new Guid("8cd707a2-cd8f-495f-8838-69e61a644ec3"), new Guid("24575a54-34c9-46f6-ba14-2d74c04aa7c1"), new Guid("f3f856bd-bbe6-4842-96b5-40ac2c5b6c38") },
                    { new Guid("a13a4a9d-f645-46aa-ab7c-ec4a09319d2b"), new Guid("3e87b47b-657b-4e0b-8a55-59241604752a"), new Guid("c90e9084-21c3-46b0-82f6-43fca5421cb2") },
                    { new Guid("a47197b0-f415-4a85-9536-7f9b9899e7f7"), new Guid("74ad856b-3978-46b4-9c99-5ac11281d12d"), new Guid("5da8c185-1073-45f2-972e-edbb59af9091") },
                    { new Guid("a8a6aaca-e270-4143-bd2a-03efc3def55b"), new Guid("8a4a0eb1-03d0-4bcc-a085-24e95ce00575"), new Guid("5da8c185-1073-45f2-972e-edbb59af9091") },
                    { new Guid("de62e11d-722b-4869-8c94-836057f90062"), new Guid("3b7f0077-9754-42d5-a440-eb3d7f9d05a7"), new Guid("c90e9084-21c3-46b0-82f6-43fca5421cb2") }
                });

            migrationBuilder.InsertData(
                table: "tblOrder",
                columns: new[] { "Id", "CustomerId", "OrderDate", "ShipDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("781db6a1-16ae-43a0-864c-dc83f6112409"), new Guid("07dc5e16-ce6e-42f9-be3b-fd5f699c2da6"), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01ec4844-5259-453b-8784-f9bfe718fcf3") },
                    { new Guid("79c4c361-e49f-42e7-9c0e-63a663ac7025"), new Guid("f38ad6db-d2c7-43a4-8151-01dc654b27da"), new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6bf60220-ad00-45f0-921d-5e3d14b4d4e4") },
                    { new Guid("b9ab0d66-79e5-458c-ad7f-d7802c6acf27"), new Guid("07dc5e16-ce6e-42f9-be3b-fd5f699c2da6"), new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6bf60220-ad00-45f0-921d-5e3d14b4d4e4") }
                });

            migrationBuilder.InsertData(
                table: "tblOrderItem",
                columns: new[] { "Id", "Cost", "MovieId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("15bcdae2-4f8c-4a41-b0ba-84993fcb4ecc"), 9.9900000000000002, new Guid("c90e9084-21c3-46b0-82f6-43fca5421cb2"), new Guid("b9ab0d66-79e5-458c-ad7f-d7802c6acf27"), 1 },
                    { new Guid("afb6bf5a-68ed-4b62-ac7a-b89f8d2d2366"), 8.9900000000000002, new Guid("69a9e53a-88d0-4432-abc9-a36c4e9bfb82"), new Guid("b9ab0d66-79e5-458c-ad7f-d7802c6acf27"), 1 },
                    { new Guid("f772123b-dc8c-4bd7-8d27-f8eacd02e238"), 10.99, new Guid("c90e9084-21c3-46b0-82f6-43fca5421cb2"), new Guid("781db6a1-16ae-43a0-864c-dc83f6112409"), 1 }
                });

            migrationBuilder.Sql(@"CREATE PROCEDURE [dbo].[spGetMovies]
                AS
                SELECT m.Id, m.RatingId, 
                m.DirectorId, m.FormatId, m.Cost, m.Title, m.InStkQty,
                r.Description RatingDescription,
                f.Description FormatDescription,
                d.FirstName, d.LastName
                FROM tblMovie m
                INNER JOIN tblRating r on m.RatingId = r.Id
                INNER JOIN tblFormat f on m.FormatId = f.Id
                INNER JOIN tblDirector d on m.DirectorId = d.Id

                return 0
                ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE [dbo].[spGetMovies]");

            migrationBuilder.DropTable(
                name: "spGetMoviesResult");

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("85750aea-fda2-4221-941e-de46f36afef5"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("c3ed8bc1-4b1a-4620-ac03-faf55c1dc6ac"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("09afb148-1700-4a2a-b229-2e3b2ccf153b"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("36473983-e830-4e69-95db-c6830df7d541"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("a2f2856a-efd1-4a87-a6c3-c4e293d10071"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("8a411452-6eb3-46a1-b49f-9a84535d1130"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("b7f9b549-e525-4545-baad-aa0d4692e1a5"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("d1d7c595-8870-48c9-860b-176d5c4d597b"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("3b0cf02d-727d-4826-8b1b-c1da1bf1f0ec"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("038aeee0-e143-4c6b-8700-3764579fdfc2"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("0ba3a226-38f6-484b-97e1-dc3e6a2e8228"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("1dc99cbd-3194-44b5-8115-e0ff9b23517e"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("38e226da-8963-4e81-bfa9-cc62a761d8cd"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("664504ad-ffde-413c-98d7-8519fe4ee00f"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("6a5f8d1d-777a-4cbf-a1ab-4dfbf7ff2aa4"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("73a0b13c-f006-4784-9ef8-3810a4cea109"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("827cca84-97ba-439a-868f-b1915304673d"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("8cd707a2-cd8f-495f-8838-69e61a644ec3"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("a13a4a9d-f645-46aa-ab7c-ec4a09319d2b"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("a47197b0-f415-4a85-9536-7f9b9899e7f7"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("a8a6aaca-e270-4143-bd2a-03efc3def55b"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("de62e11d-722b-4869-8c94-836057f90062"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("79c4c361-e49f-42e7-9c0e-63a663ac7025"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("15bcdae2-4f8c-4a41-b0ba-84993fcb4ecc"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("afb6bf5a-68ed-4b62-ac7a-b89f8d2d2366"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("f772123b-dc8c-4bd7-8d27-f8eacd02e238"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("ec573346-db6b-4cd1-a070-169aee2d6669"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("573f46c8-10f5-4a50-af6b-412c3c50ba8c"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("f38ad6db-d2c7-43a4-8151-01dc654b27da"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("24575a54-34c9-46f6-ba14-2d74c04aa7c1"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("3b7f0077-9754-42d5-a440-eb3d7f9d05a7"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("3e87b47b-657b-4e0b-8a55-59241604752a"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("6419e69d-043f-466e-b320-dd4586cf00fa"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("74ad856b-3978-46b4-9c99-5ac11281d12d"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("8a4a0eb1-03d0-4bcc-a085-24e95ce00575"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("acc98b10-28f1-427b-b466-0977d7ee09e1"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("5da8c185-1073-45f2-972e-edbb59af9091"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("69a9e53a-88d0-4432-abc9-a36c4e9bfb82"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("9926feee-0d0f-4948-8bd2-9bc3b485b356"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("c90e9084-21c3-46b0-82f6-43fca5421cb2"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("f3f856bd-bbe6-4842-96b5-40ac2c5b6c38"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("f67938d9-6a42-4f87-8d31-f94c146a0b0a"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("781db6a1-16ae-43a0-864c-dc83f6112409"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("b9ab0d66-79e5-458c-ad7f-d7802c6acf27"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("4aaad1ee-15fa-4d81-8717-6b9317059137"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("07dc5e16-ce6e-42f9-be3b-fd5f699c2da6"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("07b131b9-1add-4473-9528-2941f5655992"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("2c43d0de-2305-42e9-a24b-7741d2b13cf5"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("82c72373-7dd2-4c75-95f1-a98feed67835"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("a882e5ae-aecc-433f-a4e1-706f4acdf76b"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("60827f42-c368-4fef-ba34-610b68626694"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("74503613-bded-4a75-8edc-29246e0597fe"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("c547a498-d8a7-4a04-a3b8-235fdb0c8fa2"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("27589f2c-4b75-4cd0-96ad-947261996250"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("2c425159-927f-450f-bcc2-5f133be6b888"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("68b55e4b-f31a-4ace-8a93-744f648e7ef6"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("842f3c81-b51c-4b0b-ac6a-c9b15ed0f4c2"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("6bf60220-ad00-45f0-921d-5e3d14b4d4e4"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("01ec4844-5259-453b-8784-f9bfe718fcf3"));

            migrationBuilder.InsertData(
                table: "tblDirector",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("26590f9d-72bf-4db4-91fb-3a527c8b4921"), "Clint", "Eastwood" },
                    { new Guid("44151a9e-a522-41ea-b50c-6c45dc39190b"), "Rob", "Reiner" },
                    { new Guid("72f2ae73-5ffd-40ca-8d7a-219b89597bed"), "John", "Avildsen" },
                    { new Guid("a5847793-5163-4a28-89ca-10c315662eca"), "George", "Lucas" },
                    { new Guid("ec8d62eb-1c27-447f-85e9-4cebe6ff158e"), "Steven", "Spielberg" },
                    { new Guid("f05b1751-05ce-4aa7-8e33-e886bac5d159"), "Other", "Other" }
                });

            migrationBuilder.InsertData(
                table: "tblFormat",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("929622cc-6be9-45fa-a758-47d809fc5683"), "DVD" },
                    { new Guid("a6ba33d4-fabe-4194-abef-c90cee75d291"), "Other" },
                    { new Guid("d1c3a568-977b-4ad8-88fd-975c29d54965"), "VHS" },
                    { new Guid("fa7bf046-3d42-4b05-aa11-c3853ce3b1be"), "Blu-Ray" }
                });

            migrationBuilder.InsertData(
                table: "tblGenre",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("2554f62b-2153-468a-ba84-83df15147f5f"), "Sci-Fi" },
                    { new Guid("328b62c0-2d4b-4fce-927a-b4d19689b927"), "Mystery" },
                    { new Guid("6715bdaf-f5fa-41fc-bf2f-20f1440a001a"), "Musical" },
                    { new Guid("672a0c47-d498-46a5-aa77-7fa892b2d7c4"), "Documentary" },
                    { new Guid("8118fca5-2e87-4bb6-9dfc-773a85a24247"), "Comedy" },
                    { new Guid("93563451-319d-422d-bcdd-1225c5103020"), "Western" },
                    { new Guid("a9b3539a-eafa-4434-9331-978951ce2e2f"), "Action" },
                    { new Guid("cf794402-c743-494b-bfc0-58b8b3d32e85"), "Horror" },
                    { new Guid("d1d5ba7c-5674-4f18-9543-0dc03c6dec04"), "Other" },
                    { new Guid("e9e2991e-b7d8-4b46-9c33-483bb0fc41c8"), "Romance" }
                });

            migrationBuilder.InsertData(
                table: "tblRating",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("064f5963-e477-4b75-b707-10f78e5fb71e"), "R" },
                    { new Guid("6e78fdd2-795b-4439-9bf2-411bd03d39a9"), "Other" },
                    { new Guid("70f4de95-db5a-4748-a3c6-88d255dddec6"), "PG" },
                    { new Guid("c5d825f6-d2ae-464e-b753-c0d90df33d35"), "PG-13" },
                    { new Guid("f864adf7-48fd-4a67-954c-e7dbe5016b54"), "G" }
                });

            migrationBuilder.InsertData(
                table: "tblUser",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserId" },
                values: new object[,]
                {
                    { new Guid("259a2a2a-1006-42f9-80eb-a15a55eb1af8"), "Steve", "Marin", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "smarin" },
                    { new Guid("5c19b233-711f-467b-b932-62aca6e7e99d"), "Brian", "Foote", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "bfoote" },
                    { new Guid("5e489d79-76f4-4f5d-b4ea-e39aa37fdf86"), "John", "Doro", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "jdoro" },
                    { new Guid("b6e68cf7-8fd5-43ee-bcff-0afa2bb8a88b"), "Other", "Other", "X1BEO/529yeajg8vCpiXXNv/OOk=", "sophie" }
                });

            migrationBuilder.InsertData(
                table: "tblCustomer",
                columns: new[] { "Id", "Address", "City", "FirstName", "LastName", "Phone", "State", "UserId", "Zip" },
                values: new object[,]
                {
                    { new Guid("4a9719a8-49da-4109-80bc-e3cdfaf4a586"), "987 Willow Road", "Slinger", "John", "Doro", "9202623345", "WI", new Guid("5e489d79-76f4-4f5d-b4ea-e39aa37fdf86"), "56495" },
                    { new Guid("6bcb26ca-55ec-4a8d-b3f8-53bd27df8cda"), "159 Johnson Avenue", "Allenton", "Other", "Other", "9202623415", "WI", new Guid("5c19b233-711f-467b-b932-62aca6e7e99d"), "53142" },
                    { new Guid("8ac084ec-0d24-443a-9d7d-d80716e38eaa"), "159 Johnson Avenue", "Allenton", "Brian", "Foote", "9202623415", "WI", new Guid("5c19b233-711f-467b-b932-62aca6e7e99d"), "53142" },
                    { new Guid("b315c88b-ed2e-4d59-8f54-0943b057643c"), "453 Oak Street", "Fond du Lac", "Steve", "Marin", "9205879797", "WI", new Guid("259a2a2a-1006-42f9-80eb-a15a55eb1af8"), "54935" }
                });

            migrationBuilder.InsertData(
                table: "tblMovie",
                columns: new[] { "Id", "Cost", "Description", "DirectorId", "FormatId", "ImagePath", "InStkQty", "RatingId", "Title" },
                values: new object[,]
                {
                    { new Guid("3d0add41-5007-43d1-9b00-6b864c1a0281"), 10.5, "Indiana Jones and the Last Crusade is a 1989 American action-adventure film directed by Steven Spielberg, from a story co-written by executive producer George Lucas.", new Guid("a5847793-5163-4a28-89ca-10c315662eca"), new Guid("fa7bf046-3d42-4b05-aa11-c3853ce3b1be"), "IndianaJonesLastCrusade.jpg", 2, new Guid("064f5963-e477-4b75-b707-10f78e5fb71e"), "Indiana Jones and the Last Crusade" },
                    { new Guid("5d38bc3e-ccd1-4768-aa52-4cb7eec8b987"), 9.9900000000000002, "Pale Rider is a 1985 American Western film produced and directed by Clint Eastwood, who also stars in the lead role.", new Guid("ec8d62eb-1c27-447f-85e9-4cebe6ff158e"), new Guid("929622cc-6be9-45fa-a758-47d809fc5683"), "PaleRider.jpg", 1, new Guid("c5d825f6-d2ae-464e-b753-c0d90df33d35"), "Pale Rider" },
                    { new Guid("732d945e-1482-46cb-9abf-f097e0957d85"), 6.9900000000000002, "Rocky is a 1976 American sports drama film directed by John G. Avildsen, written by and starring Sylvester Stallone.", new Guid("72f2ae73-5ffd-40ca-8d7a-219b89597bed"), new Guid("d1c3a568-977b-4ad8-88fd-975c29d54965"), "Rocky.jpg", 2, new Guid("f864adf7-48fd-4a67-954c-e7dbe5016b54"), "Rocky" },
                    { new Guid("bae7740e-96ce-482e-9db4-ed3ec8a0abd1"), 7.5, "Star Wars: Episode IV – A New Hope is a 1977 American epic space-opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", new Guid("ec8d62eb-1c27-447f-85e9-4cebe6ff158e"), new Guid("929622cc-6be9-45fa-a758-47d809fc5683"), "StarWarsNewHope.jpg", 1, new Guid("c5d825f6-d2ae-464e-b753-c0d90df33d35"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("c49b331b-34b9-4142-a198-2eb207e6a4fa"), 12.5, "The Princess Bride is a 1987 American fantasy adventure comedy film directed and co-produced by Rob Reiner, starring Cary Elwes, Robin Wright, Mandy Patinkin, Chris Sarandon, Wallace Shawn, André the Giant, and Christopher Guest.", new Guid("44151a9e-a522-41ea-b50c-6c45dc39190b"), new Guid("fa7bf046-3d42-4b05-aa11-c3853ce3b1be"), "PrincessBride.jpg", 4, new Guid("70f4de95-db5a-4748-a3c6-88d255dddec6"), "The Princess Bride" },
                    { new Guid("f5f4d76c-62f7-42bf-9f4d-625a8075cb54"), 6.9900000000000002, "Other", new Guid("72f2ae73-5ffd-40ca-8d7a-219b89597bed"), new Guid("d1c3a568-977b-4ad8-88fd-975c29d54965"), "Rocky.jpg", 2, new Guid("f864adf7-48fd-4a67-954c-e7dbe5016b54"), "Other" },
                    { new Guid("fc624838-23b0-43a9-a7b7-3c7aba189f4a"), 8.9900000000000002, "Jaws is a 1975 American thriller film directed by Steven Spielberg and based on the Peter Benchley 1974 novel of the same name.", new Guid("ec8d62eb-1c27-447f-85e9-4cebe6ff158e"), new Guid("929622cc-6be9-45fa-a758-47d809fc5683"), "Jaws1.jpg", 1, new Guid("c5d825f6-d2ae-464e-b753-c0d90df33d35"), "Jaws" }
                });

            migrationBuilder.InsertData(
                table: "tblMovieGenre",
                columns: new[] { "Id", "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("0af105dd-484a-4207-b8c2-9d348370c2cc"), new Guid("328b62c0-2d4b-4fce-927a-b4d19689b927"), new Guid("5d38bc3e-ccd1-4768-aa52-4cb7eec8b987") },
                    { new Guid("131407b6-09a1-4711-9f46-897bfb789d71"), new Guid("cf794402-c743-494b-bfc0-58b8b3d32e85"), new Guid("732d945e-1482-46cb-9abf-f097e0957d85") },
                    { new Guid("204e3dd1-74d7-4dfa-9781-e4547d7012b4"), new Guid("cf794402-c743-494b-bfc0-58b8b3d32e85"), new Guid("3d0add41-5007-43d1-9b00-6b864c1a0281") },
                    { new Guid("4642452c-b6aa-4674-a2cd-20baeba00dd9"), new Guid("8118fca5-2e87-4bb6-9dfc-773a85a24247"), new Guid("c49b331b-34b9-4142-a198-2eb207e6a4fa") },
                    { new Guid("5d75b195-e85c-4ffb-b6e8-f88bb9df18c7"), new Guid("672a0c47-d498-46a5-aa77-7fa892b2d7c4"), new Guid("3d0add41-5007-43d1-9b00-6b864c1a0281") },
                    { new Guid("686f5e97-cdcf-44f0-b250-22c1b1dfec38"), new Guid("672a0c47-d498-46a5-aa77-7fa892b2d7c4"), new Guid("c49b331b-34b9-4142-a198-2eb207e6a4fa") },
                    { new Guid("7de13edf-36ad-4a81-aabf-63506e189632"), new Guid("cf794402-c743-494b-bfc0-58b8b3d32e85"), new Guid("fc624838-23b0-43a9-a7b7-3c7aba189f4a") },
                    { new Guid("87757825-3e9a-46c6-8ce6-0029cbe1b5dd"), new Guid("cf794402-c743-494b-bfc0-58b8b3d32e85"), new Guid("bae7740e-96ce-482e-9db4-ed3ec8a0abd1") },
                    { new Guid("aabbf2a5-817d-4f84-8c45-34a1df8d1261"), new Guid("672a0c47-d498-46a5-aa77-7fa892b2d7c4"), new Guid("732d945e-1482-46cb-9abf-f097e0957d85") },
                    { new Guid("c7043aa7-c33d-4209-945e-5c0ad50f5b18"), new Guid("6715bdaf-f5fa-41fc-bf2f-20f1440a001a"), new Guid("bae7740e-96ce-482e-9db4-ed3ec8a0abd1") },
                    { new Guid("d151fb6c-7051-4bfe-9a64-5ccbcef9294d"), new Guid("2554f62b-2153-468a-ba84-83df15147f5f"), new Guid("fc624838-23b0-43a9-a7b7-3c7aba189f4a") },
                    { new Guid("ec479098-1d5e-4be7-aca6-9c5c36ee5e65"), new Guid("a9b3539a-eafa-4434-9331-978951ce2e2f"), new Guid("c49b331b-34b9-4142-a198-2eb207e6a4fa") },
                    { new Guid("fe51f0af-00c9-4663-8ec4-711805bcf971"), new Guid("2554f62b-2153-468a-ba84-83df15147f5f"), new Guid("732d945e-1482-46cb-9abf-f097e0957d85") }
                });

            migrationBuilder.InsertData(
                table: "tblOrder",
                columns: new[] { "Id", "CustomerId", "OrderDate", "ShipDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("19f2228e-eafd-4b6e-bb67-b4742ed630d7"), new Guid("8ac084ec-0d24-443a-9d7d-d80716e38eaa"), new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5e489d79-76f4-4f5d-b4ea-e39aa37fdf86") },
                    { new Guid("229b05ca-bfa1-48e4-b6ad-25ad9f106c2e"), new Guid("4a9719a8-49da-4109-80bc-e3cdfaf4a586"), new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5e489d79-76f4-4f5d-b4ea-e39aa37fdf86") },
                    { new Guid("3eaab255-b26f-486b-8ab1-48bb1231520d"), new Guid("8ac084ec-0d24-443a-9d7d-d80716e38eaa"), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c19b233-711f-467b-b932-62aca6e7e99d") }
                });

            migrationBuilder.InsertData(
                table: "tblOrderItem",
                columns: new[] { "Id", "Cost", "MovieId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("101d324d-1091-4088-b338-042c6ae25a33"), 10.99, new Guid("fc624838-23b0-43a9-a7b7-3c7aba189f4a"), new Guid("3eaab255-b26f-486b-8ab1-48bb1231520d"), 1 },
                    { new Guid("2214297a-2f6d-44d6-a3e3-c725114ed47b"), 8.9900000000000002, new Guid("732d945e-1482-46cb-9abf-f097e0957d85"), new Guid("19f2228e-eafd-4b6e-bb67-b4742ed630d7"), 1 },
                    { new Guid("47c6e7aa-4704-4f9e-90e9-44c40d0d856b"), 9.9900000000000002, new Guid("fc624838-23b0-43a9-a7b7-3c7aba189f4a"), new Guid("19f2228e-eafd-4b6e-bb67-b4742ed630d7"), 1 }
                });
        }
    }
}
