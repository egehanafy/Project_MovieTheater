using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Common
{
    public class CartItem
    {
        public CartItem()
        {
            Quantity = 1;
        }
        public int Id { get; set; }
        public short Quantity { get; set; }
        public string MovieTitle { get; set; }
        public string HallNo { get; set; }
        public DateTime ShowTime { get; set; }
        public string? SeatLetter { get; set; } //yapilacak
        public string? SeatNo { get; set; } //yapilacak

        public decimal? UnitPrice { get; set; }
        public decimal? SubTotal
        {
            get
            {
                return Quantity * UnitPrice;
            }


        }

    }
}
