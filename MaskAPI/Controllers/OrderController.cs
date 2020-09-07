using System.Collections.Generic;
using MaskAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MaskAPI.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class OrderController : ControllerBase
    {
        public static List<Mask> MasksInStock = new List<Mask>();
        public static List<Order> Orders = new List<Order>();

        public OrderController() {
            MasksInStock.Add(new Mask("m-999", 1, "Black", true, false, "Spots", true, 30.00));
            MasksInStock.Add(new Mask("m-456", 2, "Blue", false, true, "Swirls", false, 1.00));
            MasksInStock.Add(new Mask("m-900", 3, "Purple", false, false, "Flowers", true, 15.00));

            Orders.Add(new Order(new Mask("m-999", 1, "Black", true, false, "Spots", true, 30.00), 12));
            Orders.Add(new Order(new Mask("m-456", 2, "Blue", false, true, "Swirls", false, 1.00), 5));
        }

        [HttpGet("GetAll")]
        public List<Order> GetAll() {
            return Orders;
        }

        [HttpGet("{orderNo}")]
        public Order GetOrder(int orderNo) {
            Order found = null;
            foreach (Order order in Orders) {
                if (orderNo == order.OrderNo) {
                    found = order;
                    break;
                }
            }
            return found;
        }

        [HttpPost]
        public int MakeOrder(MaskRequest request) {
            Mask found = MasksInStock.Find(m => m.MaskID == request.MaskID);

            if (found == null) {
                return 0;
            }

            Order newOrder = new Order(found, request.Quantity);
            Orders.Add(newOrder);

            return newOrder.OrderNo;
        }
    }
}