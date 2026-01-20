using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BDF.DVDCentral.PL.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCustomer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Zip = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    Phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomer_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblDirector",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDirector_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblFormat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFormat_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblGenre",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGenre_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMovie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    FormatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    InStkQty = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMovie_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMovieGenre",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMovieGenre_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ShipDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrder_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblOrderItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrderItem_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblRating",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRating_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Password = table.Column<string>(type: "varchar(28)", unicode: false, maxLength: 28, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser_Id", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCustomer");

            migrationBuilder.DropTable(
                name: "tblDirector");

            migrationBuilder.DropTable(
                name: "tblFormat");

            migrationBuilder.DropTable(
                name: "tblGenre");

            migrationBuilder.DropTable(
                name: "tblMovie");

            migrationBuilder.DropTable(
                name: "tblMovieGenre");

            migrationBuilder.DropTable(
                name: "tblOrder");

            migrationBuilder.DropTable(
                name: "tblOrderItem");

            migrationBuilder.DropTable(
                name: "tblRating");

            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
