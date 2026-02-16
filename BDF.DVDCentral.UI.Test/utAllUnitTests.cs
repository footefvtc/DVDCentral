using BDF.DVDCentral.BL;
using BDF.DVDCentral.BL.Models;
using BDF.DVDCentral.UI.Controllers;
using BDF.DVDCentral.UI.Test;
using BDF.DVDCentral.UI.ViewModels;
using FVTC.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// Added Comment
namespace BDF.DVDCentral.UI.Test
{
    [TestClass]
    public class utAllUnitTests : utBase
    {
        //[TestMethod]
        //public void UserLoginTest()
        //{
        //    UserController controller = new UserController();
        //    var entity = new User { UserId = "bfoote", Password = "maple" };
        //    var results = controller.Login(entity) as RedirectToActionResult;
        //    Assert.AreEqual("Index", results?.ActionName);
        //    Debug.WriteLine($"User Login: {typeof(UserController).Name.ToString()}");
        //}

        [TestMethod]
        public void IndexTests()
        {
            // This will depends on your specific data in your DefaultData
            //dynamic controller = (UserController)Activator.CreateInstance(typeof(UserController));
            //var entity = new User { UserId = "bfoote", Password = "maple" };
            //controller.Seed();
            //IndexTest<CustomerController, Customer>(4);
            IndexTest<DirectorController, Director>(6);
            //IndexTest<FormatController, Format>(5);
            //IndexTest<GenreController, Genre>(3);
            //IndexTest<MovieController, Movie>(9);
            //IndexTest<OrderController, Order>(10);
            //IndexTest<OrderItemController, OrderItem>(10);
            //IndexTest<RatingController, Rating>(5);
            //IndexTest<UserController, User>(3);

            // This will depends on your specific data in your DefaultData
            string[] searchFields = { "FirstName", "LastName" };
            DetailsTest<CustomerController, Customer>(searchFields);
            DetailsTest<DirectorController, Director>(searchFields);
            //DetailsTest<UserController, User>(searchFields);//No User Details view/controller functionallity yet
            searchFields = new string[] { "Description" };
            //DetailsTest<FormatController, Format>(searchFields);
            //DetailsTest<GenreController, Genre>(searchFields);
            //DetailsTest<RatingController, Rating>(searchFields);
            //DetailsTest<MovieController, Movie>(searchFields);
            //searchFields = new string[] { "OrderDate", "ShipDate" };
            //DetailsTest<OrderController, Order>(searchFields);
            //searchFields = new string[] { "Cost", "Quantity" };
            //DetailsTest<OrderItemController, OrderItem>(searchFields);
        }

        [TestMethod]
        public void InsertTest()
        {

            //CreateTest<StudentController, StudentVM>(new StudentVM
            //{
            //    Student = new Student
            //    {
            //        FirstName = "Test",
            //        LastName = "Test",
            //        StudentId = "Test"
            //    }
            //});

            //CreateTest<CustomerController, Customer>(new Customer { FirstName = "", LastName = "", UserId = -1, Address = "", City = "", State = "", Zip = "", Phone = "", Id = -1 });
            //CreateTest<DirectorController, Director>(new Director { FirstName = "", LastName = "" });
            //CreateTest<FormatController, Format>(new Format { Description = ""});
            //CreateTest<GenreController, Genre>(new Genre { Description = "" });
            //Movie movie = new Movie { InStkQty = 0, Cost = 0, Description = "", ImagePath = "", Title = "", RatingId = -1, DirectorId = -1, FormatId = -1, Id = -1 };
            //movie.Genres = new List<Genre> { GenreManager.LoadById(1) };
            //CreateTest<MovieController, MovieVM>(new MovieVM { Movie = movie, GenreIds = movie.Genres.Select(x => x.Id) });
            //<OrderController, Order>(new Order { CustomerId = -1, UserId = -1, OrderDate = DateTime.Now, ShipDate = DateTime.Now, Id = -1 });
            //CreateTest<OrderItemController, OrderItem>(new OrderItem { OrderId = -1, MovieId = -1, Quantity = -1, Cost = 0, Id = -1 });
            //CreateTest<RatingController, Rating>(new Rating { Description = "", Id = -1 });
            //CreateTest<UserController, User>(new User { UserId = "Test", FirstName = "Test", LastName = "Test", Password = "Test" });
        }
        [TestMethod]
        public void EditTest()
        {
            //Guid id = Guid.NewGuid();
            //EditTest<CustomerController, Customer>(id, new Customer { FirstName = "", LastName = "", UserId = -1, Address = "", City = "", State = "", Zip = "", Phone = "", Id = id });
            //EditTest<DirectorController, Director>(id, new Director { FirstName = "", LastName = "", Id = id });
            //EditTest<GenreController, Genre>(id, new Genre { Description = "", Id = id });
            //EditTest<FormatController, Format>(id, new Format { Description = "", Id = id });
            //Movie movie = MovieManager.LoadById(id);
            //movie.Title = "Test";
            //EditTest<MovieController, MovieVM>(id, new MovieVM { Movie = movie });
            //EditTest<OrderController, Order>(id, new Order { CustomerId = -1, UserId = -1, OrderDate = DateTime.Now, ShipDate = DateTime.Now, Id = id });
            //EditTest<OrderItemController, OrderItem>(id, new OrderItem { OrderId = -1, MovieId = -1, Quantity = -1, Cost = 0, Id = id });
            //EditTest<RatingController, Rating>(id, new Rating { Description = "", Id = id });
            //No Edit Method//EditTest<UserController, User>(id,new User { UserId = "Test", FirstName = "Test", LastName = "Test", Password = "Test" });
        }

        [TestMethod]
        public void DeleteTest()
        {
            //Guid id = Guid.NewGuid();
            //DeleteTest<CustomerController, Customer>(id);
            //DeleteTest<DirectorController, Director>(id);
            //DeleteTest<FormatController, Format>(id);
            //DeleteTest<GenreController, Genre>(id);
            //DeleteTest<MovieController, Movie>(id);
            //DeleteTest<OrderController, Order>(id);
            //DeleteTest<OrderItemController, OrderItem>(id);
            //DeleteTest<RatingController, Rating>(id);
            //No Delete Method//DeleteTest<UserController, User>(id);
        }

    }
}
