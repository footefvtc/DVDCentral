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
                    table.ForeignKey(
                        name: "FK_tblMovie_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "tblDirector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblMovie_FormatId",
                        column: x => x.FormatId,
                        principalTable: "tblFormat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblMovie_RatingId",
                        column: x => x.RatingId,
                        principalTable: "tblRating",
                        principalColumn: "Id");
                });

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
                    table.ForeignKey(
                        name: "FK_tblCustomer_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "Id");
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
                    table.ForeignKey(
                        name: "tblMovieGenre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "tblGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "tblMovieGenre_MovieId",
                        column: x => x.MovieId,
                        principalTable: "tblMovie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_tblOrder_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "tblCustomer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblOrder_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_tblOrderItem_OrderId",
                        column: x => x.OrderId,
                        principalTable: "tblOrder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblOrderItem_tblMovie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "tblMovie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblDirector",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("14e12a61-7686-4ab8-b52d-e0b5326ffb0a"), "Rob", "Reiner" },
                    { new Guid("2192ce1b-d58b-42bf-a3d0-9541d978e02e"), "George", "Lucas" },
                    { new Guid("2aae61f2-e655-496d-957b-0fb9fa04eeb0"), "Clint", "Eastwood" },
                    { new Guid("9b834fe5-6fff-4997-ba55-d9fcafcf468f"), "John", "Avildsen" },
                    { new Guid("aa53c8eb-341c-455c-83b6-c6bdf63c65bc"), "Steven", "Spielberg" },
                    { new Guid("cebf514d-5c31-45f1-af7d-ee05c3240961"), "Other", "Other" }
                });

            migrationBuilder.InsertData(
                table: "tblFormat",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("3e9ccf22-c4e6-4cd7-86b3-cea3615b4593"), "VHS" },
                    { new Guid("b54b8fbf-912a-4b2f-883f-21cd7890de08"), "Blu-Ray" },
                    { new Guid("b5b7fc65-43ad-4d4e-9849-034f4f5de04c"), "Other" },
                    { new Guid("ddc2c9f4-9924-4b5d-a069-fa94d5612ec2"), "DVD" }
                });

            migrationBuilder.InsertData(
                table: "tblGenre",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("11223866-4298-486f-99dc-f2c5d90d4e36"), "Other" },
                    { new Guid("206c6b8a-153f-4865-a21b-1ca05883b442"), "Western" },
                    { new Guid("4940bdbc-0669-40f3-b0a1-0297bfa68889"), "Comedy" },
                    { new Guid("4ad4270b-e1fc-401d-bb47-5dd3240a7582"), "Romance" },
                    { new Guid("70de320c-bc5a-46ed-b7ce-3759bddee213"), "Horror" },
                    { new Guid("856146aa-cb28-4118-8e01-5a0d7fe4c078"), "Sci-Fi" },
                    { new Guid("8b1f45e3-94ff-4de3-91d1-750bae029ae3"), "Musical" },
                    { new Guid("a08dd089-c643-40f3-af07-f7203f73b8e7"), "Mystery" },
                    { new Guid("bd973808-5459-40cb-9b0a-c097bf8dd51f"), "Documentary" },
                    { new Guid("d02a8a04-b776-41e7-84f5-45f8c001ddcb"), "Action" }
                });

            migrationBuilder.InsertData(
                table: "tblRating",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("06d3a510-1126-4e26-9bab-f7836e0b9430"), "PG-13" },
                    { new Guid("093721dc-f8b2-4ac6-bce5-db0e0d390002"), "PG" },
                    { new Guid("11e5c391-9ea7-494f-966c-5cc622bc2a05"), "G" },
                    { new Guid("41bd2a90-ea93-45ff-afb6-5d30be30a82f"), "Other" },
                    { new Guid("8319f572-0b50-4595-843d-3ea72dffa6b6"), "R" }
                });

            migrationBuilder.InsertData(
                table: "tblUser",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c7bb3c2-e2b2-4203-b15b-a4ff5cf7fed5"), "Other", "Other", "X1BEO/529yeajg8vCpiXXNv/OOk=", "sophie" },
                    { new Guid("8ea8177b-0d8b-4485-a65d-d7d4f3355a80"), "Brian", "Foote", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "bfoote" },
                    { new Guid("af0c6cae-232e-4374-b987-8f1b1926d0f8"), "John", "Doro", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "jdoro" },
                    { new Guid("b2a6d8ee-baef-475d-8b69-8a801c1f1df3"), "Steve", "Marin", "pYfdnNb8sO0FgS4H0MRSwLGOIME=", "smarin" }
                });

            migrationBuilder.InsertData(
                table: "tblCustomer",
                columns: new[] { "Id", "Address", "City", "FirstName", "LastName", "Phone", "State", "UserId", "Zip" },
                values: new object[,]
                {
                    { new Guid("0d25ae19-5f37-4f67-872c-6ff8356b7367"), "159 Johnson Avenue", "Allenton", "Brian", "Foote", "9202623415", "WI", new Guid("8ea8177b-0d8b-4485-a65d-d7d4f3355a80"), "53142" },
                    { new Guid("1d530b0f-2e5e-48d1-9432-1506d07af0ee"), "987 Willow Road", "Slinger", "John", "Doro", "9202623345", "WI", new Guid("af0c6cae-232e-4374-b987-8f1b1926d0f8"), "56495" },
                    { new Guid("456f6618-3b75-4976-ba86-2b42517dbebf"), "159 Johnson Avenue", "Allenton", "Other", "Other", "9202623415", "WI", new Guid("8ea8177b-0d8b-4485-a65d-d7d4f3355a80"), "53142" },
                    { new Guid("ab5c14a4-5cc1-4d33-a0e8-bdfd645edb21"), "453 Oak Street", "Fond du Lac", "Steve", "Marin", "9205879797", "WI", new Guid("b2a6d8ee-baef-475d-8b69-8a801c1f1df3"), "54935" }
                });

            migrationBuilder.InsertData(
                table: "tblMovie",
                columns: new[] { "Id", "Cost", "Description", "DirectorId", "FormatId", "ImagePath", "InStkQty", "RatingId", "Title" },
                values: new object[,]
                {
                    { new Guid("0bddd30b-c549-4b36-91d3-023909e59231"), 6.9900000000000002, "Other", new Guid("9b834fe5-6fff-4997-ba55-d9fcafcf468f"), new Guid("3e9ccf22-c4e6-4cd7-86b3-cea3615b4593"), "Rocky.jpg", 2, new Guid("11e5c391-9ea7-494f-966c-5cc622bc2a05"), "Other" },
                    { new Guid("1d659b3e-4c4f-49a3-9ea1-4253b944bb89"), 9.9900000000000002, "Pale Rider is a 1985 American Western film produced and directed by Clint Eastwood, who also stars in the lead role.", new Guid("aa53c8eb-341c-455c-83b6-c6bdf63c65bc"), new Guid("ddc2c9f4-9924-4b5d-a069-fa94d5612ec2"), "PaleRider.jpg", 1, new Guid("06d3a510-1126-4e26-9bab-f7836e0b9430"), "Pale Rider" },
                    { new Guid("1e058a09-763c-4a30-b862-2436a7611d02"), 12.5, "The Princess Bride is a 1987 American fantasy adventure comedy film directed and co-produced by Rob Reiner, starring Cary Elwes, Robin Wright, Mandy Patinkin, Chris Sarandon, Wallace Shawn, André the Giant, and Christopher Guest.", new Guid("14e12a61-7686-4ab8-b52d-e0b5326ffb0a"), new Guid("b54b8fbf-912a-4b2f-883f-21cd7890de08"), "PrincessBride.jpg", 4, new Guid("093721dc-f8b2-4ac6-bce5-db0e0d390002"), "The Princess Bride" },
                    { new Guid("4f2641e5-aee3-4886-a83b-f5c6f5decde3"), 10.5, "Indiana Jones and the Last Crusade is a 1989 American action-adventure film directed by Steven Spielberg, from a story co-written by executive producer George Lucas.", new Guid("2192ce1b-d58b-42bf-a3d0-9541d978e02e"), new Guid("b54b8fbf-912a-4b2f-883f-21cd7890de08"), "IndianaJonesLastCrusade.jpg", 2, new Guid("8319f572-0b50-4595-843d-3ea72dffa6b6"), "Indiana Jones and the Last Crusade" },
                    { new Guid("77bd3f3a-70e2-46ad-a0a3-16d3297fc86e"), 8.9900000000000002, "Jaws is a 1975 American thriller film directed by Steven Spielberg and based on the Peter Benchley 1974 novel of the same name.", new Guid("aa53c8eb-341c-455c-83b6-c6bdf63c65bc"), new Guid("ddc2c9f4-9924-4b5d-a069-fa94d5612ec2"), "Jaws1.jpg", 1, new Guid("06d3a510-1126-4e26-9bab-f7836e0b9430"), "Jaws" },
                    { new Guid("83039748-b641-48f4-a729-878c19321779"), 7.5, "Star Wars: Episode IV – A New Hope is a 1977 American epic space-opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", new Guid("aa53c8eb-341c-455c-83b6-c6bdf63c65bc"), new Guid("ddc2c9f4-9924-4b5d-a069-fa94d5612ec2"), "StarWarsNewHope.jpg", 1, new Guid("06d3a510-1126-4e26-9bab-f7836e0b9430"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("a175333c-62e2-4e59-96ef-0df176b35b68"), 6.9900000000000002, "Rocky is a 1976 American sports drama film directed by John G. Avildsen, written by and starring Sylvester Stallone.", new Guid("9b834fe5-6fff-4997-ba55-d9fcafcf468f"), new Guid("3e9ccf22-c4e6-4cd7-86b3-cea3615b4593"), "Rocky.jpg", 2, new Guid("11e5c391-9ea7-494f-966c-5cc622bc2a05"), "Rocky" }
                });

            migrationBuilder.InsertData(
                table: "tblMovieGenre",
                columns: new[] { "Id", "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("020177e8-a4c7-4349-8fcc-bc58f1687636"), new Guid("8b1f45e3-94ff-4de3-91d1-750bae029ae3"), new Guid("83039748-b641-48f4-a729-878c19321779") },
                    { new Guid("06a35923-e293-4f2d-865b-7ddc3e3d38bc"), new Guid("70de320c-bc5a-46ed-b7ce-3759bddee213"), new Guid("83039748-b641-48f4-a729-878c19321779") },
                    { new Guid("0967604f-3bbb-4d5b-9398-abf1a68884b4"), new Guid("856146aa-cb28-4118-8e01-5a0d7fe4c078"), new Guid("77bd3f3a-70e2-46ad-a0a3-16d3297fc86e") },
                    { new Guid("107729ad-3890-42fd-80eb-ecc19bc0ce92"), new Guid("bd973808-5459-40cb-9b0a-c097bf8dd51f"), new Guid("4f2641e5-aee3-4886-a83b-f5c6f5decde3") },
                    { new Guid("76453fe9-1c51-4b6e-b9be-b7c337074da1"), new Guid("856146aa-cb28-4118-8e01-5a0d7fe4c078"), new Guid("a175333c-62e2-4e59-96ef-0df176b35b68") },
                    { new Guid("78ee0a68-bab7-4fe6-8ca0-3cf2820a53d4"), new Guid("a08dd089-c643-40f3-af07-f7203f73b8e7"), new Guid("1d659b3e-4c4f-49a3-9ea1-4253b944bb89") },
                    { new Guid("7abff031-9243-4974-8115-e0f81537d40e"), new Guid("70de320c-bc5a-46ed-b7ce-3759bddee213"), new Guid("a175333c-62e2-4e59-96ef-0df176b35b68") },
                    { new Guid("7fc88c92-c921-4245-a92d-403732691e0c"), new Guid("d02a8a04-b776-41e7-84f5-45f8c001ddcb"), new Guid("1e058a09-763c-4a30-b862-2436a7611d02") },
                    { new Guid("9a3a4bb3-7567-43b3-b05a-c8e29d17c26b"), new Guid("bd973808-5459-40cb-9b0a-c097bf8dd51f"), new Guid("1e058a09-763c-4a30-b862-2436a7611d02") },
                    { new Guid("bc2d27ef-eef2-473e-a87b-e283f97e84b5"), new Guid("4940bdbc-0669-40f3-b0a1-0297bfa68889"), new Guid("1e058a09-763c-4a30-b862-2436a7611d02") },
                    { new Guid("bcda6e98-2cab-4b78-9396-3d5d0572c98e"), new Guid("70de320c-bc5a-46ed-b7ce-3759bddee213"), new Guid("4f2641e5-aee3-4886-a83b-f5c6f5decde3") },
                    { new Guid("bfbe750f-c78b-4610-b9a5-e77ff288b496"), new Guid("bd973808-5459-40cb-9b0a-c097bf8dd51f"), new Guid("a175333c-62e2-4e59-96ef-0df176b35b68") },
                    { new Guid("c26e0e92-e4c3-4fc1-b4f6-b3d6cb297b92"), new Guid("70de320c-bc5a-46ed-b7ce-3759bddee213"), new Guid("77bd3f3a-70e2-46ad-a0a3-16d3297fc86e") }
                });

            migrationBuilder.InsertData(
                table: "tblOrder",
                columns: new[] { "Id", "CustomerId", "OrderDate", "ShipDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("1243f5fe-ec85-4c56-a281-35f61d167193"), new Guid("1d530b0f-2e5e-48d1-9432-1506d07af0ee"), new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("af0c6cae-232e-4374-b987-8f1b1926d0f8") },
                    { new Guid("bbce3197-c764-4ca5-a9a4-5b4375b00db5"), new Guid("0d25ae19-5f37-4f67-872c-6ff8356b7367"), new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("af0c6cae-232e-4374-b987-8f1b1926d0f8") },
                    { new Guid("dbb17e94-c308-4311-9aae-ab7bc784aee0"), new Guid("0d25ae19-5f37-4f67-872c-6ff8356b7367"), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ea8177b-0d8b-4485-a65d-d7d4f3355a80") }
                });

            migrationBuilder.InsertData(
                table: "tblOrderItem",
                columns: new[] { "Id", "Cost", "MovieId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("60a1e82a-83bc-4ec2-8cae-48d598db3882"), 9.9900000000000002, new Guid("77bd3f3a-70e2-46ad-a0a3-16d3297fc86e"), new Guid("bbce3197-c764-4ca5-a9a4-5b4375b00db5"), 1 },
                    { new Guid("732a12d3-3432-4999-86f6-7c3e4da7d166"), 8.9900000000000002, new Guid("a175333c-62e2-4e59-96ef-0df176b35b68"), new Guid("bbce3197-c764-4ca5-a9a4-5b4375b00db5"), 1 },
                    { new Guid("ae99302d-1ee1-4764-9e03-a815d4acbccc"), 10.99, new Guid("77bd3f3a-70e2-46ad-a0a3-16d3297fc86e"), new Guid("dbb17e94-c308-4311-9aae-ab7bc784aee0"), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomer_UserId",
                table: "tblCustomer",
                column: "UserId");

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
                name: "IX_tblMovieGenre_GenreId",
                table: "tblMovieGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMovieGenre_MovieId",
                table: "tblMovieGenre",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_CustomerId",
                table: "tblOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_UserId",
                table: "tblOrder",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderItem_MovieId",
                table: "tblOrderItem",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderItem_OrderId",
                table: "tblOrderItem",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblMovieGenre");

            migrationBuilder.DropTable(
                name: "tblOrderItem");

            migrationBuilder.DropTable(
                name: "tblGenre");

            migrationBuilder.DropTable(
                name: "tblOrder");

            migrationBuilder.DropTable(
                name: "tblMovie");

            migrationBuilder.DropTable(
                name: "tblCustomer");

            migrationBuilder.DropTable(
                name: "tblDirector");

            migrationBuilder.DropTable(
                name: "tblFormat");

            migrationBuilder.DropTable(
                name: "tblRating");

            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
