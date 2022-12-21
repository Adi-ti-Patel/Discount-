using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public class InternalCustomer : Customer
    {
        public override void CalculateDiscount()
        {
            _discountPercentage = 10;
        }
    }
}
