using ExpressShop.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressShop.Domain.Entities.Products
{
    public class Product : IAuditable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
        
        public DateTime CreatedAt { get; set; }

        public int Expiration { get; set; }
    }
}
