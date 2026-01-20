using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BDF.DVDCentral.PL.Migrations
{
    /// <inheritdoc />
    public partial class CreateForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("12176b73-8682-44cc-b25b-256188972aa7"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("56d46d8c-6e38-4d1a-83f5-7d23c3f97f2f"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("9774781c-d9d0-418b-8d34-a74a72e3a930"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("e9206012-e932-4b81-b5b1-9702f07bb50d"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("315d99c7-4c21-47fb-a595-9944975f8d93"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("3db2f963-8fe4-46f5-8566-beeb8608b86a"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("696580b1-6f25-452d-b6b5-abc3e69934cc"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("a91cba8e-088d-4fd2-a866-fcaa6c081e86"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("afc2ab30-36d1-4c05-8cb8-d71f796e5025"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("b8a60bf1-33c1-412b-9f17-464e55d606d8"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("05fca4b0-d9f4-4464-bead-8da1db25f707"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("3b88fdfe-7239-4f77-a043-c50cceebdabe"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("906f9375-60e8-49bf-82bc-6a6c2240cb38"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("9ce50789-8e1c-432d-81d1-96aa151fcaca"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("09889e20-531c-4258-a177-0bbca611099d"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("0a5369f8-f7a7-4002-8643-d6d46a1776f0"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("0ac4af58-5882-4547-b55d-1ec19bbb9528"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("1463e903-2e0e-450b-ae96-07e1b823ddf2"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("2c6fa4b5-e371-40eb-ace2-d64709f3ea8b"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("4766a066-a130-4b81-bb80-4bda7165413f"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("573ea92b-1419-4a9b-8b9d-a26330ed0d1b"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("798ae005-3b38-401a-90f8-357f6dd8e3e6"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("7fdd941c-249f-4d02-a3d5-ebdf054d6912"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("b37a851c-d258-424e-9505-70a9a8e1c7a2"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("45cc25ff-57b6-48ad-b0d3-cc7692f53eee"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("6a89be25-06c3-4e6b-9616-03ad4714e685"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("77824d82-82b6-4cdf-a769-ec56b1b6c356"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("83d4046b-69e5-4701-813a-e7cbc0d984cd"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("9b90cc6e-1c59-436e-aa6c-f6a5770d36ec"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("bdac7d92-bb6c-402e-b53b-be9156ca58df"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("e99bbbf5-6aa3-4ae2-b5c0-0b4423eb169e"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("1e39f8cc-58b1-40b1-ad4c-7550e27c8f30"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("2ce93fdf-7a08-4edb-b027-b5ec04f85768"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("2d4b4397-2bf7-40c9-8db4-a5ab526389f9"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("2e930790-caf7-4f80-a694-eb56f1608134"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("31ca17c0-8fb2-4440-a4ad-07be975ab236"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("468c56f9-7cc5-42a6-a322-6bb6e6527db4"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("46cd753e-d141-4eba-aa8b-f7ef514ab07c"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("63a87660-9a62-44f2-bdaf-a49e1fb5054d"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("9fa7a9a4-99b6-4f57-a1e1-b088df1e7dbf"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("a54b9117-915e-4fd9-94c8-9e73b643859a"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("e52c2c0e-b92e-4437-94e3-580928d96fdd"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("e60fb601-12ec-438b-bfb9-af01daf39cb1"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("ef8f1d6d-aae3-4cb9-95a9-0a66fcfce664"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("a188a96c-2bcb-4701-b3c6-fdb2871d58f8"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("ce120240-8280-4c4a-91f1-5cd83fc1140d"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("d3f533ae-2c41-4a2c-af0e-97030318d557"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("2982eaa1-8ca1-43af-b7b6-9ef3f9453b79"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("40197c7f-cf52-45d9-8aa8-6aadc3535799"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("b2289530-8829-4c47-a0a7-dc6cefbc36dd"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("118ea8d9-aa86-436e-8616-d00c946caf18"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("27b904f1-ca8a-433c-8646-51caec1cf297"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("4ae04e4b-7816-4e18-bf71-54c5437c6356"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("b8d9370b-ab2a-46f4-8eae-db3583c7a49c"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("bf9b53fe-b6f9-4077-9288-8d366ac1199c"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("064a9ab2-c3f9-4762-8725-211a410ec121"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("5051dd18-3f2f-4994-88dc-ddad097dce98"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("8a881c24-fca7-4ef2-99a9-1acc4606c763"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("c5585438-0d6c-4eec-b21a-cc64c7f3c604"));

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

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderItem_MovieId",
                table: "tblOrderItem",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderItem_OrderId",
                table: "tblOrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_CustomerId",
                table: "tblOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_UserId",
                table: "tblOrder",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMovieGenre_GenreId",
                table: "tblMovieGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMovieGenre_MovieId",
                table: "tblMovieGenre",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMovie_DirectorId",
                table: "tblMovie",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMovie_FormatId",
                table: "tblMovie",
                column: "FormatId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMovie_RatingId",
                table: "tblMovie",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomer_UserId",
                table: "tblCustomer",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCustomer_UserId",
                table: "tblCustomer",
                column: "UserId",
                principalTable: "tblUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblMovie_DirectorId",
                table: "tblMovie",
                column: "DirectorId",
                principalTable: "tblDirector",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblMovie_FormatId",
                table: "tblMovie",
                column: "FormatId",
                principalTable: "tblFormat",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblMovie_RatingId",
                table: "tblMovie",
                column: "RatingId",
                principalTable: "tblRating",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "tblMovieGenre_GenreId",
                table: "tblMovieGenre",
                column: "GenreId",
                principalTable: "tblGenre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "tblMovieGenre_MovieId",
                table: "tblMovieGenre",
                column: "MovieId",
                principalTable: "tblMovie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrder_CustomerId",
                table: "tblOrder",
                column: "CustomerId",
                principalTable: "tblCustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrder_tblUser_UserId",
                table: "tblOrder",
                column: "UserId",
                principalTable: "tblUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrderItem_OrderId",
                table: "tblOrderItem",
                column: "OrderId",
                principalTable: "tblOrder",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrderItem_tblMovie_MovieId",
                table: "tblOrderItem",
                column: "MovieId",
                principalTable: "tblMovie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCustomer_UserId",
                table: "tblCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_tblMovie_DirectorId",
                table: "tblMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_tblMovie_FormatId",
                table: "tblMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_tblMovie_RatingId",
                table: "tblMovie");

            migrationBuilder.DropForeignKey(
                name: "tblMovieGenre_GenreId",
                table: "tblMovieGenre");

            migrationBuilder.DropForeignKey(
                name: "tblMovieGenre_MovieId",
                table: "tblMovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_CustomerId",
                table: "tblOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblUser_UserId",
                table: "tblOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOrderItem_OrderId",
                table: "tblOrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOrderItem_tblMovie_MovieId",
                table: "tblOrderItem");

            migrationBuilder.DropIndex(
                name: "IX_tblOrderItem_MovieId",
                table: "tblOrderItem");

            migrationBuilder.DropIndex(
                name: "IX_tblOrderItem_OrderId",
                table: "tblOrderItem");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_CustomerId",
                table: "tblOrder");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_UserId",
                table: "tblOrder");

            migrationBuilder.DropIndex(
                name: "IX_tblMovieGenre_GenreId",
                table: "tblMovieGenre");

            migrationBuilder.DropIndex(
                name: "IX_tblMovieGenre_MovieId",
                table: "tblMovieGenre");

            migrationBuilder.DropIndex(
                name: "IX_tblMovie_DirectorId",
                table: "tblMovie");

            migrationBuilder.DropIndex(
                name: "IX_tblMovie_FormatId",
                table: "tblMovie");

            migrationBuilder.DropIndex(
                name: "IX_tblMovie_RatingId",
                table: "tblMovie");

            migrationBuilder.DropIndex(
                name: "IX_tblCustomer_UserId",
                table: "tblCustomer");

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

            migrationBuilder.InsertData(
                table: "tblCustomer",
                columns: new[] { "Id", "Address", "City", "FirstName", "LastName", "Phone", "State", "UserId", "Zip" },
                values: new object[,]
                {
                    { new Guid("12176b73-8682-44cc-b25b-256188972aa7"), "159 Johnson Avenue", "Allenton", "Other", "Other", "9202623415", "WI", new Guid("064a9ab2-c3f9-4762-8725-211a410ec121"), "53142" },
                    { new Guid("56d46d8c-6e38-4d1a-83f5-7d23c3f97f2f"), "159 Johnson Avenue", "Allenton", "Brian", "Foote", "9202623415", "WI", new Guid("064a9ab2-c3f9-4762-8725-211a410ec121"), "53142" },
                    { new Guid("9774781c-d9d0-418b-8d34-a74a72e3a930"), "987 Willow Road", "Slinger", "John", "Doro", "9202623345", "WI", new Guid("5051dd18-3f2f-4994-88dc-ddad097dce98"), "56495" },
                    { new Guid("e9206012-e932-4b81-b5b1-9702f07bb50d"), "453 Oak Street", "Fond du Lac", "Steve", "Marin", "9205879797", "WI", new Guid("8a881c24-fca7-4ef2-99a9-1acc4606c763"), "54935" }
                });

            migrationBuilder.InsertData(
                table: "tblDirector",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("315d99c7-4c21-47fb-a595-9944975f8d93"), "Steven", "Spielberg" },
                    { new Guid("3db2f963-8fe4-46f5-8566-beeb8608b86a"), "Rob", "Reiner" },
                    { new Guid("696580b1-6f25-452d-b6b5-abc3e69934cc"), "George", "Lucas" },
                    { new Guid("a91cba8e-088d-4fd2-a866-fcaa6c081e86"), "John", "Avildsen" },
                    { new Guid("afc2ab30-36d1-4c05-8cb8-d71f796e5025"), "Other", "Other" },
                    { new Guid("b8a60bf1-33c1-412b-9f17-464e55d606d8"), "Clint", "Eastwood" }
                });

            migrationBuilder.InsertData(
                table: "tblFormat",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("05fca4b0-d9f4-4464-bead-8da1db25f707"), "Blu-Ray" },
                    { new Guid("3b88fdfe-7239-4f77-a043-c50cceebdabe"), "VHS" },
                    { new Guid("906f9375-60e8-49bf-82bc-6a6c2240cb38"), "Other" },
                    { new Guid("9ce50789-8e1c-432d-81d1-96aa151fcaca"), "DVD" }
                });

            migrationBuilder.InsertData(
                table: "tblGenre",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("09889e20-531c-4258-a177-0bbca611099d"), "Comedy" },
                    { new Guid("0a5369f8-f7a7-4002-8643-d6d46a1776f0"), "Mystery" },
                    { new Guid("0ac4af58-5882-4547-b55d-1ec19bbb9528"), "Action" },
                    { new Guid("1463e903-2e0e-450b-ae96-07e1b823ddf2"), "Western" },
                    { new Guid("2c6fa4b5-e371-40eb-ace2-d64709f3ea8b"), "Other" },
                    { new Guid("4766a066-a130-4b81-bb80-4bda7165413f"), "Romance" },
                    { new Guid("573ea92b-1419-4a9b-8b9d-a26330ed0d1b"), "Sci-Fi" },
                    { new Guid("798ae005-3b38-401a-90f8-357f6dd8e3e6"), "Documentary" },
                    { new Guid("7fdd941c-249f-4d02-a3d5-ebdf054d6912"), "Musical" },
                    { new Guid("b37a851c-d258-424e-9505-70a9a8e1c7a2"), "Horror" }
                });

            migrationBuilder.InsertData(
                table: "tblMovie",
                columns: new[] { "Id", "Cost", "Description", "DirectorId", "FormatId", "ImagePath", "InStkQty", "RatingId", "Title" },
                values: new object[,]
                {
                    { new Guid("45cc25ff-57b6-48ad-b0d3-cc7692f53eee"), 8.9900000000000002, "Jaws is a 1975 American thriller film directed by Steven Spielberg and based on the Peter Benchley 1974 novel of the same name.", new Guid("315d99c7-4c21-47fb-a595-9944975f8d93"), new Guid("9ce50789-8e1c-432d-81d1-96aa151fcaca"), "Jaws1.jpg", 1, new Guid("bf9b53fe-b6f9-4077-9288-8d366ac1199c"), "Jaws" },
                    { new Guid("6a89be25-06c3-4e6b-9616-03ad4714e685"), 9.9900000000000002, "Pale Rider is a 1985 American Western film produced and directed by Clint Eastwood, who also stars in the lead role.", new Guid("315d99c7-4c21-47fb-a595-9944975f8d93"), new Guid("9ce50789-8e1c-432d-81d1-96aa151fcaca"), "PaleRider.jpg", 1, new Guid("bf9b53fe-b6f9-4077-9288-8d366ac1199c"), "Pale Rider" },
                    { new Guid("77824d82-82b6-4cdf-a769-ec56b1b6c356"), 6.9900000000000002, "Rocky is a 1976 American sports drama film directed by John G. Avildsen, written by and starring Sylvester Stallone.", new Guid("a91cba8e-088d-4fd2-a866-fcaa6c081e86"), new Guid("3b88fdfe-7239-4f77-a043-c50cceebdabe"), "Rocky.jpg", 2, new Guid("b8d9370b-ab2a-46f4-8eae-db3583c7a49c"), "Rocky" },
                    { new Guid("83d4046b-69e5-4701-813a-e7cbc0d984cd"), 10.5, "Indiana Jones and the Last Crusade is a 1989 American action-adventure film directed by Steven Spielberg, from a story co-written by executive producer George Lucas.", new Guid("696580b1-6f25-452d-b6b5-abc3e69934cc"), new Guid("05fca4b0-d9f4-4464-bead-8da1db25f707"), "IndianaJonesLastCrusade.jpg", 2, new Guid("4ae04e4b-7816-4e18-bf71-54c5437c6356"), "Indiana Jones and the Last Crusade" },
                    { new Guid("9b90cc6e-1c59-436e-aa6c-f6a5770d36ec"), 12.5, "The Princess Bride is a 1987 American fantasy adventure comedy film directed and co-produced by Rob Reiner, starring Cary Elwes, Robin Wright, Mandy Patinkin, Chris Sarandon, Wallace Shawn, André the Giant, and Christopher Guest.", new Guid("3db2f963-8fe4-46f5-8566-beeb8608b86a"), new Guid("05fca4b0-d9f4-4464-bead-8da1db25f707"), "PrincessBride.jpg", 4, new Guid("118ea8d9-aa86-436e-8616-d00c946caf18"), "The Princess Bride" },
                    { new Guid("bdac7d92-bb6c-402e-b53b-be9156ca58df"), 7.5, "Star Wars: Episode IV – A New Hope is a 1977 American epic space-opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", new Guid("315d99c7-4c21-47fb-a595-9944975f8d93"), new Guid("9ce50789-8e1c-432d-81d1-96aa151fcaca"), "StarWarsNewHope.jpg", 1, new Guid("bf9b53fe-b6f9-4077-9288-8d366ac1199c"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("e99bbbf5-6aa3-4ae2-b5c0-0b4423eb169e"), 6.9900000000000002, "Other", new Guid("a91cba8e-088d-4fd2-a866-fcaa6c081e86"), new Guid("3b88fdfe-7239-4f77-a043-c50cceebdabe"), "Rocky.jpg", 2, new Guid("b8d9370b-ab2a-46f4-8eae-db3583c7a49c"), "Other" }
                });

            migrationBuilder.InsertData(
                table: "tblMovieGenre",
                columns: new[] { "Id", "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("1e39f8cc-58b1-40b1-ad4c-7550e27c8f30"), new Guid("7fdd941c-249f-4d02-a3d5-ebdf054d6912"), new Guid("bdac7d92-bb6c-402e-b53b-be9156ca58df") },
                    { new Guid("2ce93fdf-7a08-4edb-b027-b5ec04f85768"), new Guid("798ae005-3b38-401a-90f8-357f6dd8e3e6"), new Guid("77824d82-82b6-4cdf-a769-ec56b1b6c356") },
                    { new Guid("2d4b4397-2bf7-40c9-8db4-a5ab526389f9"), new Guid("0a5369f8-f7a7-4002-8643-d6d46a1776f0"), new Guid("6a89be25-06c3-4e6b-9616-03ad4714e685") },
                    { new Guid("2e930790-caf7-4f80-a694-eb56f1608134"), new Guid("798ae005-3b38-401a-90f8-357f6dd8e3e6"), new Guid("9b90cc6e-1c59-436e-aa6c-f6a5770d36ec") },
                    { new Guid("31ca17c0-8fb2-4440-a4ad-07be975ab236"), new Guid("0ac4af58-5882-4547-b55d-1ec19bbb9528"), new Guid("9b90cc6e-1c59-436e-aa6c-f6a5770d36ec") },
                    { new Guid("468c56f9-7cc5-42a6-a322-6bb6e6527db4"), new Guid("b37a851c-d258-424e-9505-70a9a8e1c7a2"), new Guid("bdac7d92-bb6c-402e-b53b-be9156ca58df") },
                    { new Guid("46cd753e-d141-4eba-aa8b-f7ef514ab07c"), new Guid("b37a851c-d258-424e-9505-70a9a8e1c7a2"), new Guid("77824d82-82b6-4cdf-a769-ec56b1b6c356") },
                    { new Guid("63a87660-9a62-44f2-bdaf-a49e1fb5054d"), new Guid("573ea92b-1419-4a9b-8b9d-a26330ed0d1b"), new Guid("77824d82-82b6-4cdf-a769-ec56b1b6c356") },
                    { new Guid("9fa7a9a4-99b6-4f57-a1e1-b088df1e7dbf"), new Guid("b37a851c-d258-424e-9505-70a9a8e1c7a2"), new Guid("45cc25ff-57b6-48ad-b0d3-cc7692f53eee") },
                    { new Guid("a54b9117-915e-4fd9-94c8-9e73b643859a"), new Guid("b37a851c-d258-424e-9505-70a9a8e1c7a2"), new Guid("83d4046b-69e5-4701-813a-e7cbc0d984cd") },
                    { new Guid("e52c2c0e-b92e-4437-94e3-580928d96fdd"), new Guid("09889e20-531c-4258-a177-0bbca611099d"), new Guid("9b90cc6e-1c59-436e-aa6c-f6a5770d36ec") },
                    { new Guid("e60fb601-12ec-438b-bfb9-af01daf39cb1"), new Guid("798ae005-3b38-401a-90f8-357f6dd8e3e6"), new Guid("83d4046b-69e5-4701-813a-e7cbc0d984cd") },
                    { new Guid("ef8f1d6d-aae3-4cb9-95a9-0a66fcfce664"), new Guid("573ea92b-1419-4a9b-8b9d-a26330ed0d1b"), new Guid("45cc25ff-57b6-48ad-b0d3-cc7692f53eee") }
                });

            migrationBuilder.InsertData(
                table: "tblOrder",
                columns: new[] { "Id", "CustomerId", "OrderDate", "ShipDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("a188a96c-2bcb-4701-b3c6-fdb2871d58f8"), new Guid("56d46d8c-6e38-4d1a-83f5-7d23c3f97f2f"), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("064a9ab2-c3f9-4762-8725-211a410ec121") },
                    { new Guid("ce120240-8280-4c4a-91f1-5cd83fc1140d"), new Guid("9774781c-d9d0-418b-8d34-a74a72e3a930"), new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5051dd18-3f2f-4994-88dc-ddad097dce98") },
                    { new Guid("d3f533ae-2c41-4a2c-af0e-97030318d557"), new Guid("56d46d8c-6e38-4d1a-83f5-7d23c3f97f2f"), new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5051dd18-3f2f-4994-88dc-ddad097dce98") }
                });

            migrationBuilder.InsertData(
                table: "tblOrderItem",
                columns: new[] { "Id", "Cost", "MovieId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("2982eaa1-8ca1-43af-b7b6-9ef3f9453b79"), 8.9900000000000002, new Guid("77824d82-82b6-4cdf-a769-ec56b1b6c356"), new Guid("d3f533ae-2c41-4a2c-af0e-97030318d557"), 1 },
                    { new Guid("40197c7f-cf52-45d9-8aa8-6aadc3535799"), 10.99, new Guid("45cc25ff-57b6-48ad-b0d3-cc7692f53eee"), new Guid("a188a96c-2bcb-4701-b3c6-fdb2871d58f8"), 1 },
                    { new Guid("b2289530-8829-4c47-a0a7-dc6cefbc36dd"), 9.9900000000000002, new Guid("45cc25ff-57b6-48ad-b0d3-cc7692f53eee"), new Guid("d3f533ae-2c41-4a2c-af0e-97030318d557"), 1 }
                });

            migrationBuilder.InsertData(
                table: "tblRating",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("118ea8d9-aa86-436e-8616-d00c946caf18"), "PG" },
                    { new Guid("27b904f1-ca8a-433c-8646-51caec1cf297"), "Other" },
                    { new Guid("4ae04e4b-7816-4e18-bf71-54c5437c6356"), "R" },
                    { new Guid("b8d9370b-ab2a-46f4-8eae-db3583c7a49c"), "G" },
                    { new Guid("bf9b53fe-b6f9-4077-9288-8d366ac1199c"), "PG-13" }
                });

            migrationBuilder.InsertData(
                table: "tblUser",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserId" },
                values: new object[,]
                {
                    { new Guid("064a9ab2-c3f9-4762-8725-211a410ec121"), "Brian", "Foote", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "bfoote" },
                    { new Guid("5051dd18-3f2f-4994-88dc-ddad097dce98"), "John", "Doro", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "jdoro" },
                    { new Guid("8a881c24-fca7-4ef2-99a9-1acc4606c763"), "Steve", "Marin", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "smarin" },
                    { new Guid("c5585438-0d6c-4eec-b21a-cc64c7f3c604"), "Other", "Other", "X1BEO/529yeajg8vCpiXXNv/OOk=", "sophie" }
                });
        }
    }
}
