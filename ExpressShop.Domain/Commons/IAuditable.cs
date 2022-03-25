using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressShop.Domain.Commons
{
    public interface IAuditable
    {
        Guid Id { get; set; }
    }
}
