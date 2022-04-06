using System;
using System.Collections.Generic;
using System.Text;

namespace FileStream_Serialize_DeSerialize_Practic.Model
{
     class Order
    {
        public int ID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public double TotalPrice { get; set; }
    }
}
