using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    internal class RetailCustomer : Customer
    {
        public override void CalculateDiscount()
        {
            _discountPercentage = 15;
        }
    }
}
