using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderProject.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Cost { get; set; }
        public int OrderId { get; set; }
        public int Quantity{ get; set; }
        public Order Order { get; set; }
       
       
    }
}
