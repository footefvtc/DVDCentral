using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BDF.DVDCentral.PL.Migrations
{
    /// <inheritdoc />
    public partial class AddMyStoredProcedure : Migration
    {


        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    FormatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    InStkQty = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormatDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.InsertData(
                table: "tblDirector",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("08854003-57d3-492a-b0f3-fa3fcf286abe"), "Other", "Other" },
                    { new Guid("1fa3262c-facb-4a87-a829-258356580f24"), "George", "Lucas" },
                    { new Guid("378df2de-fd08-429e-99e8-8e89dc689bf6"), "Clint", "Eastwood" },
                    { new Guid("3ddc8157-5ce9-4537-92c3-932bd82ed3ad"), "Steven", "Spielberg" },
                    { new Guid("622b213c-c240-4ac7-adc3-feec6a001cb8"), "Rob", "Reiner" },
                    { new Guid("dee911a9-9dec-4022-abdd-29a1f997bfd8"), "John", "Avildsen" }
                });

            migrationBuilder.InsertData(
                table: "tblFormat",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("36be7e9e-4901-45f3-b15d-06dd219c3483"), "Blu-Ray" },
                    { new Guid("9c13eacf-a220-4f95-84ca-8dad09982ed1"), "DVD" },
                    { new Guid("bbcb1876-5f2c-45ee-ade5-71dd9723c7f3"), "VHS" },
                    { new Guid("c85d45f6-f13c-4025-90e0-ce5846a32f8b"), "Other" }
                });

            migrationBuilder.InsertData(
                table: "tblGenre",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("1c73ca74-a653-4de3-8fcb-4e1f1359bdf5"), "Action" },
                    { new Guid("55e0ab56-c6a2-44d2-b956-ae0c60a4e000"), "Sci-Fi" },
                    { new Guid("79b12ea8-3099-4cef-b100-91be9ce72b1e"), "Romance" },
                    { new Guid("7e4650e8-9431-44f9-8100-c55c9dc41e64"), "Other" },
                    { new Guid("7ee91343-af4d-425d-b46c-0c8f14ab6fd8"), "Documentary" },
                    { new Guid("9d7bbe2d-d41b-4cdd-a697-7c83519ca4bd"), "Mystery" },
                    { new Guid("b3652ff2-171d-44ce-b506-cf0aae3c3285"), "Western" },
                    { new Guid("d28e71a2-e2de-403c-b618-8752dab8f921"), "Musical" },
                    { new Guid("e79d4aeb-76b7-4063-9819-3101261d81af"), "Horror" },
                    { new Guid("ec2d0b8e-13b2-4005-9a2c-5fb094fe2702"), "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "tblRating",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("35f1d110-6db9-4946-84c7-26fa999e3d8d"), "PG" },
                    { new Guid("77b4cd7e-2a9b-4ca0-941a-8ee613ffd32e"), "R" },
                    { new Guid("bbfb250d-4320-4e4d-9ae3-281541a25731"), "Other" },
                    { new Guid("e0790961-a07f-4c86-acbe-230762b36171"), "G" },
                    { new Guid("f4f7e340-4b54-48ef-9586-6ca967cf0b32"), "PG-13" }
                });

            migrationBuilder.InsertData(
                table: "tblUser",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserId" },
                values: new object[,]
                {
                    { new Guid("2f7cdf07-aba3-46f8-b772-e23e4b206b3c"), "Steve", "Marin", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "smarin" },
                    { new Guid("51a3e110-4cb6-4302-8a4e-2e02b0fa1b2c"), "Brian", "Foote", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "bfoote" },
                    { new Guid("c9bfc8b6-5674-4c86-bc88-df5c4b2080c5"), "John", "Doro", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "jdoro" },
                    { new Guid("e0b8d7bd-c269-462d-804c-2f725125b28c"), "Other", "Other", "X1BEO/529yeajg8vCpiXXNv/OOk=", "sophie" }
                });

            migrationBuilder.InsertData(
                table: "tblCustomer",
                columns: new[] { "Id", "Address", "City", "FirstName", "LastName", "Phone", "State", "UserId", "Zip" },
                values: new object[,]
                {
                    { new Guid("1502d7fa-c62d-40ba-950a-3bcd6cf53034"), "159 Johnson Avenue", "Allenton", "Other", "Other", "9202623415", "WI", new Guid("51a3e110-4cb6-4302-8a4e-2e02b0fa1b2c"), "53142" },
                    { new Guid("29c6d19a-253b-4719-82dc-e6e51fa0e8d5"), "159 Johnson Avenue", "Allenton", "Brian", "Foote", "9202623415", "WI", new Guid("51a3e110-4cb6-4302-8a4e-2e02b0fa1b2c"), "53142" },
                    { new Guid("36cc4c6a-1b04-431c-90bc-e4b02ff27829"), "987 Willow Road", "Slinger", "John", "Doro", "9202623345", "WI", new Guid("c9bfc8b6-5674-4c86-bc88-df5c4b2080c5"), "56495" },
                    { new Guid("e42de403-2576-488e-8da2-595e5ce53391"), "453 Oak Street", "Fond du Lac", "Steve", "Marin", "9205879797", "WI", new Guid("2f7cdf07-aba3-46f8-b772-e23e4b206b3c"), "54935" }
                });

            migrationBuilder.InsertData(
                table: "tblMovie",
                columns: new[] { "Id", "Cost", "Description", "DirectorId", "FormatId", "ImagePath", "InStkQty", "RatingId", "Title" },
                values: new object[,]
                {
                    { new Guid("16ee85f2-4eda-4fc5-955e-b0098167d9fd"), 6.9900000000000002, "Other", new Guid("dee911a9-9dec-4022-abdd-29a1f997bfd8"), new Guid("bbcb1876-5f2c-45ee-ade5-71dd9723c7f3"), "Rocky.jpg", 2, new Guid("e0790961-a07f-4c86-acbe-230762b36171"), "Other" },
                    { new Guid("38d5fcc4-39fe-422c-9f49-608c2e9e2c7c"), 8.9900000000000002, "Jaws is a 1975 American thriller film directed by Steven Spielberg and based on the Peter Benchley 1974 novel of the same name.", new Guid("3ddc8157-5ce9-4537-92c3-932bd82ed3ad"), new Guid("9c13eacf-a220-4f95-84ca-8dad09982ed1"), "Jaws1.jpg", 1, new Guid("f4f7e340-4b54-48ef-9586-6ca967cf0b32"), "Jaws" },
                    { new Guid("4c015640-3c5e-4dd8-9020-01350459bf52"), 9.9900000000000002, "Pale Rider is a 1985 American Western film produced and directed by Clint Eastwood, who also stars in the lead role.", new Guid("3ddc8157-5ce9-4537-92c3-932bd82ed3ad"), new Guid("9c13eacf-a220-4f95-84ca-8dad09982ed1"), "PaleRider.jpg", 1, new Guid("f4f7e340-4b54-48ef-9586-6ca967cf0b32"), "Pale Rider" },
                    { new Guid("6d1daac8-52f5-4df1-8987-6a80c87803b5"), 12.5, "The Princess Bride is a 1987 American fantasy adventure comedy film directed and co-produced by Rob Reiner, starring Cary Elwes, Robin Wright, Mandy Patinkin, Chris Sarandon, Wallace Shawn, André the Giant, and Christopher Guest.", new Guid("622b213c-c240-4ac7-adc3-feec6a001cb8"), new Guid("36be7e9e-4901-45f3-b15d-06dd219c3483"), "PrincessBride.jpg", 4, new Guid("35f1d110-6db9-4946-84c7-26fa999e3d8d"), "The Princess Bride" },
                    { new Guid("78ce64de-8473-4443-9d11-46fc776db418"), 6.9900000000000002, "Rocky is a 1976 American sports drama film directed by John G. Avildsen, written by and starring Sylvester Stallone.", new Guid("dee911a9-9dec-4022-abdd-29a1f997bfd8"), new Guid("bbcb1876-5f2c-45ee-ade5-71dd9723c7f3"), "Rocky.jpg", 2, new Guid("e0790961-a07f-4c86-acbe-230762b36171"), "Rocky" },
                    { new Guid("8c215c6b-5faa-44e9-93e2-e5273ca6d93e"), 7.5, "Star Wars: Episode IV – A New Hope is a 1977 American epic space-opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", new Guid("3ddc8157-5ce9-4537-92c3-932bd82ed3ad"), new Guid("9c13eacf-a220-4f95-84ca-8dad09982ed1"), "StarWarsNewHope.jpg", 1, new Guid("f4f7e340-4b54-48ef-9586-6ca967cf0b32"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("b1689e29-3578-44a8-8e4d-18ba55663a4b"), 10.5, "Indiana Jones and the Last Crusade is a 1989 American action-adventure film directed by Steven Spielberg, from a story co-written by executive producer George Lucas.", new Guid("1fa3262c-facb-4a87-a829-258356580f24"), new Guid("36be7e9e-4901-45f3-b15d-06dd219c3483"), "IndianaJonesLastCrusade.jpg", 2, new Guid("77b4cd7e-2a9b-4ca0-941a-8ee613ffd32e"), "Indiana Jones and the Last Crusade" }
                });

            migrationBuilder.InsertData(
                table: "tblMovieGenre",
                columns: new[] { "Id", "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("08ccfbeb-a00f-4929-8186-82202d148927"), new Guid("e79d4aeb-76b7-4063-9819-3101261d81af"), new Guid("8c215c6b-5faa-44e9-93e2-e5273ca6d93e") },
                    { new Guid("0b28bc10-9dc2-4220-b6de-3a8b65515096"), new Guid("1c73ca74-a653-4de3-8fcb-4e1f1359bdf5"), new Guid("6d1daac8-52f5-4df1-8987-6a80c87803b5") },
                    { new Guid("138be0a1-ab84-4627-adac-cf0355e9c75c"), new Guid("7ee91343-af4d-425d-b46c-0c8f14ab6fd8"), new Guid("b1689e29-3578-44a8-8e4d-18ba55663a4b") },
                    { new Guid("2cdc6da3-8e26-4cdc-a925-9544b73ad703"), new Guid("e79d4aeb-76b7-4063-9819-3101261d81af"), new Guid("78ce64de-8473-4443-9d11-46fc776db418") },
                    { new Guid("3e36f610-f91f-4946-a3ae-48de257f2c66"), new Guid("e79d4aeb-76b7-4063-9819-3101261d81af"), new Guid("38d5fcc4-39fe-422c-9f49-608c2e9e2c7c") },
                    { new Guid("59b680b6-6ab5-4205-a180-27c1d2ef39b4"), new Guid("55e0ab56-c6a2-44d2-b956-ae0c60a4e000"), new Guid("38d5fcc4-39fe-422c-9f49-608c2e9e2c7c") },
                    { new Guid("5c7da3c9-a390-4b4f-a57f-677d2b632ee9"), new Guid("d28e71a2-e2de-403c-b618-8752dab8f921"), new Guid("8c215c6b-5faa-44e9-93e2-e5273ca6d93e") },
                    { new Guid("6c1b5a28-c52b-469e-82aa-29c2b551c672"), new Guid("ec2d0b8e-13b2-4005-9a2c-5fb094fe2702"), new Guid("6d1daac8-52f5-4df1-8987-6a80c87803b5") },
                    { new Guid("7e513a49-60b1-44e6-a653-c97ce77cf92d"), new Guid("7ee91343-af4d-425d-b46c-0c8f14ab6fd8"), new Guid("6d1daac8-52f5-4df1-8987-6a80c87803b5") },
                    { new Guid("9f683363-6249-40fd-92d2-5be78cb4fb1d"), new Guid("7ee91343-af4d-425d-b46c-0c8f14ab6fd8"), new Guid("78ce64de-8473-4443-9d11-46fc776db418") },
                    { new Guid("a585b868-7417-4bd0-9128-c77971c17151"), new Guid("55e0ab56-c6a2-44d2-b956-ae0c60a4e000"), new Guid("78ce64de-8473-4443-9d11-46fc776db418") },
                    { new Guid("a7a3a48e-01ad-4993-94a8-c53bdba88c75"), new Guid("e79d4aeb-76b7-4063-9819-3101261d81af"), new Guid("b1689e29-3578-44a8-8e4d-18ba55663a4b") },
                    { new Guid("fb66407c-7c8b-4df2-b5ff-551cab117e1d"), new Guid("9d7bbe2d-d41b-4cdd-a697-7c83519ca4bd"), new Guid("4c015640-3c5e-4dd8-9020-01350459bf52") }
                });

            migrationBuilder.InsertData(
                table: "tblOrder",
                columns: new[] { "Id", "CustomerId", "OrderDate", "ShipDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("33eb407f-d23c-40b0-8887-083f72f4e4c1"), new Guid("29c6d19a-253b-4719-82dc-e6e51fa0e8d5"), new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9bfc8b6-5674-4c86-bc88-df5c4b2080c5") },
                    { new Guid("d92bb350-aa62-472f-8168-217ac1cbddde"), new Guid("36cc4c6a-1b04-431c-90bc-e4b02ff27829"), new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9bfc8b6-5674-4c86-bc88-df5c4b2080c5") },
                    { new Guid("f411a2ba-a7c0-430a-a8e1-6dede48f9a9f"), new Guid("29c6d19a-253b-4719-82dc-e6e51fa0e8d5"), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("51a3e110-4cb6-4302-8a4e-2e02b0fa1b2c") }
                });

            migrationBuilder.InsertData(
                table: "tblOrderItem",
                columns: new[] { "Id", "Cost", "MovieId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("30eb7f90-48a8-435d-80c9-a497c7b4858f"), 8.9900000000000002, new Guid("78ce64de-8473-4443-9d11-46fc776db418"), new Guid("33eb407f-d23c-40b0-8887-083f72f4e4c1"), 1 },
                    { new Guid("616e7198-0632-4f2c-a4fc-26e09a0355aa"), 9.9900000000000002, new Guid("38d5fcc4-39fe-422c-9f49-608c2e9e2c7c"), new Guid("33eb407f-d23c-40b0-8887-083f72f4e4c1"), 1 },
                    { new Guid("632e641e-26af-4a89-88b2-848e0718e59b"), 10.99, new Guid("38d5fcc4-39fe-422c-9f49-608c2e9e2c7c"), new Guid("f411a2ba-a7c0-430a-a8e1-6dede48f9a9f"), 1 }
                });
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
                keyValue: new Guid("1502d7fa-c62d-40ba-950a-3bcd6cf53034"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("e42de403-2576-488e-8da2-595e5ce53391"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("08854003-57d3-492a-b0f3-fa3fcf286abe"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("378df2de-fd08-429e-99e8-8e89dc689bf6"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("c85d45f6-f13c-4025-90e0-ce5846a32f8b"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("79b12ea8-3099-4cef-b100-91be9ce72b1e"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("7e4650e8-9431-44f9-8100-c55c9dc41e64"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("b3652ff2-171d-44ce-b506-cf0aae3c3285"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("16ee85f2-4eda-4fc5-955e-b0098167d9fd"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("08ccfbeb-a00f-4929-8186-82202d148927"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("0b28bc10-9dc2-4220-b6de-3a8b65515096"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("138be0a1-ab84-4627-adac-cf0355e9c75c"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("2cdc6da3-8e26-4cdc-a925-9544b73ad703"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("3e36f610-f91f-4946-a3ae-48de257f2c66"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("59b680b6-6ab5-4205-a180-27c1d2ef39b4"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("5c7da3c9-a390-4b4f-a57f-677d2b632ee9"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("6c1b5a28-c52b-469e-82aa-29c2b551c672"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("7e513a49-60b1-44e6-a653-c97ce77cf92d"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("9f683363-6249-40fd-92d2-5be78cb4fb1d"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("a585b868-7417-4bd0-9128-c77971c17151"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("a7a3a48e-01ad-4993-94a8-c53bdba88c75"));

            migrationBuilder.DeleteData(
                table: "tblMovieGenre",
                keyColumn: "Id",
                keyValue: new Guid("fb66407c-7c8b-4df2-b5ff-551cab117e1d"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("d92bb350-aa62-472f-8168-217ac1cbddde"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("30eb7f90-48a8-435d-80c9-a497c7b4858f"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("616e7198-0632-4f2c-a4fc-26e09a0355aa"));

            migrationBuilder.DeleteData(
                table: "tblOrderItem",
                keyColumn: "Id",
                keyValue: new Guid("632e641e-26af-4a89-88b2-848e0718e59b"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("bbfb250d-4320-4e4d-9ae3-281541a25731"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("e0b8d7bd-c269-462d-804c-2f725125b28c"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("36cc4c6a-1b04-431c-90bc-e4b02ff27829"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("1c73ca74-a653-4de3-8fcb-4e1f1359bdf5"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("55e0ab56-c6a2-44d2-b956-ae0c60a4e000"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("7ee91343-af4d-425d-b46c-0c8f14ab6fd8"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("9d7bbe2d-d41b-4cdd-a697-7c83519ca4bd"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("d28e71a2-e2de-403c-b618-8752dab8f921"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("e79d4aeb-76b7-4063-9819-3101261d81af"));

            migrationBuilder.DeleteData(
                table: "tblGenre",
                keyColumn: "Id",
                keyValue: new Guid("ec2d0b8e-13b2-4005-9a2c-5fb094fe2702"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("38d5fcc4-39fe-422c-9f49-608c2e9e2c7c"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("4c015640-3c5e-4dd8-9020-01350459bf52"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("6d1daac8-52f5-4df1-8987-6a80c87803b5"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("78ce64de-8473-4443-9d11-46fc776db418"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("8c215c6b-5faa-44e9-93e2-e5273ca6d93e"));

            migrationBuilder.DeleteData(
                table: "tblMovie",
                keyColumn: "Id",
                keyValue: new Guid("b1689e29-3578-44a8-8e4d-18ba55663a4b"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("33eb407f-d23c-40b0-8887-083f72f4e4c1"));

            migrationBuilder.DeleteData(
                table: "tblOrder",
                keyColumn: "Id",
                keyValue: new Guid("f411a2ba-a7c0-430a-a8e1-6dede48f9a9f"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("2f7cdf07-aba3-46f8-b772-e23e4b206b3c"));

            migrationBuilder.DeleteData(
                table: "tblCustomer",
                keyColumn: "Id",
                keyValue: new Guid("29c6d19a-253b-4719-82dc-e6e51fa0e8d5"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("1fa3262c-facb-4a87-a829-258356580f24"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("3ddc8157-5ce9-4537-92c3-932bd82ed3ad"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("622b213c-c240-4ac7-adc3-feec6a001cb8"));

            migrationBuilder.DeleteData(
                table: "tblDirector",
                keyColumn: "Id",
                keyValue: new Guid("dee911a9-9dec-4022-abdd-29a1f997bfd8"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("36be7e9e-4901-45f3-b15d-06dd219c3483"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("9c13eacf-a220-4f95-84ca-8dad09982ed1"));

            migrationBuilder.DeleteData(
                table: "tblFormat",
                keyColumn: "Id",
                keyValue: new Guid("bbcb1876-5f2c-45ee-ade5-71dd9723c7f3"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("35f1d110-6db9-4946-84c7-26fa999e3d8d"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("77b4cd7e-2a9b-4ca0-941a-8ee613ffd32e"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("e0790961-a07f-4c86-acbe-230762b36171"));

            migrationBuilder.DeleteData(
                table: "tblRating",
                keyColumn: "Id",
                keyValue: new Guid("f4f7e340-4b54-48ef-9586-6ca967cf0b32"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("c9bfc8b6-5674-4c86-bc88-df5c4b2080c5"));

            migrationBuilder.DeleteData(
                table: "tblUser",
                keyColumn: "Id",
                keyValue: new Guid("51a3e110-4cb6-4302-8a4e-2e02b0fa1b2c"));

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
