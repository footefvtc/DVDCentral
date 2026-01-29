//using BDF.DVDCentral.BL.Models;
//using BDF.DVDCentral.PL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BDF.DVDCentral.BL
//{
//    public static class ShoppingCartManager
//    {
//        public static void Add(ShoppingCart cart, Movie movie)
//        {
//            if (cart != null) 
//            {
//                var existingMovie = cart.Items.FirstOrDefault(m => m.Id == movie.Id);

//                if(existingMovie != null)
//                {
//                    existingMovie.Count++;
//                }
//                else 
//                { 
//                    cart.Items.Add(movie); 
//                    movie.Count = 1;
//                }
//            }
//        }

//        public static void Remove(ShoppingCart cart, Movie movie)
//        {
//            if (cart != null) 
//            {
//                var existingMovie = cart.Items.FirstOrDefault(m => m.Id == movie.Id);

//                if (existingMovie != null) 
//                {
//                    existingMovie.Count--; // Reduce the movie quantity in the cart

//                    if(existingMovie.Count == 0) 
//                    {
//                        cart.Items.Remove(movie); // Remove the movie from the cart
//                    }
//                }
//            }
//        }

//        public static void Checkout(ShoppingCart cart, ref int orderId)
//        {
//            try
//            {
//                while(cart.Items.Count > 0)
//                {
//                    List<OrderItem> orderItems = new List<OrderItem>();

//                    Order order = new Order();

//                    DateTime orderDate = DateTime.Now;
//                    DateTime shipDate = orderDate.AddDays(3);
//                    order.CustomerId = cart.CustomerId;
//                    order.UserId = cart.UserId;

//                    OrderManager.Insert(order.CustomerId, orderDate, shipDate, order.UserId, ref orderId);

//                    order.Id = orderId;

//                    int orderItemId = 1;

//                    OrderItem orderItem = new OrderItem();

//                    foreach (Movie item in cart.Items)
//                    {
//                        if (item.InStkQty > 0)
//                        {
//                            OrderItemManager.Insert(order.Id, item.Count, item.Id, item.Cost, ref orderItemId);

//                            orderItem.Id = orderItemId;

//                            order.OrderItems.Add(orderItem);

//                            item.InStkQty -= 1;

//                            MovieManager.Update(item);
//                        }
//                        else
//                        {
//                            continue;
//                        }
//                    }

//                    cart = new ShoppingCart();
//                }
//            }
//            catch (Exception)
//            {
//                throw new Exception("There was an error processing your request. Please add in stock items to your cart and try again.");
//            }
//        }
//    }
//}
