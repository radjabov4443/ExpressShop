using ExpressShop.Domain.Commons;
using ExpressShop.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressShop.Domain.Entities.Orders
{
    public class Order : IAuditable
    {
        public Guid Id { get; set; }

        public Product Product { get; set; }
    }
}
