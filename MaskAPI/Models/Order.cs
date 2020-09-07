using System;

namespace MaskAPI.Models
{
    public class Order
    {
        public int OrderNo { get; set; }
        public Mask Mask { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }

        public Order(Mask mask, int qty)
        {
            this.OrderNo = this.GenerateOrderNo();
            this.Mask = mask;
            this.Qty = qty;
            this.SetPrice();
        }

        public void SetPrice()
        {
            this.Price = this.Qty * Mask.Cost;
        }

        public int GenerateOrderNo() {
            Random r = new Random();
            return r.Next(100, 10000);
        }
    }
}